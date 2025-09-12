using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IxcNet.Services
{
    public partial class IxcNetService
    {
        HttpClient _http = new();

        public IxcNetService() { }

        public IxcNetService(HttpClient http) { }

        public void Setup(string host, string token)
        {
            _http.BaseAddress = new Uri(host);
            _http.DefaultRequestHeaders.Add("ixcsoft", "listar");
            _http.DefaultRequestHeaders.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(token)));
        }
    }
}
