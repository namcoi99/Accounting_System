using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmTscd
    {
        public int PkId { get; set; }
        public byte FkDvcs { get; set; }
        public byte? CCap { get; set; }
        public string CMa { get; set; }
        public string CTen { get; set; }
        public byte? FkDvt { get; set; }
        public string CCongsuat { get; set; }
        public string CTailieukt { get; set; }
        public short? FkLdtg { get; set; }
        public DateTime? CNgaygt { get; set; }
        public string CSohd { get; set; }
        public short? FkBpsd { get; set; }
        public short? FkNguoiql { get; set; }
        public short? FkMdsd { get; set; }
        public bool? CTkh { get; set; }
        public byte? CPpkh { get; set; }
        public string FkTkhm { get; set; }
        public string FkTkcp { get; set; }
        public DateTime? CNgaybdkh { get; set; }
        public decimal? CStkh { get; set; }
        public byte? FkNuocsx { get; set; }
        public short? CNamsx { get; set; }
        public string CSerialno { get; set; }
        public string CTenncc { get; set; }
        public string CHopdong { get; set; }
        public DateTime? CNgaybd { get; set; }
        public DateTime? CNgaykt { get; set; }
        public string CGhichu { get; set; }
        public short? FkUser { get; set; }
        public DateTime? CDatetime { get; set; }
        public int? CConvert { get; set; }
        public double? CTieuthuckh { get; set; }
        public double? CTongtieuthuc { get; set; }
        public short? FkNhomts1 { get; set; }
        public short? FkNhomts2 { get; set; }
        public short? FkDtcp { get; set; }
        public short? FkKmp { get; set; }
        public short? FkVuviec { get; set; }
        public short? FkPhanxuong { get; set; }
        public int? FkPhongban { get; set; }
        public short? FkModifyuser { get; set; }
        public short? CThoigianbaohanh { get; set; }
        public short? FkTinhtrang { get; set; }
        public byte? FkPpkh { get; set; }
        public double? CSoluongtp { get; set; }
        public int? FkCostCenter { get; set; }
        public DateTime? CLastexport { get; set; }
    }
}
