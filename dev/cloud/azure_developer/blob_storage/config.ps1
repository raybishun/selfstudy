# login in Azure
# -----------------------------------------------------------------------------
az login

# Init Variables
$rg = "blobs"
$location = "eastus"
$acct = "laazblobs"

# Create Resource Group
# -----------------------------------------------------------------------------
az group create -n $rg -l $location

# Create a Storage Account
# -----------------------------------------------------------------------------
az storage account create `
 -g $rg `
 -n $acct `
 -l $location `
 --sku Standard_LRS

# Show Connection String
# -----------------------------------------------------------------------------
 az storage account show-connection-string `
 -n $acct `
 --query "connectionString"
 
# Clean Up
# -----------------------------------------------------------------------------
az group delete -n $rg