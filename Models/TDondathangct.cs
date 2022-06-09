using System;
using System.Collections.Generic;
using System.ComponentModel;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDondathangct
    {
        public int PkId { get; set; }
        public int FkDondathang { get; set; }
        public short CStt { get; set; }
        [DisplayName("Mã VTHH")]
        public int FkVthh { get; set; }
        [DisplayName("Ngày nhận")]
        public DateTime? CNgaynhan { get; set; }
        [DisplayName("Số lượng")]
        public decimal? CSoluong { get; set; }
        [DisplayName("Đvt")]
        public short FkDvban { get; set; }
        [DisplayName("Đơn giá")]
        public decimal? CDongia { get; set; }
        public bool? CPheduyet { get; set; }
        public short? FkNguoipd { get; set; }
        [DisplayName("Trạng thái")]
        public short? FkTrangthai { get; set; }
        [DisplayName("Đơn giá(USD)")]
        public decimal? CDongia2 { get; set; }
        [DisplayName("Khuyến mại")]
        public bool? CKhuyenmai { get; set; }
        [DisplayName("Nguồn CC")]
        public short? FkNguoncc { get; set; }
        [DisplayName("Ngày dự kiến")]
        public DateTime? CNgaydukien { get; set; }
        [DisplayName("Thành tiền")]
        public decimal? CDongiatc { get; set; }
        public bool? CDaban { get; set; }
        [DisplayName("Tính thuế")]
        public bool? CTinhthue { get; set; }
        public bool? CStopRemind { get; set; }
    }
}
