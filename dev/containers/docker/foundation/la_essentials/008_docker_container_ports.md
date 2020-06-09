# Docker Container Ports

### Start with a clean slate
1. docker container ls (show status of RUNNING containers)
2. docker container ls -a
3. docker image ls
4. docker system prune -a

### Run a new image that exposes a port, i.e. 80/tcp
1. docker container run -d nginx (get and attach image using whatever default port was configured)
2. docker image ls (show status of RUNNING containers, as well as listening ports)
3. docker image history nginx (to view exposed port(s))
4. docker container inspect cae9bd846c34 | grep IPAdd (grep the IPaddress the image is using)
5. sudo yum install elinks
6. elinks 172.17.0.2 (to verify the web server is running)
7. docker container run -d -P nginx (where -P maps a random ephemeral port to a local port on our container)
8. docker container ls (show status of RUNNING containers)
9. docker container run -d -p 80:80 httpd
10. TIP curl -4 icanhazip.com (get the public IP address of your host server)
11. elinks <public IP address> (confirm you are able to view the default nginx web page)