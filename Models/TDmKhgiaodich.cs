using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmKhgiaodich
    {
        public int PkId { get; set; }
        public byte FkDvcs { get; set; }
        public string CMa { get; set; }
        public short? FkPhongban { get; set; }
        public int FkKhachhang { get; set; }
        public string CContactName { get; set; }
        public string CContent { get; set; }
        public string CFeedBack { get; set; }
        public string CNextContent { get; set; }
        public DateTime? CTransDate { get; set; }
        public DateTime? CTransTime { get; set; }
        public DateTime? CNextDate { get; set; }
        public DateTime? CNextTime { get; set; }
        public DateTime? CRemindDate { get; set; }
        public DateTime? CRemindTime { get; set; }
        public bool? CStopRemind { get; set; }
        public byte? FkDanhgia { get; set; }
        public short? FkUser { get; set; }
        public short? FkModifyuser { get; set; }
        public DateTime? CDatetime { get; set; }
        public byte? FkLoaigd { get; set; }
    }
}
