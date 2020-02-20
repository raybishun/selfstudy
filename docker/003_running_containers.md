# List docker images (legacy)
docker images

# List docker images (newer)
docker image ls

# Run docker container (legacy)
docker run <repository> || <image id>

# Run docker container (newer)
docker container run hello-world


# Run docker container
## The below names the container and puts you inside it
## Note the prompt after running the command
## Also note, 1633 is the first 4 number of the image ID
docker container run -it --name python-container 1633
cat /etc/issue 
	(verify it's running Ubuntu 16.04 that was used as the base image)
python3
	exit()
apt install vim
	(this is just for demo purposes, YOU DON'T WANT TO INSTALL ANYTHING THIS WAY in a container)
vim hello-world.py
:wq
python3 hello-world.py
chmod +x hello-world.py