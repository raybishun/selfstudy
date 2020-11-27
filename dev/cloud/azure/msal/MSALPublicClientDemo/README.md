# Microsoft Authentication Library (MSAL) Intro (Part 1 of 2)

### MSAL Overview
- Makes use of Client Application Builders
- Two type of apps (public client app, and confidential client app)
- Both type of apps require AzureAD app registration

#### Public Client App
- Typically desktop and mobile apps
- Uses a the Delegated' app permission type, where your application needs to access the API as the signed-in user

#### Confidential Client App
- Typically for web apps, web APIs, daemons, functions, jobs, etc.
- Uses the 'Application' permission type, where your application runs as a background service or daemon without a signed-in user.

#### AzureAD App Registration
- Scope appropriately, i.e. read-only access


# App Registration

### Register a PUBLIC Client App
1. https://portal.azure.com/
2. Azure Active Directory
3. App Registration
3. New Registration
4. Name: MSALPublicClientDemo
5. Supported account types: Accounts in this organizational directory only (Bits & Bytes Information Systems, LLC only - Single tenant)
6. Register
7. Copy and save the Application (client) ID (to be used later in your app)
8. Copy and save the Directory (tenant) ID (to be used later in your app)
9. API permissions
10. Add a permission
11. Microsoft Graph
12. Delegated permissions (your app needs to access the API as the signed-in user)
13. Select permissions: sites
14. Permission: Sites.Read.All
15. Add permission
16. Grant admin consent for tenant (all accounts in tenant)
17. Authentication
18. Add a platform
19. Configure platforms: Mobile and desktop applications
20. Custom redirect URIs: http://localhost (since we're creating a PoC Console app)
21. Configure

### Create the PoC Console App
1. In VS, create a Console App (.NET Core)
2. Project and Solution name: MSALPublicClientDemo (I used the same name as my Azure registered app)

### NuGet Packages
1. Microsoft.Identity.Client