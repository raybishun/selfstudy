# How to install Splunk on CentOS using the CLI

### Introduction
This is a walk-through on how to install Splunk Enterprise 8.0.3 on CentOS 7. The free version allows you to Index 500 MB/Day. After 60 days you are able to convert to a perpetual free license or purchase a Splunk Enterprise license. For more information plese visit: https://www.splunk.com/en_us/download/get-started-with-your-free-trial.html.

### Download Splunk
1. Sign-up and retrieve download command from: https://www.splunk.com/en_us/download/splunk-enterprise/thank-you-enterprise.html

2. Select the Download via Command Line (wget) option, and copy the wget command
```
wget -O splunk-8.0.3-a6754d8441bf-Linux-x86_64.tgz 'https://www.splunk.com/bin/splunk/DownloadActivityServlet?architecture=x86_64&platform=linux&version=8.0.3&product=splunk&filename=splunk-8.0.3-a6754d8441bf-Linux-x86_64.tgz&wget=true'
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
sudo /opt/splunk/bin/splunk start
```
2. Accept the license agreement (required only during the first start)
3. Enter a username and password for the admin account

### Verify installation
By default, the Splunk interface is at http://serverName:8000