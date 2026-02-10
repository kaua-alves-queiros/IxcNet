using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Logging;


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
        /// Instância para registro de logs e monitoramento.
        /// </summary>
        private readonly ILogger? _logger;

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
        /// <param name="logger">Opcional: Instância de logger para monitoramento.</param>
        public IxcNetService(ILogger<IxcNetService>? logger = null)
        {
            _logger = logger;
        }

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="IxcNetService"/> com um <see cref="HttpClient"/> customizado.
        /// </summary>
        /// <param name="http">A instância de <see cref="HttpClient"/> a ser utilizada.</param>
        /// <param name="logger">Opcional: Instância de logger para monitoramento.</param>
        public IxcNetService(HttpClient http, ILogger<IxcNetService>? logger = null)
        {
            _http = http;
            _logger = logger;
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
