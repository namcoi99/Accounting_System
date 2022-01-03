using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class THnNuocloct
    {
        public int PkId { get; set; }
        public int FkHnNuoclo { get; set; }
        public string CGiothuchien { get; set; }
        public decimal? CNthaiph { get; set; }
        public decimal CNngungduong { get; set; }
        public decimal CNnguonEdta { get; set; }
        public decimal? CB3Edta { get; set; }
        public decimal? CB4Edta { get; set; }
        public decimal? CB5Edta { get; set; }
        public decimal? CB6Edta { get; set; }
        public decimal CPh1 { get; set; }
        public decimal CCl1 { get; set; }
        public decimal CEdta1 { get; set; }
        public decimal CPh2 { get; set; }
        public decimal CCl2 { get; set; }
        public decimal CEdta2 { get; set; }
        public decimal CPp3 { get; set; }
        public decimal CMo3 { get; set; }
        public decimal CEdta3 { get; set; }
        public decimal CCl3 { get; set; }
        public decimal CPo43 { get; set; }
        public decimal CPh3 { get; set; }
        public decimal CPp4 { get; set; }
        public decimal CMo4 { get; set; }
        public decimal CEdta4 { get; set; }
        public decimal CCl4 { get; set; }
        public decimal CPo44 { get; set; }
        public decimal CPh4 { get; set; }
        public string CGhichu { get; set; }

        public virtual THnNuoclo FkHnNuocloNavigation { get; set; }
    }
}
