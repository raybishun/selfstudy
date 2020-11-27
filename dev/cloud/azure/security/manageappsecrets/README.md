# Manage User Secrets Notes

### User Secret Id Reference
- your .csproj file

### Secrets File Location
- C:\Users\{user_name}\AppData\Roaming\Microsoft\UserSecrets\{UserSecretsId}

### Secrets File Name
- secrets.json

### Ways to Set App Secrets
1. Manually edit the secrets.json file
2. PMC (Package Manager Console)

### Edit the secrets.json file manually
```
{
  "ConnectionString":  "this-is-my-connection-string"
}
```

### Edit the secrets.json file using the PMC (Package Manager Console)
```
dotnet user-secrets set "Facebook:AppId" "12345" --project manageappsecrets
dotnet user-secrets set "Facebook:AppSeret" "fb-app-secret" --project manageappsecrets
```

### Append to the secrets.json file using data from another config file, i.e. appsettings.json (via PMC)
```
type "The-full-path\appsettings.json" | dotnet user-secrets set --project manageappsecrets
```

### List Secrets
```
dotnet user-secrets list --project manageappsecrets
```