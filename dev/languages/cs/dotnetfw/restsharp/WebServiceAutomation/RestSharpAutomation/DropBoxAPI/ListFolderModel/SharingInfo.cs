﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpAutomation.DropBoxAPI.ListFolderModel
{
    public class SharingInfo
    {
        public bool ReadOnly { get; set; }
        public string ParentSharedFolderId { get; set; }
        public string ModifiedBy { get; set; }
        public bool? TraverseOnly { get; set; }
        public bool? NoAccess { get; set; }
    }
}
