using System.Collections.Generic;

namespace RestSharpAutomation.DropBoxAPI.ListFolderModel
{
    public class RootObject
    {
        public List<Entry> Entry { get; set; }
        public string Cursor { get; set; }
        public bool HasMore { get; set; }
    }
}
