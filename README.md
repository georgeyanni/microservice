
#### Catalog microservice which includes; 
* ASP.NET Core Web API application 
* REST API principles, CRUD operations
* **MongoDB database** connection and containerization
* Repository Pattern Implementation
* Swagger Open API implementation	

#### Email Service includes;
* ASP.NET Web API application


#### API Gateway Ocelot Microservice
* Implement **API Gateways with Ocelot**
* Sample microservices/containers to reroute through the API Gateways
	

## Run The Project
You will need the following tools:

* [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/)
* [.Net Core 5 or later](https://dotnet.microsoft.com/download/dotnet-core/5)
* [Docker Desktop](https://www.docker.com/products/docker-desktop)

### Installing
At the root directory which include **docker-compose.yml** files, run below command:
```csharp
docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d
```


 You can **launch microservices** as below urls:

* **Catalog API -> http://localhost:8000/swagger/index.html**
* **API Gateway -> http://localhost:8010/Catalog**
* **Rabbit Management Dashboard -> http://localhost:15672**   -- guest/guest
