using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TXntc
    {
        public decimal PkId { get; set; }
        [Required(ErrorMessage = "{0} là trường bắt buộc")]
        [DisplayName("Loại C.từ")]
        public int? FkChungtu { get; set; }
        [Required(ErrorMessage = "{0} là trường bắt buộc")]
        [DisplayName("Số phiếu")]
        public string CSophieu { get; set; }
        [DisplayName("ĐVCS")]
        [Required(ErrorMessage = "{0} là trường bắt buộc")]
        public byte FkDvcs { get; set; }
        public byte? FkTruso { get; set; }
        [Required(ErrorMessage = "{0} là trường bắt buộc")]
        [DisplayName("Ngày lập")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-ddTHH:mm}")]
        public DateTime? CNgaylap { get; set; }
        [DisplayName("Ngày CT")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-ddTHH:mm}")]
        public DateTime? CNgayct { get; set; }
        public string CSoct { get; set; }
        [DisplayName("Mã KH")]
        public int? FkKhachhang { get; set; }
        [DisplayName("Người liên hệ")]
        public int? FkNguoilh { get; set; }
        [DisplayName("Loại tiền")]
        public short? FkLoaitien { get; set; }
        [DisplayName("Tỉ giá")]
        public double? CTigia { get; set; }
        [DisplayName("Phòng ban")]
        public short? FkPhongban { get; set; }
        [DisplayName("TK Nợ")]
        public string FkTkno { get; set; }
        [DisplayName("TK Có")]
        public string FkTkco { get; set; }
        [DisplayName("PS Nợ")]
        public decimal? CPsno { get; set; }
        [DisplayName("TK Có")]
        public decimal? CPsco { get; set; }
        [DisplayName("Diễn giải")]
        public string CDiengiai { get; set; }
        public string CDgdong { get; set; }
        public short? FkThutruong { get; set; }
        public short? FkThuquy { get; set; }
        public short? FkKetoan { get; set; }
        public short? FkKttruong { get; set; }
        public short? FkNguoilap { get; set; }
        public short? FkThukho { get; set; }
        [DisplayName("Kho xuất")]
        public short? FkKhoxuat { get; set; }
        [DisplayName("Kho nhập")]
        public short? FkKhonhap { get; set; }
        [DisplayName("Kệ xuất")]
        public short? FkKexuat { get; set; }
        [DisplayName("Kệ nhập")]
        public short? FkKenhap { get; set; }
        public short? FkNguoigiao { get; set; }
        [DisplayName("Mã VTHH")]
        public short? FkVthh { get; set; }
        [DisplayName("ĐVT")]
        public short? FkDvt { get; set; }
        [DisplayName("Số lượng")]
        public double? CSoluong { get; set; }
        [DisplayName("Đơn giá")]
        public decimal? CDongia { get; set; }
        [DisplayName("Vat")]
        public float? CVat { get; set; }
        [DisplayName("Vụ việc")]
        public short? FkVuviec { get; set; }
        [DisplayName("PTTT")]
        public short? FkPttt { get; set; }
        public short? CHantt { get; set; }
        public DateTime? CHantt2 { get; set; }
        public byte CLoaibt { get; set; }
        public bool? CCopy { get; set; }
        public bool? CPosted { get; set; }
        public short? CPoster { get; set; }
        public short? FkUser { get; set; }
        public DateTime? CDatetime { get; set; }
        public string CSoxe { get; set; }
        public decimal? CKm { get; set; }
        public bool? CPromo { get; set; }
        public int FkOrder { get; set; }
        public bool? CTrong { get; set; }
        public byte CLoaixn { get; set; }
        public byte CLoaict { get; set; }
        [DisplayName("KMP")]
        public short? FkKmp { get; set; }
        [DisplayName("ĐTCP")]
        public short? FkDtcp { get; set; }
        [DisplayName("Phân xưởng")]
        public short? FkPhanxuong { get; set; }
        [DisplayName("Hóa đơn")]
        public int? CHoadon { get; set; }
        public int? FkLsx { get; set; }
        public int? FkLsxct { get; set; }
        [DisplayName("CPSX")]
        public bool? CCpsx { get; set; }
        public string CMst { get; set; }
        public string CKhthue { get; set; }
        public byte? CChatluong { get; set; }
        public byte? CMrb { get; set; }
        public decimal? CSlkiemtra { get; set; }
        public short? FkLdhh { get; set; }
        public int? FkKhachhangco { get; set; }
        [DisplayName("Mã TSCĐ")]
        public int? FkTscd { get; set; }
        public string CSophieutralai { get; set; }
        public string CNote { get; set; }
        [DisplayName("NVKD")]
        public int? FkNvkd { get; set; }
        public short? FkKmpc { get; set; }
        public bool? CKhuno { get; set; }
        public bool? CKhuco { get; set; }
        [DisplayName("Tiền thuế")]
        public decimal? CTienthue { get; set; }
        [DisplayName("Hóa đơn GTGT")]
        public string CSohdgtgt { get; set; }
        [DisplayName("Người liên hệ")]
        public string CNguoilh { get; set; }
        public short? FkModifyuser { get; set; }
        public string CThanhtoan { get; set; }
        public short? FkLdtg { get; set; }
        public short? FkNguonvon { get; set; }
        public bool? CLaphd { get; set; }
        [DisplayName("Theo bộ")]
        public decimal? CTheobo { get; set; }
        [DisplayName("Mặt hàng")]
        public string CMathang { get; set; }
        public byte? FkLoaidl { get; set; }
        [DisplayName("CK")]
        public decimal? CChietkhau { get; set; }
        [DisplayName("Đơn đặt hàng")]
        public int? FkDondathang { get; set; }
        public decimal? CSlthung { get; set; }
        public int? FkQuicach { get; set; }
        [DisplayName("Tiền hàng")]
        public decimal? CTienhang { get; set; }
        public bool? CCpbanhang { get; set; }
        [DisplayName("PS Nợ NT")]
        public decimal? CPsno2 { get; set; }
        [DisplayName("PS Có NT")]
        public decimal? CPsco2 { get; set; }
        [DisplayName("Diễn giải (EN)")]
        public string CDiengiai2 { get; set; }
        public short? FkCuocvanchuyen { get; set; }
        [DisplayName("Số xe")]
        public short? FkSoxe { get; set; }
        [DisplayName("Đơn giá tc")]
        public decimal? CDongiatc { get; set; }
        public short? FkChucnang { get; set; }
        public short? FkCa { get; set; }
        public short? FkTotruong { get; set; }
        [DisplayName("Địa chỉ")]
        public string CKhdiachi { get; set; }
        [DisplayName("Tiền thuế (USD)")]
        public decimal? CTienthue2 { get; set; }
        [DisplayName("Số chuyến")]
        public short? FkSochuyen { get; set; }
        [DisplayName("Hãng vận chuyển")]
        public int? FkHangvanchuyen { get; set; }
        [DisplayName("Người vận chuyển")]
        public string CNguoivanchuyen { get; set; }
        public string CField1 { get; set; }
        public string CField2 { get; set; }
        public bool? CExtraentry { get; set; }
        public string CMauso { get; set; }
        public string CTk { get; set; }
        public int? FkTour { get; set; }
        [DisplayName("STT")]
        public short? CStt { get; set; }
        public decimal? CSoluongxuat { get; set; }
        public string CTmpdichdanh { get; set; }
        public byte? FkThutruong02 { get; set; }
        public byte? FkKttruong02 { get; set; }
        public byte? FkKetoan02 { get; set; }
        public byte? FkThuquy02 { get; set; }
        public byte? FkNguoilap02 { get; set; }
        public byte? FkThukho02 { get; set; }
        public byte? FkNguoigiao02 { get; set; }
        [DisplayName("Bút toán thêm")]
        public bool? CButtoanthem { get; set; }
        [DisplayName("Số phiếu cũ")]
        public string CSophieucu { get; set; }
        public decimal? CFob { get; set; }
        public decimal? CF { get; set; }
        public decimal? CI { get; set; }
        public decimal? CCif { get; set; }
        public decimal? CCif2 { get; set; }
        public decimal? CThuenk { get; set; }
        public decimal? CGttruocthue { get; set; }
        public decimal? CGttruocthue2 { get; set; }
        public short? FkCostCenter { get; set; }
        public bool? CImportData { get; set; }
        public decimal? CTienhangvanchuyen { get; set; }
        [DisplayName("Ngân hàng")]
        public string CSotknh { get; set; }
        public int? FkVoyage { get; set; }
        public string CBillOflading { get; set; }
        public string CVoyage { get; set; }
        public string CVessel { get; set; }
        public DateTime? CEta { get; set; }
        public string CPol { get; set; }
        public string CPod { get; set; }
        public string CPoreceive { get; set; }
        public string CPodelivery { get; set; }
        public int? FkBillOflading { get; set; }
        public byte? CDain { get; set; }
        public DateTime? CLastexport { get; set; }
        public int? FkVthhLuu { get; set; }
        public int? FkNhomKc { get; set; }
        public string CBookingnote { get; set; }
        public int? FkBookingnote { get; set; }
        public int? FkDtcpLuu { get; set; }
        public bool? CImportXuat { get; set; }
        [DisplayName("T/Tiền")]
        public decimal? CCkTienmat { get; set; }
        public int? FkQlxDenghixuat { get; set; }
        public int? FkDtcpco { get; set; }
        public byte? CUpdate { get; set; }
        [DisplayName("Ký hiệu mẫu")]
        public string CKyhieumau { get; set; }
        [DisplayName("Mã hóa đơn")]
        public string CMahoadon { get; set; }
        [DisplayName("Nguyên giá")]
        public decimal? CNguyengia { get; set; }
        public int? FkVitri { get; set; }
        public string CSolo { get; set; }
        public DateTime? CHansudung { get; set; }
        public bool? CHetSl { get; set; }
    }
}
