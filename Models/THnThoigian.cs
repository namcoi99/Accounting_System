using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class THnThoigian
    {
        public THnThoigian()
        {
            THnThoigianct = new HashSet<THnThoigianct>();
        }

        public int PkId { get; set; }
        public short FkCa { get; set; }
        public DateTime CNgaythuchien { get; set; }
        public short? FkUser { get; set; }
        public DateTime? CCreatetime { get; set; }
        public short? FkModifyuser { get; set; }
        public DateTime? CDatetime { get; set; }
        public string FkVuep { get; set; }
        public int? FkDvcs { get; set; }
        public string CGhichu { get; set; }

        public virtual TCa FkCaNavigation { get; set; }
        public virtual ICollection<THnThoigianct> THnThoigianct { get; set; }
    }
}
