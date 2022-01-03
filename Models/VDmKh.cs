using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class VDmKh
    {
        public int PkId { get; set; }
        public string CMa { get; set; }
        public byte? FkDvcs { get; set; }
        public byte? FkQuocgia { get; set; }
        public string CMst { get; set; }
        public byte? CSndn { get; set; }
        public decimal? CTongno { get; set; }
        public string CGiamdoc { get; set; }
        public string CKtt { get; set; }
        public string CEmail { get; set; }
        public string CWebsite { get; set; }
        public short? FkNhomkh { get; set; }
        public short? FkNhomkh2 { get; set; }
        public short? FkNhomkh3 { get; set; }
        public short? FkVung { get; set; }
        public bool CTccn { get; set; }
        public bool CNguoimua { get; set; }
        public bool CNhacungcap { get; set; }
        public string CGhichu { get; set; }
        public bool CGiaodich { get; set; }
        public string CTen { get; set; }
        public string CTvt { get; set; }
        public string CDiachi { get; set; }
        public short? FkTtp { get; set; }
        public string CFax { get; set; }
        public string CDienthoai { get; set; }
        public string CTaikhoan { get; set; }
        public DateTime? CNgaythietlap { get; set; }
        public short? FkUser { get; set; }
        public DateTime? CDatetime { get; set; }
        public short? FkHuyen { get; set; }
        public short? FkXa { get; set; }
        public short? FkXom { get; set; }
        public int? CConvert { get; set; }
        public bool? CNhanvien { get; set; }
        public int? CEffectid { get; set; }
        public short? FkModifyuser { get; set; }
        public string FkTaikhoan { get; set; }
        public decimal? CMucno { get; set; }
        public decimal? CMax { get; set; }
        public int? FkPttt { get; set; }
        public decimal? CCuoc { get; set; }
        public decimal? CTrietkhau { get; set; }
        public string CMathang { get; set; }
        public decimal? CKhoangcach { get; set; }
        public bool? CExported { get; set; }
    }
}
