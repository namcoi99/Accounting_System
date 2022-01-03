using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TBangketquaPhanboct
    {
        public int PkId { get; set; }
        public byte FkDvcs { get; set; }
        public int? FkPhongban { get; set; }
        public int? FkCostCenter { get; set; }
        public int? FkVthh { get; set; }
        public int? CInBom { get; set; }
        public DateTime CNgay { get; set; }
        public decimal? CLaborTime { get; set; }
        public decimal? CQuantity { get; set; }
        public decimal? CSoluongSx { get; set; }
        public decimal? CSoCong { get; set; }
        public decimal? CTongTien { get; set; }
        public short? FkUser { get; set; }
        public byte? CSpPhu { get; set; }
    }
}
