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
            var response = await _http.PostAsJsonAsync(route, model, _jsonOptions);
            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            return response.StatusCode;
        }
    }
}
