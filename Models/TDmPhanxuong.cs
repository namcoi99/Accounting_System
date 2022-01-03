using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmPhanxuong
    {
        public short PkId { get; set; }
        public byte FkDvcs { get; set; }
        public string CMa { get; set; }
        public string CMota { get; set; }
        public bool? CCap { get; set; }
        public bool? CSanxuat { get; set; }
        public short? CSeq { get; set; }
        public bool? CSelect { get; set; }
        public string CRead { get; set; }
        public string CWrite { get; set; }
        public string CVisible { get; set; }
        public DateTime? CLastexport { get; set; }
        public bool? CAn { get; set; }
        public string CDienthoai1 { get; set; }
        public string CDienthoai2 { get; set; }
        public string CDienthoai3 { get; set; }
        public string CFax { get; set; }
        public string CDaidien1 { get; set; }
        public string CDaidien2 { get; set; }
        public string CDaidien3 { get; set; }
        public int? FkPhongban { get; set; }
    }
}
