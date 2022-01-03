using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TGiuhang
    {
        public int PkId { get; set; }
        public byte FkDvcs { get; set; }
        public int FkVthh { get; set; }
        public double CSoluong { get; set; }
        public DateTime CNgay { get; set; }
        public string CGhichu { get; set; }
        public short FkKhonhap { get; set; }
        public short? FkKenhap { get; set; }
        public int? FkDongnhap { get; set; }
        public short? FkVuviec { get; set; }
        public short? FkPhongban { get; set; }
        public DateTime? CDatetime { get; set; }
        public short? FkUser { get; set; }
        public string CSophieu { get; set; }
        public string FkKieuyeucau { get; set; }
    }
}
