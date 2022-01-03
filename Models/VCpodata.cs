using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class VCpodata
    {
        public bool CConvert { get; set; }
        public long PkId { get; set; }
        public int FkMrpoption { get; set; }
        public int FkVthh { get; set; }
        public string CMavthh { get; set; }
        public string CTenvthh { get; set; }
        public string CMaphu { get; set; }
        public short FkDvtonkho { get; set; }
        public string CDvt { get; set; }
        public DateTime? CNgaybd { get; set; }
        public DateTime CNgaynhan { get; set; }
        public double CSlyeucau { get; set; }
        public int? FkPoprimaryVendor { get; set; }
        public string CMancc { get; set; }
        public string CTenncc { get; set; }
        public int? FkGiaydathang { get; set; }
        public string CSophieu { get; set; }
        public short FkDvmua { get; set; }
        public bool? CPolastPrice { get; set; }
    }
}
