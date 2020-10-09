# login in Azure
# -----------------------------------------------------------------------------
az login

# Init Variables
$rg = "aksdemos"
$cluster = "akscluster"

# Create Resource Group
# -----------------------------------------------------------------------------
az group create -n $rg `
 -l eastus

 # Create the Azure Kubernetes Cluster
# -----------------------------------------------------------------------------
az aks create -g $rg `
 -n $cluster `
 --node-count 1 `
 --generate-ssh-keys `
 --enable-addons monitoring

# Create Credentials
# -----------------------------------------------------------------------------
az aks get-credentials `
 -g $rg `
 -n $cluster

# Get Cluster Nodes
# -----------------------------------------------------------------------------
kubectl get nodes

# Apply app
# -----------------------------------------------------------------------------
kubectl apply -f azure-vote.yaml

# Wait for Deployment
# -----------------------------------------------------------------------------
kubectl get service azure-vote-front `
 --watch