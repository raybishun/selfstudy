# List current images (show partial image id)
docker images

# List current images (show full image id)
docker images --no-trunc

# pull ubuntu 16.04 image
docker pull ubuntu:16.04

# pull latest ubuntu image
docker pull ubuntu

# run an image
docker images
docker run <repository> || <image id>

# Purge All Dangling Images, Containers, Volumes, and Networks
docker system prune

# Pruge any stopped container
docker system prune -a