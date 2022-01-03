using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmVthhqtsxct
    {
        public int PkId { get; set; }
        public int FkVthhqtsx { get; set; }
        public short CStt { get; set; }
        public byte CKieu { get; set; }
        public short? FkChucnang { get; set; }
        public short? FkPhanxuong { get; set; }
        public decimal? CMachineTime { get; set; }
        public decimal? CLaborTime { get; set; }
        public decimal? CQuantity { get; set; }
        public byte? CPacer { get; set; }
        public decimal? COverlapQuantity { get; set; }
        public int? FkNcc { get; set; }
        public short? FkLaborrate { get; set; }
        public short? FkMachinerate { get; set; }
        public short? FkLabortimeuom { get; set; }
        public short? FkMachinetimeuom { get; set; }
        public short? FkCostCenter { get; set; }

        public virtual TDmVthhqtsx FkVthhqtsxNavigation { get; set; }
    }
}
