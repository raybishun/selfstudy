# get ubuntu, modify, and push to your dockerhub account
1. docker images
2. docker pull ubuntu (ubuntu is the image name)
3. docker run -it -d ubuntu (standup container)
4. docker ps -a (list containers)
5. docker exec -it heuristic_hugle bash (log into the container)
6. Or using: docker exec -it <container id> bash (log into the container and run bash)
7. mkdir test-directory (make a directory)
8. ls -hal
9. exit
10. docker ps -a (verify container still running)

### Use the container to create a new image
1. docker commit heuristic_hugle
2. raybishun/my-ubuntu-image-feb19:sometag
3. docker images

### Push to DockerHub account
1. docker login
2. docker push raybishun/my-ubuntu-image-feb19:sometag