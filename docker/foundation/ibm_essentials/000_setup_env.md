#  Setup you working environment

### Play with Docker
1. https://labs.play-with-docker.com/

# The Basics

### What are Containers?
- A group of processes running in isolation on a shared kernel
- Containers leverage Linux 'namespaces'
- Linux Control Groups limit and monitor container resources

### Why Docker?
- Portable and light-weight (process based)
- Automated with CI/CD pipeline
- Uses a build once, deploy anywhere model
- Hardware and OS independent (think of .NET Framework and CLR)
- Language independent (use simple docker commands to create small scripts that are not tided to any development language)
- Eliminates environment drift (which eventually occurs with long standing environments)
- Rich open-source ecosystem, i.e. orchestration tools
- Used to manage containers