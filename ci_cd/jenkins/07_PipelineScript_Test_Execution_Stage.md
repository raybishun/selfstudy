# Using the Snippet Generator to Populate the Pipeline Script's Test Execution Stage

### Generate snippet for 'Test Execution Stage'
1. http://localhost:8181/
2. Select the RestSharpAutomation job
3. Configure
4. Pipeline\Script
5. Note 1: For my 'Test Execution Stage', I have 3 DLLs
6. Note 2: You do not enter the full path to the DLL's location(s)
7. Note 3: That is, do not enter the Jenkins 'Current Working Directory', i.e. for this Jenkins's job it is: 'C:\jenkins\workspace\RestSharpAutomation'
8. Update the Pipeline script's 'Test Execution Stage' step as shown below
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
                bat "\"${tool 'VSTest'}\" cs/dotnetfw/restsharp/WebServiceAutomation/WebServiceAutomation/bin/Release/WebServiceAutomation.dll cs/dotnetfw/restsharp/WebServiceAutomation/RestSharpAutomation/bin/Release/RestSharpAutomation.dll cs/dotnetfw/restsharp/WebServiceAutomation/MsTestProject/bin/Release/MsTestProject.dll /InIsolation /Logger:html"
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
10. Per the Console Output, find (and review)the Html test results file: C:\jenkins\workspace\RestSharpAutomation\TestResults\TestResult_ray.bishun_X1CARBON_20200502_194105.html