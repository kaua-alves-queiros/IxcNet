using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace IxcNet.Services
{
    /// <summary>
    /// Serviço principal para interação com a API do IXC.
    /// Esta é uma classe parcial que contém os métodos core, de listagem e inserção.
    /// </summary>
    public partial class IxcNetService
    {
        private static JsonIgnoreCondition JsonIgnoreCOndition;
        HttpClient _http = new();
        JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
        };

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="IxcNetService"/>.
        /// </summary>
        public IxcNetService() { }

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="IxcNetService"/> com um HttpClient customizado.
        /// </summary>
        /// <param name="http">Instância de HttpClient.</param>
        public IxcNetService(HttpClient http) { }

        /// <summary>
        /// Configura as credenciais e o host para as requisições à API do IXC.
        /// </summary>
        /// <param name="host">O endereço do host (ex: servidor.ixcsoft.com.br).</param>
        /// <param name="token">O token de autenticação (API Token).</param>
        public void Setup(string host, string token)
        {
            _http.BaseAddress = new Uri("https://" + host + "/webservice/v1/");
            _http.DefaultRequestHeaders.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(token)));
        }
    }
}
