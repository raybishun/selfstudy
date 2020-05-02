# Using the Snippet Generator to Populate the Pipeline Script Restore Package Stage

### Generate snippet for the 'Restore Package Stage'
1. http://localhost:8181/
2. Select the RestSharpAutomation job
3. Configure
4. Pipeline\Script
5. Add [bat nuget] as shown below
```
stage('Restore Package Stage'){
             steps{
                bat 'echo Restore Package Stage'
                bat 'nuget'
            }
        }
```
6. Save
7. Build Now
8. Build History\<buildNumber>\Console Output
9. Verify the last line shows Finished: SUCCESS

### Optional step
- NOTE: If the above step fails, perform the below. Note however, running the below even if the above step was successful will not break anything. In fact, it's a good example of how to use variables in the Pipeline script.

1. Select the RestSharpAutomation job
2. Pipeline Syntax
3. Declarative Directive Generate
4. Directives\Sample Directive = environment: Environment
5. Add
6. Name = nuget
7. Value = C:\jenkins\nuget.exe (this is where we copied nuget.exe)
8. Generate Declarative Directive
9. Copy the results, i.e.:
```
environment {
  nuget = "C:\jenkins\nuget.exe"
}
```
10. Select the RestSharpAutomation job
11. Configure
12. And update the Pipeline Script (the relevant portion of the script is shown below). Notice the double backslashes in the nuget string value, as well as '%nuget%'
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
                bat '%nuget%'
            }
        }
```
13. Save
14. Build Now
15. Build History\<buildNumber>\Console Output
16. And note the 'Build Stage Path' (it will be used in the next step below)
17. In my case the full path was: 'C:\jenkins\workspace\RestSharpAutomation'
18. Verify the last line shows Finished: SUCCESS


### Call the Nuget restore
1. Select the RestSharpAutomation job
2. Configure
3. From the previous step, add the 'Build Stage Path' to the Pipeline script
4. NOTE, since the VS .sln file I need to reference is under several folder levels, I will use the full path: C:\\jenkins\\workspace\\RestSharpAutomation\\cs\\dotnetfw\restsharp\\WebServiceAutomation\\WebServiceAutomation.sln
5. The relevant portion of the Pipeline script is shown below
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
```
6. Save
7. Build Now
8. Build History\<buildNumber>\Console Output
9. Verify the last line shows Finished: SUCCESS