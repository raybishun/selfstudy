using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpAutomation.DropBoxAPI.ListFolderModel
{
    public class PropertyGroup
    {
        public string Template_Id { get; set; }
        public List<Field> Fields { get; set; }
    }
}
