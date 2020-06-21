# Set the default boot target to multi-user.target (run levels)

### Description
- The default boot target can be either multi-user or graphical

### Steps
[root@ideapad ~]# systemctl get-default
```
graphical.target
```
[root@ideapad ~]# systemctl set-default multi-user.target
```
Removed symlink /etc/systemd/system/default.target.
Created symlink from /etc/systemd/system/default.target to /usr/lib/systemd/system/multi-user.target.
```
[root@ideapad ~]# systemctl get-default
```
multi-user.target
```
[root@ideapad ~]# systemctl set-default graphical.target
```
Removed symlink /etc/systemd/system/default.target.
Created symlink from /etc/systemd/system/default.target to /usr/lib/systemd/system/graphical.target.
```
[root@ideapad ~]# systemctl get-default
```
graphical.target
```
