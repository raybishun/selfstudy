### List current images (show partial image id)
1. docker images

### List current images (show full image id)
1. docker images --no-trunc

### Pull Ubuntu 16.04 image
1. docker pull ubuntu:16.04

### Pull latest Ubuntu image
1. docker pull ubuntu

### Run an image
1. docker images
1. docker run repository
1. OR docker run image id

### Purge all dangling images, containers, volumes and networks
1. docker system prune

### Purge any stopped container
1. docker system prune -a