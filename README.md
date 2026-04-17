# GestaoPessoasApi

API REST em .NET 8 para cadastro, consulta, edição e exclusão de pessoas usando Entity Framework Core e SQL Server.

## Ferramentas Utilizadas

- [.NET SDK](https://dotnet.microsoft.com/en-us/download)
- [Entity Framework Core CLI](https://learn.microsoft.com/pt-br/ef/core/cli/dotnet)
- [Swashbuckle.AspNetCore](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)

## Configuração do Ambiente

1. **Instale o .NET SDK**:
    - Baixe e instale o SDK do .NET a partir do [site oficial](https://dotnet.microsoft.com/en-us/download).

2. **Instale o Entity Framework Core CLI**:
    - Siga as instruções disponíveis na [documentação oficial](https://learn.microsoft.com/pt-br/ef/core/cli/dotnet) para instalar a CLI do Entity Framework Core.

## String de Conexão

Configure a string de conexão para SQL Server no arquivo `appsettings.json`:

```json
"ConnectionStrings": {
    "DefaultConnection": "Server=seu_servidor;Database=sua_base_de_dados;User Id=seu_usuario;Password=sua_senha;"
}
```

## Executando a Aplicação

1. Clone este repositório:
    ```bash
git clone https://github.com/seu_usuario/GestaoPessoasApi.git
```

2. Navegue até o diretório do projeto:
    ```bash
cd GestaoPessoasApi
```

3. Restaurar os pacotes:
    ```bash
dotnet restore
```

4. Atualizar o banco de dados:
    ```bash
dotnet ef database update
```

5. Iniciar a aplicação:
    ```bash
dotnet run
```

6. Acesse a documentação Swagger em:
    ```
https://localhost:7146/swagger
```

## O que esta API faz

- Cria e gerencia registros de pessoas
- Oferece endpoints REST para CRUD
- Usa Entity Framework Core para persistência no SQL Server
- Inclui suporte a Swagger para testes e documentação
