using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class THnXomia
    {
        public int PkId { get; set; }
        public short FkCa { get; set; }
        public DateTime CNgaythuchien { get; set; }
        public decimal? CTlmia { get; set; }
        public decimal? CTlba { get; set; }
        public decimal? CTlnuocmia { get; set; }
        public decimal? CTltks { get; set; }
        public decimal? CTlsks { get; set; }
        public decimal CPerw { get; set; }
        public decimal? CTltkn { get; set; }
        public decimal? CTlskn { get; set; }
        public decimal? CTlddmatdi { get; set; }
        public decimal? CBxqsddskn { get; set; }
        public decimal? CNhietdo { get; set; }
        public decimal? CBxddskn { get; set; }
        public decimal CBxba { get; set; }
        public decimal? CPolqsddskn { get; set; }
        public decimal? CPolba { get; set; }
        public decimal CPerxomia { get; set; }
        public string CGhichu { get; set; }
        public string FkVuep { get; set; }

        public virtual TCa FkCaNavigation { get; set; }
    }
}
