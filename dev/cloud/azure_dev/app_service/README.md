# Azure App Service

### What is Azure App Service?
- Allows you to deploy scalable mission-critical web applications
- Considered the workhorse of Azure PaaS

### Features
1. Cross platform
2. Built-in auto-scale and load-balancing
3. High availability with auto-patching
4. Continuous deployment with Git, Team Foundation server, GetHub, and DevOps
5. Even supports WordPress, Umbraco, Joomla!, and Drupal

### Creating an App Service (on Windows and using the Free Sku)
1. http://portal.azure.com
2. App Services
3. Add
4. Resource Group\Create New: webapp
5. Web App name: laazwebappjuly19 (must be unique in the .azurewebsites.net namespace)
6. Publish: Code
7. Runtime stack: .NET Core 3.1 (LTS)
8. Operating System: Windows
9. Region: East US
10. App Service Plan\Windows Plan (East US)\Sku and size: Free F1
11. Review + create
12. Create

# References


# Appendix

### Create and run a new console app
- mkdir helloworld
- cd .\helloworld\
- dotnet new console
- dotnet build
- dotnet run