using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using RestSharpAutomation.DropBoxAPI.ListFolderModel;
using System;
using System.Collections.Generic;
using System.IO;
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
        private static string listFolderUrl = "https://api.dropboxapi.com/2/files/list_folder";
        private static string createFolderUrl = "https://api.dropboxapi.com/2/files/create_folder_v2";
        private static string downloadUrl = "https://content.dropboxapi.com/2/files/download";

        [TestMethod]
        public void TestListFolder()
        {
            string body = 
                "{\"path\": \"\",\"recursive\": false,\"include_media_info\": false,\"include_deleted\": false,\"include_has_explicit_shared_members\": false,\"include_mounted_folders\": true,\"include_non_downloadable_files\": true}";
            
            IRestClient client = new RestClient();
            
            IRestRequest request = new RestRequest() { Resource = listFolderUrl };
            request.AddHeader("Authorization", $"Bearer {accessToken}");
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
            request.AddBody(body);

            IRestResponse response = client.Post<RootObject>(request);
            
            Assert.AreEqual(200, (int)response.StatusCode);
        }

        [TestMethod]
        public void TestCreateFolder()
        {
            string body = "{\"path\": \"/TestFolder\",\"autorename\": true}";

            IRestClient client = new RestClient();
            
            IRestRequest request = new RestRequest() { Resource = createFolderUrl };
            request.AddHeader("Authorization", $"Bearer {accessToken}");
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
            request.AddBody(body);

            IRestResponse response = client.Post(request);
            
            Assert.AreEqual(200, (int)response.StatusCode);
        }

        [TestMethod]
        public void TestFileDownload()
        {
            string srcFile = "{\"path\": \"/Book.xlsx\"}";
            string dstFile = "Test.xlsx";
            
            IRestClient client = new RestClient();

            IRestRequest request = new RestRequest() { Resource = downloadUrl };
            request.AddHeader("Authorization", $"Bearer {accessToken}");
            request.AddHeader("Dropbox-API-Arg", srcFile);
            request.RequestFormat = DataFormat.Json;
           
            byte[] byteArrayResponse = client.DownloadData(request);

            File.WriteAllBytes(dstFile, byteArrayResponse);
        }
    }
}
