using System.Text.Json.Serialization;

namespace IxcNet.ViewModels.Sistema.Cadastros.Locais
{
    public class CidadeViewmodel
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? id { get; set; }
        public string? origem { get; set; }
        public string? nome { get; set; }
        public string? uf { get; set; }
        public string? regiao { get; set; }
        public string? cod_ibge { get; set; }
        public string? cod_siafi { get; set; }
        public string? cod_cidade_nfse_forquilhinha_sc { get; set; }
    }
}
