# get ubuntu, modify, and push to your dockerhub account
docker images
docker pull ubuntu (ubuntu is the image name)
docker run -it -d ubuntu (standup container)
docker ps -a (list containers)
docker exec -it heuristic_hugle bash (log into the container)
	or using: docker exec -it <container id> bash (log into the container and run bash)
mkdir test-directory (make a directory)
ls -hal
exit
docker ps -a (verify container still running)

# use the container to create a new image
docker commit heuristic_hugle raybishun/my-ubuntu-image-feb19:sometag
docker images

# push to dockerhub account
docker login
docker push raybishun/my-ubuntu-image-feb19:sometag