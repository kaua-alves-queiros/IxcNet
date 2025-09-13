using IxcNet.Interfaces;
using System.Text.Json.Serialization;

namespace IxcNet.ViewModels.Sistema.Suporte.OrdemDeServico
{
    public class SuOssChamadoViewModel : INamedModel
    {
        public string? ModelName => "su_oss_chamado";
        public string? id { get; set; }
        public string? mensagem_resposta { get; set; }
        public string? data_hora_analise { get; set; }
        public string? data_hora_encaminhado { get; set; }
        public string? data_hora_assumido { get; set; }
        public string? data_hora_execucao { get; set; }
        public string? id_contrato_kit { get; set; }
        public string? preview { get; set; }
        public string? data_agenda_final { get; set; }
        public string? tipo { get; set; }
        public string? id_filial { get; set; }
        public string? id_wfl_tarefa { get; set; }
        public string? status_sla { get; set; }
        public string? data_abertura { get; set; }
        public string? melhor_horario_agenda { get; set; }
        public string? liberado { get; set; }
        public string? status { get; set; }
        public string? id_cliente { get; set; }
        public string? id_assunto { get; set; }
        public string? setor { get; set; }
        public string? id_cidade { get; set; }
        public string? id_tecnico { get; set; }
        public string? prioridade { get; set; }
        public string? mensagem { get; set; }
        public string? protocolo { get; set; }
        public string? endereco { get; set; }
        public string? complemento { get; set; }
        public string? id_condominio { get; set; }
        public string? bloco { get; set; }
        public string? apartamento { get; set; }
        public string? latitude { get; set; }
        public string? bairro { get; set; }
        public string? longitude { get; set; }
        public string? referencia { get; set; }
        public string? impresso { get; set; }
        public string? data_inicio { get; set; }
        public string? data_agenda { get; set; }
        public string? data_final { get; set; }
        public string? data_fechamento { get; set; }
        public string? id_wfl_param_os { get; set; }
        public string? valor_total_comissao { get; set; }
        public string? valor_total { get; set; }
        public string? valor_outras_despesas { get; set; }
        public string? idx { get; set; }
        public string? id_su_diagnostico { get; set; }
        public string? gera_comissao { get; set; }
        public string? id_estrutura { get; set; }
        public string? id_login { get; set; }
        public string? valor_unit_comissao { get; set; }
        public string? data_prazo_limite { get; set; }
        public string? data_reservada { get; set; }
        public string? id_ticket { get; set; }
        public string? origem_endereco { get; set; }
        public string? justificativa_sla_atrasado { get; set; }
        public string? origem_endereco_estrutura { get; set; }
        public string? data_reagendar { get; set; }
        public string? data_prev_final { get; set; }
        public string? origem_cadastro { get; set; }
        public string? ultima_atualizacao { get; set; }
    }

}
