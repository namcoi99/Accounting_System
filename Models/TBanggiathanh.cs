using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TBanggiathanh
    {
        public int PkId { get; set; }
        public byte FkDvcs { get; set; }
        public int? FkPhongban { get; set; }
        public int? FkKmp { get; set; }
        public int? FkDtcp { get; set; }
        public int? FkPhanxuong { get; set; }
        public int? FkVthh { get; set; }
        public DateTime CTungay { get; set; }
        public bool? CNguyenkhai { get; set; }
        public decimal CSoluong { get; set; }
        public int FkDvt { get; set; }
        public decimal? CPsno { get; set; }
        public decimal? CPsno2 { get; set; }
        public string FkTkno { get; set; }
        public string FkTkco { get; set; }
        public short? FkUser { get; set; }
        public short? FkModifyuser { get; set; }
        public int? FkVuviec { get; set; }
    }
}
