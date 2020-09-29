# Manual Configs

### Add a Connection String to appsettings.json
```
"ConnectionStrings": {
    "Default": "Data Source=(LocalDB)\\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
  }
```
### Add the required NuGet packages
1. Open a CMD prompt to the root of the app, i.e. c:\apps\IdentityNetCore
```
dotnet --version
dotnet add package Microsoft.AspnetCore.Identity
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.AspnetCore.Identity.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.entityFrameworkCore.SqlServer
dotnet tool install --global dotnet-ef
```
### Create the Migrations and Create the Database Objects
1. Open a CMD prompt to the root of the app, i.e. c:\apps\IdentityNetCore
```
dotnet ef migrations add Init
dotnet ef database update -v
```