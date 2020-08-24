# How to install Splunk on CentOS using the CLI

### Introduction
This is a walk-through on how to install Splunk Enterprise 8.0.5 on CentOS 8. The free version of Splunk allows you to Index 500 MB/Day. After 60 days you are able to convert to a perpetual free license or purchase a Splunk Enterprise license. For more information visit: https://www.splunk.com/en_us/download/get-started-with-your-free-trial.html.

### Prerequisites

#### Check Linux Kernel Version in CentOS (showing 5 options)
```
hostnamectl
rpm -qa centos-release
cat /etc/centos-release
cat /etc/os-release
uname -r
```
#### Update Linux (optional)
```
sudo yum update
```

#### Install wget on CentOS8 (if not found)
```
sudo yum search wget (try to locate wget package)
sudo yum install wget
```
#### Install tar (if not found)
```
sudo yum search tar
sudo yum list tar
yum info tar.x86_64
sudo yum install tar
```

### Download Splunk
1. mkdir download (if necessary)
2. cd download
3. Sign-up and retrieve download command from: https://www.splunk.com/en_us/download/splunk-enterprise/thank-you-enterprise.html

4. Select the Download via Command Line (wget) option, and copy the wget command
```
wget -O splunk-8.0.5-a1a6394cc5ae-Linux-x86_64.tgz 'https://www.splunk.com/bin/splunk/DownloadActivityServlet?architecture=x86_64&platform=linux&version=8.0.5&product=splunk&filename=splunk-8.0.5-a1a6394cc5ae-Linux-x86_64.tgz&wget=true'
```
### Install Splunk
1. Unzip the tarball file
```
tar xvzf splunk-8.0.3-a6754d8441bf-Linux-x86_64.tgz -C /opt
```
2. Copy the default conf file to the production conf file
```
cp /opt/splunk/etc/splunk-launch.conf.default splunk.launch.conf
```
3. Set Splunk home environment variable
```
export SPLUNK_HOME=/opt/splunk
```
### Start Splunk
1. Start Splunk
```
sudo /opt/splunk/bin/splunk start (q/y/enter to accept the EULA, or use the next line instead)
sudo /opt/splunk/bin/splunk start –accept-license
```
2. Accept the license agreement (required only during the first start)
3. Enter a username and password for the admin account

### Verify installation
By default, the Splunk interface is at http://serverName:8000

### Enable Splunk to start at boot
```
cd /opt/splunk/bin
./splunk enable boot-start
./splunk disable boot-start (to disable)
```
### Troubleshooting

#### Open TCP:8000 on CentOS8
```
firewall-cmd --list-all
firewall-cmd --get-services
firewall-cmd --get-zones
firewall-cmd --zone=public --permanent --add-port 8000/tcp
firewall-cmd --reload
firewall-cmd --list-all
```
#### Disable Splunk to start at boot
```
splunk disable boot-start
```
#### Uninstalling Splunk
```
cd /opt/splunk/bin
./splunk stop
reboot
rm -rf /opt/splunk
```
# References
1. Uninstall Splunk Enterprise: https://docs.splunk.com/Documentation/Splunk/8.0.5/Installation/UninstallSplunk