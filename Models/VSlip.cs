using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class VSlip
    {
        public string CSophieu { get; set; }
        public string CTaikhoan { get; set; }
        public string CTenen { get; set; }
        public decimal? CPsnovnd { get; set; }
        public decimal? CPsnousd { get; set; }
        public decimal? CPscovnd { get; set; }
        public decimal? CPscousd { get; set; }
        public double? CTigia { get; set; }
    }
}
