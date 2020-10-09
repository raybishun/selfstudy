# Azure App Service: Web Apps

### What is Azure App Service: Web Apps?
- Allows you to deploy scalable mission-critical web applications
- Considered the workhorse of Azure PaaS

### Features
1. Cross platform
2. Built-in auto-scale and load-balancing
3. High availability with auto-patching
4. Continuous deployment with Git, Team Foundation server, GetHub, and DevOps
5. Even supports WordPress, Umbraco, Joomla!, and Drupal

### What we will be doing - creating an App Service using 3 different methods
1. Create an App Service using the Azure Portal
2. Create an App Service using the CLI (deploy-from-github.ps1), and deploying an app from github
3. Create an App Service using the CLI (via deploy-from-dockerhub.ps1), and deploying an app from dockerhub 

### Creating an App Service using the Azure Portal (and the Free Sku)
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
1. App Service docs: https://docs.microsoft.com/en-us/azure/app-service/
2. Create an App Service app with deployment from GitHub using Azure CLI: https://docs.microsoft.com/en-us/azure/app-service/scripts/cli-deploy-github
3. Create an App Service app with deployment from GitHub using Azure CLI: https://azure.microsoft.com/en-us/services/app-service/containers/
4. Build a containerized web application with Docker: https://docs.microsoft.com/en-us/learn/modules/intro-to-containers/
5. GitHub Sample app used in this tutorial: https://github.com/Azure-Samples/php-docs-hello-world
6. DockerHub .NET Core Samples used in this tutorial: https://hub.docker.com/_/microsoft-dotnet-core-samples

# Appendix

### Azure commands used in this tutorial
1. az group create
2. az app service plan create
3. az webapp create

### Create and run a new console app
- mkdir helloworld
- cd .\helloworld\
- dotnet new console
- dotnet build
- dotnet run