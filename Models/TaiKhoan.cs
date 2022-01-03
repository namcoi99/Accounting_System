using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TaiKhoan
    {
        public bool? CTktdcn { get; set; }
        public bool? CCap { get; set; }
        public string CTen { get; set; }
        public string CMa { get; set; }
        public string CTenen { get; set; }
    }
}
