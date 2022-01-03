using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class VDmTaikhoan
    {
        public short PkId { get; set; }
        public byte? FkDvcs { get; set; }
        public bool? CCap { get; set; }
        public string CMa { get; set; }
        public string CTen { get; set; }
        public string CTenen { get; set; }
        public short? FkNgoaite { get; set; }
        public bool? CLoaitk { get; set; }
        public bool? CTktdcn { get; set; }
        public bool? CTkme { get; set; }
        public bool? CTksc { get; set; }
        public string CRead { get; set; }
        public string CWrite { get; set; }
        public string CVisible { get; set; }
    }
}
