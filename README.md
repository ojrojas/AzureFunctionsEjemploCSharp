# AzureFunctionsEjemploCSharp
Breve ejemplo de azure functions C#, mas authorization

Docker Mysql 
docker-compose up -d

Crear Migracion
dotnet ef migrations add initial -c AzureFunctionsDbContext -p ../Infraestructure/ -s AzureFunctions.csproj -o Data/Migrations -v 

Actualizar Migracion
dotnet ef database update --connection "Data Source=azuredb.db" --context AzureFunctionsDbContext -p ../Infraestructure/ -s AzureFunctions.csproj -v

