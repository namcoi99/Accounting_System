using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class VDmKhgiaodich
    {
        public int PkId { get; set; }
        public string CMa { get; set; }
        public DateTime? CTransDate { get; set; }
        public DateTime? CTransTime { get; set; }
        public string CMakh { get; set; }
        public string CTenkh { get; set; }
        public string CContactName { get; set; }
        public string CContent { get; set; }
        public string CFeedBack { get; set; }
        public string CDanhgia { get; set; }
        public DateTime? CNextDate { get; set; }
        public DateTime? CNextTime { get; set; }
        public string CNextContent { get; set; }
        public string CPhongban { get; set; }
        public byte FkDvcs { get; set; }
        public DateTime? CRemindDate { get; set; }
        public DateTime? CRemindTime { get; set; }
        public bool? CStopRemind { get; set; }
        public string CLoaigd { get; set; }
        public string CNhanviengd { get; set; }
        public short? FkUser { get; set; }
    }
}
