﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmTigia
    {
        public int PkId { get; set; }
        public DateTime CNgay { get; set; }
        public decimal CTigia { get; set; }
        public int? FkLoaitien { get; set; }
    }
}
