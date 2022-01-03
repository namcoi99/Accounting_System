using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TKyketoan
    {
        public short PkId { get; set; }
        public string CTen { get; set; }
        public DateTime CTungay { get; set; }
        public DateTime CDenngay { get; set; }
        public bool? CKhoa { get; set; }
        public bool? CHientai { get; set; }
        public decimal? CTiGiaHachToan { get; set; }
    }
}
