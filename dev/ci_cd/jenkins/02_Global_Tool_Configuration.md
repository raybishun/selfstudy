# Global Tool Configuration

### Prerequisites 1 of 3: Dotnet development tools (included with VS)
1. MSBuild: C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe
2. VSTestConsole: C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\Extensions\TestPlatform\vstest.console.exe

### Prerequisites 2 of 3: Git Source Code Management
1. Download and install the Windows Git client from https://git-scm.com/downloads
2. Ensure git.exe exists under: C:\Program Files\Git\bin

### Prerequisites 3 of 3: Nuget Package Manager
1. Download the latest version of Nuget from: https://www.nuget.org/downloads
2. And save nuget.exe to C:\jenkins

### Add C:\jenkins to the path
1. Search\Advanced System Settings
2. Advanced
3. Environment Variables...
4. System Variables
5. Path
6. Edit...
7. New
8. C:\jenkins
9. OK\OK\OK

### Verify nuget is accessible
1. Open a CMD prompt
2. nuget
3. Ensure the nuget 'available commands' are displayed

### Global Tool Configuration
1. http://localhost:8181/
2. Login if necessary using the admin account you created during the Jenkins installation
3. Manage Jenkins
4. Global Tool Configuration
5. Git\Git installations\Path to Git executable = C:\Program Files\Git\bin\git.exe
6. MSBuild\MSBuild installations...\Add MSBuild\Name = MSBuild
7. Path to MSBuild = C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe
8. VSTest\VSTest installations..\Add VSTest\Name = VSTest
9. Path to VSTest = C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\Extensions\TestPlatform\vstest.console.exe
10. Save