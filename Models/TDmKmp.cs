using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmKmp
    {
        public short PkId { get; set; }
        public byte FkDvcs { get; set; }
        public bool? CCap { get; set; }
        public string CMa { get; set; }
        public string CMota { get; set; }
        public string FkTkno { get; set; }
        public string FkTkco { get; set; }
        public bool? CTinhlai { get; set; }
        public decimal? CDongia { get; set; }
        public bool? CVattu { get; set; }
        public DateTime? CLastexport { get; set; }
        public bool? CAn { get; set; }
    }
}
