using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmDtcp
    {
        public short PkId { get; set; }
        public byte? FkDvcs { get; set; }
        public bool? CCap { get; set; }
        public string CMa { get; set; }
        public string CTen { get; set; }
        public short? FkDvt { get; set; }
        public short? FkNhomvattu { get; set; }
        public string FkTkno { get; set; }
        public short? CCapsp { get; set; }
        public int? CNhomdtcp { get; set; }
        public int? FkVthh { get; set; }
        public decimal? CValueUsd { get; set; }
        public decimal? CDoanhthuUsd { get; set; }
        public decimal? CDoanhthu { get; set; }
        public DateTime? CLastexport { get; set; }
        public bool? CAn { get; set; }
        public decimal? CValueVat { get; set; }
        public decimal? CValueUsdVat { get; set; }
        public decimal? CDoanhthuVat { get; set; }
        public decimal? CDoanhthuUsdVat { get; set; }
    }
}
