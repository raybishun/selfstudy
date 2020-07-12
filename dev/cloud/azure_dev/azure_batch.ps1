
# Note: Each block must be executed one at a time as described below
# -----------------------------------------------------------------------------

# login in Azure
# -----------------------------------------------------------------------------
az login

# Init Variables
$rgName = "bbsbatch"
$stgAcctName = "bbsbatchsa"
$location = "eastus"
$batchAcctName = "bbsbatchacct"
$poolName = "bbsPool"

# Create Resource Group (run login and this block together using F8 in VSCode)
# -----------------------------------------------------------------------------
az group create `
 -l $location `
 -n $rgName

# Create Resource Group (run this block only after the above 2 blocks complete)
# -----------------------------------------------------------------------------
az storage account create `
 -g $rgName `
 -n $stgAcctName `
 -l $location `
 --sku Standard_LRS

 # Create a Batch Account   TODO
 # -----------------------------------------------------------------------------
az batch account create `
 -n $batchAcctName `
 --storage-account $stgAcctName `
 -g $rgName `
 -l $location

 # Login
az batch account login `
 -n $batchAcctName `
 -g $rgName `
 --shared-key-auth

az batch pool create `
 --id $poolName `
 --vm-size Standard_A1_v2 `
 --target-dedicated-nodes 2 `
 --image `
   canonical:ubuntuserver:16.04-LTS `
 --node-agent-sku-id `
   "batch.node.ubuntu 16.04"

az batch pool show `
 --pool-id $poolName `
 --query "allocationState"

az batch job create `
 --id myjob `
 --pool-id $poolName

for ($i=0; $i -lt 4; $i++) {
    az batch task create `
     --task-id mytask$i `
     --job-id myjob `
     --command-line "/bin/bash -c 'printenv | grep AZ_BATCH; sleep 90s'" 
}

az batch task show `
 --job-id myjob `
 --task-id mytask1

az batch task file list `
 --job-id myjob `
 --task-id mytask1 `
 --output table

az batch task file download `
 --job-id myjob `
 --task-id mytask0 `
 --file-path stdout.txt `
 --destination ./stdout0.txt

az batch pool delete -n $poolName
az group delete -n $rgName