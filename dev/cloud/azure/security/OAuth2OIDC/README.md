# OAuth2 and OpenID Connect

# Setup IdentityServer4
- IdentityServer4 is an OpenID Connect and OAuth 2.0 opensource framework for ASP.NET Core.

### Setup IdentityServer4

```
cd Z:\Git\selfstudy\dev\cloud\azure\security\OAuth2OIDC\src
dotnet new -i IdentityServer4.Templates (where i = install)
```
### Verify the IdentityServer4 Installation
1. Run the below, and find at least 6 templates beginning with IdentityServer4~ in the name
```
dotnet new
```
### Create an IdentityServer4 app (using the Empty template)
```
cd Z:\Git\selfstudy\dev\cloud\azure\security\OAuth2OIDC\src
dotnet new is4empty -n Marvin.IDP (where n = name of project to create)
dir (verify you find a Marvin.IDP directory)
From VS, Add\Existing Project\Marvin.IDP\Marvin.IDP.csproj
From VS, move the Marvin.IDP project under the src folder
```
### Test the (empty) IdentityServer4 app
1. Tip: Add the JSONView plug-in from Google to Chrome at: https://chrome.google.com/webstore/detail/jsonview/chklaanhfefbnpoihckbnefhakgolnmc
2. https://localhost:5001/.well-known/openid-configuration (this is currently the only viewable page)

### Add the Quickstart UI to the IdentityServer4 app
```
cd Z:\Git\selfstudy\dev\cloud\azure\security\OAuth2OIDC\src\Marvin.IDP
dotnet new (verify you find 'IdentityServer4 Quickstart UI')
dotnet new is4ui (takes about 30s to complete)
```
### Updating Startup.cs after the Quickstart UI has been added
1. In the ConfigureServices method - add 'services.AddControllerWithViews()'
2. In the Configure method - add the following 4 middleware components to the pipeline
- app.UseStaticFiles
- app.UseRouting
- app.UseEndpoints
- app.UseAuthorization

### Build and run the app to view the UI
1. https://localhost:5001/ - should return the 'Welcome to IdentityServer4' page





# References
1. Welcome to IdentityServer4 (latest): https://identityserver4.readthedocs.io/en/latest/
