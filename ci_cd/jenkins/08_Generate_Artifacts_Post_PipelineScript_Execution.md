# Generation Artifact Post Pipeline Script Execution

The below describes how to generate artifacts post execution of the Pipeline script, i.e. reports, logs, images, etc.

# Use the 'Declarative Directive Generator' to generate 'always run' snippet
1. http://localhost:8181/
2. Select the RestSharpAutomation job
3. Pipeline Syntax
4. Declarative Directive Generator
5. Directives
6. Sample Directives = post:Post Stage or Build Conditions
7. Conditions = Always run, regardless of build status
8. Generate Declarative Directive
9. Copy the results (shown below)
```
post {
  always {
    // One or more steps need to be included within each condition's block.
  }
}
```

# Update the Pipeline script
1. Select the RestSharpAutomation job
2. Configure
3. Pipeline script
4. Past the above snippet into the Pipeline script
5. Review to the full Pipeline script below
6. Apply
7. Save

# Use the 'Snippet Generator' to generate 'target and fingerprint' snippet
1. Pipeline Syntax
2. Snippet Generator
3. Steps
4. Sample Step = archiveArtifacts:Archive the artifacts
5. Files to archive = TestResults/
6. Advanced
7. Ensure the following are checked
- Fingerprint all archived artifacts
- Use default excludes
- Treat include and exclude patterns as case sensitive
8. Generate Pipeline Script
9. Copy the results (shown below)
```
archiveArtifacts artifacts: 'TestResults/', fingerprint: true
```

# Update the Pipeline script
1. Select the RestSharpAutomation job
2. Configure
3. Pipeline script
4. Past the above snippet into the Pipeline script
5. Review to the full Pipeline script below
6. Apply
7. Save

# Use the 'Snippet Generator' to generate 'report' snippet
1. Pipeline Syntax
2. Snippet Generator
3. publishHTML:Publish HTML reports
4. HTML directory to archive = TestResults
5. Index pages[s] = index.html
6. Report title = HTML Report
7. Include files = **/*
8. Escape underscores in Report Title = checked
9. Generate Pipeline Script
10. Copy the results (shown below)
```
publishHTML([allowMissing: false, alwaysLinkToLastBuild: false, keepAll: false, reportDir: 'TestResults', reportFiles: 'index.html', reportName: 'HTML Report', reportTitles: ''])
```
# Update the Pipeline script
1. Select the RestSharpAutomation job
2. Configure
3. Pipeline script
4. Past the above snippet into the Pipeline script
5. Review to the full Pipeline script below
6. Apply
7. Save

# Verify the artifacts Option 1 of 2
1. Select the RestSharpAutomation job
2. Find and hover over the 'Declarative: Post Actions' tile
3. Select Logs 
4. Click to open the 'Archive the artifacts' link
5. Click to open the 'Publish HTML reports' link

# Verify the artifacts Option 2 of 2
1. Review the contents of the Job's 'Current Working Directory', i.e. C:\jenkins\workspace\RestSharpAutomation\TestResults

# A note about the 'fingerprint: true' option in the Pipeline script
1. The fingerprint will link the artifact(s) to a build number
2. I.e. opening my last build (under Console Output) I find a 'See Fingerprints' link
3. Clicking the 'See Fingerprint' link reveals the full path to the report artifact

# Completed Pipeline script
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
    
    post {
      always {
        archiveArtifacts artifacts: 'TestResults/', fingerprint: true
        publishHTML([allowMissing: false, alwaysLinkToLastBuild: false, keepAll: false, reportDir: 'TestResults', reportFiles: 'index.html', reportName: 'HTML Report', reportTitles: ''])
      }
    }
}
```