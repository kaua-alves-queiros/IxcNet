using System.Text.Json.Serialization;

namespace IxcNet.ViewModels.Sistema.Provedor
{
    public class RadPopRadioClienteFibraViewModel
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? id { get; set; }
        public string? radpop_estrutura { get; set; }
        public string? id_projeto { get; set; }
        public string? id_caixa_ftth { get; set; }
        public string? porta_ftth { get; set; }
        public string? id_transmissor { get; set; }
        public string? id_hardware { get; set; }
        public string? id_contrato { get; set; }
        public string? id_login { get; set; }
        public string? id_ramal { get; set; }
        public string? nome { get; set; }
        public string? mac { get; set; }
        public string? id_perfil { get; set; }
        public string? ponid { get; set; }
        public string? vlan { get; set; }
        public string? onu_numero { get; set; }
        public string? gemport { get; set; }
        public string? service_port { get; set; }
        public string? comandos { get; set; }
        public string? id_chamado_radpop { get; set; }
        public string? tipo_operacao { get; set; }
        public string? vlan_pppoe { get; set; }
        public string? vlan_dhcp { get; set; }
        public string? vlan_tr69 { get; set; }
        public string? vlan_iptv { get; set; }
        public string? vlan_voip { get; set; }
        public string? vlan_outros { get; set; }
        public string? ip_gerencia { get; set; }
        public string? login_onu_cliente { get; set; }
        public string? senha_onu_cliente { get; set; }
        public string? porta_telnet_onu_cliente { get; set; }
        public string? porta_web_onu_cliente { get; set; }
        public string? perfil_onu_cliente { get; set; }
        public string? script_onu_cliente { get; set; }
        public string? onu_tipo { get; set; }
        public string? slotno { get; set; }
        public string? ponno { get; set; }
        public string? onu_rede_neutra { get; set; }
        public string? tipo_autenticacao { get; set; }
        public string? versao { get; set; }
        public string? sinal_rx { get; set; }
        public string? sinal_tx { get; set; }
        public string? temperatura { get; set; }
        public string? voltagem { get; set; }
        public string? data_sinal { get; set; }
        public string? causa_ultima_queda { get; set; }
        public string? senorid { get; set; }
        public string? distancia_onu { get; set; }
        public string? id_onu_unms { get; set; }
        public string? id_activity { get; set; }
        public string? endereco_padrao_cliente { get; set; }
        public string? condominio_cliente { get; set; }
        public string? id_condominio { get; set; }
        public string? bloco_cliente { get; set; }
        public string? bloco { get; set; }
        public string? apartamento_cliente { get; set; }
        public string? apartamento { get; set; }
        public string? cep_cliente { get; set; }
        public string? cep { get; set; }
        public string? endereco_cliente { get; set; }
        public string? endereco { get; set; }
        public string? numero_cliente { get; set; }
        public string? numero { get; set; }
        public string? bairro_cliente { get; set; }
        public string? bairro { get; set; }
        public string? cidade_cliente { get; set; }
        public string? cidade { get; set; }
        public string? referencia_cliente { get; set; }
        public string? referencia { get; set; }
        public string? complemento_cliente { get; set; }
        public string? complemento { get; set; }
        public string? latitude { get; set; }
        public string? longitude { get; set; }
    }

}
