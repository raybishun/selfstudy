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
1. Create a mobile app service
2. Create a client to consume the mobile app
3. Review off-line data storage for the mobile app
4. Create a back-end SQL database for the mobile app

### Create a mobile app service based on the Mobile App Template in the Azure Marketplace
1. http://portal.azure.com
2. App Services *** used to also create mobile apps
3. Add
4. Resource Group\Create new: MyAppService_MobileApp_RG
5. Name: mymobileappjuly24
6. Publish: Code
7. Runtime stack: .NET Core 3.1 (LTS)
8. Operating System: Linux
9. Region: East US
10. Sku and size: Dev/Test, F1 (1GB 60m/day compute, free)

### Configure the mobile app: Application Settings
1. Settings\Configuration
2. Application Settings\New application settings
3. Name: MobileAppsManagement_EXTENSION_VERSION
4. Value: latest
5. OK

### Configure the mobile app: Create the Database
1. 

### Configure the Firewall rules for the Database
1. 

### Configure the mobile app: Connection Strings 
1. Connection strings\New connection string
2. 


# References

# Appendix

### Azure commands used in this tutorial


### Create and run a new console app
- mkdir helloworld
- cd .\helloworld\
- dotnet new console
- dotnet build
- dotnet run