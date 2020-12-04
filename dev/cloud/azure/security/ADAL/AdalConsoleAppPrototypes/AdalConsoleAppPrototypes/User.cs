﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AdalConsoleAppPrototypes
{
    class User
    {
        public string Id { get; set; }
        public string UserPrincipalName { get; set; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public string DisplayName { get; set; }
        public string JobTitle { get; set; }
        public string Mail { get; set; }
        public string[] BusinessPhones { get; set; }
        public string MobilePhone { get; set; }
        public string OfficeLocation { get; set; }
        public string PreferredLanguage { get; set; }

        public override string ToString()
        {
            return $"{Id}\n{UserPrincipalName}\n{GivenName}\n{Surname}\n{DisplayName}\n{JobTitle}\n{Mail}\n{BusinessPhones[0]}\n{MobilePhone}\n{OfficeLocation}\n{PreferredLanguage}";
        }
    }
}
