# DayTwo - Implementação da Autenticação e Estrutura Base

## 🎯 O que foi implementado

### 1. Estrutura do Projeto (Clean Architecture)
- Criação dos projetos seguindo Clean Architecture:
  - `BuberDinner.Api`: Camada de apresentação
  - `BuberDinner.Contracts`: DTOs e contratos da API
  - `BuberDinner.Infrastructure`: Implementações concretas
  - `BuberDinner.Application`: Regras de negócio e interfaces
  - `BuberDinner.Domain`: Entidades e regras de domínio

### 2. Autenticação
- Implementação do sistema de autenticação com:
  - Registro de usuários
  - Login
  - Geração de JWT Token

### 3. Componentes Principais

#### 3.1 Entidades
- Implementação da entidade `User` com propriedades básicas:
  - Id (Guid)
  - FirstName
  - LastName
  - Email
  - Password

#### 3.2 Repositórios
- Interface `IUserRepository` com métodos:
  - `AddUser`
  - `GetUserByEmail`
- Implementação em memória usando `List<User>` estática

#### 3.3 Serviços
- `AuthenticationService` implementando:
  - Registro de usuários
  - Login
  - Validações básicas
- `JwtTokenGenerator` para geração de tokens JWT

#### 3.4 Controllers
- `AuthenticationController` com endpoints:
  - POST /auth/register
  - POST /auth/login

### 4. Persistência
- Implementação de repositório em memória
- Uso de lista estática para armazenamento temporário
- Preparação para futura implementação com banco de dados

### 5. Configurações
- Configuração do JWT:
  - Secret
  - Issuer
  - Audience
  - ExpiryInMinutes

## 🔧 Padrões Utilizados
- Dependency Injection
- Repository Pattern
- Clean Architecture
- Interface Segregation

## 📝 Próximos Passos
1. Implementar persistência com banco de dados real
2. Adicionar validações mais robustas
3. Implementar hash de senha
4. Adicionar refresh tokens
5. Implementar autorização baseada em roles

## 🚀 Como Testar

### Registro de Usuário
```http
POST http://localhost:5136/auth/register
Content-Type: application/json

{
  "firstName": "John",
  "lastName": "Doe",
  "email": "john.doe@example.com",
  "password": "password123"
}
```

### Login
```http
POST http://localhost:5136/auth/login
Content-Type: application/json

{
  "email": "john.doe@example.com",
  "password": "password123"
}
```

## 🔒 Segurança
- Implementação básica de JWT
- Preparação para futura implementação de hash de senha
- Tokens com expiração configurável

## 📚 Referências
- Clean Architecture
- JWT Authentication
- ASP.NET Core Web API
- Repository Pattern 