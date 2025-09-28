using IxcNet.Interfaces;
using System.Net;
using System.Net.Http.Json;

namespace IxcNet.Services
{
    public partial class IxcNetService
    {
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
