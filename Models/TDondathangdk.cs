using System;
using System.Collections.Generic;
using System.ComponentModel;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDondathangdk
    {
        public int PkId { get; set; }
        [DisplayName("STT")]
        public byte CStt { get; set; }
        public int FkDondathang { get; set; }
        [DisplayName("Điều khoản")]
        public short FkDkbg { get; set; }

        public virtual TDondathang FkDondathangNavigation { get; set; }
    }
}
