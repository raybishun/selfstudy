# Docker Build

### Review the latest dotnet core images 
1. http://dockerhub.com
2. search for: microsoft/dotnet

### Review your local docker images
```
docker images
docker ps -a (view any running containers)
```
### Build
1. Create a docker_prep folder
2. Copy in the webapp folder and its contents
3. Copy in the dockerfile
4. CD to the docker_prep folder
```
docker build -t webapp .
```
### Review docker images
```
docker images (you should see two new images)
```
### Run the docker container
```
docker run -p 8081:80 --name mywebapp webapp
```
### Verify the container is running
```
docker ps -a (view your webapp container)
```
### Access the app from a browser
1. http://localhost:8081/