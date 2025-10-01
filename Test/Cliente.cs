using IxcNet.Services;
using IxcNet.ViewModels.Sistema.Cadastros;
using System.Text;
using System.Text.Json;

namespace Test
{
    public class Cliente
    {
        IxcNetService ixcNet = new IxcNetService();
        string apiHost = Environment.GetEnvironmentVariable("IXC_HOST");
        string token = Environment.GetEnvironmentVariable("IXC_TOKEN");

        public Cliente()
        {
            ixcNet.Setup(apiHost, token);
        }

        [Fact]
        public async Task ClienteList_Should_Return_One_Client_When_MaxResults_Is_One()
        {
            var query = QueryBuilder.List();
            query.MaxResults = "1";
            var clientes = await ixcNet.Listar<ClienteViewModel>(query);
            Assert.Equal(1, clientes.Count());
        }

        [Fact]
        public async Task ClienteList_Should_Return_Two_Clients_When_MaxResults_Is_Two()
        {
            var query = QueryBuilder.List();
            query.MaxResults = "2";
            var clientes = await ixcNet.Listar<ClienteViewModel>(query);
            Assert.Equal(2, clientes.Count());
        }

        [Fact]
        public async Task ClientList_Should_Return_Client_With_Id_One_Where_Query_Is_SpecificId()
        {
            var query = QueryBuilder.Where("id", "==", "42079");
            query.ModelName = "cliente";
            query.MaxResults = "1";
            var clientes = await ixcNet.Listar<ClienteViewModel>(query);
            Assert.Equal(clientes.First().id, "42079");
        }

        [Fact]

        public async Task CreateClient()
        {
            var cliente = new ClienteViewModel
            {
                ativo = "S",
                id_tipo_cliente = "1",
                tipo_cliente_scm = "01",
                tipo_pessoa = "F",
                razao = "TESTE IXC NET 2",
                fantasia = "TESTE FANTASIA",
                cnpj_cpf = "175.181.720-20",
                ie_identidade = "123456789",
                contribuinte_icms = "I",
                rg_orgao_emissor = "SSP/PR",
                nacionalidade = "Brasileiro",
                cidade_naturalidade = "Curitiba",
                estado_nascimento = "PR",
                data_nascimento = "1990-05-15",
                profissao = "Analista de Sistemas",
                estado_civil = "Casado(a)",
                inscricao_municipal = "123456",
                isuf = "7890",
                tipo_assinante = "1",
                filial_id = "1",
                filtra_filial = "N",
                idx = "0",
                ativo_serasa = "S",
                convert_cliente_forn = "N",
                atualizar_cadastro_galaxPay = "N",
                id_condominio = "1",
                bloco = "A",
                apartamento = "101",
                cep = "83215-210",
                cif = "C",
                endereco = "Rua Teste",
                numero = "1200",
                complemento = "Apartamento 1",
                bairro = "Teste",
                cidade = "1",
                referencia = "Próximo à praça",
                uf = "PR",
                tipo_localidade = "U",
                latitude = "-25.4284",
                longitude = "-49.2733",
                cep_cob = "83215-210",
                endereco_cob = "Rua Teste Cobrança",
                numero_cob = "200",
                bairro_cob = "Bairro Cobrança",
                cidade_cob = "1",
                complemento_cob = "Complemento",
                referencia_cob = "Próximo à loja",
                uf_cob = "PR",
                fone = "41999999999",
                telefone_comercial = "4133333333",
                ramal = "123",
                id_operadora_celular = "1",
                telefone_celular = "41988888888",
                whatsapp = "S",
                email = "teste@exemplo.com",
                contato = "Contato Teste",
                website = "www.exemplo.com",
                skype = "teste_skype",
                facebook = "https://facebook.com/teste",
                hotsite_email = "hotsite@exemplo.com",
                senha = "senha123",
                acesso_automatico_central = "S",
                alterar_senha_primeiro_acesso = "S",
                senha_hotsite_md5 = "md5hash",
                hotsite_acesso = "S",
                crm = "S",
                id_candato_tipo = "1",
                id_campanha = "1",
                id_concorrente = "1",
                id_perfil = "1",
                responsavel = "Responsavel Teste",
                indicado_por = "Indicado Teste",
                cadastrado_via_viabilidade = "S",
                status_prospeccao = "1",
                // Campos de data corrigidos
                crm_data_novo = DateTime.Now.ToString("yyyy-MM-dd"),
                crm_data_sondagem = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd"),
                crm_data_apresentando = DateTime.Now.AddDays(-2).ToString("yyyy-MM-dd"),
                crm_data_negociando = DateTime.Now.AddDays(-3).ToString("yyyy-MM-dd"),
                crm_data_vencemos = DateTime.Now.AddDays(-4).ToString("yyyy-MM-dd"),
                crm_data_perdemos = DateTime.Now.AddDays(-5).ToString("yyyy-MM-dd"),
                crm_data_abortamos = DateTime.Now.AddDays(-6).ToString("yyyy-MM-dd"),
                crm_data_sem_porta_disponivel = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd"),
                crm_data_sem_viabilidade = DateTime.Now.AddDays(-8).ToString("yyyy-MM-dd"),
                foto_cartao = "foto_base64_aqui",
                participa_cobranca = "S",
                num_dias_cob = "5",
                participa_pre_cobranca = "S",
                cob_envia_email = "S",
                cob_envia_sms = "S",
                id_conta = "1",
                cond_pagamento = "1",
                id_vendedor = "1",
                tabela_preco = "1",
                deb_automatico = "N",
                deb_agencia = "1234",
                deb_conta = "56789",
                codigo_operacao = "013",
                tipo_pessoa_titular_conta = "F",
                cnpj_cpf_titular_conta = "175.181.720-20",
                nome_pai = "Pai Teste",
                cpf_pai = "111.111.111-11",
                identidade_pai = "987654",
                nascimento_pai = "1960-01-01",
                nome_mae = "Mae Teste",
                cpf_mae = "222.222.222-22",
                identidade_mae = "654321",
                nascimento_mae = "1965-02-02",
                quantidade_dependentes = "2",
                nome_conjuge = "Conjuge Teste",
                fone_conjuge = "41977777777",
                cpf_conjuge = "333.333.333-33",
                rg_conjuge = "112233",
                data_nascimento_conjuge = "1992-03-03",
                nome_contador = "Contador Teste",
                telefone_contador = "41966666666",
                orgao_publico = "N",
                im = "12345",
                nome_representante_1 = "Rep 1",
                cpf_representante_1 = "444.444.444-44",
                identidade_representante_1 = "123123",
                nome_representante_2 = "Rep 2",
                cpf_representante_2 = "555.555.555-55",
                identidade_representante_2 = "321321",
                iss_classificacao_padrao = "00",
                desconto_irrf_valor_inferior = "0.0",
                ref_com_empresa1 = "Empresa Com 1",
                ref_com_fone1 = "4132101234",
                ref_com_empresa2 = "Empresa Com 2",
                ref_com_fone2 = "4132104321",
                ref_pes_nome1 = "Pessoa 1",
                ref_pes_fone1 = "41955555555",
                ref_pes_nome2 = "Pessoa 2",
                ref_pes_fone2 = "41944444444",
                obs = "Observação de teste",
                alerta = "Alerta de teste"
            };


            var result = await ixcNet.Inserir(cliente);
        }
    }
}