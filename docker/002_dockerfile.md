### Creating a dockerfile
1. mkdir onboarding
2. cd onboarding
3. vim dockerfile
- FROM ubuntu:16.04
- LABEL maintainer="ray.bishun@bitsbytes.com"
- RUN apt-get update
- RUN apt-get install-y python
- :wq
	
### Build docker file
1. docker build . (to use the local file) || <docker_file_name>

### Review what just happened
1. Step 1/4: Pull ubuntu
2. Step 2/4: Adds label
3. Step 3/4: RUN apt-get update
4. Step 4/4: RUN apt-get install-y python