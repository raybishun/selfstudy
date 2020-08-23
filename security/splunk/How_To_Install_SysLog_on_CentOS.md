# How to Install and Test SysLog on CentOS8

### Overview
- Install SysLog (if not already installed)
- Verify SysLog is is accepting events from the system using the /var/log/messages file

### Install SysLog
```
dnf install rsyslog -y
```
### Verify Installation 
```
rpm -q rsyslog --verbose
```
### Get the status of the SysLog service
```
systemctl status rsyslog.service
```
### How to stop/start the SysLog service
```
systemctl stop rsyslog.service
systemctl start rsyslog.service
```
### Verify SysLog is accepting events from the system
```
echo "test message from user ray" | logger
tail /var/log/messages
```