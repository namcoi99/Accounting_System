using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TQlxDinhmucCt
    {
        public int PkId { get; set; }
        public int? FkQlxDinhmuc { get; set; }
        public int? FkVthh { get; set; }
        public string CVthh { get; set; }
        public string CTenVthh { get; set; }
        public string CVthhMaphu { get; set; }
        public string CDvt { get; set; }
        public int? FkDvt { get; set; }
        public decimal? CSoluong { get; set; }
        public decimal? CTlhh { get; set; }
        public string CHangsx { get; set; }
        public string CKho { get; set; }
        public string CNhh { get; set; }
        public string CTaikhoan { get; set; }
        public decimal? CTnk { get; set; }
        public int? CStt { get; set; }
        public string CTruoc { get; set; }
        public string CSau { get; set; }
        public byte? CXoa { get; set; }
    }
}
