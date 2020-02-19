# docker installation on centos (Azure CentOS VM)

## Prerequisites
# 1. (1) Linux (centos 7.7.1908) Azure VM was used
# 1a. Specs: Standard B1s (1 vcpus, 1 GiB memory)

## check Linux version
cat /etc/redhat-release

## check/install dependencies
sudo yum install -y yum-utils device-mapper-persistent-data lvm2

## add URL to where you will download docker repo (docker-ce = community edition, docker-ee = enterprise edition)
sudo yum-config-manager --add-repo https://download.docker.com/linux/centos/docker-ce.repo

## install docker (docker-ce = community edition, docker-ee = enterprise edition)
sudo yum install docker-ce

## Note, if not found, docker's GPG keys will be automatically imported

## POST Install - enable and start docker
sudo systemctl enable docker
sudo systemctl start docker

## Checkouts (instllation validation)
docker --version
sudo docker run hello-world

## Now let's add a regular to the docker user group (so you're not running via sudo)
sudo usermod -a -G docker ray_so
exit (best practice to logout out, i.e. verify env variables work as expected)
docker run hello-world (should now run w/o sudo)