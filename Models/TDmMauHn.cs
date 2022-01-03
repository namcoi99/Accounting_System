using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmMauHn
    {
        public TDmMauHn()
        {
            THnApct = new HashSet<THnApct>();
            THnCuongvikiemct = new HashSet<THnCuongvikiemct>();
            THnDuongnonct = new HashSet<THnDuongnonct>();
        }

        public int PkId { get; set; }
        public string CMa { get; set; }
        public string CTenloai { get; set; }
        public decimal? CHsphaloang { get; set; }
        public int? CNhomhn { get; set; }
        public string CGhichu { get; set; }

        public virtual ICollection<THnApct> THnApct { get; set; }
        public virtual ICollection<THnCuongvikiemct> THnCuongvikiemct { get; set; }
        public virtual ICollection<THnDuongnonct> THnDuongnonct { get; set; }
    }
}
