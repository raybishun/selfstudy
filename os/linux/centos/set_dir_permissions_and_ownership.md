# Set Directory Permissions and Ownership

### Create a directory named '/redhat/sysgrp'
[root@ideapad ~]# mkdir -p /redhat/sysgrp

### View the current group ownership
[root@ideapad ~]# ls -ltrd /redhat/sysgrp/
```
drwxr-xr-x. 2 root root 6 Jun 19 23:18 /redhat/sysgrp/
```
### Change the group ownership of '/redhat/sysgrp/' to the sysgrp group
[root@ideapad ~]# chgrp sysgrp /redhat/sysgrp/
[root@ideapad ~]# ls -ltrd /redhat/sysgrp/
```
drwxr-xr-x. 2 root sysgrp 6 Jun 19 23:18 /redhat/sysgrp/
```
### Set the permissions of the '/redhat/sysgrp/' directory to RW for only the sysgrp members
[root@ideapad ~]# chmod 770 /redhat/sysgrp/
[root@ideapad ~]# ls -ltrd /redhat/sysgrp/
```
drwxrwx---. 2 root sysgrp 6 Jun 19 23:18 /redhat/sysgrp/
```
### Ensure files created under '/redhat/sysgrp' automatically have group ownership set to the sysgrp group
[root@ideapad sysgrp]# cd /redhat/sysgrp/
[root@ideapad sysgrp]# touch test.txt
[root@ideapad sysgrp]# ls -ltr
```
total 0
-rw-r--r--. 1 root root 0 Jun 19 23:30 test.txt
```
[root@ideapad sysgrp]# chmod 2770 /redhat/sysgrp/
[root@ideapad sysgrp]# ls -ltrd /redhat/sysgrp/
```
drwxrws---. 2 root sysgrp 21 Jun 19 23:30 /redhat/sysgrp/
```
[root@ideapad sysgrp]# pwd
```
/redhat/sysgrp
```
[root@ideapad sysgrp]# touch test2.txt
[root@ideapad sysgrp]# ls -ltr
```
total 0
-rw-r--r--. 1 root root   0 Jun 19 23:30 test.txt
-rw-r--r--. 1 root sysgrp 0 Jun 19 23:33 test2.txt
```