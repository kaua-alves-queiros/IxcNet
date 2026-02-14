using IxcNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IxcNet.ViewModels.Sistema.Cadastros.Clientes
{
    public class ClienteCondominioViewModel : INamedModel
    {
        public string? ModelName => "cliente_condominio";

        public string? id { get; set; }
        public string? condominio { get; set; }
        public string? cnpj { get; set; }
        public string? id_cidade { get; set; }
        public string? endereco { get; set; }
        public string? numero { get; set; }
        public string? cep { get; set; }
        public string? bairro { get; set; }
        public string? sindico { get; set; }
        public string? celular_sindico { get; set; }
        public string? data_cadastro { get; set; }
        public string? bloco_unico { get; set; }
        public string? quantidade_shafts { get; set; }
        public string? obs { get; set; }
    }
}
