﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StackExchange.DataExplorer.Models
{
    public class AppSetting
    {
        public int Id { get; set; }
        public string Setting { get; set; }
        public string Value { get; set; }
    }
}