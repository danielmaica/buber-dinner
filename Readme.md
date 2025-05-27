# BuberDinner API Documentation

## 📝 Descrição

BuberDinner é uma API desenvolvida em .NET 9.0, baseada em Clean Architecture, para gerenciamento de autenticação e jantares colaborativos.

## 🏗️ Arquitetura do Projeto

O projeto está estruturado em camadas:

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
Retorna um JWT e dados do usuário autenticado.

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
Retorna um JWT e dados do usuário autenticado.

## 🛠️ Tecnologias Utilizadas

- .NET 9.0
- Clean Architecture
- JWT Authentication
- REST API

## ⚙️ Como Executar

1. Clone o repositório
2. Na raiz do projeto, execute:
   ```bash
   dotnet build
   dotnet run --project BuberDinner.Api
   ```

## 🔒 Configuração do JWT

No arquivo `appsettings.json`, configure o secret JWT com pelo menos 32 caracteres:

```json
"Jwt": {
  "Issuer": "BuberDinner",
  "Audience": "BuberDinner",
  "Secret": "sua-chave-super-secreta-com-32-caracteres-ou-mais",
  "ExpiryInMinutes": 60
}
```

> **Importante:** Nunca compartilhe o secret publicamente.

## 📦 Estrutura de Pastas

```
BuberDinner/
├── BuberDinner.Api/           # API Layer
├── BuberDinner.Application/   # Application Layer
├── BuberDinner.Domain/        # Domain Layer
├── BuberDinner.Infrastructure/# Infrastructure Layer
└── BuberDinner.Contracts/     # DTOs and Contracts
```

## 🔄 Fluxo da Aplicação

1. Requisições HTTP chegam pela camada API
2. Application processa comandos/queries e regras de negócio
3. Domain define entidades e validações
4. Infrastructure lida com autenticação, persistência e integrações externas

---

_Documentação em desenvolvimento. Novos endpoints e funcionalidades serão adicionados conforme o projeto evolui._
