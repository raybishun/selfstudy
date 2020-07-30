# Creating a NuGet package for the .NET Framework

### Lab
1. Create a Class Library (.NET Framework)
2. Find demo lib here: ...\selfstudy\dev\ide\vs2019\nuget_packages\lib\NuGetDemoLib
3. You must build a 'Release' mode of the project
4. Download nuget.exe from: https://www.nuget.org/nuget.exe
5. Copy nuget.exe to the 'root' of the 'project' folder
6. Open a CMD prompt

### Several ways to create the 'nuspec' file
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