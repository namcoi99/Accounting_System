using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmKhDoc
    {
        public int PkId { get; set; }
        public int FkKhachHang { get; set; }
        public string CFileName { get; set; }
        public byte[] CContent { get; set; }

        public virtual TDmKh FkKhachHangNavigation { get; set; }
    }
}
