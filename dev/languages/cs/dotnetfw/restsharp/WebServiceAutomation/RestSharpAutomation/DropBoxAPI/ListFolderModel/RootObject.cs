using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpAutomation.DropBoxAPI.ListFolderModel
{
    public class RootObject
    {
        public List<Entry> Entry { get; set; }
        public string Cursor { get; set; }
        public bool HasMore { get; set; }
    }
}
