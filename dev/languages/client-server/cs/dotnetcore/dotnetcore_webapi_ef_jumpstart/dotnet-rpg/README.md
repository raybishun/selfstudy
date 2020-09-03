# .NET Core 3.1 Web API and Entity Framework JumpStart

# Prerequisites
1. Visual Studio Code
2. Download/install the latest version for Git at: https://git-scm.com/downloads
4. Download/install Postman at: https://www.postman.com/downloads/
3. Make a folder called dotnet-rpg (Role Playing Game)

# VS Code Extensions
1. C# for Visual Studio Code from Microsoft (powered by OmniSharp)
2. C# Extensions by jchannon 
3. Material Icon Theme by Philipp Kief 
4. Gitignore Templates by Hasan Ali

# Basic dotnet core commands
- dotnet --version
- dotnet -h
- dotnet -run

# Create a new dotnet webapi app
1. cd dotnet-rpg
2. Run VS Code from the dotnet-rpg folder
3. dotnet new webapi
4. NOTE: if prompted to add dotnet files - add them

# Run the app (in Chrome)
1. dotnet run
2. http://localhost:5000/WeatherForecast
3. F12\Network tab\WeatherForecast\Review to the returned JSON data

# Test from Postman
1. Create a request
2. GET: http://localhost:5000/WeatherForecast
3. Send

# Prepare Git
1. F1
2. Type: Generate .gitignore
3. Type: Visual Studio
4. Select to open and view the .gitignore file; make no changes
5. Select the vertical ellipsis
6. Commit\Commit All\Yes
7. Select the vertical ellipsis\Pull, Push\Push

# Notes

### HTTP Request Methods
- Create: POST
- Read: GET
- Update: PUT
- Delete: DELETE