﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StackExchange.DataExplorer.Models
{
    public class BlackList
    {
        public int Id { get; set; }
        public string IPAddress { get; set; }
        public DateTime CreationDate { get; set; }
    }
}