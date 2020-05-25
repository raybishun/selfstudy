# Installing Jenkins (on Windows)

### Introduction
This walk-through uses the jenkins.war (Web Application Resource or Web application ARchive) file to run Jenkins as a web application on Windows.

### Prerequisites
#### Install the Java JDK
1. Find, save locally, i.e. Downloads folder, and install the latest version of the JDK from https://www.oracle.com/java/ (or https://www.oracle.com/java/technologies/javase-downloads.html)

#### Verify Java is installed successfully
1. "C:\Program Files\Java\jdk-14.0.1\bin\java" --version (at the time of this post, the latest version was 14.0.1)
```
C:\Program Files\Java\jdk-14.0.1\bin>java --version
java 14.0.1 2020-04-14
Java(TM) SE Runtime Environment (build 14.0.1+7)
Java HotSpot(TM) 64-Bit Server VM (build 14.0.1+7, mixed mode, sharing)
```
#### Add the JAVA_HOME System variable
1. Control Panel\System and Security\System\Advanced system settings
2. Environment Variables
3. System variables
4. New...
5. Variable name: JAVA_HOME
6. Variable value: C:\Program Files\Java\jdk-14.0.1
7. OK

#### Add JAVA to the Path variable
1. Control Panel\System and Security\System\Advanced system settings
2. Environment Variables
3. System variables
4. Path\Edit...
5. Add --> C:\Program Files\Java\jdk-14.0.1\bin
6. OK
7. Reboot

#### Verify Java is accessible via the Path variable
1. Open a CMD prompt
2. java --version
```
C:\>java --version
java 14.0.1 2020-04-14
Java(TM) SE Runtime Environment (build 14.0.1+7)
Java HotSpot(TM) 64-Bit Server VM (build 14.0.1+7, mixed mode, sharing)
```
### Download & save .war file
1. Download the Generic Java package (jenkins.war) from: https://www.jenkins.io/download/ (file size is approximately 64MB)
2. Save locally, i.e. C:\jenkins

### Create an environment variable
1. Search\Advanced System Settings
2. Advanced
3. Environment variables...
4. System variables
5. New...
6. Variable name: JENKINS_HOME
7. Variable value: C:\jenkins
8. OK\OK

### Verify TCP:8181 is not in use
1. Launch an elevated CMD prompt
2. netstat -abno | findstr 8181

### Install Jenkins
1. Open a CMD prompt
2. cd C:\jenkins
3. java -jar jenkins.war --httpPort=8181 (default is 8080)
4. NOTE: At the time of this post, Jenkins only supports Java version [8, 11], however, run with the '--enable-future-java' switch as shown below
5. For more info, visit: https://jenkins.io/redirect/java-support/
```
java -jar jenkins.war --httpPort=8181 --enable-future-java
```
6. If prompted, select the appropriate domain(s), and 'Allow Access'

### Review the output in the CMD window
1. "Running from C:\jenkins\jenkins.war"
2. "webroot: EnvVars.masterEnvVars.get("JENKINS_HOME")"
3. "Jenkins is fully up an running" (last line of output)

### Complete the install
1. http://localhost:8181/
2. Enter the 'Administrator password' from: C:\jenkins\secrets\initialAdminPassword
3. Continue

### Customize Jenkins
1. Install suggested plugins

### Create First Admin User
1. Enter credentials, i.e. 'admin'
2. Save and Continue
3. Confirm the Instance Configuration URL is: http://localhost:8181/
4. Save and Finish
5. Start using Jenkins

### Add additional plugins
1. Manage Jenkins
2. Manage Plugins
3. Available tab
4. Filter: Blue Ocean, find and select Blue Ocean
5. Filter: MSBuild, find and select MSBuild
6. Filter: VSTest, find and select VSTest Runner
7. Install without restart
8. Wait about 2 minutes for the 'Installing Plugins/Upgrades' to complete

### How to start Jenkins
- java -jar jenkins.war --httpPort=8181
- or java -jar jenkins.war --httpPort=8181 --enable-future-java (per above)