using System;
using System.Collections.Generic;
using System.ComponentModel;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmPhongban
    {
        public short PkId { get; set; }
        public byte FkDvcs { get; set; }
        [DisplayName("Mã phòng ban")]
        public string CMa { get; set; }
        public string CMota { get; set; }
        public bool? CCap { get; set; }
        public string CTen { get; set; }
        public string CDiachi { get; set; }
        public string CDienthoai { get; set; }
        public string CMst { get; set; }
        public string CNhomkethue { get; set; }
        public DateTime? CLastexport { get; set; }
        public string CDienthoai2 { get; set; }
        public string CDienthoai3 { get; set; }
        public string CFax { get; set; }
        public string CDaidien1 { get; set; }
        public string CDaidien2 { get; set; }
        public string CDaidien3 { get; set; }
        public string CWrite { get; set; }
    }
}
