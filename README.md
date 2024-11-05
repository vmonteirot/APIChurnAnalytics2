# API Churn Analytics

## Descrição

Esta API foi desenvolvida em .NET Core para a análise de churn de clientes. Ela fornece endpoints para operações CRUD em dados de empresas, feedbacks, e outras informações relacionadas ao comportamento do cliente. A API se integra a um banco de dados Oracle em nuvem e inclui funcionalidades de autenticação e análise de sentimento usando ML.NET.

## Requisitos

- **Banco de dados**: Oracle (em nuvem).
- **Ambiente de Deploy**: Azure App Service.
- **Pipeline de CI/CD**: Azure DevOps.

## Estrutura da API

- **AuthController**: Gerencia autenticação com um serviço externo.
- **CadastroEmpresaController**: Endpoints CRUD para cadastro de empresas.
- **SentimentController**: Endpoint para análise de sentimento.

## Configuração de Pipeline no Azure DevOps

### 1. Pipeline de Build

A pipeline de build realiza o seguinte:
- Restauração de pacotes
- Compilação do projeto
- Publicação dos artefatos

#### Arquivo YAML de Build (Exemplo)

Crie uma pipeline de build em Azure DevOps com o arquivo yaml fornecido no projeto. No caso, a versão 'azure-pipelines-1.yml'
### 2. Pipeline de Release

A pipeline de release utiliza o artefato gerado pelo build e o implanta no Serviço de Aplicativo da Azure.

#### Etapas para Configurar a Pipeline de Release

1. No Azure DevOps, vá para **Pipelines > Releases**.
2. Adicione um novo pipeline de release e configure-o para usar o artefato do build.
3. Adicione uma tarefa de **Azure App Service Deploy** no estágio de deploy.
4. Configure o Serviço de Aplicativo, a assinatura do Azure e as variáveis de ambiente (como a string de conexão do banco de dados).

## Executando a API e Testando CRUD

### Configuração Local

1. Clone o repositório.
   \`\`\`bash
   git clone https://github.com/vmonteirot/APIChurnAnalytics2
   cd APIChurnAnalytics2
   \`\`\`

2. Atualize a string de conexão no `appsettings.json` para apontar para seu banco de dados Oracle.

3. Compile e execute o projeto.
   \`\`\`bash
   dotnet build
   dotnet run
   \`\`\`

4. Acesse a API no Swagger em:
   \`\`\`
   https://localhost:5001/swagger/index.html
   \`\`\`

### Scripts JSON para Operações CRUD

Estes são exemplos de scripts JSON para operações CRUD na API.

#### Create (POST)
URL: `/api/cadastroempresa`

\`\`\`json
{
  "razaoSocial": "Empresa Exemplo",
  "cnpj": "12345678000100",
  "setorAtuacao": "Tecnologia",
  "porte": "Grande",
  "endereco": "Rua Exemplo, 123",
  "numero": 100,
  "bairro": "Centro",
  "cidade": "São Paulo",
  "estado": "SP",
  "cep": "01001000",
  "pais": "Brasil",
  "nomeContatoPrincipal": "João da Silva",
  "cargoContatoPrincipal": "Diretor",
  "emailContato": "contato@empresaexemplo.com",
  "telefoneContato": "(11) 98765-4321",
  "produtoServicoAdquirido": "SaaS",
  "valorCompra": 100000,
  "receitaAnual": 5000000,
  "lucratividade": 20
}
\`\`\`

#### Read (GET)
URL: `/api/cadastroempresa`

#### Update (PUT)
URL: `/api/cadastroempresa/{id}`

\`\`\`json
{
  "razaoSocial": "Empresa Atualizada",
  "setorAtuacao": "Saúde",
  "porte": "Médio"
}
\`\`\`

#### Delete (DELETE)
URL: `/api/cadastroempresa/{id}`

## Executando os Testes

Para rodar os testes do projeto:

1. Compile os testes:
   \`\`\`bash
   dotnet test
   \`\`\`

2. Verifique os resultados no console.

## Variáveis de Ambiente

No **Azure App Service**, configure a variável `ASPNETCORE_ENVIRONMENT` para `Production`. Adicione também outras variáveis de ambiente, como a string de conexão do banco de dados.
"""

# Save the content as README.md
readme_path = '/mnt/data/README.md'
with open(readme_path, 'w') as readme_file:
    readme_file.write(readme_content)

readme_path
