using System.Text.Json.Serialization;

namespace IxcNet.ViewModels.Sistema.Provedor.Transmissores
{
    public class RadPopViewModel
    {
        public string? id { get; set; }
        public string? login_hw { get; set; }
        public string? senha_hw { get; set; }
        public string? fabricante_modelo { get; set; }
        public string? descricao { get; set; }
        public string? id_pop { get; set; }
        public string? ip { get; set; }
        public string? login { get; set; }
        public string? senha { get; set; }
        public string? perfil_fibra_padrao { get; set; }
        public string? porta_ssh { get; set; }
        public string? porta_telnet { get; set; }
        public string? httpd_port { get; set; }
        public string? id_prov_snmp { get; set; }
        public string? porta_api { get; set; }
        public string? timeout { get; set; }
        public string? ativo { get; set; }
        public string? cor_mapa { get; set; }
        public string? id_padrao_cores { get; set; }
        public string? ip_anm { get; set; }
        public string? login_anm { get; set; }
        public string? senha_anm { get; set; }
        public string? porta_telnet_tl1 { get; set; }
        public string? gabinete { get; set; }
        public string? subrack { get; set; }
        public string? usa_smart { get; set; }
        public string? id_servidor_unms { get; set; }
        public string? id_olt_unms { get; set; }
        public string? id_olt_conscius { get; set; }
        public string? id_olt_externo { get; set; }
        public string? conexoes_ultima_data { get; set; }
        public string? conexoes_ultima { get; set; }
        public string? fwversion { get; set; }
        public string? uptime { get; set; }
        public string? time { get; set; }
        public string? modelo { get; set; }
        public string? cpu_load { get; set; }
        public string? total_memory { get; set; }
        public string? free_memory { get; set; }
        public string? temperatura { get; set; }
        public string? voltagem { get; set; }
        public string? current_firmware { get; set; }
        public string? upgrade_firmware { get; set; }
        public string? id_olt { get; set; }
        public string? autosave { get; set; }
        public string? speed_lan { get; set; }
        public string? speed_wlan { get; set; }
        public string? rxrate { get; set; }
        public string? txrate { get; set; }
        public string? usa_vpn { get; set; }
        public string? busca_potencia { get; set; }
        public string? perfil_neutro_bridge { get; set; }
        public string? perfil_neutro_router { get; set; }
        public string? id_pv_grupo_backup { get; set; }
        public string? operador_neutro { get; set; }
    }
}
