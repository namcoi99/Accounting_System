using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysTieuthucpb
    {
        public short PkId { get; set; }
        public string CTen { get; set; }
        public string CGiatri { get; set; }
        public string CDk { get; set; }
        public string CDk2 { get; set; }
        public bool? CExported { get; set; }
        public string CBangthaytheXntc { get; set; }
        public string CGiatriDinhmuc { get; set; }
    }
}
