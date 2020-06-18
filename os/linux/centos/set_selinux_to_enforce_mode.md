# Set SELinux to Enforcing Mode

### Description
SELinux modes can be:
- enforcing
- permissive (warns but not enforced)
- disabled 

SELinux has 3 types
- targeted - targeted processes are protect
- minimum - only selected processes are protected
- mls - Multi Level Security protection

Important
- a reboot is required
- a 'relabeling' process is initiated on next reboot

### Steps
[root@ideapad ~]# getenforce
```
Enforcing
```

[root@ideapad ~]# ll /etc/selinux/config
```
-rw-r--r--. 1 root root 547 Jan  5  2019 /etc/selinux/config
```

[root@ideapad ~]# cp -p /etc/selinux/config /etc/selinux/config_backup (good practice to backup file before you make changes)

[root@ideapad ~]# vi /etc/selinux/config (change SELINUX=enforcing)
```
# This file controls the state of SELinux on the system.
# SELINUX= can take one of these three values:
#     enforcing - SELinux security policy is enforced.
#     permissive - SELinux prints warnings instead of enforcing.
#     disabled - No SELinux policy is loaded.
SELINUX=enforcing
# SELINUXTYPE= can take one of three two values:
#     targeted - Targeted processes are protected,
#     minimum - Modification of targeted policy. Only selected processes are protected.
#     mls - Multi Level Security protection.
SELINUXTYPE=targeted
```