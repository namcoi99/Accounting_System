using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysFile
    {
        public bool CUpdate { get; set; }
        public string CFilename { get; set; }
        public DateTime CModifydate { get; set; }
        public string CClientname { get; set; }
        public bool? CExported { get; set; }
        public bool? CDownload { get; set; }
        public byte[] CContent { get; set; }
    }
}
