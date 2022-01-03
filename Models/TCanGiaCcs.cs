using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TCanGiaCcs
    {
        public int PkId { get; set; }
        public string CMota { get; set; }
        public byte? CNguon { get; set; }
        public decimal? CMucduoi { get; set; }
        public decimal? CMuctren { get; set; }
        public decimal? CTile { get; set; }
        public decimal? CConggia { get; set; }
        public decimal? CToithieu { get; set; }
        public decimal? CGia { get; set; }
        public int? FkKh { get; set; }
    }
}
