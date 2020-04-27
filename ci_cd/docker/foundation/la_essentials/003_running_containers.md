### List docker images (legacy)
1. docker images

### List docker images (newer)
1. docker image ls

### Run docker container (legacy)
1. docker run repository
1. OR docker run image id

### Run docker container (newer)
1. docker container run hello-world

### Run docker container
- The below names the container attached to it
- Note the prompt after running the command
- Also note, 1633 is the first 4 number of the image ID
1. docker container run -it --name python-container 1633
1. cat /etc/issue 
1. (verify it's running Ubuntu 16.04 that was used as the base image)
1. python3
1. exit()
1. apt install vim
1. NOTE This is just for demo purposes, YOU DON'T WANT TO INSTALL ANYTHING THIS WAY in a container
1. vim hello-world.py
1. :wq
1. python3 hello-world.py
1. chmod +x hello-world.py