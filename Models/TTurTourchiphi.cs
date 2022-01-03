using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TTurTourchiphi
    {
        public int PkId { get; set; }
        public int FkTour { get; set; }
        public int FkYeucau { get; set; }
        public short FkKmp { get; set; }
        public decimal CPsno { get; set; }
        public decimal CPsno2 { get; set; }
        public string CGhichu { get; set; }
        public int? FkKhachhang { get; set; }
        public DateTime? CNgaylap { get; set; }
        public decimal? CTygia { get; set; }
        public short? FkLoaitien { get; set; }
        public decimal? CDongia { get; set; }
        public decimal? CDongiausd { get; set; }
        public DateTime? CNgayct { get; set; }
        public string CSoct { get; set; }
        public string CSohdgtgt { get; set; }
        public decimal? CVat { get; set; }
        public decimal? CTienthue { get; set; }
        public decimal? CTienthueusd { get; set; }
    }
}
