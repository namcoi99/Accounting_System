using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TQlxDenghixuatDtcp
    {
        public int PkId { get; set; }
        public int? FkQlxDenghixuat { get; set; }
        public int? FkDtcp { get; set; }
        public string CDtcp { get; set; }
        public string CDinhmuc { get; set; }
        public string CDtcpTen { get; set; }
        public decimal? CSoluong { get; set; }
        public int? FkDvt { get; set; }
        public string CDvt { get; set; }
        public string CTaikhoan { get; set; }
        public string CKmp { get; set; }
        public string CGhichu { get; set; }
        public int? CCap { get; set; }
        public bool? CHoanthanh { get; set; }
        public int? CStt { get; set; }
    }
}
