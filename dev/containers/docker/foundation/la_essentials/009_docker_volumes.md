# Docker Volumes

### What are Docker Volumes?
- Docker volumes are used to store persisted data generated by a Docker Container
- Or data that will be used by a Docker Container

### Start with a clean slate
1. docker container ls (show status of RUNNING containers)
2. docker container ls -a
3. docker stop container_id (if necessary)
4. docker image ls

### Create a new volume
1. docker volume ls
docker volume create devvolume (create a volume called devvolume)
2. docker volume ls
3. docker volume inspect devvolume
4. docker container run -d --name devcont --mount source=devvolume,target=/app nginx
5. docker container ls
6. docker container inspect devcont
7. sudo ls /var/lib/docker/volumes (verify docker volume exists)
8. sudo ls /var/lib/docker/volumes/devvolume
9. sudo ls /var/lib/docker/volumes/devvolume/_data (empty at this point)
10. docker container exec -it devcont sh (open a shell within the container)
11. echo "Hello!" >> /app/hello.txt
12. ls app
13. exit
14. sudo ls /var/lib/docker/volumes/devvolume/_data
15. docker container stop devcont
16. docker container rm devcont (remove container from the system)
17. sudo ls /var/lib/docker/volumes/devvolume/_data (verify our data is still there)
18. docker container run -d --name devcont2 -v devvolume:/app nginx
19. docker container exec -it devcont2 sh (shell into container to verify if your data is there)
20. ls -hal app (and confirm that our hello.txt file exists)
21. cat /app/hello.txt
22. echo "Goodbye!" >> /app/bye.txt
23. exit
24. sudo ls /var/lib/docker/volumes/devvolume/_data (verify both .txt files exists)