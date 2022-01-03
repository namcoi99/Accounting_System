using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmPhanxuongnangluc
    {
        public int PkId { get; set; }
        public short FkPhanxuong { get; set; }
        public DateTime CTungay { get; set; }
        public DateTime CDenngay { get; set; }
        public double CHieusuat { get; set; }
        public byte CLoainangluc { get; set; }
        public double? CSlnguoi { get; set; }
        public double? CSlmay { get; set; }
        public double? CNangluc { get; set; }
        public string CCa { get; set; }
        public short? FkDvt { get; set; }
    }
}
