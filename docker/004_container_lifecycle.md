# Lifecycle = Start --> Running --> Stop

### List containers in a stopped state
1. docker container ls -a

### Run container (and 'attach' to it - get inside)
1. docker container run -it ubuntu:16.04

### List running containers from another terminal session
1. docker container ls
	- Note the 'friendly_wiles' name
	- Provided since you didn't provide a name for the container
	- Find name generator here: https://github.com/moby/moby/blob/master/pkg/namesgenerator/names-generator.go (https://mobyproject.org/)

### exit container and check if still running
1. exit
1. docker container ps -a

### Run the same container again
1. docker container ls -a (note the name and image id)
1. docker container start friendly_wiles

### Check if running
1. docker container ls

### Show status
1. docker container ls -a

### Attach to a running container
1. docker attach friendly_wiles
1. exit