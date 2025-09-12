﻿using IxcNet.Interfaces;
using System.Text.Json.Serialization;

namespace IxcNet.ViewModels.Sistema.FolhaDePagamento.Colaboradores
{
    public class FuncionarioViewModel : INamedModel
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string? ModelName => "funcionarios";
        public string? id { get; set; }
        public string? img_assinatura { get; set; }
        public string? ramal { get; set; }
        public string? envia_telegram_os { get; set; }
        public string? telegram_chat_id_funcionario { get; set; }
        public string? id_chat_telegram_funcionario { get; set; }
        public string? id_perfil_jornada_trabalho { get; set; }
        public string? rastreador { get; set; }
        public string? ferias_colaborador { get; set; }
        public string? id_conta_decimo { get; set; }
        public string? funcionario { get; set; }
        public string? ativo { get; set; }
        public string? id_funcao { get; set; }
        public string? fone_celular { get; set; }
        public string? id_conta { get; set; }
        public string? email { get; set; }
        public string? coeficiente { get; set; }
        public string? cor_mapa { get; set; }
        public string? filial_id { get; set; }
        public string? data_nascimento { get; set; }
        public string? data_admissao { get; set; }
        public string? id_conta_salario { get; set; }
        public string? envia_email_os { get; set; }
        public string? envia_sms_os { get; set; }
        public string? integracao_calendario { get; set; }
        public string? id_setor_padrao { get; set; }
        public string? endereco { get; set; }
        public string? cidade { get; set; }
        public string? numero { get; set; }
        public string? bairro { get; set; }
        public string? uf { get; set; }
        public string? cep { get; set; }
        public string? complemento { get; set; }
        public string? referencia { get; set; }
        public string? cpf_cnpj { get; set; }
        public string? ie_identidade { get; set; }
        public string? rg_orgao_emissor { get; set; }
        public string? nacionalidade { get; set; }
        public string? fone { get; set; }
        public string? telefone_comercial { get; set; }
        public string? assinatura_email { get; set; }
        public string? id_email_smtp { get; set; }
        public string? banco { get; set; }
        public string? agencia { get; set; }
        public string? numero_conta_dv { get; set; }
        public string? agencia_dv { get; set; }
        public string? conta { get; set; }
        public string? tipo_recebimento { get; set; }
        public string? data_demissao { get; set; }
        public string? obs { get; set; }
        public string? percen_max_desc_areceber { get; set; }
        public string? prj_custo_hora_adicionais { get; set; }
        public string? prj_custo_hora_base { get; set; }
        public string? camara_centralizadora { get; set; }
        public string? estado_civil { get; set; }
        public string? nome_mae { get; set; }
        public string? nome_pai { get; set; }
        public string? tipo_deficiencia { get; set; }
        public string? possui_deficiencia { get; set; }
        public string? camiseta { get; set; }
        public string? num_manequim { get; set; }
        public string? cor_raca { get; set; }
        public string? num_dependentes { get; set; }
        public string? dependentes_ir { get; set; }
        public string? nome_conjuge { get; set; }
        public string? estagio_escolaridade { get; set; }
        public string? periodo_escolaridade { get; set; }
        public string? grau_escolaridade { get; set; }
        public string? falar_com { get; set; }
        public string? fone_emergencia { get; set; }
        public string? salario { get; set; }
        public string? cnh_categoria { get; set; }
        public string? titulo_secao { get; set; }
        public string? titulo_zona { get; set; }
        public string? titulo_numero { get; set; }
        public string? ctps_cidade_emissao { get; set; }
        public string? ctps_data_emissao { get; set; }
        public string? ctps_serie { get; set; }
        public string? ctps_numero { get; set; }
        public string? cnh_numero { get; set; }
        public string? cpf_conjuge { get; set; }
        public string? rg_conjuge { get; set; }
        public string? cnh_vencimento { get; set; }
        public string? pis_data { get; set; }
        public string? pis_numero { get; set; }
        public string? rg_data_emissao { get; set; }
        public string? dep_tres_cpf { get; set; }
        public string? dep_tres_rg { get; set; }
        public string? dep_tres_nome { get; set; }
        public string? dep_dois_cpf { get; set; }
        public string? dep_dois_rg { get; set; }
        public string? dep_dois_nome { get; set; }
        public string? dep_um_cpf { get; set; }
        public string? dep_um_rg { get; set; }
        public string? dep_um_nome { get; set; }
        public string? id_departamento { get; set; }
        public string? ultima_atualizacao { get; set; }
        public string? exibir_colaborador_inmap { get; set; }

    }
}
