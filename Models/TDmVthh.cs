using System;
using System.Collections.Generic;
using System.ComponentModel;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmVthh
    {
        public int PkId { get; set; }
        public short? FkDvcs { get; set; }
        [DisplayName("Mã VTHH")]
        public string CMa { get; set; }
        [DisplayName("Mã phụ")]
        public string CMaphu { get; set; }
        [DisplayName("Tên VTHH")]
        public string CTen { get; set; }
        [DisplayName("ĐV mua")]
        public short FkDvmua { get; set; }
        [DisplayName("ĐV tồn kho")]
        public short FkDvtonkho { get; set; }
        [DisplayName("ĐV bán")]
        public short FkDvban { get; set; }
        public bool? CTdtk { get; set; }
        public byte? FkCtg { get; set; }
        public string FkTkkho { get; set; }
        public short? FkNhomvt { get; set; }
        public short? FkNhomvt2 { get; set; }
        public short? FkNhomvt3 { get; set; }
        [DisplayName("Thuế VAT")]
        public float? CThuevat { get; set; }
        public bool? CKttsx { get; set; }
        public byte[] CAnh { get; set; }
        public DateTime? CNgaytl { get; set; }
        public bool? CXoa { get; set; }
        public bool? CSanxuat { get; set; }
        public byte? CSogia { get; set; }
        public string CGhichu { get; set; }
        public int? CSlttt { get; set; }
        public int? CSlttd { get; set; }
        public string CTskt { get; set; }
        public string CQcdg { get; set; }
        public short? FkHsx { get; set; }
        public byte? CTgbh { get; set; }
        [DisplayName("Giá chuẩn")]
        public decimal? CGiachuan { get; set; }
        public decimal? CGiatran { get; set; }
        [DisplayName("Giá sàn")]
        public decimal? CGiasan { get; set; }
        public short? FkUser { get; set; }
        public DateTime? CDatetime { get; set; }
        public int? CConvert { get; set; }
        public float? CTilehongvc { get; set; }
        public float? CTelehongsx { get; set; }
        [DisplayName("Mã Kho")]
        public short? FkKhohang { get; set; }
        public short? FkDtcp { get; set; }
        public short? FkModifyuser { get; set; }
        public int? FkVthh { get; set; }
        public decimal? CThuenk { get; set; }
        [DisplayName("Qui cách")]
        public int? FkQuicach { get; set; }
        public string FkTkgvon { get; set; }
        public bool? CPolastPrice { get; set; }
        public decimal? CPomultiple { get; set; }
        public decimal? CPominOrder { get; set; }
        public decimal? CPomaxOrder { get; set; }
        public int? FkPoprimaryVendor { get; set; }
        public decimal? CPoleadTime { get; set; }
        public decimal? CPromultiple { get; set; }
        public decimal? CProminOrder { get; set; }
        public decimal? CPromaxOrder { get; set; }
        public decimal? CProleadTime { get; set; }
        public byte? CBanphamvi { get; set; }
        public DateTime? CBantungay { get; set; }
        public DateTime? CBandenngay { get; set; }
        public decimal? CBanboiso { get; set; }
        public byte? CBandonggoi { get; set; }
        public bool? CHotrovc { get; set; }
        public double? CNetweight { get; set; }
        public double? CGrossweight { get; set; }
        public double? CChieudai { get; set; }
        public double? CChieucao { get; set; }
        public double? CChieurong { get; set; }
        public byte? CPhichuan { get; set; }
        public int? FkSptieuChuan { get; set; }
        public string CMavach { get; set; }
        public short? FkVitri { get; set; }
        public short? CSeq { get; set; }
        public bool? CSelect { get; set; }
        public string CSize { get; set; }
        public int? FkNoisx { get; set; }
        public decimal? CPoprice { get; set; }
        public bool? CDodangdt { get; set; }
        public bool? CTrongcongdoan { get; set; }
        public byte? CSpPhu { get; set; }
        public decimal? CHsThuhoi { get; set; }
        public DateTime? CLastexport { get; set; }
        public byte? CChoxoa { get; set; }
        public DateTime? CUpdatedate { get; set; }
    }
}
