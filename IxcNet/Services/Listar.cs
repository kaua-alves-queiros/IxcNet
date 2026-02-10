using IcNet.ViewModels;
using IxcNet.Interfaces;
using System.Text;
using System.Text.Json;

namespace IxcNet.Services
{
    partial class IxcNetService
    {
        public async Task<List<T>?> Listar<T>(QueryBuilder query) where T : INamedModel, new()
        {
            try
            {
                query.ModelName = new T().ModelName;
                var request = new HttpRequestMessage(HttpMethod.Post, query.ModelName);
                request.Headers.Add("ixcsoft", "listar");
                var jsonBody = JsonSerializer.Serialize(query.GetContent());
                request.Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                var response = await _http.SendAsync(request);
                var content = await response.Content.ReadAsStringAsync();

                return JsonSerializer.Deserialize<IxcResponseViewModel<T>>(content)!.registros!;
            }
            catch
            {
                return null;
            }
        }
    }
}
