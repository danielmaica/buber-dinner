# BuberDinner API Documentation

## 📝 Descrição
BuberDinner é uma API desenvolvida em .NET que implementa uma arquitetura limpa (Clean Architecture) com separação clara de responsabilidades.

## 🏗️ Arquitetura do Projeto

O projeto está estruturado em camadas:

- **BuberDinner.Api**: Camada de apresentação/API
- **BuberDinner.Application**: Lógica de aplicação e casos de uso
- **BuberDinner.Domain**: Regras de negócio e entidades
- **BuberDinner.Infrastructure**: Implementações de persistência e serviços externos
- **BuberDinner.Contracts**: Contratos/DTOs da API

## 🚀 Endpoints

### WeatherForecast
```http
GET http://localhost:5136/weatherforecast
```
Headers:
```
Accept: application/json
```

## 🛠️ Tecnologias Utilizadas

- .NET 9.0
- Clean Architecture
- REST API

## ⚙️ Como Executar

1. Clone o repositório
2. Na raiz do projeto, execute:
```bash
dotnet build
dotnet run --project BuberDinner.Api
```

## 🔒 Ambiente de Desenvolvimento

A API roda por padrão em:
- URL: `http://localhost:5136`

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

1. As requisições HTTP são recebidas pela camada API
2. A camada de Application processa os comandos/queries
3. O Domain contém as regras de negócio
4. A Infrastructure lida com persistência e serviços externos

---

*Documentação em desenvolvimento. Mais endpoints e funcionalidades serão adicionados conforme o projeto evolui.* 