using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmCtkm
    {
        public short PkId { get; set; }
        public short FkDvcs { get; set; }
        public string CMa { get; set; }
        public string CTen { get; set; }
        public DateTime CTungay { get; set; }
        public DateTime CDenngay { get; set; }
        public short CMdut { get; set; }
        public bool CPheduyet { get; set; }
    }
}
