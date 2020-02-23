# CI/CD with Docker images

### Create a sample python (Flask) app
1. echo 'from flask import Flask
1. app = Flask(__name__)
1. @app.route("/")
1. def hello():
1. 		return "hello world!"
1. if __name__ == "__main__":
1. 		app.run(host="0.0.0.0")' > app.py

## Build a Docker image

### Create Dockerfile
1. vim Dockerfile
1. FROM python:3.6.1-alpine	(start with a specific image - note, alpine is a very small python image)
1. RUN pip install flask	(RUN is at BUILD time, i.e. preform necessary prep steps)
1. CMD ["python","app.py"]	(CMD is RUNTIME, i.e. run python app.py when the image starts)
1. COPY app.py /app.py		(COPY /app.py into a new layer of our image)
1. :wq

### Build the Docker image using your Dockerfile
1. docker image build -t python-hello-world .	(where the . means use the local Dockerfile, and -t is used to name the image, i.e. python-hello-world)
1. docker image ls (and verify that you see the python:3.6.1-alpine image)

### Run the Docker image
1. docker run -p 5001:5000 -d python-hello-world (-p maps TCP:5000 inside the container to TCP:5000 on the host)
1. docker container ls (verify the image is running)
1. TIP curl -4 icanhazip.com (get public IP address of your Linux host)
1. TIP You will need to add an inbound firewall rule to allow 5001 on your Linux host
1. http://public_ip_address:5001 (verify hello world! is returned)

### Review the log output of the container
1. docker container logs 460e (where 460e is the first 4 chars for the container_id)

### Push to DockerHub
1. docker login (if necessary)
1. docker tag python-hello-world raybishun/python-hello-world
1. docker push raybishun/python-hello-world

## Deploy a change

### Make a trivial change
1. vim app.py
1. make a trivial change, i.e. return "Hello Beautiful World!"
1. :wq

### Rebuild image
1. docker image build -t raybishun/python-hello-world .

### Push change
1. docker push raybishun/python-hello-world

### Pull the latest image
1. docker pull raybishun/python-hello-world:latest

### Run the latest image
1. docker run -p 5001:5000 -d raybishun/python-hello-world
1. TIP curl -4 icanhazip.com (get public IP address of your Linux host)
1. TIP You will need to add an inbound firewall rule to allow 5001 on your Linux host
1. http://public_ip_address:5001 (verify hello world! is returned)

### Cleanup (removing containers)
1. docker container ls
1. docker container stop c310 (where c310 is the first 4 chars of the container_id)
1. docker system prune (removes stopped containers, not used network, dangling images and dangling build cache)
1. docker container ls

### Review
1. Docker incorporates copy-on-write and the union file system to efficiently store images and run containers
1. Each line in the Dockerfile creates a new layer (that contains only the delta)
1. Image layers are cached by the Docker build and push system
1. The bottom layers are read-only, except for the (thin) top layer (which improves performance)
1. The (thin) top layer is the container layer for your code (app)
1. Be cautions of the size, security and source when using the FROM statement in a Dockerfile