using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmKho
    {
        public short PkId { get; set; }
        public byte FkDvcs { get; set; }
        public short? FkTongkho { get; set; }
        public string CMa { get; set; }
        public string CLoaikho { get; set; }
        public bool? CSanxuat { get; set; }
        public bool? CBanhang { get; set; }
        public bool? CKehang { get; set; }
        public string CMota { get; set; }
        public double? CKhoangcach { get; set; }
        public bool? CCap { get; set; }
        public DateTime? CLastexport { get; set; }
        public byte? CChoxoa { get; set; }
    }
}
