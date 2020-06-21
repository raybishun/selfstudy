# Managing Users, Groups and Passwords

### Create a group
[root@ideapad ~]# groupadd sysgrp

### Create a user
[root@ideapad ~]# useradd andrew

### Add user to a secondary group
[root@ideapad ~]# usermod -aG sysgrp andrew

### Verify user was added to the secondary group
[root@ideapad ~]# id andrew
```
uid=1001(andrew) gid=1002(andrew) groups=1002(andrew),1001(sysgrp)
```
### Create another user and add her to sysgrp
[root@ideapad ~]# useradd susan
[root@ideapad ~]# usermod -aG sysgrp susan
[root@ideapad ~]# id susan
```
uid=1002(susan) gid=1003(susan) groups=1003(susan),1001(sysgrp)
```
### Create and delete a user
[root@ideapad ~]# useradd sarah
[root@ideapad ~]# userdel -r sarah

### Switch user
[ray@ideapad root]$ su andrew
```
Password:
```
### Create a user that does not have access to an interactive shell on the host
[root@ideapad ~]# useradd -s /sbin/nolgin sarah

### Verify the user does not have access to an interactive shell on the host
[andrew@ideapad root]$ su sarah
Password:
```
su: failed to execute /sbin/nolgin: No such file or directory
```
### Set a user password
[root@ideapad ~]# passwd andrew
```
Changing password for user andrew.
New password:
BAD PASSWORD: The password fails the dictionary check - it is based on a dictionary word
Retype new password:
passwd: all authentication tokens updated successfully.
```
### View CLI history
history (this shows the command history for current user)