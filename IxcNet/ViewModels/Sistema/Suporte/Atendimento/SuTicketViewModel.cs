using IxcNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IxcNet.ViewModels.Sistema.Suporte.Atendimento
{
    public class SuTicketViewModel : INamedModel
    {
        public string? ModelName => "su_ticket";

        // Identificadores (IDs)
        public string? id { get; set; }
        public string? id_cliente { get; set; }
        public string? id_login { get; set; }
        public string? id_contrato { get; set; }
        public string? id_assunto { get; set; }
        public string? id_filial { get; set; }
        public string? id_usuarios { get; set; }
        public string? id_responsavel_tecnico { get; set; }
        public string? id_ticket_setor { get; set; }
        public string? id_wfl_processo { get; set; }
        public string? id_su_diagnostico { get; set; }
        public string? id_estrutura { get; set; }
        public string? id_circuito { get; set; }
        public string? id_canal_atendimento { get; set; }
        public string? id_resposta { get; set; }
        public string? id_evento_status_processo { get; set; }
        public string? id_ticket_origem { get; set; }

        // Conteúdo e Status
        public string? titulo { get; set; }
        public string? protocolo { get; set; }
        public string? menssagem { get; set; } // Mantido com 'ss' conforme o JSON do IXC
        public string? status { get; set; }     // Ex: OSAG (Agendada)
        public string? su_status { get; set; }  // Ex: EP (Em Planejamento/Execução)
        public string? prioridade { get; set; }
        public string? tipo { get; set; }
        public string? token { get; set; }
        public string? interacao_pendente { get; set; }
        public string? origem_cadastro { get; set; }

        // Datas e SLA
        public string? data_criacao { get; set; }
        public string? data_ultima_alteracao { get; set; }
        public string? data_reservada { get; set; }
        public string? melhor_horario_reserva { get; set; }
        public string? ultima_atualizacao { get; set; }
        public string? status_sla { get; set; }

        // Localização e Endereço
        public string? endereco { get; set; }
        public string? latitude { get; set; }
        public string? longitude { get; set; }
        public string? origem_endereco { get; set; }
        public string? origem_endereco_estrutura { get; set; }

        // Contadores e Mensagens
        public string? mensagens_nao_lida_sup { get; set; }
        public string? mensagens_nao_lida_cli { get; set; }
    }
}
