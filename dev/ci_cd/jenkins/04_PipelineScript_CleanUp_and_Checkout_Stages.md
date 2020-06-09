# Using the Snippet Generator to Populate the Pipeline Script's CleanUp and Checkout Stages

### Generate snippet for the 'CleanUp Stage'
1. http://localhost:8181/
2. Select the RestSharpAutomation job
3. Pipeline Syntax
4. Snippet Generator
5. Steps\Sample Step = cleanWs: Delete workspace when build is done
6. Advanced
7. Check - Don't fail the build if cleanup fails
8. Generate Pipeline Script
9. Results: cleanWs notFailBuild: true
10. Copy the results
11. Select the RestSharpAutomation job
10. Configure
11. Pipeline\Script
12. Copy and paste the above results to the 'CleanUp Stage' step
13. Save

### Generate snippet for the 'Git Checkout Stage'
1. Pipeline Syntax
2. Snippet Generator
3. Steps\Sample Step = git: Git
5. Repository URL = https://github.com/raybishun/selfstudy.git
6. Generate Pipeline Script
7. Results: checkout([$class: 'GitSCM', branches: [[name: '*/master']], doGenerateSubmoduleConfigurations: false, extensions: [], submoduleCfg: [], userRemoteConfigs: [[url: 'https://github.com/raybishun/selfstudy.git']]])
8. Copy the results
9. Select the RestSharpAutomation job
10. Configure
11. Pipeline\Script
12. Copy and paste the above results to the 'Git Checkout Stage' step
13. Save

### Build
1. Build Now
2. Build History\<buildNumber>\Console Output
3. Ensure the last line of output says: 'Finished: SUCCESS'
4. And per the output, verify the Git repo was created here: C:\jenkins\workspace\RestSharpAutomation

### Current Pipeline Script
```
pipeline {
    agent any
    
    stages{
        stage('CleanUp Stage'){
            steps{
                bat 'echo CleanUp Stage'
                cleanWs notFailBuild: true
            }
        }
        stage('Git Checkout Stage'){
             steps{
                bat 'echo Git Checkout Stage'
                checkout([$class: 'GitSCM', branches: [[name: '*/master']], doGenerateSubmoduleConfigurations: false, extensions: [], submoduleCfg: [], userRemoteConfigs: [[url: 'https://github.com/raybishun/selfstudy.git']]])
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