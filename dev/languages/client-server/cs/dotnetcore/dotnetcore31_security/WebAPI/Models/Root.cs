using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Root
    {
        [JsonPropertyName("data")]
        public TestUser1 User { get; set; }

        [JsonPropertyName("ad")]
        public Ad Ad { get; set; }
    }
}
