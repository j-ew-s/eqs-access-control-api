# Projeto API EQS

Este projeto é parte do teste apresentado pela EQS. A segunda parte é o cliente Web feito no framework Angular (5) e pode ser encontrado neste link.

### Tecnologias utilizadas 
* .Net Core 2.1
* Entity Framework Core
* AutoMapper
* JWT

### Organização do projeto
##### API
* Controllers
* Configuração JWT
* Configuração Autorização

##### Application
* AutoMapper
* ViewModel e ResponseModels
* Regras da aplicação

##### Domain
* Entidades
* Registro das interfaces de Serviço e Repositório
* Registro das regras de negócio
* Aplicação das regras de negócio de acordo com a ação executada (Salvar, remover , etc)

##### Infra
* Acesso a dados
* Configuração das Tabelas do Banco
* Execução do Repositório
* Migrations
