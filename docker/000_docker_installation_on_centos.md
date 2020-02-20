# Manually Install Docker on CentOS

## Prerequisites
1. (1) Linux (centos 7.7.1908) Azure VM was used
1a. Specs: Standard B1s (1 vcpus, 1 GiB memory)

## check Linux version
cat /etc/redhat-release

## check/install dependencies
sudo yum install -y yum-utils device-mapper-persistent-data lvm2

## add URL to where you will download docker repo (docker-ce = community ed, docker-ee = entp ed)
sudo yum-config-manager --add-repo https://download.docker.com/linux/centos/docker-ce.repo

## install docker (docker-ce = community ed, docker-ee = entp ed)
sudo yum install docker-ce

## NOTE: If not found, docker's GPG keys will be automatically imported

## POST Install - enable and start docker
sudo systemctl enable docker
sudo systemctl start docker

## Checkouts (installation validation)
docker --version
docker version
sudo docker run hello-world

## Now let's add a regular to the docker user group (so you're not running via sudo)
sudo usermod -a -G docker ray_so
(sudo usermod -aG docker ray_so)
exit (best practice to logout out, i.e. verify env variables work as expected)
docker run hello-world (should now run w/o sudo)

# Automated Installation of Docker on CentOS

## Review script by opening https://get.docker.com in your browser
wget -qO- https://get.docker.com |sh