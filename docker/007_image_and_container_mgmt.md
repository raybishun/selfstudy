# Hello
## Hello


# List Running Docker Containers
- docker container ls

# List Running Docker Containers -All
- docker container ls -a

# Remove a Docker Container <Container ID>
- docker container rm a10c40fde697

# Remove a Docker Container <names>
- docker container rm heuristic_hugle

# List Images
- docker images

# Remove Images <image id>
 `docker rmi cd47d6573802`
 
# Push to DockerHub
1. docker login
2. docker images (to find desired image id)
3. docker tag 96da9143fb18 raybishun/onboarding:v1 (to update the tag)
4. docker push raybishun/onboarding
5. cat onboarding/dockerfile
 
# Retrieve image from DockerHub
`docker pull raybishun/onboarding:v1`
`docker image ls`
