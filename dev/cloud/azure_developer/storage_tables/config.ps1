# login in Azure
# -----------------------------------------------------------------------------
az login

# Init Variables
$rg = "tables"
$location = "eastus"
$acct = "laaztables"

# Create a Storage Group
# -----------------------------------------------------------------------------
az group create -n $rg -l $location

# Create a Storage Account
# -----------------------------------------------------------------------------
az storage account create `
 -g $rg `
 -n $acct `
 -l $location `
 --sku Standard_LRS

# Return the connection string
# -----------------------------------------------------------------------------
az storage account show-connection-string `
-n $acct

# Return only the connection string
# -----------------------------------------------------------------------------
az storage account show-connection-string `
 -n $acct `
 --query "connectionString"

# Now copy the returned connection string
# And assign it to the Tables.cs _connectionString variable

# Delete Storage Group
# -----------------------------------------------------------------------------
az group delete -n $rg