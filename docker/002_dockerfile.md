# Creating a dockerfile
mkdir onboarding
cd onboarding
vim dockerfile
	FROM ubuntu:16.04
	LABEL maintainer="ray.bishun@bitsbytes.com"
	RUN apt-get update
	RUN apt-get install-y python
	:wq
	
# Build docker file
docker build . (to use the local file) || <docker_file_name>

# What just happended
Step 1/4: Pull ubuntu
Step 2/4: Adds label
Step 3/4: RUN apt-get update
Step 4/4: RUN apt-get install-y python