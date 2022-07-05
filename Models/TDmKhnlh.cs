using System;
using System.Collections.Generic;
using System.ComponentModel;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmKhnlh
    {
        public int PkId { get; set; }
        public int FkKh { get; set; }
        [DisplayName("Người LH")]
        public string CTen { get; set; }
        public string CChucvu { get; set; }
        public string CSonoibo { get; set; }
        public string CMobile { get; set; }
        public string CEmail { get; set; }
        public string CGhichu { get; set; }
        public string CPhongBan { get; set; }
        public DateTime? CNgaySinh { get; set; }
        public byte? CGioiTinh { get; set; }
    }
}
