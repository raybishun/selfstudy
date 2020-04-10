﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceAutomation.Model
{
    public class RestResponse
    {
        private int statusCode;
        private string responseContent;

        public RestResponse(int statusCode, string responseData)
        {
            this.statusCode = statusCode;
            this.responseContent = responseData;
        }

        public int StatusCode
        {
            get 
            {
                return statusCode;
            }
        }
        public string ResponseContent
        {
            get 
            {
                return responseContent;
            }
        }

        public override string ToString()
        {
            return $"StatusCode: {statusCode} ResponseData: {responseContent}";
        }
    }
}