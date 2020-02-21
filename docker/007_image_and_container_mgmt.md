# Image & Container Management

## List Running Docker Containers
1. docker container ls

## List Running Docker Containers -All
1. docker container ls -a

## Remove a Docker Container <Container ID>
1. docker container rm a10c40fde697

## Remove a Docker Container <names>
1. docker container rm heuristic_hugle

## List Images
1. docker images

## Remove Images <image id>
1. docker rmi cd47d6573802
 
## Push to DockerHub
1. docker login
2. docker images (to find desired image id)
3. docker tag 96da9143fb18 raybishun/onboarding:v1 (to update the tag)
4. docker push raybishun/onboarding
5. cat onboarding/dockerfile
 
## Retrieve image from DockerHub
1. docker pull raybishun/onboarding:v1
2. docker image ls