# How to install .NET Core on Windows

### Introduction
I needed .NET Core on Windows Server 2012r2. Below are the steps I used to install the LTS version of .NET Core SDK (not the Runtime).

### Download and install .NET Core
1. Check if .NET Core is already installed
```
dotnet --version
```
2. https://dotnet.microsoft.com/download/dotnet-core
3. Find and select the recommended LTS version of .NET Core
4. At the time of this post, I downloaded and ran: dotnet-sdk-3.1.202-win-x64.exe
5. The following was installed:
	- .NET Core SDK 3.1.202
	- .NET Core Runtime 3.1.4
	- ASP.NET Core Runtime 3.1.4
	- .NET Core windows Desktop Runtime 3.1.4
6. A Reboot is not required
7. Check that .NET Core is now installed 
8. NOTE: You may need to close and reopen the CMD prompt if it was still open from step 1 above
```
dotnet --version
```