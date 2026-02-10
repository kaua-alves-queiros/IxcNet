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
        /// <summary>
        /// Define a condição de ignorância para o serializador JSON.
        /// </summary>
        private static JsonIgnoreCondition JsonIgnoreCondition;

        /// <summary>
        /// Instância do <see cref="HttpClient"/> utilizada para realizar as requisições HTTP para a API.
        /// </summary>
        private HttpClient _http = new();

        /// <summary>
        /// Opções de configuração para o serializador JSON.
        /// </summary>
        private JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
        };

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="IxcNetService"/>.
        /// </summary>
        public IxcNetService() { }

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="IxcNetService"/> com um <see cref="HttpClient"/> customizado.
        /// </summary>
        /// <param name="http">A instância de <see cref="HttpClient"/> a ser utilizada.</param>
        public IxcNetService(HttpClient http)
        {
            _http = http;
        }

        /// <summary>
        /// Configura as credenciais e o endereço base para as requisições à API do IXCSoft.
        /// </summary>
        /// <param name="host">O endereço do host do webservice (ex: provedor.ixcsoft.com.br).</param>
        /// <param name="token">O token de API utilizado para autenticação Basic.</param>
        public void Setup(string host, string token)
        {
            _http.BaseAddress = new Uri("https://" + host + "/webservice/v1/");
            _http.DefaultRequestHeaders.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(token)));
        }
    }
}
