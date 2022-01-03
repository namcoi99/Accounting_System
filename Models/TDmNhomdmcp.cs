using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmNhomdmcp
    {
        public TDmNhomdmcp()
        {
            TDmNhomdmcpct = new HashSet<TDmNhomdmcpct>();
        }

        public byte FkDvcs { get; set; }
        public short PkId { get; set; }
        public string CMa { get; set; }
        public string CMota { get; set; }

        public virtual ICollection<TDmNhomdmcpct> TDmNhomdmcpct { get; set; }
    }
}
