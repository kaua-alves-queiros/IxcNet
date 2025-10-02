using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace IxcNet.Services
{
    public partial class IxcNetService
    {
        private static JsonIgnoreCondition JsonIgnoreCOndition;
        HttpClient _http = new();
        JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
        };

        public IxcNetService() { }

        public IxcNetService(HttpClient http) { }
        public void Setup(string host, string token)
        {
            _http.BaseAddress = new Uri("https://" + host + "/webservice/v1/");
            _http.DefaultRequestHeaders.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(token)));
        }
    }
}
