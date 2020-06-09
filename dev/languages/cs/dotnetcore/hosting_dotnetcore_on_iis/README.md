# Hosting .NET Core on IIS

### Overview
- At the time of this post, the LTS version of .NET Core is 3.1.4 (v5.0 was in preview.4)
- The current version of the ASP.NET Core Runtime Windows Hosting Bundle is also 3.1.4
- My web server is running IIS 8.5.9600.16384 on Windows Server 2012r2
- The 2012r2 server is running .NET Framework 4.8 (ndp48-x86-x64-allos-enu.exe), from: https://support.microsoft.com/en-us/help/4503548/microsoft-net-framework-4-8-offline-installer-for-windows) 
- IIS is currently able to host standard ASP.NET Framework sites
- The below steps will essentially allow IIS to serve up .NET Core sites as well

### Basic Steps (server reboot not required)
1. Download and install the latest .NET Core 'SDK' (dotnet-sdk-3.1.300-win-x64.exe), from: https://dotnet.microsoft.com/download/dotnet-core
2. Install the .NET Core Hosting Bundle (dotnet-hosting-3.1.4-win.exe), from: https://dotnet.microsoft.com/permalink/dotnetcore-current-windows-runtime-bundle-installer
3. Run the below
```
	net stop was /y 
	net start w3svc
```
### Create a Test ASP.NET Core App
Open a CMD prompt
```
	cd\inetpub
	dotnet new webapp -o aspnetcoreapp
	dotnet dev-certs https --trust
	dotnet publish --configuration Release
```
### Create an Application in IIS (as you would normally)
1. Using the IIS Management Console, create an 'Application Pool', but for the .NET CLR version, select 'No Managed Code' (as IIS doesn't actually run the app)
2. Add an IIS 'Application' under the Default Web Site
3. Select the Application pool you created above (and use its name for the Alias)
4. Enter the Physical path to the ASP.NET Core app files
* TIP: Ensure the 'Physical Path' is set to the 'Publish' folder, i.e. C:\inetpub\aspnetcoreapp\bin\Release\netcoreapp3.1\publish

### Test the app
1. From within the IIS Management Console - select the app, and click Browse on the Actions pane

### References
1. .NET Core SDK overview: https://docs.microsoft.com/en-us/dotnet/core/sdk 
2. Publish an ASP.NET Core app to IIS: https://docs.microsoft.com/en-us/aspnet/core/tutorials/publish-to-iis?view=aspnetcore-3.1&tabs=visual-studio