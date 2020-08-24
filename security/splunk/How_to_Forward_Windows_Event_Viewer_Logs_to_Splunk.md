# How to Forward Windows Event Viewer Logs to Splunk

### Download the Splunk Universal Forwarder
1. https://www.splunk.com/en_us/download/universal-forwarder.html#tabs/windows
2. Find and download the 64-bit version of: 'Windows 10 Windows Server 2016, 2019'

### Install and configure the Splunk Universal Forwarder on a Windows 10 client
1. Accept the EULA
2. Customize Options
3. C:\Program Files\SplunkUniversalForwarder\
4. For this lab, I will use the default Splunk certificate
5. Local System
6. Windows Event Logs: Application and System Logs
7. Admin Username: splunk_fwd
8. For Deployment Server, I will used my Splunk server's IP address, and the default port: 8089
9. For Receiving Indexer, I will used my Splunk server's IP address, and the default port: 9997
10. Install
11. Finish

### Open the required TCP ports on the Splunk CentOS8 Server
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
4. The Windows 10 client should auto enroll in approximately 5 minutes

#### Verify the Splunk Service is running
1. Restart the 'SplunkForwarder' service

#### Verify the Splunk Working Folder was created
1. C:\Program Files\SplunkUniversalForwarder

### Configure Deployment App

#### Overview
1. You create a deployment app by simply creating a folder, i.e.: /opt/splunk/etc/deployment-apps/eventvwr/local
2. eventvwr is the 'app' in this case
3. Then add an inputs.conf and outputs.conf file into eventvwr\local folder

#### Configure Deployment App to Collect the Windows Logs
1. SSH to the Splunk Server
```
cd /opt/splunk/etc/deployment-apps/
mkdir eventvwr
cd eventvwr
```
2. In the Splunk Portal, refresh the Settings\Distributed Environment\Forwarder management page
3. eventvwr should automatically appear under the Apps tab
4. Back in the SSH session, mkdir local (opt/splunk/etc/deployment-apps/eventvwr/local)
```
cd local
```
#### Review the serverclass.conf file
- NOTE: Before creating the inputs.conf and outputs.conf files, you need to map the 'app' and 'client' using serverClass

```
cd /opt/splunk/etc/system/local
cat serverclass.conf (to view the current settings)
```
#### Create a New ServerClass
1. From the Splunk Portal\Settings\Forwarder management
2. Select the Server Classes tabs
3. New Server Class
4. Name: win_servers
5. Save
6. Add Apps
7. Select eventvwr 
8. Save
9. Add Clients
10. For this lab environment, I entered an asterisk in the Include (whitelist) - to add all clients
11. Save
12. Back to Forwarder Management link
13. Verify the Server Classes (1) now shows 1 client deployed
14. From the SSH session, review the serverclass.conf file
```
cat /opt/splunk/etc/system/local/serverclass.conf

	[serverClass:win_servers:app:eventvwr]
	restartSplunkWeb = 0
	restartSplunkd = 0
	stateOnClient = enabled

	[serverClass:win_servers]
	whitelist.0 = *
```
### Verify the .conf files were created
1. On the Windows 10 client, verify the app.conf file was created under: C:\Program Files\SplunkUniversalForwarder\etc\apps\eventvwr\local
2. Back in the SSH session, verify the app.conf file was created under: /opt/splunk/etc/deployment-apps/eventvwr/local

### Create New Indexer
1. From the Splunk Portal
2. Settings\Indexes\New Index\Index Name: windows_logs
3. Save
4. Settings\Source types\New Source Type\Name: Windowslogs
5. Save

### Create the inputs.conf file
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
### Create the outputs.conf file
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

### Reload Splunk settings
1. Enter the below
```
cd /opt/splunk/bin
./splunk reload deploy-server
(You may need to enter the Splunk Admin username and password)
```

2. After about 2 minutes, C:\Program Files\SplunkUniversalForwarder\etc\apps\eventvwr\local now contains 3 files: app.conf, inputs.conf, and outputs.conf

### Review the Forwarded inputs
1. From the Splunk Portal
2. Settings\Data inputs
3. Find Windows Event Logs now has 3 Inputs: Application, Security and System
4. Find Files & Directories now has 1 additional input: Source path: C:\Windows\Performance\WinSAT\winsat.log
5. Find Windows Performance Monitoring now has 2 additional inputs: CPU and LogicalDisk

# Run Test Queries
1. Search & Reporting
2. index="windows_logs"
3. index="windows_logs" source="Perfmon:LogicalDisk" counter="Free Megabytes" instance="C:" | stats by instance
4. index="windows_logs" source="Perfmon:LogicalDisk" counter="Free Megabytes" instance="C:" | stats by instance | fields max(Value)
5. index="windows_logs" source="WinEventLog:System"

# Troubleshooting

### Found that I had to manually add the Receiving port
1. From the Splunk Portal
2. Settings\Forwarding and receiving
3. Receive data\configure receiving
4. New Receiving port
5. Listen on this port: 9997

### Experienced a delay in creating the 'windows_logs' index
1. Don't know if this is normal, but was only able to search the 'windows_logs' index the next day (I think)...but more testing required to determine RC

### Restart Splunk
1. cd /opt/splunk/bin
2. ./splunk stop
3. ./splunk start –accept-license

# Notes
1. C:\windows\Performance\WinSAT\winsat.log tracks errors during startup, as well as runtime errors

# Addendum

### Adding additional Windows Application and Service Logs (for Windows Defender and ATP)

#### Modify the inputs.conf file
1. SSH to the Splunk server
2. cd /opt/splunk/etc/deployment-apps/eventvwr/local
3. vi inputs.conf
```
[WinEventLog://Microsoft-Windows-Windows Defender/Operational]
disabled = 0
index = windows_logs
sourcetype = Windowslogs
checkpointInterval = 5
current_only = 0
evt_resolve_ad_obj = 0
start_from = oldest

[WinEventLog://Microsoft-Windows-SENSE/Operational]
disabled = 0
index = windows_logs
sourcetype = Windowslogs
checkpointInterval = 5
current_only = 0
evt_resolve_ad_obj = 0
start_from = oldest
blacklist = 54
```
#### Reload Splunk settings
1. Enter the below
```
cd /opt/splunk/bin
./splunk reload deploy-server
(You may need to enter the Splunk Admin username and password)
```
#### Verify the conf files were updated
1. I noticed all 3 .conf files were updated in about 5 minutes under: C:\Program Files\SplunkUniversalForwarder\etc\apps\eventvwr\local
2. I didn't need to restart the Splunk service (client or server)

# References
1. https://www.youtube.com/watch?v=COVb0A9PFtI