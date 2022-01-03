using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysReportcolprop
    {
        public int PkId { get; set; }
        public int FkReport { get; set; }
        public string CColname { get; set; }
        public short CWidth { get; set; }
        public byte? CDecimaldigits { get; set; }
        public byte? CReportsummaryposition { get; set; }
        public byte? CPagesummaryposition { get; set; }
        public byte? CGroupby { get; set; }
        public string CParent { get; set; }
        public bool? CIsgroup { get; set; }
        public string CCaptionvn { get; set; }
        public string CCaptionen { get; set; }
        public byte? CCaptiontype { get; set; }
        public decimal? CHeight { get; set; }
        public byte? CType { get; set; }
        public string CFormat { get; set; }
        public byte? CAlign { get; set; }
        public bool? CVisible { get; set; }
        public byte? CGroupposition { get; set; }
        public byte? COrder { get; set; }
        public bool? CExported { get; set; }
        public bool? CSumgrid { get; set; }
        public bool? CHidegrid { get; set; }
        public string CColor { get; set; }
        public bool? CBold { get; set; }
        public bool? COnfooter { get; set; }
        public byte? COnheader { get; set; }
        public bool? CInword { get; set; }
        public bool? CUsd { get; set; }
        public string CGroupalign { get; set; }
        public byte? COverride { get; set; }
        public short? CHeaderangle { get; set; }
        public byte? CHeaderheight { get; set; }
        public short? CContentangle { get; set; }
        public string CColNumber { get; set; }
        public short? CSubreport { get; set; }
        public string CFf1 { get; set; }
        public string CFf2 { get; set; }
        public string CFf3 { get; set; }
        public string CTf1 { get; set; }
        public string CTf2 { get; set; }
        public string CTf3 { get; set; }
        public bool? CCrlf { get; set; }
        public byte? CColsummaryposition { get; set; }
        public bool? COutlookGroupBy { get; set; }
    }
}
