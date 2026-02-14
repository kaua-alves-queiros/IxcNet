using IxcNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IxcNet.ViewModels.Sistema.FolhaDePagamento.Cadastros
{
    public class EmpresaSetorViewModel : INamedModel
    {
        public string? empresa_setor_chatid_telegram { get; set; }
        public string? token_bot_telegram_setor { get; set; }
        public string? id { get; set; }
        public string? ativo { get; set; }
        public string? setor { get; set; }
        public string? recebe_telegram_setor { get; set; }
        public string? cor { get; set; }
        public string? id_depto { get; set; }

        public string? ModelName => "empresa_setor";
    }
}
