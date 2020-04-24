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
        private readonly string listEndPointUrl = 
            "https://api.dropboxapi.com/2/files/list_folder";
        private const string accessToken = 
            "v_QhBm64dEAAAAAAAAAADwb2Ie3LHTpzxC_ECbuxd5V-BE9cz0lVPbBXfFZEc5Rp";

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
