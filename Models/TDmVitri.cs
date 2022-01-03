using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmVitri
    {
        public short PkId { get; set; }
        public string CMa { get; set; }
        public string CMota { get; set; }
        public DateTime? CNgaytl { get; set; }
        public string CGiadehang { get; set; }
        public int? FkKhohang { get; set; }
        public int? FkNhomvt { get; set; }
        public int? FkQuicach { get; set; }
        public int? FkHsx { get; set; }
        public decimal? CDai { get; set; }
        public decimal? CRong { get; set; }
        public decimal? CCao { get; set; }
        public byte[] CAnh { get; set; }
        public int? FkDvcs { get; set; }
    }
}
