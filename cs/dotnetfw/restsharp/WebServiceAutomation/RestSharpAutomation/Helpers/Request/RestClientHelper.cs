﻿using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpAutomation.HelperClass.Request
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
                restRequest.AddBody(body);
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
    }
}
