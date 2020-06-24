# Set File Permissions and Ownership

###
- In this example we will set permissions on the /etc/fstab file
- setfacl (set-file-acl) can be used to set file permissions
- getfacl can be used to view file permissions

### List the file we will work with
[root@ideapad ~]# ll /etc/fstab
```
-rw-r--r--. 1 root root 628 Jan  5  2019 /etc/fstab
```
### As a precaution, make a copy of the file, and work with that file
[root@ideapad ~]# cp -p /etc/fstab /var/tmp

### List the file, and review its permissions
[root@ideapad ~]# ll /var/tmp/fstab
```
-rw-r--r--. 1 root root 628 Jan  5  2019 /var/tmp/fstab
```
### To restrict the file to only the root user and root group, you would...
[root@ideapad ~]# chown root:root /var/tmp/fstab
[root@ideapad ~]# ls -ltr /var/tmp/fstab
```
-rw-r--r--. 1 root root 628 Jan  5  2019 /var/tmp/fstab
```
### Ensure user Andrew exists (created previously using managing_users_groups_and_passwords.md)
[root@ideapad ~]# id andrew
```
uid=1001(andrew) gid=1002(andrew) groups=1002(andrew),1001(sysgrp)
```
### Allow RW to the file for Andrew
[root@ideapad ~]# setfacl -m u:andrew:rw- /var/tmp/fstab
[root@ideapad ~]# getfacl /var/tmp/fstab

### Deny RW to the file for Susan
[root@ideapad ~]# setfacl -m u:susan:--- /var/tmp/fstab
[root@ideapad ~]# getfacl /var/tmp/fstab

### To validate the above settings (simply attempt to read/modify the file)
```
su - susan
cat /var/tmp/fstab (to confirm read denied)

su - andrew 
vi /var/tmp/fstab (to confirm RW)
```