using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpBasicUsage2UnitTest.Model
{
    public class Posts
    {
        // Never name properties this way, 
        // just following silly instructor...
        public string id { get; internal set; }
        public string title { get; set; }
        public string author { get; set; }
    }
}
