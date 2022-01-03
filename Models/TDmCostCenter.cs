using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmCostCenter
    {
        public short PkId { get; set; }
        public string CMa { get; set; }
        public string CMota { get; set; }
        public bool? CTructiepsx { get; set; }
        public bool? CPbTong { get; set; }
        public string CTheoKmp { get; set; }
        public int? FkPhongban { get; set; }
        public string CPrecostcenter { get; set; }
        public int? CStt { get; set; }
        public bool? CGtUti { get; set; }
        public bool? CCap { get; set; }
    }
}
