using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysReport
    {
        public short PkId { get; set; }
        public short? CParent { get; set; }
        public short CKey { get; set; }
        public string CLabel { get; set; }
        public string CLabelen { get; set; }
        public bool? CReport { get; set; }
        public bool? CDelete { get; set; }
        public bool? CGroupby { get; set; }
        public bool? COrderby { get; set; }
        public byte CTop { get; set; }
        public short CTopvalue { get; set; }
        public bool? CCondition { get; set; }
        public bool? CAutocolumns { get; set; }
        public string CCaption { get; set; }
        public string CWrite { get; set; }
        public string CRead { get; set; }
        public string CVisible { get; set; }
        public string CPicture { get; set; }
        public string CPicture1 { get; set; }
        public string CVisiblefields { get; set; }
        public string CSql { get; set; }
        public string CStrselect { get; set; }
        public string CStrfrom { get; set; }
        public string CStrwhere { get; set; }
        public string CStrorder { get; set; }
        public string CStrgroup { get; set; }
        public string CFonttitlereport { get; set; }
        public byte CSizefontreport { get; set; }
        public bool? CBoldtitlereport { get; set; }
        public bool? CItanictitlereport { get; set; }
        public bool? CUndertitlereport { get; set; }
        public string CColortitlereport { get; set; }
        public string CFonttitlecolumns { get; set; }
        public byte CSizefontcolumns { get; set; }
        public bool? CBoldcolumns { get; set; }
        public bool? CItaniccolumns { get; set; }
        public bool? CUndercolumns { get; set; }
        public string CColorcolumns { get; set; }
        public string CFontcontent { get; set; }
        public byte CSizecontent { get; set; }
        public bool? CBoldcontent { get; set; }
        public bool? CItaniccontent { get; set; }
        public bool? CUndercontent { get; set; }
        public string CColorcontent { get; set; }
        public bool? CA4 { get; set; }
        public float CTopmargin { get; set; }
        public float CBottommargin { get; set; }
        public float CLeftmargin { get; set; }
        public float CRightmargin { get; set; }
        public bool? CPrintdate { get; set; }
        public bool? CReporter { get; set; }
        public bool? CPage { get; set; }
        public byte? CLandcape { get; set; }
        public string CPrintcolumns { get; set; }
        public bool? CSystem { get; set; }
        public string CReportfile { get; set; }
        public string CMa { get; set; }
        public string CFormula { get; set; }
        public string CValue { get; set; }
        public string CCmddel { get; set; }
        public string CNote { get; set; }
        public short CGroupreport { get; set; }
        public bool? CIsroot { get; set; }
        public short? CReporttype { get; set; }
        public string CParameter { get; set; }
        public byte? CGrid { get; set; }
        public string CReportfooter { get; set; }
        public short? CIndex { get; set; }
        public string CBangcongthuc { get; set; }
        public int? CDetailreport { get; set; }
        public string CIso { get; set; }
        public string CDetailcode { get; set; }
        public bool? CLocalreport { get; set; }
        public string CX { get; set; }
        public string CY { get; set; }
        public decimal? CHeaderheight { get; set; }
        public decimal? CGroupheight { get; set; }
        public decimal? CDetailheight { get; set; }
        public byte? CLinestyle { get; set; }
        public byte? CLineweight { get; set; }
        public string CReporttitlefont { get; set; }
        public string CParameterfont { get; set; }
        public string CHeaderfooterfont { get; set; }
        public string CGroupfont { get; set; }
        public string CDetailfont { get; set; }
        public string CReportfooterfont { get; set; }
        public string CPapersize { get; set; }
        public string CSignature { get; set; }
        public bool? CExported { get; set; }
        public bool? CDateinreport { get; set; }
        public string CSignatureen { get; set; }
        public bool? CColNumbering { get; set; }
        public short? CRootId { get; set; }
        public string CDescription { get; set; }
        public string CDescriptionen { get; set; }
        public string CTemplateGroup { get; set; }
        public bool? CTheoTaiKhoan { get; set; }
        public bool? CSoPhatSinh { get; set; }
        public string CPostSql { get; set; }
        public string CPrinterName { get; set; }
    }
}
