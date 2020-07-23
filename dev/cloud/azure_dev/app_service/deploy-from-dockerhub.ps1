# -----------------------------------------------------------------------------
# 1. Create an App Service 
# 2. Manually deploy an app stored in a dockerhub into the App Service
# 3. Run the app
# -----------------------------------------------------------------------------

# Review the app we will publish at: https://hub.docker.com/_/microsoft-dotnet-core-samples
# -----------------------------------------------------------------------------

# login in Azure
# -----------------------------------------------------------------------------
az login

# Init Variables
$rg = "webapps"
$planname = "dockerhubdeployasp"
$appname = "laazdockerhubdeploy"
$container = "microsoft/dotnet-samples:aspnetapp"

# Create Resource Group
# -----------------------------------------------------------------------------
az group create -n $rg -l eastus

# Create the App Service Plan
# -----------------------------------------------------------------------------
az appservice plan create `
 -n $planname `
 -g $rg `
 --sku B1 `
 --is-linux

# Deploy app to the Azure App Service using 'webapp create'
# -----------------------------------------------------------------------------
az webapp create `
 -n $appname `
 -g $rg `
 --plan $planname `
 --deployment-container-image-name $container 

# Map TCP:80 into the dockerhub container running the app (note, I didn't need to do this - it just worked)
# -----------------------------------------------------------------------------
 az webapp config appsettings set `
 -g $rg `
 -n $appname `
 --settings WEBSITES_PORT=80

# Get the FQDN of your web app (http://laazdockerhubdeploy.azurewebsites.net)
# -----------------------------------------------------------------------------
az webapp show -n $appname -g $rg
az webapp show -n $appname -g $rg --query "defaultHostName" -o tsv

# Clean Up
# -----------------------------------------------------------------------------
az group delete -n $rg --yes