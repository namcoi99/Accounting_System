using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmCtkmvung
    {
        public short PkId { get; set; }
        public short FkCtkm { get; set; }
        public short FkVung { get; set; }
    }
}
