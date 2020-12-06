# Using Okta as your Identity Provider (IDP)

- This ASP.NET Core MVC app uses the Microsoft built-in OIDC Middleware with the Okta IDP
- The below steps walk through how to register an IDP app with Okta

### Getting Started
- This example uses the 'Authorization Code' flow

#### Adding an Application
1. Create a (free) developer account at http:developer.okta.com
2. Sign Up
3. Applications\Add Application
4. Web (.NET, Java, etc.)
5. Name: DotnetCoreOIDCMiddlewareWithOkta
6. Base URIs: https://localhost:5001
7. Login redirect URIs: https://localhost:5001/signin-oidc
8. Logout redirect URIs: https://localhost:5001/signout-callback-oidc
9. Group assignments: Everyone
10. Grant type allowed: Authorization Code
11. Leave all other settings at their defaults
12. Done

#### Add Groups to our out-going Tokens
1. API
2. Authorization Servers
3. Select the 'default' Authorization Servers
4. Claims tab
5. Add Claim
6. Name: groups
7. Include in token type: ID Tokens (and Always)
8. Value type: Groups
9. Filter\Matches regex: .*
10. Disable claim: leave unchecked
11. Include in: Any scope
12. Create