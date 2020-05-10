# Manually Install Docker on CentOS

### Prerequisites
- A Linux (centos 7.7.1908) Azure VM was used during this walkthrough
- Specs: Standard B1s (1 vcpus, 1 GiB memory)

### Check Linux version
1. cat /etc/redhat-release

### Check/install dependencies
1. sudo yum install -y yum-utils device-mapper-persistent-data lvm2

### Add URL to where you will download docker repo (docker-ce = community ed, docker-ee = entp ed)
1. sudo yum-config-manager --add-repo https://download.docker.com/linux/centos/docker-ce.repo

### Install docker (docker-ce = community ed, docker-ee = entp ed)
1. sudo yum install docker-ce
1. NOTE If not found, docker's GPG keys will be automatically imported

### Post install - enable and start docker
1. sudo systemctl enable docker
1. sudo systemctl start docker

### Checkouts (installation validation)
1. docker --version
1. docker version
1. sudo docker run hello-world

### Now let's add a regular to the docker user group (so you're not running via sudo)
1. sudo usermod -a -G docker ray_so
1. OR sudo usermod -aG docker ray_so
1. exit (best practice to logout out, i.e. verify env variables work as expected)
1. docker run hello-world (should now run w/o sudo)

# Automated Installation of Docker on CentOS

### Review script by opening https://get.docker.com in your browser
1. wget -qO- https://get.docker.com |sh