# Create and Publish a NuGet package for the .NET Framework

### Getting Started
1. Create a Class Library (.NET Framework)
2. Find demo lib here: ...\selfstudy\dev\ide\vs2019\nuget_packages\lib\NuGetDemoLib
3. You must build a 'Release' mode of the project
4. Download nuget.exe from: https://www.nuget.org/nuget.exe
5. Copy nuget.exe to the 'root' of the 'project' folder
6. Open a CMD prompt

### There are several ways to create the '.nuspec' file
- Option #1: nuget spec
- Option #2: nuget spec NuGetDemoLib.csproj 
- Option #3: nuget spec bin\Release\NuGetDemoLib.dll  

### Option #2
```
nuget spec NuGetDemoLib.csproj 
Created 'NuGetDemoLib.nuspec' successfully.
```
### Option #2 NuGetDemoLib.nuspec file
```
<?xml version="1.0"?>
<package >
  <metadata>
    
	<!-- *** RB Notes: Must be globally unique in the NuGet Store *** -->
	<id>$id$</id> 
    
	<version>$version$</version>
    <title>$title$</title>
    <authors>$author$</authors>
    <owners>$author$</owners>
    
	<!-- *** RB Notes: Optional, remove if not used *** -->
	<licenseUrl>http://LICENSE_URL_HERE_OR_DELETE_THIS_LINE</licenseUrl>
    <projectUrl>http://PROJECT_URL_HERE_OR_DELETE_THIS_LINE</projectUrl>
    <iconUrl>http://ICON_URL_HERE_OR_DELETE_THIS_LINE</iconUrl>
    
	<requireLicenseAcceptance>false</requireLicenseAcceptance>
    <description>$description$</description>
    <releaseNotes>Summary of changes made in this release of the package.</releaseNotes>
    <copyright>Copyright 2020</copyright>
    <tags>Tag1 Tag2</tags>
  </metadata>
</package>
```

### Semantic Versioning
- NuGet uses semantic versioning, where you have the Major.Minor.Patch convention
- NuGet uses this semantic versioning to determine the latest stable version

### Semantic Versioning Best Practice
- Version example: 3.5.1-beta (where 3 = Major, 5 = Minor, 1-beta = Patch)
- When not releasing the GA version, it's common practice to append: -alpha, -beta, -gamma
- Or use the -prelease switch
- Or any string that describes the non GA release

# Build the NuGet Package
1. Update the above '.nuspec' file as shown below
```
<?xml version="1.0"?>
<package >
  <metadata>
    <id>Demo.Ray.Bishun.NuGetDemoLib</id>
    <version>1.0.0-alpha</version>
    <title>NuGet Demo Library</title>
    <authors>Ray Bishun</authors>
    <owners>BitsBytesLab</owners>
    <description>For demo use only</description>
    <releaseNotes>ChangeLog1, ChangeLog2, ...</releaseNotes>
    <copyright>Copyright 2020</copyright>
    <tags>Demo, BitsBytesLab</tags>
  </metadata>
  <files>
	<file src="bin\Release\NuGetDemoLib.dll"
		target="lib\NuGetDemoLib.dll"/>
  </files>
</package>
```
2. Build
```
cd ...\NuGetDemoLib\NuGetDemoLib>
.\nuget.exe pack .\NuGetDemoLib.nuspec

Attempting to build package from 'NuGetDemoLib.nuspec'.
Successfully created package 'C:\git\selfstudy\dev\ide\vs2019\nuget_packages\lib\NuGetDemoLib\NuGetDemoLib\Demo.Ray.Bishun.NuGetDemoLib.1.0.0-alpha.nupkg'.

WARNING: 1 issue(s) found with package 'Demo.Ray.Bishun.NuGetDemoLib'.

Issue: Assembly not inside a framework folder.
Description: The assembly 'lib\NuGetDemoLib.dll' is placed directly under 'lib' folder. It is recommended that assemblies be placed inside a framework-specific folder.
Solution: Move it into a framework-specific folder. If this assembly is targeted for multiple frameworks, ignore this warning.
```
3. Note the naming convention used for the resultant NuGet filename (based from the data you entered in the NuGetDemoLib.nuspec file: Demo.Ray.Bishun.NuGetDemoLib.1.0.0-alpha.nupkg

# Publish the package to the NuGet Store
1. From your web browser, sign into: https://www.nuget.org/
2. Find and select 'Upload'
3. Browse
4. Find and select the Demo.Ray.Bishun.NuGetDemoLib.1.0.0-alpha.nupkg file
5. Publish
```
You successfully uploaded Demo.Ray.Bishun.NuGetDemoLib 1.0.0-alpha.

This package has not been published yet. It will appear in search results and will be available for install/restore after both validation and indexing are complete. Package validation and indexing may take up to an hour. Read more.

This is a prerelease version of Demo.Ray.Bishun.NuGetDemoLib.

*** NOTE: The validation and indexing completed in less than 5 minutes.
```
6. View the package on-line at: https://www.nuget.org/packages/Demo.Ray.Bishun.NuGetDemoLib/

# Install the NuGet Package: Option 1 of 2
1. Create a .NET Framework Console sample application
2. Right-click the project and select 'Manage NuGet Packages...'
3. Ensure the Package Source is: nuget.org/
4. Check 'Include prerelease'
5. In the Search bar enter: Demo.Ray.Bishun.NuGetDemoLib
6. Install

# Install the NuGet Package: Option 2 of 2
(From within Visual Studio)
1. Tools
2. NuGet Package Manager
3. Package Manager Console
```
Install-Package Demo.Ray.Bishun.NuGetDemoLib -Pre
```

### Add the Using Statement to the sample Console app
1. using NuGetDemoLib;
```
using NuGetDemoLib;

namespace client_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            LogHelper.Log("Hello for NuGetDemoLib");
        }
    }
}
```
# Managing NuGet Packages (in Visual Studio, from the client app perspective)
1. Tools
2. NuGet Package Manager
3. Manage NuGet Packages for Solutions...
4. Installed, where:
- A blue up-arrow shows that an update is available
- A green check-mark denotes the package is installed

# Configuring NuGet Packages (in Visual Studio, from the client app perspective)
1. Tools
2. Options
3. Find and expand NuGet Package Manager

### NuGet Package Manager: General

#### Package Restore
1. Allow NuGet to download missing packages/Demo
2. Automatically check for missing packages during build in Visual Studio

#### Package Management
1. Select the 'Default package management format', either: Packages.config or PackageReference
- Note, .NET Core typically use the PackageReference format

#### Clear NuGet Cache
1. Clear All NuGet Cache(s) button

### NuGet Package Manager: Package Sources 

#### Package Sources
1. Add/remove (HTTP) package sources