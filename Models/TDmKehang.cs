﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmKehang
    {
        public short PkId { get; set; }
        public short FkKho { get; set; }
        public string CMa { get; set; }
        public double? CDai { get; set; }
        public double? CRong { get; set; }
        public double? CCao { get; set; }
        public short? FkDonvi { get; set; }
        public string CMota { get; set; }
    }
}
