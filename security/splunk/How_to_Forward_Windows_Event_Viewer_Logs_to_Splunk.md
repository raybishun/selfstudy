# How to Forward Windows Event Viewer Logs to Splunk

### Download the Splunk Universal Forwarder
1. https://www.splunk.com/en_us/download/universal-forwarder.html#tabs/windows
2. Find and download the 64-bit version of: 'Windows 10 Windows Server 2016, 2019'

### Install and configure the Universal Forwarder on a Windows 10 client
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
1. SSH to the Splunk Server
```
cd /opt/splunk/etc/deployment-apps/
mkdir eventvwr
cd eventvwr
```
In the Splunk Portal, refresh the Settings\Distributed Environment\Forwarder management page
eventvwr should automatically appear under the Apps(1) tabs
Back in the SSH session, mkdir local (opt/splunk/etc/deployment-apps/eventvwr/local)
```
cd local
ls -hal /opt/splunk/etc/system/local (to view the Server Class files)
```
In the Splunk Portal, select the Server Classes tabs
Create one
New Server Class: win_servers
Save
Add Apps
Select eventvwr 
Save
Add Clients
For this lab environment, I entered an asteric in the Include (whitelist)
Save
Back to Forwarder Management, verify the Server Classes (1) now shows 1 client deployed
Back in the SSH session, enter the below
```
cat /opt/splunk/etc/system/local/serverclass.conf
```
On the Windows 10 client, verify the app.conf file was created under: C:\Program Files\SplunkUniversalForwarder\etc\apps\eventvwr\local
Back in the SSH session, verify the app.conf file was created under: /opt/splunk/etc/deployment-apps/eventvwr/local

### Create New Indexer
1. Log into the Splunk Portal
2. Settings\Indexes
3. New Index
4. Index Name: windows_logs
5. Save
6. Settings\Source types
7. New Source Type
8. Name: Windowslogs
8. Save
9. Settings\Data inputs

### Create the Inputs file
1. SSH to the Splunk server
2. cd /opt/splunk/etc/deployment-apps/eventvwr/local
3. vi inputs.conf
```
[monitor://C:\Windows\Performance\WinSAT\winsat.log]
disabled = 0
index = windows_logs
sourcetype = Windowslogs
source = C:\Windows\Performance\WinSAT\winsat.log

[WinEventLog://Application]
disabled = 0
index = windows_logs
sourcetype = Windowslogs

[WinEventLog://Security]
disabled = 0
index = windows_logs
sourcetype = Windowslogs

[WinEventLog://System]
disabled = 0
index = windows_logs
sourcetype = Windowslogs

[perfmon://CPU]
disabled = 0
index = windows_logs
counters = % Processor Time
instances  = _Total;
object = Processor
interval = 300
 
[perfmon://LogicalDisk]
disabled = 0
index = windows_logs
counters = % Free Space; Free Megabytes
instances  = *
object = LogicalDisk
interval = 300
```
### Create the Output file
1. SSH to the Splunk server
2. cd /opt/splunk/etc/deployment-apps/eventvwr/local
3. vi outputs.conf
```
[tcpout]

defaultGroup = default-autolb-group

[tcpout:default-autolb-group]

server = <your-splunk-ip-address>:9997

[tcpout-server://<your-splunk-ip-address>:9997]
```

### Start...
```
cd /opt/splunk/bin
./splunk reload deploy-server
(You may need to enter the Splunk Admin username and password)
```
After about 2 minutes, C:\Program Files\SplunkUniversalForwarder\etc\apps\eventvwr\local now contains 3 files: app.conf, inputs.conf, and outputs.conf


### Review the Forwarded inputs
Settings\Data inputs
Find Windows Event Logs has 3 Inputs: Application, Security and System
Find Files & Directories has 1 additional input: Source path: C:\Windows\Performance\WinSAT\winsat.log
Find Windows Performance Monitoring has 2 additional inputs: CPU and LogicalDisk

# Run Test Queries
Search & Reporting
index="windows_logs"


# References
1. https://www.youtube.com/watch?v=COVb0A9PFtI