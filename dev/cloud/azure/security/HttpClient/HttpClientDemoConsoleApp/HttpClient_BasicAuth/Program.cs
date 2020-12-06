using System;
using System.Net.Http;

namespace HttpClient_BasicAuth
{
    class Program
    {
        #region HttpClient Basic Authentication Notes
        // Requests contain a header field in the form of Authorization: Basic <credentials>
        // Credentials use BASE64 encoding of ID and PASSWORD joined by a single colon :.
        // Credentials are NOT encrypted, so always use with HTTPS
        // Does NOT require cookies/session identifies/login pages
        // Uses standard fields in the HTTP header
        #endregion

        static readonly string requestUri = "https://httpbin.org/basic-auth/user7/passwd";
        static readonly HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            
        }

        static void DoWork()
        { 
        
        }
    }
}
