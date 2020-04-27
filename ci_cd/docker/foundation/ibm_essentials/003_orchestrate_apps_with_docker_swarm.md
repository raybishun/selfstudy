# Orchestrate apps with Docker Swarm

- The Docker Swarm uses a declarative model
- A Swarm is comprised of one or more nodes creating a cluster that forms a routing mesh that acts as a load balancer for containers
- A request over a service's published port gets routed to a node running a container for that service
- Note however, a routing mesh is limited to publishing only one service over port 80; if multiple services need to be exposed over port 80, you'll need to use a 3rd party load-balancer solution
- Docker Swarm has an inspect-and-adapt model, i.e. if a node becomes unavailable, the swarm automatically senses this, and will reschedule containers on available nodes
- We will create a 3-node swarm with 1 master and 2 worker nodes, note however, in a production environment you would also cluster the master (aka manager node)
- Manager nodes run the raft consensus algorithm which require more than 50% of the nodes to agree on the cluster state
- To deliver a highly available swarm, the minimum number of manager nodes are:
	- 3 manager nodes protects against a single manager node failure
	- 5 manager nodes protects against 2 manager node failures
	- 7 manager nodes protects against 3 manager node failures (note it's advised to not exceed 7 manager nodes)
- During the creation of a swarm, a Join Token gets generated - this is to prevent malicious nodes from joining the swarm
- Workers nodes utilize the gossip protocol (which is optimized for large network)
- Worker nodes only run containers (although manager nodes can as well)
- Built in templates can be used to quickly deploy multiple manage node configurations, i.e. find and select the Template (wrench) icon in the free Play-with-Docker lab portal (mentioned below)

### Create a 3-node Swarm cluster using Play-with-Docker
1. https://labs.play-with-docker.com/ (provides on-demand free 4 hour sessions 24/7)
1. Add New Instance

### Initialize the swarm on node 1
1. docker swarm init --advertise-addr eth0

### Add a manager to the swarm
1. docker swarm join-token manager
1. Add two more instances
1. Switch back to node1
1. copy and past the 'docker swarm join --token...' line into the other two instances
1. Switch back to node1
1. docker node ls (to verify you have a 3-node cluster: 1 manager node, and 2 worker nodes)
1. The manager node handles commands and manages the state of the swarm
1. The worker nodes do not handle commands, only run containers at scale
1. Note however, by default, the manager node is able to run containers as well
1. There is an API to manage the swarm remotely, which makes use of 2 environment variables ($DOCKER_HOST and $DOCKER_CERT_PATH)

### Deploy containers to the swarm (by creating a service)
- The following commands must be executed only on node1 (unless otherwise noted)

### Create a service
1. docker service create --detach=true --name nginx1 --publish 80:80  --mount source=/etc/hostname,target=/usr/share/nginx/html/index.html,type=bind,ro nginx:1.12
1. docker service ls
1. docker service ps nginx1

### Test the service
1. curl localhost:80 (run on each node)
1. Observe the output: node1 (that's because the container is currently running only on node1)

### Scale the service
1. docker service update --replicas=5 --detach=true nginx1
1. Wait a few seconds
1. docker service ps nginx1 (you will find that the swarm started 4 more containers distributed across the 3 nodes)
1. curl localhost:80 (run several times from node1 and notice that any of the 3 nodes responds)

### View the service's aggregated logs
1. docker service logs nginx1
1. docker service ps nginx1

### Applying rolling updates to the swarm
1. docker service update --image nginx:1.13 --detach=true nginx1
1. docker service ps nginx1 (immediately enter this command repeatedly to view the updates in realtime)
1. NOTE --update-parallelism and --update-delay switches can be used with the docker service update command

### Diagnosing container problems
- We'll start by creating a new service
- Start from node1
1. docker service create --detach=true --name nginx2 --replicas=5 --publish 81:80  --mount source=/etc/hostname,target=/usr/share/nginx/html/index.html,type=bind,ro nginx:1.12
1. watch -n 1 docker service ps nginx2 (use the Linux Watch utility to view updates in realtime)
1. Switch to node3
1. docker swarm leave (use the --force switch if you receive an error)
1. Switch to node1
1. Observe the node reconciliation in action