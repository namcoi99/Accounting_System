using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class VCposchedule
    {
        public bool? CSelect { get; set; }
        public bool CConvert { get; set; }
        public short? CStt { get; set; }
        public string CMaPhanXuong { get; set; }
        public string CTenPhanXuong { get; set; }
        public string CMaChucNang { get; set; }
        public string CTenChucNang { get; set; }
        public string CMaVthh { get; set; }
        public string CTenVthh { get; set; }
        public string CMaPhuVthh { get; set; }
        public string CDvt { get; set; }
        public string CCa { get; set; }
        public DateTime? CNgay { get; set; }
        public DateTime CTugio { get; set; }
        public DateTime CDengio { get; set; }
        public double CSoluong { get; set; }
        public string CMaLsx { get; set; }
        public int FkMrpoption { get; set; }
        public int FkPhanxuong { get; set; }
        public int? FkChucnang { get; set; }
        public long FkCpodata { get; set; }
        public int? FkLsx { get; set; }
        public int? FkGiaydathang { get; set; }
    }
}
