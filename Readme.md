# BuberDinner API Documentation

## 📝 Descrição

BuberDinner é uma API desenvolvida em .NET 9.0, baseada em Clean Architecture, para gerenciamento de autenticação e jantares colaborativos.

## 🏗️ Arquitetura do Projeto

O projeto está estruturado em camadas seguindo os princípios da Clean Architecture:

- **BuberDinner.Api**: Camada de apresentação/API (controllers, middlewares)
- **BuberDinner.Application**: Lógica de aplicação, casos de uso, interfaces de serviços
- **BuberDinner.Domain**: Entidades e regras de negócio
- **BuberDinner.Infrastructure**: Persistência, autenticação (JWT), serviços externos
- **BuberDinner.Contracts**: Contratos/DTOs usados na comunicação entre API e clientes

## 🚀 Endpoints Principais

### Autenticação

#### Registrar Usuário

```http
POST http://localhost:5136/auth/register
Content-Type: application/json

{
  "firstName": "Daniel",
  "lastName": "Maica",
  "email": "danielmaica.dev@gmail.com",
  "password": "1234567"
}
```

**Resposta:**  
```json
{
  "id": "00000000-0000-0000-0000-000000000000",
  "firstName": "Daniel",
  "lastName": "Maica",
  "email": "danielmaica.dev@gmail.com",
  "token": "seu.jwt.token"
}
```

#### Login

```http
POST http://localhost:5136/auth/login
Content-Type: application/json

{
  "email": "danielmaica.dev@gmail.com",
  "password": "1234567"
}
```

**Resposta:**  
```json
{
  "id": "00000000-0000-0000-0000-000000000000",
  "firstName": "Daniel",
  "lastName": "Maica",
  "email": "danielmaica.dev@gmail.com",
  "token": "seu.jwt.token"
}
```

## 🛠️ Tecnologias e Padrões Utilizados

- .NET 9.0
- Clean Architecture
- JWT Authentication
- REST API
- Repository Pattern
- Dependency Injection
- Interface Segregation

## ⚙️ Como Executar

1. Clone o repositório
2. Na raiz do projeto, execute:
   ```bash
   dotnet build
   dotnet run --project BuberDinner.Api
   ```

## 🔒 Configuração do JWT

No arquivo `appsettings.json`, configure as seguintes propriedades:

```json
"JwtSettings": {
  "Secret": "",
  "Issuer": "BuberDinner",
  "Audience": "BuberDinnerUsers",
  "ExpiryInMinutes": 1440
}
```

> **Importante:** Configure um Secret com pelo menos 32 caracteres e nunca o compartilhe publicamente.

## 📦 Estrutura do Projeto

```
BuberDinner/
├── BuberDinner.Api/           # Controllers, Middlewares, Configurações
├── BuberDinner.Application/   # Serviços, Interfaces, Regras de Negócio
├── BuberDinner.Domain/        # Entidades, Regras de Domínio
├── BuberDinner.Infrastructure/# Implementações (Auth, Persistence)
└── BuberDinner.Contracts/     # DTOs, Requests, Responses
```

## 🔄 Fluxo da Aplicação

1. Requisições HTTP chegam aos Controllers na camada API
2. Controllers mapeiam requests para DTOs e chamam serviços apropriados
3. Application processa a lógica de negócio usando interfaces
4. Infrastructure implementa as interfaces (repositórios, autenticação)
5. Domain mantém as entidades e regras de negócio centrais

## 💾 Persistência

Atualmente, a aplicação utiliza armazenamento em memória através de uma lista estática no `UserRepository`. 
Isso significa que os dados são perdidos quando a aplicação é reiniciada.

### Próximas Implementações Planejadas:
- Persistência com banco de dados real
- Hash de senhas
- Refresh tokens
- Autorização baseada em roles
- Validações mais robustas
- Logs e monitoramento

## 🔐 Segurança

- Autenticação via JWT Token
- Tokens com tempo de expiração configurável
- Preparado para implementação de hash de senhas
- Configurações sensíveis via variáveis de ambiente

---

_Documentação em constante evolução. Novas funcionalidades serão adicionadas conforme o projeto se desenvolve._
