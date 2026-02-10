using IcNet.ViewModels;
using IxcNet.Interfaces;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Logging;


namespace IxcNet.Services
{
    partial class IxcNetService
    {
        /// <summary>
        /// Lista registros de um determinado modelo na API do IXC.
        /// </summary>
        /// <typeparam name="T">O tipo do modelo que deve implementar <see cref="INamedModel"/> e ter um construtor sem parâmetros.</typeparam>
        /// <param name="query">O objeto <see cref="QueryBuilder"/> contendo os filtros, ordenação e limite.</param>
        /// <returns>Uma lista de objetos do tipo <typeparamref name="T"/>, ou <c>null</c> em caso de erro.</returns>
        public async Task<List<T>?> Listar<T>(QueryBuilder query) where T : INamedModel, new()
        {
            var modelName = new T().ModelName;
            try
            {
                query.ModelName = modelName;
                _logger?.LogInformation("Iniciando listagem para o modelo {ModelName} com filtros: {Query}", modelName, JsonSerializer.Serialize(query.GetContent()));

                var request = new HttpRequestMessage(HttpMethod.Post, query.ModelName);
                request.Headers.Add("ixcsoft", "listar");
                var jsonBody = JsonSerializer.Serialize(query.GetContent());
                request.Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                var response = await _http.SendAsync(request);
                var content = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    _logger?.LogWarning("Falha ao listar {ModelName}. Status: {StatusCode}, Resposta: {Content}", modelName, response.StatusCode, content);
                    return null;
                }

                var result = JsonSerializer.Deserialize<IxcResponseViewModel<T>>(content);
                _logger?.LogInformation("Listagem de {ModelName} concluída com sucesso. Registros retornados: {Count}", modelName, result?.registros?.Count ?? 0);

                return result?.registros;
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Erro inesperado ao listar {ModelName}", modelName);
                return null;
            }
        }
    }
}
