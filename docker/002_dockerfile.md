### Creating a dockerfile
1. mkdir onboarding
1. cd onboarding
1. vim dockerfile
1. FROM ubuntu:16.04
1. LABEL maintainer="ray.bishun@bitsbytes.com"
1. RUN apt-get update
1. RUN apt-get install-y python
1. :wq
	
### Build docker file
1. docker build . (to use the local file) || <docker_file_name>

### Review what just happened
1. Step 1/4: Pull ubuntu
1. Step 2/4: Adds label
1. Step 3/4: RUN apt-get update
1. Step 4/4: RUN apt-get install-y python