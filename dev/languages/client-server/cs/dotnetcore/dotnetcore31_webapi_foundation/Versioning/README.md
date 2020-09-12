# Versioning

### 3 Types of Versioning
1. Query String, 
2. URL Path
3. Media Types

#### Query String
```
https://localhost:44300/api/movies?api-version=1.0
```
#### URL Path
```
https://localhost:44300/api/v1/movies 
```
#### Media Types
1. Versioning is added to the HTTP Header
```
https://localhost:44300/api/movies
Accept: application/json;v=1.0
```
2. Requires that you add the below to the ConfigureService method in Startup
```
services.AddApiVersioning(o => o.ApiVersionReader = new MediaTypeApiVersionReader());
```
# Versioning NuGet Package
1. Microsoft.AspNetCore.Mvc.Versioning