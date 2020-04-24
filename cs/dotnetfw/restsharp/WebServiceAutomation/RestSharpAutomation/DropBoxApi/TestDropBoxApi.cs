using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using RestSharpAutomation.DropBoxAPI.ListFolderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpAutomation.DropBoxAPI
{
    [TestClass]
    public class TestDropBoxAPI
    {
        private static string[] creds = 
            SecureStoreHelper.GetCreds(@"C:\SecureStore\dropbox_app_token_endpoint_list_folder.txt").Split(',');
        private static string accessToken = creds[0];
        private static string listEndPointUrl = creds[1];
        
        [TestMethod]
        public void TestListFolder()
        {
            string body = 
                "{\"path\": \"\",\"recursive\": false,\"include_media_info\": false,\"include_deleted\": false,\"include_has_explicit_shared_members\": false,\"include_mounted_folders\": true,\"include_non_downloadable_files\": true}";
            
            IRestClient client = new RestClient();
            IRestRequest request = new RestRequest() { Resource = listEndPointUrl };
            request.AddHeader("Authorization", $"Bearer {accessToken}");
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
            request.AddBody(body);

            IRestResponse response = client.Post<RootObject>(request);
            Assert.AreEqual(200, (int)response.StatusCode);
        }
    }
}
