# -----------------------------------------------------------------------------
# 1. Create an App Service 
# 2. Manually deploy an app stored in a github into the App Service
# 3. Run the app
# -----------------------------------------------------------------------------

# login in Azure
# -----------------------------------------------------------------------------
az login

# Init Variables
$rg = "webapps"
$planname = "githubdeployasp"
$appname = "laazgithubdeploy"
$repourl = "https://github.com/Azure-Samples/php-docs-hello-world"

# Create Resource Group
# -----------------------------------------------------------------------------
az group create `
 -n $rg -l eastus

# Create the App Service Plan
# -----------------------------------------------------------------------------
az appservice plan create `
 -n $planname `
 -g $rg `
 --sku FREE 

# Create the Web App in our Resource Group
# -----------------------------------------------------------------------------
az webapp create `
 -n $appname `
 -g $rg `
 --plan $planname 

# Deploy the sample app to the Azure App Service
# -----------------------------------------------------------------------------
az webapp deployment source config `
 -n $appname `
 -g $rg `
 --repo-url $repourl `
 --branch master `
 --manual-integration

# Show information about the source of the app in the Azure App Service
# -----------------------------------------------------------------------------
az webapp deployment source show `
 -n $appname `
 -g $rg

# Show Web App info
# -----------------------------------------------------------------------------
az webapp show `
 -n $appname `
 -g $rg

# Get the URL for the Web App
# -----------------------------------------------------------------------------
az webapp show `
 -n $appname `
 -g $rg `
 --query "defaultHostName" -o tsv
# Try: http://laazgithubdeploy.azurewebsites.net

# Since we 'manually' deployed this app, meaning ci/cd not used, you can 
# manually re-deploy, i.e. when changes were made to the source code
# -----------------------------------------------------------------------------
az webapp deployment source sync -n $appname -g $rg

# Clean Up
# -----------------------------------------------------------------------------
az group delete -n $rg --yes