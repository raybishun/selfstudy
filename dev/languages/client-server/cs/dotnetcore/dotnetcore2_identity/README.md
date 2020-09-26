# ASP.NET Core Identity 

### Intro
- Is a membership based system

### ASP.NET Core Identity Providers
- Built-in
- External, i.e.: Facebook, Google, GitHub, etc...

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

# References
1. https://dotnet.microsoft.com/download