using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSupportSalaryToAgent
    {
        public int PkId { get; set; }
        public byte FkDvcs { get; set; }
        public short? FkPhongban { get; set; }
        public DateTime CFromDate { get; set; }
        public DateTime CToDate { get; set; }
        public int FkKhachhang { get; set; }
        public int? FkNhomvattu { get; set; }
        public int? FkVthh { get; set; }
        public decimal? CCollection { get; set; }
        public decimal CFrom1 { get; set; }
        public decimal CTo1 { get; set; }
        public decimal? CSalary1 { get; set; }
        public decimal? CFrom2 { get; set; }
        public decimal? CTo2 { get; set; }
        public decimal? CSalary2 { get; set; }
        public decimal? CFrom3 { get; set; }
        public decimal? CTo3 { get; set; }
        public decimal? CSalary3 { get; set; }
        public decimal? CFrom4 { get; set; }
        public decimal? CTo4 { get; set; }
        public decimal? CSalary4 { get; set; }
        public decimal? CFrom5 { get; set; }
        public decimal? CTo5 { get; set; }
        public decimal? CSalary5 { get; set; }
        public short? FkUser { get; set; }
        public short? FkModifyuser { get; set; }
    }
}
