using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmVuviec
    {
        public short PkId { get; set; }
        public byte FkDvcs { get; set; }
        public string CMa { get; set; }
        public string CMota { get; set; }
        public DateTime? CNgaybd { get; set; }
        public DateTime? CNgaykt { get; set; }
        public DateTime? CNgayky { get; set; }
        public decimal? CGiatri { get; set; }
        public decimal? CGiatri2 { get; set; }
        public short? CThoigiankh { get; set; }
        public string CTkno { get; set; }
        public int? CKmp { get; set; }
        public int? CPhongban { get; set; }
        public int? CPhanxuong { get; set; }
        public string CTkco { get; set; }
        public int? FkKmp { get; set; }
        public int? FkPhongban { get; set; }
        public int? FkPhanxuong { get; set; }
        public int? FkDtcp { get; set; }
        public bool? CSudung { get; set; }
        public decimal? CSoluong { get; set; }
        public string FkTkno { get; set; }
        public bool? CIn { get; set; }
        public bool? CGhiam { get; set; }
        public int? FkCostCenter { get; set; }
        public DateTime? CLastexport { get; set; }
        public int? FkKh { get; set; }
        public byte? CChoxoa { get; set; }
        public string CMaDuan { get; set; }
        public decimal? CValueVat { get; set; }
        public decimal? CValueUsdVat { get; set; }
        public decimal? CDoanhthuVat { get; set; }
        public decimal? CDoanhthuUsdVat { get; set; }
    }
}
