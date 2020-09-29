# ASP.NET Core Identity 

### Intro
- Is a membership based system

### ASP.NET Core Identity Provider Options
1. No Authentication
2. Individual User Accounts (SQL Server)
3. Work or School Accounts
4. Windows Authentication

### Storage
- SQL Server can be used to store user related data

### Identity Components
1. Identity - who you are (doesn't change regardless of location)
2. Role - who you are in a give context (i.e. user, guest, admin, etc.)
3. Claim - a dictionary that stores information about you

### Identity Example
1. Your driver's license - license class, etc.
2. Your student ID - same person, but different role, major, etc.
 
### Types of Authentication
1. Token based authentication
2. Cookie based authentication

### Token Based Authentication
- Users and claims are managed by OAuth provider, i.e. Facebook, Google, Twitter, etc.
- Appropriate for client-side apps, i.e. mobile apps

### Cookie Based Authentication
- Users, Roles and Claims are stored and managed by your app in any Entity Framework supported database, i.e. SQL Server (as well as AWS Cognito, or any 3rd party Auth provider, i.e. Auth0)
- Appropriate for Server-to-server authentication

### Key Identity Classes
- IdentityUser
- IdentityRole
- IdentityUserRole
- IdentityUserClaim

### Tables in the Identity Database
- AspNetRoleClaims
- AspNetRoles
- AspNetUserClaims
- AspNetUserLogins
- AspNetUserRoles
- AspNetUsers
- AspNetUserTokens

# Tips

### You'll need a Email Sender Service
- PM> Install-Package SendGrid
- Register with: https://sendgrid.com/ to get an apiKey

### Steps to register with SendGrid
1. https://sendgrid.com/ 
2. Start for Free button
3. Complete the user registration form 
4. Create Account
5. Complete the Tell Us About Yourself form
6. Get Started!
7. Create a 'sender identity'
8. Create a Single Sender
9. https://app.sendgrid.com/guide/integrate
10. Web API
11. C#
12. Create key
13. Enter an API Key Name, i.e.: aspnetcore.demo.apikey
14. Create Key

### How to register with Google Sign-in
1. https://developers.google.com/identity/sign-in/web/sign-in


### User Registration Error
A database operation failed while processing the request.
SqlException: Cannot open database "aspnet-ASP.NETCoreIdentityDemo..." requested by the login. The login failed. Login failed for user '<domain>\<userName>'.
Applying existing migrations for ApplicationDbContext may resolve this issue
There are migrations for ApplicationDbContext that have not been applied to the database

00000000000000_CreateIdentitySchema
Apply Migrations

In Visual Studio, you can use the Package Manager Console to apply pending migrations to the database:
```
PM> Update-Database
```
Alternatively, you can apply pending migrations from a command prompt at your project directory:
```
dotnet ef database update
```
### SMTP Email Providers
1. https://sendgrid.com/
2. https://mailjet.com

# References
1. https://dotnet.microsoft.com/download