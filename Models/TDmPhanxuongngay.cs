using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmPhanxuongngay
    {
        public int FkPhanxuong { get; set; }
        public DateTime CNgay { get; set; }
        public short FkCa { get; set; }
        public DateTime CTugio { get; set; }
        public DateTime CDengio { get; set; }
        public double CNangluc { get; set; }
        public double CDadung { get; set; }
        public double CConlai { get; set; }
        public bool? CNghi { get; set; }
        public double CHieusuat { get; set; }
        public byte CLoainangluc { get; set; }
        public double CSlnguoi { get; set; }
        public double CSlmay { get; set; }
        public short FkDvt { get; set; }
    }
}
