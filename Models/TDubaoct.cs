using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDubaoct
    {
        public TDubaoct()
        {
            TDubaoctngay = new HashSet<TDubaoctngay>();
        }

        public int PkId { get; set; }
        public int FkDubao { get; set; }
        [DisplayName("Mã VTHH")]
        [Required(ErrorMessage = "{0} là trường bắt buộc")]
        public int FkVthh { get; set; }
        [DisplayName("ĐVB")]
        public short FkDvban { get; set; }
        [Required(ErrorMessage = "{0} là trường bắt buộc")]
        [DisplayName("Số lượng")]
        [Range(0, double.PositiveInfinity, ErrorMessage = "{0} phải lớn hơn {1}")]
        public decimal CSoluong { get; set; }

        public virtual TDubao FkDubaoNavigation { get; set; }
        public virtual ICollection<TDubaoctngay> TDubaoctngay { get; set; }
    }
}
