using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpBasicUsageConsoleApp
{
    public class TestDataRootObject
    {
        public TestData Data { get; set; }
        public AdData Ad { get; set; }
    }

    public class TestData
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Avatar { get; set; }
    }

    public class AdData
    {
        public string Company { get; set; }
        public string Url { get; set; }
        public string Text { get; set; }
    }
}
