# Running containers

### Warning
- Only download Docker Certified images from the Docker Store
- "Docker Certified technologies are build with best practices, tested and validated against the Docker Enterprise Edition platform and APIs, pass security requirement, and are collaboratively supported."

### Prerequisites
1. Only Docker is required - nothing else

### Initial running of a container
- If not found locally, container images are pulled from the Docker Store
- And if you don't specify the version of an image to download, the 'latest' tag is retrieved by default

### What is NGINX?
- NGINX is a lightweight web server
- Accessible via http://localhost:8080 by default

### Containers names
- If you don't specify a container name, Docker will randomly assign one

### List containers
1. docker container ls (list running containers)
1. docker container ls -a (list all running/stopped containers)

### Running a container
1. docker container run -t ubuntu top (where -t is a pseudo-TTY)

### Get container id
1. Launch a second SSH session
1. Arrange both Terminals on your screen so that you view both at the same time
1. docker container ls

### Inspect container (by running bash inside the container)
1. docker container exec -it 55e0831442bb bash (where -i is interactive mode, and t allocates a psuedo-terminal)

### Inspect running processes
1. ps -ef

### Run multiple containers (nginx and mongo)
1. docker container run --detach --publish 8080:80 --name nginx nginx (where --detach means run in the background; --publish 8080:80 means use TCP:8080 from your host to access TCP:80 in the container)
1. docker container run --detach --publish 8081:27017 --name mongo mongo:3.4
1. docker containers ls
 
### Access the web sites (if docker running locally)
1. http://localhost:8080
1. http://localhost:8081

### Access the web sites (if docker running from remotely)
1. curl -4 icanhazip.com (get public IP address of your Linux host)
1. TIP You will need to add an inbound firewall rule to allow 8080 and 8081 on your Linux host
1. http://public_ip_address:8080 
1. http://public_ip_address:8081

### Cleanup (removing containers)
1. docker container ls (list running containers)
1. docker container stop 5d39 (where 5d39 are the first 4 char of the container id; alternatively you can use the container name)
1. docker container stop 8561 (where 8561 are the first 4 char of the container id; alternatively you can use the container name)
1. docker system prune (removes stopped containers, unused volumes and networks, and dangling images)
docker container ls -a (verify all containers were removed)

### Review
1. Containers achieve isolation because of Linux kernel Namespaces
1. A container is essentially a file system with processes running in isolation
1. Linux Control Groups (cgroups) limit and monitor container resources
1. LinuxKit is used to run Docker containers on OSs other than Linux