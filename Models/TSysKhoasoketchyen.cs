using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysKhoasoketchyen
    {
        public short PkId { get; set; }
        public short? CStt { get; set; }
        public string CTaikhoan { get; set; }
        public bool? CPhongban { get; set; }
        public bool? CKhoanmuc { get; set; }
        public bool? CKhachhang { get; set; }
        public bool? CVuviec { get; set; }
        public bool? CPhanxuong { get; set; }
        public bool? CDtcp { get; set; }
        public bool? CVthh { get; set; }
        public bool? CKho { get; set; }
        public bool? CTscd { get; set; }
        public bool? CNguonvon { get; set; }
    }
}
