
# JSON Scripts for CRUD Operations on CadastroEmpresa

## Create (POST)
URL: /api/cadastroempresa
```json
{
    "razaoSocial": "Empresa Exemplo",
    "cnpj": "12345678901234",
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
```

## Read (GET)
URL: /api/cadastroempresa

## Update (PUT)
URL: /api/cadastroempresa/{id}
```json
{
    "razaoSocial": "Empresa Exemplo Atualizada",
    "setorAtuacao": "Tecnologia",
    "porte": "Médio"
}
```

## Delete (DELETE)
URL: /api/cadastroempresa/{id}
```

These JSON snippets demonstrate CRUD operations for testing the API.
