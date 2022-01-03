using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TBangketquaPhanbo
    {
        public int PkId { get; set; }
        public byte FkDvcs { get; set; }
        public int? FkPhongban { get; set; }
        public int? FkCostCenter { get; set; }
        public int? FkVthh { get; set; }
        public int? FkDtcp { get; set; }
        public int? FkKmp { get; set; }
        public string FkTaikhoan { get; set; }
        public DateTime CNgay { get; set; }
        public decimal? CDauKy { get; set; }
        public decimal? CTrongKy { get; set; }
        public decimal? CCongDoanTruoc { get; set; }
        public decimal? CDoDang { get; set; }
        public decimal? CDoDangDauCd { get; set; }
        public decimal? CSoLuongSx { get; set; }
        public short? FkUser { get; set; }
        public decimal? CSoluongTp { get; set; }
    }
}
