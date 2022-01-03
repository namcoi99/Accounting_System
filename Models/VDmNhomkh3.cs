using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class VDmNhomkh3
    {
        public short PkId { get; set; }
        public byte? FkDvcs { get; set; }
        public string CMa { get; set; }
        public string CMota { get; set; }
        public bool? CCap { get; set; }
        public byte? CLoai { get; set; }
        public bool? CExported { get; set; }
    }
}
