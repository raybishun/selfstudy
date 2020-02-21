### List current images (show partial image id)
1. docker images

### List current images (show full image id)
1. docker images --no-trunc

### pull ubuntu 16.04 image
1. docker pull ubuntu:16.04

### pull latest ubuntu image
1. docker pull ubuntu

### run an image
1. docker images
2. docker run <repository> || <image id>

### Purge All Dangling Images, Containers, Volumes, and Networks
1. docker system prune

### Pruge any stopped container
1. docker system prune -a