using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IxcNet.ViewModels.Sistema.Provedor
{
    public class FilialViewModel
    {
        // Identificação Básica
        public string? id { get; set; }
        public string? id_empresa { get; set; }
        public string? razao { get; set; }
        public string? fantasia { get; set; }
        public string? ativo { get; set; }
        public string? cnpj { get; set; }
        public string? ie { get; set; }
        public string? im { get; set; }
        public string? iest { get; set; }
        public string? tipo_pessoa { get; set; }

        // Localização e Contato
        public string? endereco { get; set; }
        public string? numero { get; set; }
        public string? complemento { get; set; }
        public string? bairro { get; set; }
        public string? cidade { get; set; }
        public string? cep { get; set; }
        public string? telefone { get; set; }
        public string? telefone1 { get; set; }
        public string? fax { get; set; }
        public string? email { get; set; }
        public string? email_suporte { get; set; }
        public string? whatsapp { get; set; }
        public string? facebook { get; set; }
        public string? site { get; set; }
        public string? latitude { get; set; }
        public string? longitude { get; set; }
        public string? cor_mapa { get; set; }

        // Dados do Contador
        public string? contador { get; set; }
        public string? contador_nome { get; set; }
        public string? contador_cnpj { get; set; }
        public string? contador_cpf { get; set; }
        public string? contador_crc { get; set; }
        public string? contador_uf { get; set; }
        public string? contador_cep { get; set; }
        public string? contador_cidade { get; set; }
        public string? contador_endereco { get; set; }
        public string? contador_numero { get; set; }
        public string? contador_complemento { get; set; }
        public string? contador_bairro { get; set; }
        public string? contador_telefone { get; set; }
        public string? contador_fax { get; set; }
        public string? contador_email { get; set; }

        // Configurações Fiscais e NF-e
        public string? nfe_ambiente { get; set; }
        public string? nfe_formato_imp { get; set; }
        public string? nfe_canhoto { get; set; }
        public string? nfe_certificado { get; set; }
        public string? nfe_chave { get; set; }
        public string? nfe_email { get; set; }
        public string? nfe_email_senha { get; set; }
        public string? nfe_inf_complementar { get; set; }
        public string? nfe_envia_pdf_email { get; set; }
        public string? nfe_envia_xml_email { get; set; }
        public string? nfe_id_email_envio_cliente { get; set; }
        public string? nfe_id_envio_email_fornecedor { get; set; }
        public string? nfe_ambiente_62 { get; set; }

        // NFSe e NFCe
        public string? nfse_padrao { get; set; }
        public string? nfse_senha_acesso { get; set; }
        public string? nfse_cod_cidade { get; set; }
        public string? nfse_client_id { get; set; }
        public string? nfse_client_secret { get; set; }
        public string? nfse_aedf { get; set; }
        public string? nfse_cfps { get; set; }
        public string? nfce_imprime_produtos { get; set; }
        public string? nfce_id_token { get; set; }
        public string? nfce_csc { get; set; }
        public string? usuario_nfse { get; set; }

        // Tributação
        public string? cnae { get; set; }
        public string? id_cnae { get; set; }
        public string? cnae_complementar { get; set; }
        public string? rt { get; set; }
        public string? rt_especial { get; set; }
        public string? insentivo_cultural { get; set; }
        public string? insentivo_fiscal { get; set; }
        public string? opcao_simples { get; set; }
        public string? iss_exigibilidade { get; set; }
        public string? regime_fiscal_col { get; set; }
        public string? tributacao_por_ramo_de_atividade { get; set; }
        public string? forma_tributacao { get; set; }
        public string? cod_classificacao_tribut_cbs_ibs { get; set; }
        public string? cod_situacao_tribut_cbs_ibs { get; set; }
        public string? base_calculo_cbs_ibs { get; set; }
        public string? regime_apuracao_tributaria_sn { get; set; }
        public string? reducao_aliquota { get; set; }
        public string? total_tributos_simples { get; set; }

        // Logos e Assinaturas
        public string? logo { get; set; }
        public string? logo_docs { get; set; }
        public string? img_assinatura { get; set; }
        public string? background_cor { get; set; }

        // Integrações e Contratos
        public string? token { get; set; }
        public string? token_rdstation { get; set; }
        public string? integracao_assinatura_digital { get; set; }
        public string? envia_email_assinatura_digital_contrato { get; set; }
        public string? smtp_envio_email_assinatura_contrato_digital { get; set; }
        public string? email_envio_contrato_assinado_filial { get; set; }
        public string? id_canal_venda_marketing { get; set; }
        public string? id_integracao_serasa { get; set; }
        public string? permite_conversoes_duplicadas { get; set; }
        public string? importar_dfe_automaticamente { get; set; }

        // Outros campos técnicos IXC
        public string? curl_type { get; set; }
        public string? centro_custo_status { get; set; }
        public string? centro_custo_data_ativacao { get; set; }
        public string? gerar_login { get; set; }
        public string? padrao_gerar_login { get; set; }
        public string? tipo_documento_nota_entrada { get; set; }
        public string? tipo_documento_nota_saida { get; set; }
        public string? mostrar_info_adicionais_anatel { get; set; }
        public string? enviar_im { get; set; }
        public string? sici_numero_fistel { get; set; }
        public string? desc_auxiliar_fone_os { get; set; }
        public string? ramal { get; set; }
        public string? contato { get; set; }
        public string? id_rps_modelo_impressao { get; set; }
        public string? id_filial_doc_opcional { get; set; }
        public string? id_filial_doc_opc2 { get; set; }
        public string? id_filial_doc_opc3 { get; set; }
        public string? id_filial_doc_opc4 { get; set; }
        public string? id_filial_isss_exig { get; set; }
        public string? enviar_email_suporte { get; set; }
        public string? envia_anexo_pdf { get; set; }
        public string? id_envio_email_personalizado { get; set; }
        public string? numero_eot { get; set; }
        public string? tv_id_regiao { get; set; }
        public string? identificador_na_febraban { get; set; }
        public string? inserir_inf_adic_contrato_descricao_servico { get; set; }
        public string? tipo_documento_identificacao_col { get; set; }
        public string? ciiu_col { get; set; }
        public string? amb_nacional { get; set; }
        public string? op_uso_consumo_pessoal { get; set; }
    }
}