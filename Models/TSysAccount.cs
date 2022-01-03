using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysAccount
    {
        public short PkId { get; set; }
        public string CMa { get; set; }
        public string CMatkhau { get; set; }
        public short? FkNhanvien { get; set; }
        public string CGhichu { get; set; }
        public bool? CDoimk { get; set; }
        public bool? CHsd { get; set; }
        public bool? CKhoatk { get; set; }
        public bool? CKhoadulieu { get; set; }
        public bool? CDbadmin { get; set; }
        public byte? FkDomat { get; set; }
        public short? FkDvcs { get; set; }
        public bool? CBom { get; set; }
        public bool? CExported { get; set; }
        public string CGranted { get; set; }
        public bool? CModifylayout { get; set; }
        public short? FkPhongban { get; set; }
        public string CTen { get; set; }
        public bool? CSingleClick { get; set; }
        public bool? CExpandAll { get; set; }
        public string CGrantedread { get; set; }
        public string CGrantedccn { get; set; }
        public bool? CLocalDictionary { get; set; }
        public bool? CAutoAlert { get; set; }
        public bool? CPotimer { get; set; }
        public bool? CSotimer { get; set; }
        public short? CAlertTime { get; set; }
        public byte? CCurrentTheme { get; set; }
        public bool? CLockAfterSave { get; set; }
        public DateTime? CLastexport { get; set; }
    }
}
