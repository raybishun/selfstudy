# login in Azure
# -----------------------------------------------------------------------------
az login

# Init Variables
$rg = "webapps"
$planname = "dockerhubdeployasp"
$appname = "laazdockerhubdeploy"
$container = "microsoft/dotnet-samples:aspnetapp"

# Create Storage Group
# -----------------------------------------------------------------------------
az group create -n $rg -l eastus
az appservice plan create `
 -n $planname `
 -g $rg `
 --sku B1 `
 --is-linux
 
az webapp create `
 -n $appname `
 -g $rg `
 --plan $planname `
 --deployment-container-image-name $container 
 
az webapp config appsettings set `
 -g $rg `
 -n $appname `
 --settings WEBSITES_PORT=80

az webapp show -n $appname -g $rg
az webapp show -n $appname -g $rg --query "defaultHostName" -o tsv

# Clean Up
# -----------------------------------------------------------------------------
az group delete -n $rg --yes