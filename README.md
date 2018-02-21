# Projeto API EQS

Este projeto é parte do teste apresentado pela EQS. A segunda parte é o cliente Web feito no framework Angular (5) e pode ser encontrado neste [Link](https://github.com/j-ew-s/eqs-access-control-web-client).

### Tecnologias utilizadas 
* [.Net Core 2.0](https://www.microsoft.com/net/download/windows)
* [Entity Framework Core](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/)
* [AutoMapper](https://www.nuget.org/packages/AutoMapper.Extensions.Microsoft.DependencyInjection/)
* [JWT](https://www.nuget.org/packages/System.IdentityModel.Tokens.Jwt/)
* [Swashbuckle](https://www.nuget.org/packages/Swashbuckle.AspNetCore/)

### Organização do projeto
##### [API](https://github.com/j-ew-s/eqs-access-control-api/tree/master/EQS.AccessControl/EQS.AccessControl.API)
* Controllers
* Configuração JWT
* Configuração Autorização
* Swagger

##### [Application](https://github.com/j-ew-s/eqs-access-control-api/tree/master/EQS.AccessControl/EQS.AccessControl.Application)
* AutoMapper
* ViewModel e ResponseModels
* Regras da aplicação

##### [Domain](https://github.com/j-ew-s/eqs-access-control-api/tree/master/EQS.AccessControl/EQS.AccessControl.Domain)
* Entidades
* Registro das interfaces de Serviço e Repositório
* Registro das regras de negócio
* Aplicação das regras de negócio de acordo com a ação executada (Salvar, remover , etc)

##### [Repository](https://github.com/j-ew-s/eqs-access-control-api/tree/master/EQS.AccessControl/EQS.AccessControl.Repository)
* Acesso a dados
* Configuração das Tabelas do Banco
* Execução do Repositório
* Migrations

### Exposição das APIS

Você encontrará a lista de APIS em http://localhost:13000/Swagger


### Observação

O projeto deve ser executado utilizando a porta 13000. Caso utilize outra porta, deverá acessar o [projet web](https://github.com/j-ew-s/eqs-access-control-web-client). e trocar o BASE_URL para executar o consumo correto das APIS.


