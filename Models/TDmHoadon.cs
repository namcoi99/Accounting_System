using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmHoadon
    {
        public int PkId { get; set; }
        public byte FkDvcs { get; set; }
        public string CQuyen { get; set; }
        public string CMauhoadon { get; set; }
        public int? CSeriDau { get; set; }
        public short? CDoidaiSeri { get; set; }
        public short? CSolienin { get; set; }
        public int? CSoluong { get; set; }
        public int? CDadung { get; set; }
        public string CLien1 { get; set; }
        public string CLien2 { get; set; }
        public string CLien3 { get; set; }
        public string CLien4 { get; set; }
        public string CLien5 { get; set; }
    }
}
