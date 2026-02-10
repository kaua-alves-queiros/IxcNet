using IxcNet.Interfaces;
using System.Net;
using System.Net.Http.Json;

namespace IxcNet.Services
{
    public partial class IxcNetService
    {
        /// <summary>
        /// Insere um novo registro de um determinado modelo na API do IXC.
        /// </summary>
        /// <typeparam name="T">O tipo do modelo que deve implementar <see cref="INamedModel"/>.</typeparam>
        /// <param name="model">O objeto do modelo a ser inserido.</param>
        /// <returns>O <see cref="HttpStatusCode"/> retornado pela API.</returns>
        public async Task<HttpStatusCode> Inserir<T>(T model) where T : INamedModel
        {
            var route = model.ModelName;
            try
            {
                _logger?.LogInformation("Tentando inserir novo registro no modelo {ModelName}", route);
                
                var response = await _http.PostAsJsonAsync(route, model, _jsonOptions);
                var content = await response.Content.ReadAsStringAsync();
                
                if (response.IsSuccessStatusCode)
                {
                    _logger?.LogInformation("Registro inserido com sucesso no modelo {ModelName}. Resposta: {Content}", route, content);
                }
                else
                {
                    _logger?.LogWarning("Falha ao inserir registro no modelo {ModelName}. Status: {StatusCode}, Resposta: {Content}", route, response.StatusCode, content);
                }

                return response.StatusCode;
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Erro inesperado ao realizar inserção no modelo {ModelName}", route);
                return HttpStatusCode.InternalServerError;
            }
        }
    }
}
