using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysThuyetminhbctc12
    {
        public int Id { get; set; }
        public string CTenvthh { get; set; }
        public string CDvt { get; set; }
        public decimal? CSanluong { get; set; }
        public decimal? CGiavon { get; set; }
        public decimal? CGiaban { get; set; }
        public decimal? CLailo1 { get; set; }
        public decimal? CLailo2 { get; set; }
        public bool? CExported { get; set; }
        public string CLabelen { get; set; }
    }
}
