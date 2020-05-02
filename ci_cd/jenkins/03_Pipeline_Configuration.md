# Configuring the Pipeline using Domain-Specific Language (DSL)

### Create new jobs
1. http://localhost:8181/
2. On the Welcome to Jenkins! page click 'create new jobs'
3. Enter an item name = RestSharpAutomation
4. Pipeline
5. OK

### Create a Pipeline script (using DSL)
1. Enter the below script under: Pipeline\Definition\Pipeline script\Script
```
pipeline {
    agent any
    
    stages{
        stage('CleanUp Stage'){
            steps{
                bat 'echo CleanUp Stage'
            }
        }
        stage('Git Checkout Stage'){
             steps{
                bat 'echo Git Checkout Stage'
            }
        }
        stage('Restore Package Stage'){
             steps{
                bat 'echo Restore Package Stage'
            }
        }
        stage('Build Stage'){
             steps{
                bat 'echo Build Stage'
            }
        }
        stage('Test Execution Stage'){
             steps{
                bat 'echo Test Execution Stage started'
                bat 'echo Test Execution Stage completed'
            }
        }
    }
}
```
2. Save

### Build
1. Configure
2. Ensure the above pipeline script was saved
3. Build Now
4. The build will complete and show the 4 stages defined in our pipeline script

### Review Results
1. Build History\<buildNumber>\Console Output
3. Ensure you find the output the Batch (bat) command echoed

### Configure housekeeping tasks
1. Select the RestSharpAutomation job
2. Configure
3. General tab
4. Check Discard old builds
5. Days to keep builds = 15
6. Max # of builds to keep = 10
7. Save

### References
1. Pipeline Syntax: https://www.jenkins.io/doc/book/pipeline/syntax/