﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysThuyetminhbctc5
    {
        public int? COrder { get; set; }
        public byte? CCap { get; set; }
        public string CChitieu { get; set; }
        public decimal? CTscdvohinh { get; set; }
        public decimal? CTong { get; set; }
        public int PkId { get; set; }
        public bool? CExported { get; set; }
        public string CLabelen { get; set; }
    }
}
