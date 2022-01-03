using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class THnCuongvikiemct
    {
        public int PkId { get; set; }
        public int FkHnCuongvikiem { get; set; }
        public int FkDmMauHn { get; set; }
        public string CGiothuchien { get; set; }
        public decimal? CPh { get; set; }
        public decimal? CSo2 { get; set; }
        public decimal? CBe { get; set; }
        public decimal? CRs { get; set; }
        public decimal? CP2o5 { get; set; }
        public decimal? CIu { get; set; }
        public string CGhichu { get; set; }

        public virtual TDmMauHn FkDmMauHnNavigation { get; set; }
        public virtual THnCuongvikiem FkHnCuongvikiemNavigation { get; set; }
    }
}
