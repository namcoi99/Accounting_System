using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysNhomketchuyen
    {
        public short PkId { get; set; }
        public string CMa { get; set; }
        public string CTen { get; set; }
        public string CCongthuc { get; set; }
        public string FkPhanbochitiet { get; set; }
        public string FkKetchuyenchitiet { get; set; }
        public byte? FkDvcs { get; set; }
        public byte? CKetchuyen { get; set; }
        public byte? CPhanbo { get; set; }
        public string FkTieuthucpb { get; set; }
        public byte? CThanhpham { get; set; }
        public byte? CTt { get; set; }
        public string CGiatriVthh { get; set; }
        public bool? CExported { get; set; }
        public string CTile { get; set; }
        public int? CSothanglamviec { get; set; }
        public bool? CLechve { get; set; }
        public bool? CLuutk { get; set; }
        public int? FkNhomKc { get; set; }
        public int? CPbCapsp { get; set; }
        public string CLuuDtcp { get; set; }
        public bool? CUpdate { get; set; }
        public bool? CCoDtcpLuu { get; set; }
    }
}
