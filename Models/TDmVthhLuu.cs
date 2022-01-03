using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmVthhLuu
    {
        public int PkId { get; set; }
        public int? FkVthh { get; set; }
        public string CTen { get; set; }
        public int? FkDvmua { get; set; }
        public int? FkDvtonkho { get; set; }
        public int? FkDvban { get; set; }
        public string FkTkkho { get; set; }
        public int? FkNhomvt { get; set; }
        public int? FkNhomvt2 { get; set; }
        public int? FkNhomvt3 { get; set; }
        public int? FkHsx { get; set; }
        public int? FkKhohang { get; set; }
        public int? FkDtcp { get; set; }
        public int? FkVitri { get; set; }
        public int? FkCreateUser { get; set; }
        public DateTime? CDatetime { get; set; }
        public string CNote { get; set; }
        public bool? CVitri { get; set; }
    }
}
