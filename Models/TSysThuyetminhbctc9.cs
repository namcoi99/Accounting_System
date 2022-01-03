using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysThuyetminhbctc9
    {
        public int? COrder { get; set; }
        public byte? CCap { get; set; }
        public string CChitieu { get; set; }
        public string CLabelen { get; set; }
        public decimal? CTongso1 { get; set; }
        public decimal? CQuahan1 { get; set; }
        public decimal? CTongso2 { get; set; }
        public decimal? CQuahan2 { get; set; }
        public decimal? CTongso3 { get; set; }
        public int PkId { get; set; }
        public bool? CExported { get; set; }
    }
}
