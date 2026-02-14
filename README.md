# IxcNet 🚀

O **IxcNet** é um SDK (Software Development Kit) independente, desenvolvido para facilitar a integração e comunicação de aplicações externas com a API do software **IXC Provedor**.

📖 **[Documentação Oficial](https://kaua-alves-queiros.github.io/IxcNet/)** | 🌐 **[DeepWiki](https://deepwiki.com/kaua-alves-queiros/IxcNet/1-overview)**

Este projeto visa abstrair a complexidade das requisições HTTP e fornecer uma interface amigável, tipada e extensível para manipular os recursos do sistema IXC.

> [!IMPORTANT]
> **Aviso de Isenção:** Este projeto é uma iniciativa independente e **não possui vínculo oficial** com a empresa IXC Soft. O desenvolvimento e suporte são mantidos exclusivamente por [Kaua Alves Queiros](https://github.com/kaua-alves-queiros).
---

## 📋 Status de Desenvolvimento

Abaixo estão as rotas e as  funcionalidades que já estão sendo mapeadas e seus respectivos status de implementação:

Funcionalidade  | Status | Testado
------------------------- | ------ | -------
Setup | ✅ Funcional | ✅ Sim
QueryBuilder | ✅ Funcional | ✅ Sim
Inserir | ✅ Funcional | ✅ Sim
Listar | ✅ Funcional | ✅ Sim
Deletar | ❌ Não Implementado | ❌ Não
Alterar | ❌ Não Implementado | ❌ Não


Endpoint | Status | Testado
------------------------- | ------ | -------
/Sistema/Cadastro/Cliente | ✅ Implementado | ✅ Sim
/Sistema/Cadastro/Cliente-Contrato | ✅ Implementado | ✅ Sim
/Sistema/Cadastro/Clientes/Cliente-Condominio | ✅ Implementado | ✅ Sim
/Sistema/Cadastro/Estruturas | ✅ Implementado | ✅ Sim
/Sistema/Cadastro/Locais/Cidade | ✅ Implementado | ✅ Sim
/Sistema/FolhaDePagamento/Colaboradores/Funcionario | ✅ Implementado | ✅ Sim
/Sistema/FolhaDePagamento/Setor | ✅ Implementado | ✅ Sim
/Sistema/InMap/Elementos/CaixaDeAtendimento/Caixa | ✅ Implementado | ✅ Sim
/Sistema/Provedor/Transmissores/Login/Radusuario | ✅ Implementado | ✅ Sim
/Sistema/Suporte/Atendimento/SuTicket | ✅ Implementado | ✅ Sim
/Sistema/Suporte/Cadastro/SuDiagnostico | ✅ Implementado | ✅ Sim
/Sistema/Provedor/Suporte/Cadastro/Assunto | ✅ Implementado | ✅ Sim
/Sistema/Provedor/Suporte/Cadastro/OrdemDeServico/SuOssChamado | ✅ Implementado | ✅ Sim

ℹ️ *Nota: Todos os modelos acima possuem testes de sanidade automatizados.*

---

## 🗺️ Roadmap de Desenvolvimento

Este roadmap descreve as etapas planejadas para evolução do **IxcNet**.

### 🔹 Fase 1 — Consolidação da Base (Curto Prazo)
- ✅ **Estrutura base do SDK**
  - ✅ Padronização da estrutura do SDK
  - ✅ Client HTTP centralizado
  - ✅ Tratamento global de erros e exceções
  - ✅ Mecanismo de autenticação reutilizável
  - ✅ Criação e refinamento de DTOs
  - ✅ Documentação inicial
  - ✅ Adição de logs nos métodos Listar, Inserir
  - ✅ Pipeline de CI/CD (GitHub Actions)

### 🔹 Fase 2 — Expansão de Endpoints (Médio Prazo)
- [ ] 🔌 Cobertura funcional da API
  - ✅ Adicionar action de build da documentação DocFX
  - [ ] Adição de métodos Alterar e Excluir
  - ✅ Finalização dos endpoints já iniciados
  - ✅ Implementação de cadastros de clientes e contratos
  - ✅ Implementação de endereços e localidades
  - ✅ Implementação de suporte e ordens de serviço
  - ✅ Testes unitários básicos

### 🔹 Fase 3 — Qualidade e Estabilidade
- [ ] 🧪 Robustez e confiabilidade
  - ✅ Testes automatizados
  - ✅ Mock da API IXC
  - ✅ Padronização de respostas e exceções
  - [ ] Validação de payloads
  - [ ] Sistema de logging configurável

### 🔹 Fase 4 — Experiência do Desenvolvedor
- [ ] 👨‍💻 DX e distribuição
  - [ ] Exemplos práticos de uso
  - [ ] Documentação por endpoint
  - [ ] Publicação no NuGet
  - [ ] Changelog automatizado
  - [ ] Pipeline de CI/CD

### 🔹 Fase 5 — Comunidade e Evolução Contínua
- [ ] 🌱 Comunidade
  - [ ] Guia de contribuição
  - [ ] Templates de Issue e Pull Request
  - [ ] Roadmap versionado
    - [ ] Evolução baseada em feedback

---

## 📖 Guia de Uso

### 1. Configuração (`IxcNetService`)

Para começar a usar o **IxcNet**, você precisa instanciar o `IxcNetService` e configurá-lo com as credenciais da sua API IXC.

```csharp
using IxcNet.Services;

// Instancia o serviço
var ixcService = new IxcNetService();

// Configura o host e o token
// O host deve ser apenas o domínio ou IP (sem https://)
// O token é o token do webservice gerado no IXC Provedor
ixcService.Setup("seu_provedor.ixcsoft.com.br", "seu_token_aqui");
```

### 2. Listagem de Registros (`Listar`)

Para buscar dados, utilize o método `Listar<T>`, passando um `QueryBuilder` com os filtros desejados.

```csharp
using IxcNet.ViewModels;
using IxcNet.Models; // Onde estão seus modelos (ex: Cliente)

var query = new QueryBuilder();
query.AddFilter("razao", "LIKE", "João%"); // Filtro opcional
query.Page = 1;
query.Rp = 10; // Registros por página

var clientes = await ixcService.Listar<Cliente>(query);

if (clientes != null)
{
    foreach (var cliente in clientes)
    {
        Console.WriteLine(cliente.Razao);
    }
}
```

### 3. Inserção de Registros (`Inserir`)

Para criar novos registros, utilize o método `Inserir<T>`.

```csharp
var novoCliente = new Cliente 
{ 
    Razao = "Novo Cliente LTDA",
    Cnpj_Cpf = "12.345.678/0001-99"
    // ... preencha outros campos obrigatórios
};

var status = await ixcService.Inserir(novoCliente);

if (status == System.Net.HttpStatusCode.OK)
{
    Console.WriteLine("Cliente inserido com sucesso!");
}
```

---

## 🛠️ Tecnologias e Ferramentas

- **Linguagem:** C# / .NET  
- **Arquitetura:** SDK / Abstração de API REST  
- **Plataforma alvo:** Integrações para provedores ISP

---

## 🚀 Como utilizar (Preview)

Devido à falta de maturidade do projeto, ele ainda não será publicado no NuGet.  
Para testes, inclua o repositório como submódulo e adicione a referência do projeto à sua solução.

---

## 🤝 Contribuição e Suporte

Contribuições são bem-vindas e ajudam diretamente na evolução do IxcNet.

Como contribuir:

1. Faça um fork deste repositório.
2. Crie uma branch a partir da main.
   Exemplo:
   feature/novo-endpoint
   fix/tratamento-erros
3. Implemente sua alteração seguindo o padrão do projeto.
4. Sempre que possível, adicione testes.
5. Faça commits com mensagens claras e objetivas.
6. Abra um Pull Request descrevendo o que foi alterado.

Boas práticas:

- Mantenha o código organizado e legível.
- Evite misturar mudanças não relacionadas.
- Documente novos endpoints ou comportamentos.
- Prefira Pull Requests pequenos e objetivos.

Reportando bugs e sugestões:

- Utilize a aba Issues do GitHub.
- Descreva claramente o problema ou sugestão.
- Informe passos para reprodução, quando aplicável.
- Inclua exemplos de payloads ou respostas da API, se possível.

Toda contribuição, seja código, documentação ou feedback, é muito apreciada.

---

### Desenvolvido e mantido por:

**Kaua Alves Queiros**

[![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/kaua-alves-queiros) 
[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/kaua-a-queiros-c-silva-09956a21b/)

---
