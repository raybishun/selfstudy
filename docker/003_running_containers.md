### List docker images (legacy)
1. docker images

### List docker images (newer)
1. docker image ls

### Run docker container (legacy)
1. docker run <repository> || <image id>

### Run docker container (newer)
1. docker container run hello-world

### Run docker container
- The below names the container and puts you inside it
- Note the prompt after running the command
- Also note, 1633 is the first 4 number of the image ID
1. docker container run -it --name python-container 1633
2. cat /etc/issue 
- (verify it's running Ubuntu 16.04 that was used as the base image)
3. python3
4. exit()
5. apt install vim
- (this is just for demo purposes, YOU DON'T WANT TO INSTALL ANYTHING THIS WAY in a container)
6. vim hello-world.py
7. :wq
8. python3 hello-world.py
9. chmod +x hello-world.py