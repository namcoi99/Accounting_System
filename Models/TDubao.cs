using System;
using System.Collections.Generic;

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
        public byte FkDvcs { get; set; }
        public short CNam { get; set; }
        public byte CThang { get; set; }
        public short? FkPhongban { get; set; }
        public int? FkKhachhang { get; set; }
        public short? FkUser { get; set; }
        public DateTime? CDatetime { get; set; }
        public short? FkModifyuser { get; set; }

        public virtual ICollection<TDubaoct> TDubaoct { get; set; }
    }
}
