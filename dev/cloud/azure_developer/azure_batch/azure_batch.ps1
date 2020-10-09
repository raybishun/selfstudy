# Overview
# =============================================================================
# 1. az batch pool create
# 2. az batch job create
# 3. az batch task create


# Note: Each command must be executed one at a time as described below
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

# Create Resource Group (run login and this command together using F8 in VSCode)
# -----------------------------------------------------------------------------
az group create `
 -l $location `
 -n $rgName
# Verify the in the Resource Group blade

# Create Storage Account (run this command only after the above 2 commands complete)
# -----------------------------------------------------------------------------
az storage account create `
 -g $rgName `
 -n $stgAcctName `
 -l $location `
 --sku Standard_LRS
# Verify the in the Resource Group blade

# Create a Batch Account
# -----------------------------------------------------------------------------
az batch account create `
 -n $batchAcctName `
 --storage-account $stgAcctName `
 -g $rgName `
 -l $location
# Verify in the Batch accounts blade

# Login
# -----------------------------------------------------------------------------
az batch account login `
 -n $batchAcctName `
 -g $rgName `
 --shared-key-auth

# Create Batch Pool
# -----------------------------------------------------------------------------
az batch pool create `
 --id $poolName `
 --vm-size Standard_A1_v2 `
 --target-dedicated-nodes 2 `
 --image `
   canonical:ubuntuserver:16.04-LTS `
 --node-agent-sku-id `
   "batch.node.ubuntu 16.04"

# Verify in the Batch accounts blade\Features\Pools

# Show Batch Pool
# -----------------------------------------------------------------------------
az batch pool show `
 --pool-id $poolName `
 --query "allocationState"

# Allocation state should return: "steady"
# Also, the Batch accounts blade\Features\Pools\Nodes should show 'idle' when ready

# Check Pool Creation
# -----------------------------------------------------------------------------
az batch job create `
 --id myjob `
 --pool-id $poolName

# Verify in the Batch accounts blade\Features\Jobs

# Check Pool Creation
# -----------------------------------------------------------------------------
for ($i=0; $i -lt 4; $i++) {
    az batch task create `
     --task-id mytask$i `
     --job-id myjob `
     --command-line "/bin/bash -c 'printenv | grep AZ_BATCH; sleep 90s'" 
}

# Verify Verify in the Batch accounts blade\Features\Jobs\myjob\General\Tasks, i.e.
#   mytask01\stdout.txt
# Also, review resources used to run the tasks - Baatch accounts bladde\Overview

# Verify a task ran successfully (from your on-prem client)
# -----------------------------------------------------------------------------
az batch task show `
 --job-id myjob `
 --task-id mytask1

# Validate by looking for state: completed

# Check what output files were created
# -----------------------------------------------------------------------------
az batch task file list `
 --job-id myjob `
 --task-id mytask1 `
 --output table

# Download one of the output files
# -----------------------------------------------------------------------------
az batch task file download `
 --job-id myjob `
 --task-id mytask0 `
 --file-path stdout.txt `
 --destination ./stdout0.txt
# Verify downloaded file in local directory

# Cleanup
# -----------------------------------------------------------------------------
az batch pool delete -n $poolName
az group delete -n $rgName