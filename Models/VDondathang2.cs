using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class VDondathang2
    {
        public string CSophieu { get; set; }
        public DateTime CNgaylap { get; set; }
        public string CDiengiai { get; set; }
        public string CMakh { get; set; }
        public string CTenkh { get; set; }
        public string CDiachi { get; set; }
        public string CNguoilh { get; set; }
        public string CSoxe { get; set; }
        public string CNguoivanchuyen { get; set; }
        public string CHangvc { get; set; }
        public string CSocont { get; set; }
        public string CSochi { get; set; }
        public double? CVat { get; set; }
        public string CPhongban { get; set; }
        public string CVuviec { get; set; }
        public string CDvcs { get; set; }
        public int PkId { get; set; }
        public short? FkUser { get; set; }
        public int? FkLoaibg { get; set; }
        public short? FkSochuyen { get; set; }
        public decimal? COrderqty { get; set; }
        public double? CDelqty { get; set; }
        public double? CRemain { get; set; }
    }
}
