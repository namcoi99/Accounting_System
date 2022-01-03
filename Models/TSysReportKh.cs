﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysReportKh
    {
        public int PkId { get; set; }
        public int? FkReport { get; set; }
        public bool? CTenviettat { get; set; }
        public string CPhieuin { get; set; }
    }
}
