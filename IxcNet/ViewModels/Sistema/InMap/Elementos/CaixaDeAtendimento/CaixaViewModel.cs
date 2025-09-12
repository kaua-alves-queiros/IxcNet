using System.Text.Json.Serialization;

namespace IxcNet.ViewModels.Sistema.InMap.Elementos.CaixaDeAtendimento
{
    public class CaixaViewModel
    {
        public string? id { get; set; }
        public string? descricao { get; set; }
        public string? tipo { get; set; }
        public string? id_projeto { get; set; }
        public string? id_transmissor { get; set; }
        public string? id_interface { get; set; }
        public string? id_tecnologia { get; set; }
        public string? capacidade { get; set; }
        public string? latitude { get; set; }
        public string? longitude { get; set; }
        public string? codigo_estilo_caixa { get; set; }
        public string? obs_caixa_ftth { get; set; }
        public string? status { get; set; }
        public string? idx { get; set; }
        public string? ultima_atualizacao { get; set; }
        public string? cep { get; set; }
        public string? endereco { get; set; }
        public string? numero { get; set; }
        public string? bairro { get; set; }
        public string? id_cidade { get; set; }
    }
}
