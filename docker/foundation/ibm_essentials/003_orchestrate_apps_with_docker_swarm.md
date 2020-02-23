# Orchestrate apps with Docker Swarm

### Create a 3-node Swarm cluster using Play-with-Docker
1. https://labs.play-with-docker.com/
1. Add New Instance

### Initialize the swarm on node 1
docker swarm init --advertise-addr eth0

### Add a manager to the swarm
1. docker swarm join-token manager
1. follow the instructions in the Play-with-Docker terminal
1. Add two more instances
1. copy and past the 'docker swarm join --token...' line into the other two instances
1. docker node ls (to verify you have a 3-node cluster: 1 manager node, and 2 worker nodes)
1. The manager node handles commands and manages the state of the swarm
1. The worker nodes do not handle commands, only run containers at scale
1. By default, the manager node is able to run containers as well
1. There is an API to manage the swarm remotely, that makes use of to environment variables ($DOCKER_HOST and $DOCKER_CERT_PATH)

### Deploy a service to the swarm
1. YOU MUST EXECUTE THE FOLLOWING COMMANDS ONLY ON NODE1
1. docker service create --detach=true --name nginx1 --publish 80:80  --mount source=/etc/hostname,target=/usr/share/nginx/html/index.html,type=bind,ro nginx:1.12
pgqdxr41dpy8qwkn6qm7vke0q