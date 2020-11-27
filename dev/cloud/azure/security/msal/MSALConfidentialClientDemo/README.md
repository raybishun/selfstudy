# Microsoft Authentication Library (MSAL) Intro (Part 2 of 2)

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

### Register a CONFIDENTIAL Client App
1. https://portal.azure.com/
2. Azure Active Directory
3. App Registration
3. New Registration
4. Name: MSALConfidentialClientDemo
5. Supported account types: Accounts in this organizational directory only (Bits & Bytes Information Systems, LLC only - Single tenant)
6. Register
7. Copy and save the Application (client) ID (to be used later in your app)
8. Copy and save the Directory (tenant) ID (to be used later in your app)
9. API permissions
10. Add a permission
11. Microsoft Graph
12. Application permissions (your app runs as a background service or daemon without a signed-in user)
13. Select permissions: sites
14. Permission: Sites.Read.All
15. Add permission
16. Grant admin consent for tenant (all accounts in tenant)
17. Certificates & secrets
18. Client secrets (A secret string that the application uses to prove its identity when requesting a token. Also can be referred to as application password).
19. New client secret
20. Add a client secret: MSALConfidentialClientSecret
21. Expires: In 1 year
22. Add
23. *** You must copy the Value and ID - they are ONLY viewable during this one time

### Create the PoC Console App
1. In VS, create a Console App (.NET Core)
2. Project and Solution name: MSALConfidentialClientDemo (I used the same name as my Azure registered app)

### NuGet Packages
1. Microsoft.Identity.Client