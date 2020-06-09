# Using the Snippet Generator to Populate our Pipeline Script Build Stage

### Generate snippet for the 'Build Stage'
1. http://localhost:8181/
2. Select the RestSharpAutomation job
3. Configure
4. Pipeline\Script
5. Update the Pipeline script's 'Build Stage' step as shown below
```
pipeline {
    agent any
    environment {
        nuget = "C:\\jenkins\\nuget.exe"
    }
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
                bat '%nuget% restore C:\\jenkins\\workspace\\RestSharpAutomation\\cs\\dotnetfw\\restsharp\\WebServiceAutomation\\WebServiceAutomation.sln'
            }
        }
        stage('Build Stage'){
             steps{
                bat 'echo Build Stage'
                bat "\"${tool 'MSBuild'}\" -verbosity:detailed C:\\jenkins\\workspace\\RestSharpAutomation\\cs\\dotnetfw\\restsharp\\WebServiceAutomation\\WebServiceAutomation.sln /p:Configuration=Release /p:Platform=\"Any CPU\""
            }
        }
        stage('Deploy Application'){
            steps{
                bat 'echo Deploy Application'
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
6. Save
7. Build Now
8. Build History\<buildNumber>\Console Output
9. Verify the last line shows Finished: SUCCESS