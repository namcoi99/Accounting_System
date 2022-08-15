using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TXntcorder
    {
        public int PkId { get; set; }
        [DisplayName("Số phiếu")]
        [Required(ErrorMessage = "{0} là trường bắt buộc")]
        public string CSophieu { get; set; }
        [DisplayName("ĐVCS")]
        [Required(ErrorMessage = "{0} là trường bắt buộc")]
        public short FkDvcs { get; set; }
        public string CTtkhuyenmai { get; set; }
        public int? FkOrder { get; set; }
    }
}
