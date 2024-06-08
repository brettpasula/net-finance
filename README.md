# (WIP) NetFinance

### Running the development server (+ Swagger)
Build and run: `dotnet run`\
Development server: http://localhost:5204 \
Swagger: http://localhost:5204/swagger

### Database
Add a migration: `dotnet ef migrations add MyMigration`\
Apply the migration: `dotnet ef database update`

Database options are specified in the `OnConfiguring` call in `Data/DatabaseContext.cs`.

### Reference
[Swagger](https://swagger.io/docs/)\
[Create web APIs with ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-8.0)\
[Entity Framework documentation hub](https://learn.microsoft.com/en-us/ef/)\
[Entity Framework - Migrations Overview](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli)
