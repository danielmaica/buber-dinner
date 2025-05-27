# Day One — Progresso de Desenvolvimento

## Como cheguei até aqui

### 1. Configuração Inicial do Projeto

- Criei uma solução .NET 9.0:
  ```bash
  dotnet new sln -n BuberDinner
  ```
- Estruturei o projeto seguindo Clean Architecture:
  - `BuberDinner.Api` (apresentação/API)
  - `BuberDinner.Application` (lógica de aplicação)
  - `BuberDinner.Domain` (entidades e regras de negócio)
  - `BuberDinner.Infrastructure` (infraestrutura: autenticação, persistência)
  - `BuberDinner.Contracts` (DTOs/contratos)
- Adicionei referências entre os projetos conforme a arquitetura.

---

### 2. Configuração da Autenticação JWT

- Criei a classe `JwtSettings` para armazenar configurações do JWT (Issuer, Audience, Secret, Expiry).
- Configurei o `appsettings.json` com um secret seguro (mínimo 32 caracteres).
- Implementei a interface `IJwtTokenGenerator` e a classe `JwtTokenGenerator` para geração de tokens JWT.

---

### 3. Serviços de Autenticação

- Criei a interface `IAuthenticationService` e a implementação `AuthenticationService`.
- Implementei os métodos `Register` e `Login` para registrar e autenticar usuários, retornando JWT.

---

### 4. Controllers e Endpoints

- Criei o `AuthenticationController` na camada API.
- Implementei os endpoints:
  - `POST /auth/register` para registro de usuários
  - `POST /auth/login` para autenticação
- Testei os endpoints usando arquivos `.http` e ferramentas como Postman.

---

### 5. Documentação e Organização

- Documentei o projeto no `Readme.md`, explicando arquitetura, endpoints, execução e configuração do JWT.
- Organizei a estrutura de pastas conforme Clean Architecture.

---

### 6. Resolução de Problemas

- Corrigi problemas de build causados por arquivos bloqueados (parando processos em execução).
- Ajustei o tamanho do secret JWT para evitar erros de chave curta.
- Testei o fluxo de autenticação e validei o payload do JWT.

---

### 7. Pacotes NuGet Utilizados

- `Microsoft.AspNetCore.Authentication.JwtBearer`
- `Microsoft.IdentityModel.Tokens`
- `System.IdentityModel.Tokens.Jwt`
- `Microsoft.Extensions.Options`
- `Microsoft.AspNetCore.Mvc`
- Outros pacotes padrão do .NET para API e DI

---

### 8. Próximos Passos

- Expandir funcionalidades (ex: gerenciamento de jantares)
- Implementar persistência real de usuários
- Adicionar testes automatizados
- Melhorar a segurança e tratamento de erros

---

**Resumo:**  
Hoje saí do zero, estruturei o projeto em camadas, implementei autenticação JWT, criei endpoints REST, documentei e testei tudo, seguindo boas práticas de arquitetura e segurança.
