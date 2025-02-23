# 📌 Template de API 

**Este template fornece uma estrutura modular para a criação de APIs de forme generica, facilitando a organização do código e a implementação de boas práticas de desenvolvimento. Abaixo está a explicação de cada parte do projeto.**

## 📂 Estrutura do Projeto

📂 ApiTemplate/  
┣ 📂 ApiTemplate.API/            → Exposição dos endpoints  

┣ 📂 ApiTemplate.Application/    → Regras de negócio  

┣ 📂 ApiTemplate.Domain/        → Entidades e contratos  

┣ 📂 ApiTemplate.Infrastructure/ → Persistência e acesso ao banco  

┣ 📂 ApiTemplate.Infra.IoC/     → Injeção de dependências  


# 📂 ApiTemplate.API/ (Camada de Apresentação)

Esta camada é responsável por expor os endpoints da API. Aqui são configurados os controladores e a interação com a camada de aplicação.

## Responsabilidades:

Configuração do ASP.NET Core.

Exposição dos endpoints via controllers.

Tratamento de requisições e respostas.

Aplicação de autenticação e autorização.

## Principais Arquivos:

Controllers/ → Contém os controladores da API.

Program.cs → Configuração inicial da API.

appsettings.json → Configuração do ambiente e conexão com banco.


# 📂 ApiTemplate.Application/ (Regras de Negócio)

Nesta camada ficam as regras de negócio da aplicação. Aqui também é feita a comunicação entre a API e a camada de domínio.

## Responsabilidades:

Implementação dos serviços de aplicação.

Validação de dados e regras de negócio.

Uso do AutoMapper para conversão entre DTOs e entidades.

## Principais Arquivos:

Interfaces/ → Contém as interfaces dos serviços de aplicação.

Services/ → Implementações das regras de negócio.

DTOs/ → Modelos de transferência de dados (Data Transfer Objects).

Mappings/ → Configuração do AutoMapper.


# 📂 ApiTemplate.Domain/ (Camada de Domínio)

Essa camada contém as entidades e contratos que representam o modelo de negócio da aplicação.

## Responsabilidades:

Definição das entidades e contratos.

Implementação das interfaces para repositórios.

Definição das exceções de domínio.

## Principais Arquivos:

Entities/ → Modelos de entidades do domínio.

Interfaces/ → Contratos dos repositórios.

Exceptions/ → Exceções personalizadas para o domínio.


# 📂 ApiTemplate.Infrastructure/ (Acesso ao Banco de Dados)

Camada responsável por implementar a persistência dos dados e a comunicação com o banco de dados.

## Responsabilidades:

Implementação dos repositórios.

Configuração do Entity Framework Core.

Definição do contexto do banco de dados.

## Principais Arquivos:

Repositories/ → Implementações dos repositórios.

Context/ → Configuração do Entity Framework.

Migrations/ → Gerenciamento de migrações do banco de dados.


# 📂 ApiTemplate.Infra.IoC/ (Injeção de Dependências)

Esta camada é responsável por configurar a injeção de dependências da aplicação.

## Responsabilidades:

Configuração dos serviços na API.

Registro das dependências para DI (Dependency Injection).

Facilita a manutenção e escalabilidade do projeto.

## Principais Arquivos:

DependencyInjection.cs → Configuração central de DI.

** Este template foi desenvolvido para facilitar o desenvolvimento de APIs de pagamento, garantindo organização e boas práticas. Qualquer dúvida, sinta-se à vontade para contribuir! 😊 **