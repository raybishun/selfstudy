﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpAutomation.DropBoxAPI.ListFolderModel
{
    public class Entry
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public DateTime ClientModified { get; set; }
        public DateTime ServerModified { get; set; }
        public string Rev { get; set; }
        public int Size { get; set; }
        public string PathLower { get; set; }
        public string PathDisplay { get; set; }
        public SharingInfo SharingInfo { get; set; }
        public bool IsDownloadable { get; set; }
        public List<PropertyGroup> PropertyGroups { get; set; }
        public bool HasExplicitSharedMembers { get; set; }
        public string ContentHash { get; set; }
    }
}
