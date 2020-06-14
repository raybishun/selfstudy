using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using RestSharpAutomation.DropBoxAPI.ListFolderModel;
using System.IO;
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
           
            byte[] response = client.DownloadData(request);

            File.WriteAllBytes(dstFile, response);
        }

        [TestMethod]
        public void TestFileDownloadParallel()
        {
            string srcFile1 = "{\"path\": \"/VX1.dat\"}";
            string srcFile2 = "{\"path\": \"/VX2.dat\"}";

            IRestRequest request1 = new RestRequest() { Resource = downloadUrl };
            request1.AddHeader("Authorization", $"Bearer {accessToken}");
            request1.AddHeader("Drop box-API-Arg", srcFile1);
            request1.RequestFormat = DataFormat.Json;
            
            IRestRequest request2 = new RestRequest() { Resource = downloadUrl };
            request2.AddHeader("Authorization", $"Bearer {accessToken}");
            request2.AddHeader("Drop box-API-Arg", srcFile2);
            request2.RequestFormat = DataFormat.Json;

            IRestClient client = new RestClient();

            byte[] data1 = null;
            byte[] data2 = null;

            Task task1 = Task.Factory.StartNew(() =>
            {
               data1 = client.DownloadData(request1);
            });

            Task task2 = Task.Factory.StartNew(() =>
            {
                data2 = client.DownloadData(request2);
            });

            task1.Wait();
            task2.Wait();

            if (data1 != null)
            {
                File.WriteAllBytes("VX1.dat", data1);
            }

            if (data2 != null)
            {
                File.WriteAllBytes("VX2.dat", data2);
            }
        }
    }
}
