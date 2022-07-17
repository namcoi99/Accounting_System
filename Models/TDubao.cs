using Accounting_System.Areas.Admin.Pages.OrderForcastPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDubao
    {
        public TDubao()
        {
            TDubaoct = new HashSet<TDubaoct>();
        }

        public int PkId { get; set; }
        [Required(ErrorMessage = "ĐVCS là trường bắt buộc")]
        [DisplayName("ĐVCS")]
        public byte FkDvcs { get; set; }
        [DisplayName("Năm")]
        [Required(ErrorMessage = "Năm là trường bắt buộc")]
        public short CNam { get; set; }
        [Required(ErrorMessage = "Tháng là trường bắt buộc")]
        [DisplayName("Tháng")]
        public byte CThang { get; set; }
        [DisplayName("Phòng ban")]
        public short? FkPhongban { get; set; }
        [DisplayName("Mã KH")]
        public int? FkKhachhang { get; set; }
        [DisplayName("Người lập")]
        public short? FkUser { get; set; }
        public DateTime? CDatetime { get; set; }
        public short? FkModifyuser { get; set; }

        public virtual ICollection<TDubaoct> TDubaoct { get; set; }
    }
}
