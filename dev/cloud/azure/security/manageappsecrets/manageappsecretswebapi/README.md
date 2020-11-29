# How to Add User-Secrets to an Azure hosted Web App

### Pre-create a Web App
1. https://portal.azure.com/
2. App Services
3. Add
4. Create a new resource group: manageappsecretswebapi_rg
5. Name: manageappsecretswebapi
6. Publish: Code
7. Runtime stack: .NET Core 3.1 (LTS)
8. OS: Windows
9. Region: East US
10. Windows Plan\Create new: FreeAppServicePlan
11. Sku and size: Dev/Test, Free F1 (shared infra, 1GB RAM, 60m/day compute)
12. Create

### Publish your Web App to Azure
1. Right-click the app and select Publish
2. Azure\Next
3. Azure App Service (Windows)
4. Find and select the app from the Resource Group created above
5. Finish
6. Publish
7. You will recieve a message similar to the below
```
No webpage was found for the web address...
HTTP ERROR 404
```
### Add a User-Secret Key Value Pair to your Azure Web App
1. App Services
2. Find and select your web app
3. Settings\Configuration
4. Application settings\New application settings
5. Enter a Name and Value
6. OK
7. Save

### Test the Web App
1. For example: https://yourAppName.azurewebsites.net/api/secrets