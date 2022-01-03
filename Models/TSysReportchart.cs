using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysReportchart
    {
        public int PkId { get; set; }
        public int FkReport { get; set; }
        public byte CSeq { get; set; }
        public string CChartname { get; set; }
        public double CHeight { get; set; }
        public double CWidth { get; set; }
        public byte CCharttype { get; set; }
        public byte CSourcetype { get; set; }
        public string CKeycolumn { get; set; }
        public string CKeyvalue { get; set; }
        public string CSeriesx { get; set; }
        public string CSeriesy { get; set; }
        public string CAxiscaptionx { get; set; }
        public string CAxiscaptiony { get; set; }
        public bool? CExported { get; set; }
    }
}
