# Manage User Secrets

### User Secret Id Reference
- your .csproj file

### Secrets File Location
- C:\Users\{user_name}\AppData\Roaming\Microsoft\UserSecrets\{UserSecretsId}

### Secrets File Name
- secrets.json

### Ways to Set App Secrets
1. Manually edit the secrets.json file
2. PMC (Package Manager Console)

### List Secrets
```
dotnet user-secrets list --project manageappsecrets
```

### Append to the secrets.json file manually
```
{
  "ConnectionString":  "this-is-my-connection-string"
}
```

### Append the secrets.json file using the PMC (Package Manager Console)
```
dotnet user-secrets set "Facebook:AppId" "12345" --project manageappsecrets
dotnet user-secrets set "Facebook:AppSeret" "fb-app-secret" --project manageappsecrets
dotnet user-secrets list --project manageappsecrets
```

### Append to the secrets.json file using data from another config file, i.e. appsettings.json (via PMC)
```
type "The-full-path\appsettings.json" | dotnet user-secrets set --project manageappsecrets
dotnet user-secrets list --project manageappsecrets
```

### How to Remove Keys from the secrets.json file (using the key)
```
dotnet user-secrets remove "ConnectionString" --project manageappsecrets
dotnet user-secrets remove "Logging:LogLevel:Default" --project manageappsecrets
dotnet user-secrets list --project manageappsecrets
```

### How to Modify Values from the secrets.json file (using the key)
```
dotnet user-secrets set "Facebook:AppId" "54321" --project manageappsecrets
dotnet user-secrets list --project manageappsecrets
```

### How to Add IConfiguration to a Console App
1. Add the below packages

#### Packages
- Microsoft.Extensions.Configuration.Abstractions
- Microsoft.Extensions.Configuration.UserSecrets