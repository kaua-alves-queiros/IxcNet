using IxcNet.Services;
using IxcNet.Interfaces;
using System.Text.Json;
using System.Net;
using Test.Utils;
using IcNet.ViewModels;

namespace Test
{
    /// <summary>
    /// Modelo de teste simples para validar a genericidade do IxcNetService.
    /// </summary>
    public class StubModel : INamedModel
    {
        public string? ModelName => "stub_model";
        public string? Id { get; set; }
        public string? Nome { get; set; }
    }

    /// <summary>
    /// Classe de testes para o IxcNetService.
    /// Focada em validar se as funções genéricas (Listar, Inserir) realizam 
    /// as chamadas HTTP corretamente para qualquer modelo.
    /// </summary>
    public class IxcNetServiceTests
    {
        private MockHttpMessageHandler? _mockHandler;
        private IxcNetService? _service;

        private void SetupMock(Func<HttpRequestMessage, HttpResponseMessage> handlerFunc)
        {
            _mockHandler = new MockHttpMessageHandler(handlerFunc);
            var httpClient = new HttpClient(_mockHandler);
            _service = new IxcNetService(httpClient);
            _service.Setup("api.mock.com", "token-fake");
        }

        [Fact]
        public async Task Listar_DeveEnviarHeadersEPayloadCorretos()
        {
            // Arrange
            HttpRequestMessage? capturedRequest = null;
            SetupMock(request =>
            {
                capturedRequest = request;
                var listResponse = new IxcResponseViewModel<StubModel>
                {
                    registros = new List<StubModel?> { new StubModel { Id = "1" } }
                };
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(JsonSerializer.Serialize(listResponse))
                };
            });

            var query = QueryBuilder.Where("id", "=", "1");

            // Act
            await _service!.Listar<StubModel>(query);

            // Assert
            Assert.NotNull(capturedRequest);
            Assert.Equal(HttpMethod.Post, capturedRequest.Method);
            Assert.Equal("listar", capturedRequest.Headers.GetValues("ixcsoft").First());
            Assert.Contains("Basic", capturedRequest.Headers.Authorization?.Scheme);
            Assert.Equal("stub_model", capturedRequest.RequestUri?.ToString().Split('/').Last());
        }

        [Fact]
        public async Task Inserir_DeveEnviarObjetoSerializadoCorretamente()
        {
            // Arrange
            HttpRequestMessage? capturedRequest = null;
            SetupMock(request =>
            {
                capturedRequest = request;
                return new HttpResponseMessage(HttpStatusCode.Created);
            });

            var model = new StubModel { Id = "100", Nome = "Teste" };

            // Act
            var result = await _service!.Inserir(model);

            // Assert
            Assert.Equal(HttpStatusCode.Created, result);
            Assert.NotNull(capturedRequest);
            
            var body = await capturedRequest.Content!.ReadAsStringAsync();
            Assert.Contains("\"Id\":\"100\"", body);
            Assert.Contains("\"Nome\":\"Teste\"", body);
        }

        [Fact]
        public async Task Listar_DeveRetornarNull_QuandoApiRetornaErroDeConexao()
        {
            // Arrange
            SetupMock(request => new HttpResponseMessage(HttpStatusCode.Unauthorized));

            // Act
            var result = await _service!.Listar<StubModel>(QueryBuilder.List());

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task Listar_DeveRetornarNull_QuandoJsonDaApiForInvalido()
        {
            // Arrange: API retorna 200 OK mas com conteúdo que não é um JSON válido para o modelo
            SetupMock(request => new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("{ \"registros\": \"isto deveria ser uma lista, não uma string\" }")
            });

            // Act
            var result = await _service!.Listar<StubModel>(QueryBuilder.List());

            // Assert: O try-catch interno do serviço deve tratar o erro de deserialização
            Assert.Null(result);
        }
    }
}
