using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmChungtu
    {
        public int PkId { get; set; }
        public short? CStt { get; set; }
        public string CMa { get; set; }
        public string CTen { get; set; }
        public string FkTkn { get; set; }
        public string FkTkc { get; set; }
        public string FkTkthue { get; set; }
        public float? CVat { get; set; }
        public short? FkPhongban { get; set; }
        public short? FkKhoxuat { get; set; }
        public short? FkKhonhap { get; set; }
        public short? FkKenhap { get; set; }
        public short? FkKexuat { get; set; }
        public short? FkDvtt { get; set; }
        public short? FkKhoanmuc { get; set; }
        public byte? FkDvcs { get; set; }
        public short? FkThutruong { get; set; }
        public short? FkKttruong { get; set; }
        public short? FkThukho { get; set; }
        public short? FkKetoan { get; set; }
        public short? FkThuquy { get; set; }
        public short? FkNguoigiao { get; set; }
        public bool? CVuviec { get; set; }
        public string CControls { get; set; }
        public string CGridcolumns { get; set; }
        public bool? CDefault { get; set; }
        public string CRead { get; set; }
        public string CWrite { get; set; }
        public string CVisible { get; set; }
        public byte? CLoaixn { get; set; }
        public byte? CLoaibt { get; set; }
        public short? FkTiente { get; set; }
        public byte? CLoaict { get; set; }
        public string CPrefix { get; set; }
        public bool? CYear { get; set; }
        public bool? CMonth { get; set; }
        public string CTkgiavonno { get; set; }
        public string CTkgiavonco { get; set; }
        public bool? CGiavon { get; set; }
        public string CDautkno { get; set; }
        public string CDautkco { get; set; }
        public string CDautkthue { get; set; }
        public byte? CSobanin { get; set; }
        public bool? CInsauluu { get; set; }
        public short? CCtthuchi { get; set; }
        public bool? CYear2 { get; set; }
        public bool? CMonth2 { get; set; }
        public byte? CFulllen { get; set; }
        public string CSeparator { get; set; }
        public bool? CStore { get; set; }
        public byte? CYearlen { get; set; }
        public bool? CPriceincludedtax { get; set; }
        public bool? CExchangerate { get; set; }
        public byte? CCustomization { get; set; }
        public bool? CCheckquantity { get; set; }
        public bool? CLopsided { get; set; }
        public bool? CPromotion { get; set; }
        public string CAnotherentry { get; set; }
        public string CTenen { get; set; }
        public bool? CButtoanthem { get; set; }
        public string CField1 { get; set; }
        public string CField2 { get; set; }
        public string CUpdateLog { get; set; }
        public short? CRootId { get; set; }
        public string CDescription { get; set; }
        public string CDescriptionen { get; set; }
        public bool? CCheckPrice { get; set; }
        public DateTime? CLastexport { get; set; }
        public int? FkLoaihoadon { get; set; }
        public bool? CSmart { get; set; }
    }
}
