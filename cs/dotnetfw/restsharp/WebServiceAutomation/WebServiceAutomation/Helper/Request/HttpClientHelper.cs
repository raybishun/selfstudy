using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebServiceAutomation.Model;

namespace WebServiceAutomation.Helper.Request
{
    public class HttpClientHelper
    {
        private static HttpClient httpClient;
        private static HttpRequestMessage httpRequestMessage;
        private static RestResponse restResponse;

        private static HttpClient AddHeadersAndCreateHttpClient(Dictionary<string, string> httpHeader)
        {
            HttpClient httpClient = new HttpClient();
            foreach (string key in httpHeader.Keys)
            {
                httpClient.DefaultRequestHeaders.Add(key, httpHeader[key]);
            }

            return httpClient;
        }

        private static HttpRequestMessage CreateHttpRequestMessage(string requestUrl, HttpMethod httpMethod, HttpContent httpContent)
        {
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(httpMethod, requestUrl);
            if (httpMethod != HttpMethod.Get)
            {
                httpRequestMessage.Content = httpContent;
            }

            return httpRequestMessage;
        }
    }
}
