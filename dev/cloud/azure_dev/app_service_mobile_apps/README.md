# Azure App Service: Mobile Apps

### What is Azure App Service: Mobile Apps
- Allows you to build engaging iOS, Android, and Windows apps

### Features
1. Broadcast push with customer segmentation
2. Enterprise single sign-on with Azure Active Directory
3. Autoscale to support millions of devices
4. Apps can work offline and sync
5. Social integration with Facebook, Twitter, and Google

#### Lab
1. Create an App Service (*** used to also create mobile apps)
2. Create a client to consume the mobile app
3. Review off-line data storage for the mobile app
4. Create a back-end SQL database for the mobile app

### Create an App Service
1. http://portal.azure.com
2. App Services 
3. Add
4. Resource Group\Create new: MyAppService_MobileApp_RG
5. Name: mymobileappjuly25
6. Publish: Code
7. Runtime stack: ASP.NET V4.7
8. Operating System: Windows
9. Region: East US
10. Sku and size: Dev/Test, Free F1 (1GB 60m/day compute)
11. Review + create
12. Create

### QuickStart
1. App Services
2. Select the app mymobileappjuly25
3. Deployment\QuickStart
*** Process has changed; the below steps are now legacy; need to research how this is configured today...
4. Xamarin.Forms
5. Connect a database
6. Data Connections\Add
7. Add data connection
8. Type: SQL Database
9. Database\Create a new database
10. Name: mobileapp
11. Crete a new server
12. Server name: mobileappdb
13. Server admin login: mobile
14. Password: enter a password
15. Location: you region
16. Select
17. Connection string

### Create a table API
1. Backend language: Node.js

### Configure your client app
1. Click Download

### Configure the mobile app: Application Settings
1. Settings\Configuration
2. Application Settings\New application settings
3. Name: MobileAppsManagement_EXTENSION_VERSION
4. Value: latest
5. OK

### Configure the mobile app: Connection Strings 
1. Connection strings\New connection string

# References
1. Mobile Apps: https://azure.microsoft.com/en-us/services/app-service/mobile/

# Appendix

### Create and run a new console app
- mkdir helloworld
- cd .\helloworld\
- dotnet new console
- dotnet build
- dotnet run