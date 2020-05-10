using RestSharp;
using RestSharp.Deserializers;
using System.Collections.Generic;

namespace RestSharpAutomation.Helpers.Request
{
    public class RestClientHelper
    {
        private IRestClient GetRestClient()
        {
            IRestClient restClient = new RestClient();
            return restClient;
        }

        private IRestRequest GetRequestRequest(
            string url, Dictionary<string, string> header, Method method, object body, DataFormat dataFormat)
        {
            IRestRequest restRequest = new RestRequest()
            {
                Resource = url,
                Method = method
            };

            if (header != null)
            {
                foreach (var item in header)
                {
                    restRequest.AddHeader(item.Key, item.Value);
                }
            }

            #region
            //if (header != null)
            //{
            //    foreach (string key in header.Keys)
            //    {
            //        restRequest.AddHeader(key, header[key]);
            //    }
            //}
            #endregion

            if (body != null)
            {
                restRequest.RequestFormat = DataFormat.Json;

                switch (dataFormat)
                {
                    case DataFormat.Json:
                        restRequest.AddBody(body);
                        break;
                    case DataFormat.Xml:
                        restRequest.XmlSerializer = new RestSharp.Serializers.DotNetXmlSerializer();
                        restRequest.AddParameter("xmlData", GetType().Equals(typeof(string)) ? body : 
                            restRequest.XmlSerializer.Serialize(body), ParameterType.RequestBody);
                    break;
                }
            }

            return restRequest;
        }

        private IRestResponse SendRequest(IRestRequest restRequest)
        {
            IRestClient restClient = GetRestClient();
            IRestResponse restResponse = restClient.Execute(restRequest);
            return restResponse;
        }

        private IRestResponse<T> SendRequest<T>(IRestRequest restRequest) where T : new()
        {
            IRestClient restClient = GetRestClient();
            IRestResponse<T> restResponse = restClient.Execute<T>(restRequest);

            // Explicitly deserialize if ContentType is xml
            // Else (automatically) deserialize as json (the build in default), 
            // but need to verify this
            // TODO: Verify you need to explicitely deserialize if ContentType is xml
            if (restResponse.ContentType.Equals("application/xml"))
            {
                var deserializer = new DotNetXmlDeserializer();
                restResponse.Data = deserializer.Deserialize<T>(restResponse);
            }

            return restResponse;
        }

        public IRestResponse PerformGetRequest(string url, Dictionary<string, string> header)
        {
            IRestRequest restRequest = GetRequestRequest(
                url, header, Method.GET, null, DataFormat.None);
            IRestResponse restResponse = SendRequest(restRequest);
            return restResponse;
        }

        public IRestResponse<T> PerformGetRequest<T>(string url, Dictionary<string, string> header) where T : new()
        {
            IRestRequest restRequest = GetRequestRequest(
                url, header, Method.GET, null, DataFormat.None);
            IRestResponse<T> restResponse = SendRequest<T>(restRequest);
            return restResponse;
        }

        public IRestResponse<T> PerformPostRequest<T>(
            string url, Dictionary<string, string> header, object body, DataFormat dataFormat) where T : new ()
        {
            IRestRequest request = GetRequestRequest(
                url, header, Method.POST, body, dataFormat);
            IRestResponse<T> restResponse = SendRequest<T>(request);
            return restResponse;
        }

        public IRestResponse PerformPostRequest(
            string url, Dictionary<string, string> header, object body, DataFormat dataFormat)
        {
            IRestRequest request = GetRequestRequest(
                url, header, Method.POST, body, dataFormat);
            IRestResponse restResponse = SendRequest(request);
            return restResponse;
        }

        public IRestResponse<T> PerformPutRequest<T>(
    string url, Dictionary<string, string> header, object body, DataFormat dataFormat) where T : new()
        {
            IRestRequest request = GetRequestRequest(
                url, header, Method.PUT, body, dataFormat);
            IRestResponse<T> restResponse = SendRequest<T>(request);
            return restResponse;
        }

        public IRestResponse PerformPutRequest(
            string url, Dictionary<string, string> header, object body, DataFormat dataFormat)
        {
            IRestRequest request = GetRequestRequest(
                url, header, Method.PUT, body, dataFormat);
            IRestResponse restResponse = SendRequest(request);
            return restResponse;
        }

        public IRestResponse PerformDeleteRequest(string url, Dictionary<string, string> header)
        {
            IRestRequest request = GetRequestRequest(url, header, Method.DELETE, null, DataFormat.None);
            IRestResponse restResponse = SendRequest(request);
            return restResponse;
        }
    }
}
