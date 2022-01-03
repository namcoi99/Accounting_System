using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TCa
    {
        public TCa()
        {
            THnAp = new HashSet<THnAp>();
            THnBasx = new HashSet<THnBasx>();
            THnBunloc = new HashSet<THnBunloc>();
            THnCuongvikiem = new HashSet<THnCuongvikiem>();
            THnDuongnon = new HashSet<THnDuongnon>();
            THnDuongtp = new HashSet<THnDuongtp>();
            THnNuoclo = new HashSet<THnNuoclo>();
            THnThoigian = new HashSet<THnThoigian>();
            THnXomia = new HashSet<THnXomia>();
        }

        public short PkId { get; set; }
        public byte FkDvcs { get; set; }
        public int? CThoigian { get; set; }
        public string CMa { get; set; }
        public string CGhichu { get; set; }
        public DateTime? CTu01 { get; set; }
        public DateTime? CDen01 { get; set; }
        public DateTime? CTu02 { get; set; }
        public DateTime? CDen02 { get; set; }
        public DateTime? CTu03 { get; set; }
        public DateTime? CDen03 { get; set; }
        public DateTime? CTu04 { get; set; }
        public DateTime? CDen04 { get; set; }
        public DateTime? CTu05 { get; set; }
        public DateTime? CDen05 { get; set; }

        public virtual ICollection<THnAp> THnAp { get; set; }
        public virtual ICollection<THnBasx> THnBasx { get; set; }
        public virtual ICollection<THnBunloc> THnBunloc { get; set; }
        public virtual ICollection<THnCuongvikiem> THnCuongvikiem { get; set; }
        public virtual ICollection<THnDuongnon> THnDuongnon { get; set; }
        public virtual ICollection<THnDuongtp> THnDuongtp { get; set; }
        public virtual ICollection<THnNuoclo> THnNuoclo { get; set; }
        public virtual ICollection<THnThoigian> THnThoigian { get; set; }
        public virtual ICollection<THnXomia> THnXomia { get; set; }
    }
}
