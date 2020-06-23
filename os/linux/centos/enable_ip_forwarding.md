# Enable IP Forwarding

### Description
- IP Forwarding may be required when configuring Linux as a router

### Backup the sysctl.conf file
[root@ideapad ~]# cp -p /etc/sysctl.conf /etc/sysctl.conf_bak

### Verify the backup
[root@ideapad ~]# ls -lst /etc/sysctl.con*
```
4 -rw-r--r--. 1 root root 449 Aug  8  2019 /etc/sysctl.conf
4 -rw-r--r--. 1 root root 449 Aug  8  2019 /etc/sysctl.conf_bak
```
### Configure IP Forwarding
[root@ideapad ~]# vi /etc/sysctl.conf
```
# sysctl settings are defined through files in
# /usr/lib/sysctl.d/, /run/sysctl.d/, and /etc/sysctl.d/.
#
# Vendors settings live in /usr/lib/sysctl.d/.
# To override a whole file, create a new file with the same in
# /etc/sysctl.d/ and put new settings there. To override
# only specific settings, add a file with a lexically later
# name in /etc/sysctl.d/ and put new settings there.
#
# For more information, see sysctl.conf(5) and sysctl.d(5).
```
1. Use the cursor to move to the last line in the file
2. Use the cursor to move to the end of that line
3. Press i for INSERT
4. Press ENTER to add a new line
5. Enter the below
```
net.ipv4.ip_forward = 1
```
ESC (to exit edit mode)
:wq! (to write and quit)

### View configuration
[root@ideapad ~]# [root@ideapad ~]# cat /etc/sysctl.conf
```
net.ipv4.ip_forward = 1
```

### Enable IP Forwarding
[root@ideapad ~]# sysctl -p
```
net.ipv4.ip_forward = 1
```

### Test configuration
[root@ideapad ~]# sysctl -a | grep -i net.ipv4.ip_forward
```
net.ipv4.ip_forward = 1
net.ipv4.ip_forward_use_pmtu = 0

sysctl: reading key "net.ipv6.conf.all.stable_secret"
sysctl: reading key "net.ipv6.conf.default.stable_secret"
sysctl: reading key "net.ipv6.conf.enp3s0.stable_secret"
sysctl: reading key "net.ipv6.conf.lo.stable_secret"
sysctl: reading key "net.ipv6.conf.virbr0.stable_secret"
sysctl: reading key "net.ipv6.conf.virbr0-nic.stable_secret"
sysctl: reading key "net.ipv6.conf.wlp4s0.stable_secret"
```