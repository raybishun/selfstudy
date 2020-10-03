# ASP.NET Core SE

### Basic dotnet commands
- dotnet --version
- dotnet --info

### Create a new ASP.NET Core Web App
1. mkdir aspnetcoresample
2. cd aspnetcoresample
3. dotnet new web
4. dotnet run
5. http://localhost:5000

### TDD
- Test Driven Development
- Write Unit Tests before you code-up functionality

### Cool Tools
- C# Interactive (within VS)
- https://www.linqpad.net/
- https://dotnetfiddle.net/

### Setup an Azure DevOps Subscription
1. https://azure.microsoft.com/en-us/services/devops/
2. Start Free button
3. Log into your Azure Tenant
4. Enter a Project name
5. Create project

### Clone an Azure DevOps Repo
1. Repos
2. Clone in VS
3. Select Microsoft Visual Studio Web Protocol Handler Selector (NOTE: if more than one, select the last one, i.e. if you have VS 2017 and VS 2019 installed on the same computer)
4. Team Explorer
5. Settings
6. Under Ignore & Attribute Files - click Add for both the Ignore File and Attributes File
7. Home
8. Changes
9. Enter a commit message, i.e.: First commit: added the .gitignore and gitattributes files
10. Commit Staged
11. Sync
12. Push
13. Confirm the two files now appear in our repo under https://dev.azure.com/ | Repos | Files

### Creating Feature Branches
1. Team Explorer
2. Home
3. Branches
4. New Branch, i.e.: FEA-UserRegistration (where the FEA prefix is optional, and signifies this is a feature branch)
5. Create Branch


# References
1. Adopt a Git branching strategy: https://docs.microsoft.com/en-us/azure/devops/repos/git/git-branching-guidance?view=azure-devops
