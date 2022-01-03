using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TKiemke
    {
        public int PkId { get; set; }
        public short FkKykiemke { get; set; }
        public short FkKhohang { get; set; }
        public int FkVthh { get; set; }
        public short? FkDvt { get; set; }
        public double? CSlthucte { get; set; }
        public double? CSlsosach { get; set; }
        public double? CSlchenhlech { get; set; }
    }
}
