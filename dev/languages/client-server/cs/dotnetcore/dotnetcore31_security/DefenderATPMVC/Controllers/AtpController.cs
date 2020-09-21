using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace DefenderATPMVC.Controllers
{
    public class AtpController : Controller
    {
        private string _tenantId = string.Empty;
        private string _appId = string.Empty;
        private string _appSecret = string.Empty;
        private string _token = string.Empty;

        public void GetTenantInfo()
        {
            string path = @"C:\SecureStore\BBS_Get_ATP_Alerts.txt";
            string[] creds = System.IO.File.ReadAllLines(path);
            _tenantId = creds[0];
            _appId = creds[1];
            _appSecret = creds[2];
        }

        private void GetTokenUsingADAL()
        {
            string authority = "https://login.windows.net";
            string wdatpResourceId = "https://api.securitycenter.windows.com";

            AuthenticationContext authContext = new AuthenticationContext($"{authority}/{_tenantId}/");
            ClientCredential clientCreds = new ClientCredential(_appId, _appSecret);
            AuthenticationResult authResult = authContext.AcquireTokenAsync(wdatpResourceId, clientCreds).GetAwaiter().GetResult();

            _token = authResult.AccessToken;

            // References
            // ----------------------------------------------------------------
            // 1. ADAL: https://www.nuget.org/packages/Microsoft.IdentityModel.Clients.ActiveDirectory/

            // Validate the token at: https://jwt.ms/, this will:
            //  1. Decode the token (into JSON)
            //  2. Explain the Claim types and their values
        }

        // GET: AtpController
        public async Task<string> Index()
        {
            GetTenantInfo();
            GetTokenUsingADAL();

            var httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var request = new HttpRequestMessage(
                HttpMethod.Get, "https://api.securitycenter.windows.com/api/alerts");

            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            var response = httpClient.SendAsync(request).GetAwaiter().GetResult();

            var payLoad = await response.Content.ReadAsStringAsync();

            return payLoad;
        }

        // GET: AtpController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}
