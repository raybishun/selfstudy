using System;
using System.Collections.Generic;
using System.Text;

namespace RecursivePatterns.Exceptions
{
    class HttpException : Exception
    {
        public string Url { get; }
        public int StatusCode { get; }
        public HttpException(string message, string url, int statusCode) : base(message)
        {
            Url = url;
            StatusCode = statusCode;
        }
    }
}
