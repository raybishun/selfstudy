# Installing Jenkins (on Windows)

### Download & save .war file
1. Download the Generic Java package (jenkins.war) from: https://www.jenkins.io/download/
2. Save locally, i.e. C:\jenkins

### Create an environment variable
1. Search\Advanced System Settings
2. Advanced
3. Environment Variables...
4. System Variables
5. New...
6. Variable name: JENKINS_HOME
7. Variable value: C:\jenkins

### Verify that TCP:8181 is not in use
1. Launch an elevated CMD prompt
2. netstat -abno | findstr 8181

### Install Jenkins
1. Open a CMD prompt
2. cd C:\jenkins
3. java -jar jenkins.war --httpPort=8181 (default is 8080)
4. If prompted, select the appropriate domain(s), and 'Allow Access'

### Review the output in the CMD window
1. "Running from C:\jenkins\jenkins.war"
2. "webroot: EnvVars.masterEnvVars.get("JENKINS_HOME")"
3. "Jenkins is fully up an running" (last line of output)

### Complete the install
1. http://localhost:8181/
2. Enter the 'Administrator password' from: C:\jenkins\secrets\initialAdminPassword
3. Continue

### Customize jenkins
1. Install suggested plugins

### Create First Admin User
1. Enter credentials, i.e. 'admin'
2. Save and Continue
3. Confirm the Instance Configuration URL is: http://localhost:8181/
4. Save and Finish
5. Start using Jenkins