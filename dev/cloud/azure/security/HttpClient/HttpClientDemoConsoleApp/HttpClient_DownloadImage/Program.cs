using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClient_DownloadImage
{
    class Program
    {
        static readonly string requestUri = "http://webcode.me/favicon.ico";
        static readonly HttpClient client = new HttpClient();
        // User's personal Documents folder
        static readonly string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        static readonly string localFilename = "favicon.ico";

        static async Task Main(string[] args)
        {
            Console.WriteLine($"Total Elements: {await GetImage():N0}");
        }

        static async Task<int> GetImage()
        {
            byte[] imageBytes = await client.GetByteArrayAsync(requestUri);
            string localPath = Path.Combine(docPath, localFilename);
            await File.WriteAllBytesAsync(localPath, imageBytes);
            return imageBytes.Length;
        }
    }
}
