using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TQlxDenghixuatCt
    {
        public int PkId { get; set; }
        public int? FkQlxDenghixuat { get; set; }
        public int? FkDtcp { get; set; }
        public string CErrors { get; set; }
        public int? CStt { get; set; }
        public string CMa { get; set; }
        public string CTen { get; set; }
        public string CVthhMa { get; set; }
        public string CVthhTen { get; set; }
        public string CVthhMaphu { get; set; }
        public string CTruoc { get; set; }
        public string CSau { get; set; }
        public string CMagop { get; set; }
        public string CThongbao { get; set; }
        public decimal? CSoluong { get; set; }
        public decimal? CSoluongTon { get; set; }
        public decimal? CSoluongDaxuat { get; set; }
        public decimal? CDongia { get; set; }
        public decimal? CThanhtien { get; set; }
        public decimal? CTienthue { get; set; }
        public string CKho { get; set; }
        public string CNhh { get; set; }
        public string CTaikhoan { get; set; }
        public string CKmp { get; set; }
        public string CGhichu { get; set; }
        public string CDvt { get; set; }
        public int? CDtcp { get; set; }
        public string CDvtMa { get; set; }
        public string FkTkno { get; set; }
        public int? FkKhonhap { get; set; }
        public string CKmpMota { get; set; }
        public decimal? CTon { get; set; }
        public int? FkVthh { get; set; }
        public int? FkDvt { get; set; }
        public int? FkNhh { get; set; }
        public int? FkKmp { get; set; }
        public int? FkTaikhoan { get; set; }
        public string CDinhmuc { get; set; }
        public string CDtcpMa { get; set; }
        public string CDtcpTen { get; set; }
        public int? CCap { get; set; }
        public bool? CHoanthanh { get; set; }
        public int? CSttDm { get; set; }
        public int? FkQlxDinhmuc { get; set; }
        public decimal? CTontong { get; set; }
        public decimal? CSlTontong { get; set; }
        public bool? CXuatqua { get; set; }
        public int? FkDtcpco { get; set; }
        public string CDtcpcoMa { get; set; }
    }
}
