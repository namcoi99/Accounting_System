using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmKhcuocvc
    {
        public int PkId { get; set; }
        public int FkKhdiachi { get; set; }
        public double CTrongluong { get; set; }
        public double CGiacuoc { get; set; }
        public bool? CHieuluc { get; set; }
    }
}
