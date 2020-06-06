# Getting Started

### Introduction
- .NET Core is open-source, and cross-platform (Windows, macOS and Linux)

### Overvieww
1. Install the .NET Core SDK
2. Verify that .NET Core is Installed and Accessible
3. Install Visual Studio Code
4. Add an Extensions to VS Code
5. Create and run a .NET Core MVC Hello World program

### Install the .NET Core SDK
1. https://github.com/dotnet/core-sdk
2. Installers and Binaries
3. Select/download/install the latest version from the 'Master' branch, i.e. Release/3.1.4XX
(3.1.x Runtime) for your desired OS

### Verify that .NET Core is Installed and Accessible
1. Launch a CMD or PowerShell prompt
2. dotnet --version

### Install Visual Studio Code
1. https://code.visualstudio.com/
2. Select/download/install the desired version (Windows, macOS or Linux)

### Add an Extensions to VS Code
1. Launch VS Code
2. Extensions
3. Type C# into the Search box
4. Find, select, and install 'C# for Visual Code (powered by OmniSharp)'

### Hello World
1. md hello_world
2. cd hello_world
3. dotnet new mvc (a new asp.ent core mvc app will be scaffolded)
4. dotnet run (the app will be complied and a web server will be spun-up)
5.  https://localhost:5001/
6. Ctrl + C (to stop the web server)
7. Code . (to launch VS Code)
8. Click yes, if you are prompted with: "Required assets to build and debug are missing from hello_world" Add them?

### Adding a Package (Newtonsoft.Json)
1. dotnet add package Newtonsoft.Json
2. Open the hello_world.csproj file
3. Ensue you find a line added for: PackageReference Include="Newtonsoft.Json"...