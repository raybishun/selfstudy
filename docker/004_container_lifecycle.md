# Lifecycle = Start --> Running --> Stop

# List Conainers in a stopped state
docker container ls -a

# Run container (and 'attach' to it - get inside)
docker container run -it ubuntu:16.04

# List running containers from another terminal session
docker container ls
	- note the 'friendly_wiles' name
	- provided since you didn't provide a name for the container
	- find name generator here: https://github.com/moby/moby/blob/master/pkg/namesgenerator/names-generator.go (https://mobyproject.org/)

# exit container and check if still running
exit
docker container ps -a

# Run the same container again
docker container ls -a
	note the name (or image id)
docker container start friendly_wiles

# Check if running
docker container ls

# Show status
docker container ls -a

# Attach to a running container
docker attach friendly_wiles
exit