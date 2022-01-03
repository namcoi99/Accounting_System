using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmCompara
    {
        public int PkId { get; set; }
        public byte FkDvcs { get; set; }
        public int? FkPhongban { get; set; }
        public int? FkKhachhang { get; set; }
        public int? FkNhomvattu { get; set; }
        public int? FkVthh { get; set; }
        public DateTime CFromDate { get; set; }
        public DateTime CToDate { get; set; }
        public byte FkConType { get; set; }
        public byte FkConValue { get; set; }
        public byte FkBonus { get; set; }
        public decimal CFrom1 { get; set; }
        public decimal CTo1 { get; set; }
        public decimal CCom1 { get; set; }
        public decimal? CFrom2 { get; set; }
        public decimal? CTo2 { get; set; }
        public decimal? CCom2 { get; set; }
        public decimal? CFrom3 { get; set; }
        public decimal? CTo3 { get; set; }
        public decimal? CCom3 { get; set; }
        public decimal? CFrom4 { get; set; }
        public decimal? CTo4 { get; set; }
        public decimal? CCom4 { get; set; }
        public decimal? CFrom5 { get; set; }
        public decimal? CTo5 { get; set; }
        public decimal? CCom5 { get; set; }
        public short? FkUser { get; set; }
        public short? FkModifyuser { get; set; }
    }
}
