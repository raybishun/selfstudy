# How to Forward Windows Event Viewer Logs to Splunk

### Download the Splunk Universal Forwarder
1. https://www.splunk.com/en_us/download/universal-forwarder.html#tabs/windows
2. Find and download the 64-bit version of: 'Windows 10 Windows Server 2016, 2019'

### Install the Universal Forwarder on Windows 10 client
1. Accept the EULA
2. Customize Options
3. C:\Program Files\SplunkUniversalForwarder\
4. For this lab, I will use the default Splunk certificate
5. Local System
6. Windows Event Logs: Application and System Logs
7. User: splunk_fwd
8. For Deployment Server, I will used my Splunk server's IP address, and the default port: 8089
9. For Receiving Indexer, I will used my Splunk server's IP address, and the default port: 9997
10. Install
11. Finish

### Open TCP:8000 on CentOS8
```
firewall-cmd --list-all
firewall-cmd --get-services
firewall-cmd --get-zones
firewall-cmd --zone=public --permanent --add-port 8089/tcp
firewall-cmd --zone=public --permanent --add-port 9997/tcp
firewall-cmd --reload
firewall-cmd --list-all
```
### Verify the SplunkForwarder Service on the Windows 10 client is communicating with the Splunk Server

#### Check the Splunk Server
1. Log into the Splunk Portal
2. Settings
3. Distributed Environment\Forwarder management
4. The client client should auto enroll in approximately 5 minutes

#### Verify the Splunk Service is running
1. Restart the 'SplunkForwarder' service

#### Verify the Splunk Working Folder was created
1. C:\Program Files\SplunkUniversalForwarder

### Configure Deployment App to Collect the Windows Logs
