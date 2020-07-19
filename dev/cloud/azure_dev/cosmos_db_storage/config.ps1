# login in Azure
# -----------------------------------------------------------------------------
az login

# Init Variables
$resourceGroupName = "cosmosdb"
$location = "eastus"
$accountName= "laazcosmosdb"
$databaseName = "myDatabase"

# Create Resource Group
# -----------------------------------------------------------------------------
az group create `
 -n $resourceGroupName `
 -l $location

# Create a SQL API Cosmos DB account with session consistency and multi-master enabled
# -----------------------------------------------------------------------------
# az cosmosdb create `
#  -g $resourceGroupName `
#  --name $accountName `
#  --kind GlobalDocumentDB `
#  --locations "East US=0" "North Central US=1" `
#  --default-consistency-level Strong `
#  --enable-multiple-write-locations true `
#  --enable-automatic-failover true

az cosmosdb create `
 -g $resourceGroupName `
 --name $accountName `
 --kind GlobalDocumentDB `
 --locations regionName=eastus failoverPriority=0 isZoneRedundant=False `
 --locations regionName=uksouth failoverPriority=1 isZoneRedundant=True `
 --enable-multiple-write-locations

# Create a database
# -----------------------------------------------------------------------------
az cosmosdb database create `
 -g $resourceGroupName `
 --name $accountName `
 --db-name $databaseName

# List account keys
# -----------------------------------------------------------------------------
az cosmosdb list-keys `
 --name $accountName `
 -g $resourceGroupName

# List account connection strings
# -----------------------------------------------------------------------------
az cosmosdb list-connection-strings `
 --name $accountName `
 -g $resourceGroupName

# Show Primary Endpoint
# -----------------------------------------------------------------------------
 az cosmosdb show `
 --name $accountName `
 -g $resourceGroupName `
 --query "documentEndpoint"

# Clean up
az group delete -y -g $resourceGroupName