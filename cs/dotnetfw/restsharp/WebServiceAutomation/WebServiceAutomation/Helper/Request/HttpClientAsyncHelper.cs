using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebServiceAutomation.Model;

namespace WebServiceAutomation.Helper.Request
{
    public class HttpClientAsyncHelper
    {
        private HttpClient httpClient;
        private HttpClient AddHeadersAndCreateHttpClient(Dictionary<string, string> httpHeader)
        {
            HttpClient httpClient = new HttpClient();

            if (null != httpHeader)
            {
                foreach (string key in httpHeader.Keys)
                {
                    httpClient.DefaultRequestHeaders.Add(key, httpHeader[key]);
                }
            }

            return httpClient;
        }

        public async Task<RestResponse> PerformGetRequest(string requestUrl, Dictionary<string, string> httpHeader)
        {
            httpClient = AddHeadersAndCreateHttpClient(httpHeader);

            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(requestUrl);

            int statusCode = (int)httpResponseMessage.StatusCode;

            var responseData = await httpResponseMessage.Content.ReadAsStringAsync();

            return new RestResponse() { StatusCode = statusCode, ResponseContent = responseData };
        }

        public async Task<RestResponse> PerformPostRequest(string requestUrl, HttpContent httpContent, Dictionary<string, string> httpHeader)
        {
            httpClient = AddHeadersAndCreateHttpClient(httpHeader);

            HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(requestUrl, httpContent);

            int statusCode = (int)httpResponseMessage.StatusCode;

            var responseData = await httpResponseMessage.Content.ReadAsStringAsync();

            return new RestResponse() { StatusCode = statusCode, ResponseContent = responseData };
        }

        public async Task<RestResponse> PerformPostRequest(string requestUrl, string data, string mediaType, Dictionary<string, string> httpHeader)
        {
            HttpContent httpContent = new StringContent(data, Encoding.UTF8, mediaType);

            httpClient = AddHeadersAndCreateHttpClient(httpHeader);

            HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(requestUrl, httpContent);

            int statusCode = (int)httpResponseMessage.StatusCode;

            var responseData = await httpResponseMessage.Content.ReadAsStringAsync();

            return new RestResponse() { StatusCode = statusCode, ResponseContent = responseData };
        }

        public async Task<RestResponse> PerformPutRequest(string requestUrl, HttpContent httpContent, Dictionary<string, string> httpHeader)
        {
            httpClient = AddHeadersAndCreateHttpClient(httpHeader);

            HttpResponseMessage httpResponseMessage = await httpClient.PutAsync(requestUrl, httpContent);

            int statusCode = (int)httpResponseMessage.StatusCode;

            var responseData = await httpResponseMessage.Content.ReadAsStringAsync();

            return new RestResponse() { StatusCode = statusCode, ResponseContent = responseData };
        }

        public async Task<RestResponse> PerformPutRequest(string requestUrl, string data, string mediaType, Dictionary<string, string> httpHeader)
        {
            HttpContent httpContent = new StringContent(data, Encoding.UTF8, mediaType);

            httpClient = AddHeadersAndCreateHttpClient(httpHeader);

            HttpResponseMessage httpResponseMessage = await httpClient.PutAsync(requestUrl, httpContent);

            int statusCode = (int)httpResponseMessage.StatusCode;

            var responseData = await httpResponseMessage.Content.ReadAsStringAsync();

            return new RestResponse() { StatusCode = statusCode, ResponseContent = responseData };
        }

        public async Task<RestResponse> PerformDeleteRequest(string requestUrl, Dictionary<string, string> httpHeader)
        {
            httpClient = AddHeadersAndCreateHttpClient(httpHeader);

            HttpResponseMessage httpResponseMessage = await httpClient.DeleteAsync(requestUrl);

            int statusCode = (int)httpResponseMessage.StatusCode;

            var responseData = await httpResponseMessage.Content.ReadAsStringAsync();

            return new RestResponse() { StatusCode = statusCode, ResponseContent = responseData };
        }
    }
}
