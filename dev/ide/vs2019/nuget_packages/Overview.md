# Overview

### NuGet Packages
1. Have a .nupkg extension
2. Contain one or more .DLL files
3. Contain metadata that describes the packages
4. Although not common, can contain debug symbols

### NuGet Package Manager Interface Options
1. Console
2. GUI

### Where are NuGet packages stored in your app?
- For .NET Framework, a 'packages' folder your solution directory
- For .NET core, %UserProfiles%\.nuget\packages folder

### Where are NuGet packages referenced in your app?
- For .NET Framework, packages.config under your project directory
- For .NET core, within the project file, i.e. .csproj file (for a C# app)