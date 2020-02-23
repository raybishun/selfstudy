#  Setup you working environment

### Play with Docker
1. https://labs.play-with-docker.com/

# The Basics

### What are Containers?
- A group of processes running in isolation on a shared kernel
- Containers leverage native Linux 'namespaces' and use Control Groups to limit and monitor container resources
- Containerization eliminate the 'works on my machine' syndrome

### Why Docker?
- Portable and light-weight where containers run in isolation, preventing dependency conflicts with the host or other containers
- The Docker image layering system leverages the native Linux Union File System and Copy-On-Write features
- Automated with CI/CD pipeline
- Uses a build once, deploy anywhere model
- Hardware and OS independent (think of .NET Framework and CLR)
- Language independent (use simple docker commands to create small scripts that are not tied to any development language)
- Containers eliminates environment drift (which eventually occurs with long standing environments)
- Open-source orchestration tools, i.e. Docker Swarm and Kubernetes can be used to manage high-availability, scaling, fault tolerance and scheduling