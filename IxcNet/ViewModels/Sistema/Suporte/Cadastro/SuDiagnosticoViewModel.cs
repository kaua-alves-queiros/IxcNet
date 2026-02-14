using IxcNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IxcNet.ViewModels.Sistema.Suporte.Cadastro
{
    public class SuDiagnosticoViewModel : INamedModel
    {
        public string? ModelName => "su_diagnostico";

        public string? id { get; set; }
        public string? ativo { get; set; }
        public string? descricao { get; set; }
        public string? id_setor { get; set; }
        public string? ultima_atualizacao { get; set; }
    }
}
