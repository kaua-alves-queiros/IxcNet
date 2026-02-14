using IxcNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IxcNet.ViewModels.Sistema.Cadastros.Estruturas
{
    public class EstruturasViewModel : INamedModel
    {
        public string? ModelName => "estruturas";

        public string? id { get; set; }
        public string? descricao { get; set; }
        public string? ativo { get; set; }
        public string? id_cidade { get; set; }
        public string? id_filial { get; set; }
        public string? id_planejamento_analitico { get; set; }
        public string? cep { get; set; }
        public string? endereco { get; set; }
        public string? numero { get; set; }
        public string? bairro { get; set; }
        public string? complemento { get; set; }
        public string? referencia { get; set; }
        public string? latitude { get; set; }
        public string? longitude { get; set; }
        public string? observacao { get; set; }
    }
}
