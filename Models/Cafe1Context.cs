using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class Cafe1Context : DbContext
    {
        public Cafe1Context()
        {
        }

        public Cafe1Context(DbContextOptions<Cafe1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Dtcp> Dtcp { get; set; }
        public virtual DbSet<TBanggiathanh> TBanggiathanh { get; set; }
        public virtual DbSet<TBanggiathanhDtcp> TBanggiathanhDtcp { get; set; }
        public virtual DbSet<TBangketquaGiathanhct> TBangketquaGiathanhct { get; set; }
        public virtual DbSet<TBangketquaPhanbo> TBangketquaPhanbo { get; set; }
        public virtual DbSet<TBangketquaPhanboct> TBangketquaPhanboct { get; set; }
        public virtual DbSet<TBangketquaTygia> TBangketquaTygia { get; set; }
        public virtual DbSet<TBangphanboChiphi> TBangphanboChiphi { get; set; }
        public virtual DbSet<TBangphanboChiphiTt> TBangphanboChiphiTt { get; set; }
        public virtual DbSet<TBaocaosx> TBaocaosx { get; set; }
        public virtual DbSet<TBaocaosxct> TBaocaosxct { get; set; }
        public virtual DbSet<TBaocaosxlydo> TBaocaosxlydo { get; set; }
        public virtual DbSet<TCa> TCa { get; set; }
        public virtual DbSet<TCanGiaCcs> TCanGiaCcs { get; set; }
        public virtual DbSet<TCpobeginqty> TCpobeginqty { get; set; }
        public virtual DbSet<TCpocapacity> TCpocapacity { get; set; }
        public virtual DbSet<TCpodata> TCpodata { get; set; }
        public virtual DbSet<TCposchedule> TCposchedule { get; set; }
        public virtual DbSet<TCposupply> TCposupply { get; set; }
        public virtual DbSet<TDmBpsd> TDmBpsd { get; set; }
        public virtual DbSet<TDmChucnang> TDmChucnang { get; set; }
        public virtual DbSet<TDmChucnangtgcb> TDmChucnangtgcb { get; set; }
        public virtual DbSet<TDmChucnangtt> TDmChucnangtt { get; set; }
        public virtual DbSet<TDmChungtu> TDmChungtu { get; set; }
        public virtual DbSet<TDmChungtuphieuin> TDmChungtuphieuin { get; set; }
        public virtual DbSet<TDmCompara> TDmCompara { get; set; }
        public virtual DbSet<TDmComparabonus> TDmComparabonus { get; set; }
        public virtual DbSet<TDmComparacontype> TDmComparacontype { get; set; }
        public virtual DbSet<TDmComparaconvalue> TDmComparaconvalue { get; set; }
        public virtual DbSet<TDmCostCenter> TDmCostCenter { get; set; }
        public virtual DbSet<TDmCtg> TDmCtg { get; set; }
        public virtual DbSet<TDmCtkm> TDmCtkm { get; set; }
        public virtual DbSet<TDmCtkmct> TDmCtkmct { get; set; }
        public virtual DbSet<TDmCtkmvung> TDmCtkmvung { get; set; }
        public virtual DbSet<TDmCuocvanchuyenct> TDmCuocvanchuyenct { get; set; }
        public virtual DbSet<TDmDkbg> TDmDkbg { get; set; }
        public virtual DbSet<TDmDktt> TDmDktt { get; set; }
        public virtual DbSet<TDmDtcp> TDmDtcp { get; set; }
        public virtual DbSet<TDmDtcpthoigian> TDmDtcpthoigian { get; set; }
        public virtual DbSet<TDmDvcs> TDmDvcs { get; set; }
        public virtual DbSet<TDmDvcsThem> TDmDvcsThem { get; set; }
        public virtual DbSet<TDmDvt> TDmDvt { get; set; }
        public virtual DbSet<TDmDvtcd> TDmDvtcd { get; set; }
        public virtual DbSet<TDmDvtg> TDmDvtg { get; set; }
        public virtual DbSet<TDmHoadon> TDmHoadon { get; set; }
        public virtual DbSet<TDmHsx> TDmHsx { get; set; }
        public virtual DbSet<TDmHuyen> TDmHuyen { get; set; }
        public virtual DbSet<TDmHvt> TDmHvt { get; set; }
        public virtual DbSet<TDmKehang> TDmKehang { get; set; }
        public virtual DbSet<TDmKh> TDmKh { get; set; }
        public virtual DbSet<TDmKhDoc> TDmKhDoc { get; set; }
        public virtual DbSet<TDmKhcuocvc> TDmKhcuocvc { get; set; }
        public virtual DbSet<TDmKhdanhgia> TDmKhdanhgia { get; set; }
        public virtual DbSet<TDmKhdiachi> TDmKhdiachi { get; set; }
        public virtual DbSet<TDmKhgiaodich> TDmKhgiaodich { get; set; }
        public virtual DbSet<TDmKhloaigd> TDmKhloaigd { get; set; }
        public virtual DbSet<TDmKhnlh> TDmKhnlh { get; set; }
        public virtual DbSet<TDmKho> TDmKho { get; set; }
        public virtual DbSet<TDmKhts> TDmKhts { get; set; }
        public virtual DbSet<TDmKhvthh> TDmKhvthh { get; set; }
        public virtual DbSet<TDmKieuyeucau> TDmKieuyeucau { get; set; }
        public virtual DbSet<TDmKmp> TDmKmp { get; set; }
        public virtual DbSet<TDmKykiemke> TDmKykiemke { get; set; }
        public virtual DbSet<TDmLdd> TDmLdd { get; set; }
        public virtual DbSet<TDmLdhh> TDmLdhh { get; set; }
        public virtual DbSet<TDmLdtg> TDmLdtg { get; set; }
        public virtual DbSet<TDmLoaibg> TDmLoaibg { get; set; }
        public virtual DbSet<TDmLoaibt> TDmLoaibt { get; set; }
        public virtual DbSet<TDmLoaict> TDmLoaict { get; set; }
        public virtual DbSet<TDmLoaidl> TDmLoaidl { get; set; }
        public virtual DbSet<TDmLoaikho> TDmLoaikho { get; set; }
        public virtual DbSet<TDmLoaixe> TDmLoaixe { get; set; }
        public virtual DbSet<TDmLoaixn> TDmLoaixn { get; set; }
        public virtual DbSet<TDmMahoadon> TDmMahoadon { get; set; }
        public virtual DbSet<TDmMauHn> TDmMauHn { get; set; }
        public virtual DbSet<TDmMdsd> TDmMdsd { get; set; }
        public virtual DbSet<TDmMocthoigian> TDmMocthoigian { get; set; }
        public virtual DbSet<TDmMpd> TDmMpd { get; set; }
        public virtual DbSet<TDmNganhang> TDmNganhang { get; set; }
        public virtual DbSet<TDmNguonvon> TDmNguonvon { get; set; }
        public virtual DbSet<TDmNhomdmcp> TDmNhomdmcp { get; set; }
        public virtual DbSet<TDmNhomdmcpct> TDmNhomdmcpct { get; set; }
        public virtual DbSet<TDmNhomgia> TDmNhomgia { get; set; }
        public virtual DbSet<TDmNhomgt> TDmNhomgt { get; set; }
        public virtual DbSet<TDmNhomkh> TDmNhomkh { get; set; }
        public virtual DbSet<TDmNhomts> TDmNhomts { get; set; }
        public virtual DbSet<TDmNhomvattu> TDmNhomvattu { get; set; }
        public virtual DbSet<TDmNs> TDmNs { get; set; }
        public virtual DbSet<TDmNtscd> TDmNtscd { get; set; }
        public virtual DbSet<TDmPhache> TDmPhache { get; set; }
        public virtual DbSet<TDmPhanxuong> TDmPhanxuong { get; set; }
        public virtual DbSet<TDmPhanxuongca> TDmPhanxuongca { get; set; }
        public virtual DbSet<TDmPhanxuongnangluc> TDmPhanxuongnangluc { get; set; }
        public virtual DbSet<TDmPhanxuongngay> TDmPhanxuongngay { get; set; }
        public virtual DbSet<TDmPhongban> TDmPhongban { get; set; }
        public virtual DbSet<TDmPlabc> TDmPlabc { get; set; }
        public virtual DbSet<TDmPpvc> TDmPpvc { get; set; }
        public virtual DbSet<TDmPttt> TDmPttt { get; set; }
        public virtual DbSet<TDmPtvt> TDmPtvt { get; set; }
        public virtual DbSet<TDmQuicachdg> TDmQuicachdg { get; set; }
        public virtual DbSet<TDmQuocgia> TDmQuocgia { get; set; }
        public virtual DbSet<TDmTaikhoan> TDmTaikhoan { get; set; }
        public virtual DbSet<TDmTiente> TDmTiente { get; set; }
        public virtual DbSet<TDmTigia> TDmTigia { get; set; }
        public virtual DbSet<TDmTongkho> TDmTongkho { get; set; }
        public virtual DbSet<TDmTotruong> TDmTotruong { get; set; }
        public virtual DbSet<TDmTrangthai> TDmTrangthai { get; set; }
        public virtual DbSet<TDmTscd> TDmTscd { get; set; }
        public virtual DbSet<TDmTscdDtcp> TDmTscdDtcp { get; set; }
        public virtual DbSet<TDmTscdSanluongnam> TDmTscdSanluongnam { get; set; }
        public virtual DbSet<TDmTscdnv> TDmTscdnv { get; set; }
        public virtual DbSet<TDmTscdpt> TDmTscdpt { get; set; }
        public virtual DbSet<TDmTscdtinhtrang> TDmTscdtinhtrang { get; set; }
        public virtual DbSet<TDmTscdtl> TDmTscdtl { get; set; }
        public virtual DbSet<TDmTtp> TDmTtp { get; set; }
        public virtual DbSet<TDmVitri> TDmVitri { get; set; }
        public virtual DbSet<TDmVthh> TDmVthh { get; set; }
        public virtual DbSet<TDmVthhChuyendoi> TDmVthhChuyendoi { get; set; }
        public virtual DbSet<TDmVthhDtcp> TDmVthhDtcp { get; set; }
        public virtual DbSet<TDmVthhLuu> TDmVthhLuu { get; set; }
        public virtual DbSet<TDmVthhVitri> TDmVthhVitri { get; set; }
        public virtual DbSet<TDmVthhbom> TDmVthhbom { get; set; }
        public virtual DbSet<TDmVthhdvt> TDmVthhdvt { get; set; }
        public virtual DbSet<TDmVthhgia> TDmVthhgia { get; set; }
        public virtual DbSet<TDmVthhkhuyenmai> TDmVthhkhuyenmai { get; set; }
        public virtual DbSet<TDmVthhkmp> TDmVthhkmp { get; set; }
        public virtual DbSet<TDmVthhnl> TDmVthhnl { get; set; }
        public virtual DbSet<TDmVthhnlct> TDmVthhnlct { get; set; }
        public virtual DbSet<TDmVthhqtsx> TDmVthhqtsx { get; set; }
        public virtual DbSet<TDmVthhqtsxct> TDmVthhqtsxct { get; set; }
        public virtual DbSet<TDmVthhrouting> TDmVthhrouting { get; set; }
        public virtual DbSet<TDmVthhspp> TDmVthhspp { get; set; }
        public virtual DbSet<TDmVthhstdcost> TDmVthhstdcost { get; set; }
        public virtual DbSet<TDmVung> TDmVung { get; set; }
        public virtual DbSet<TDmVuviec> TDmVuviec { get; set; }
        public virtual DbSet<TDmVuviecDtcp> TDmVuviecDtcp { get; set; }
        public virtual DbSet<TDmXa> TDmXa { get; set; }
        public virtual DbSet<TDmXe> TDmXe { get; set; }
        public virtual DbSet<TDmXom> TDmXom { get; set; }
        public virtual DbSet<TDomDubao> TDomDubao { get; set; }
        public virtual DbSet<TDondathang> TDondathang { get; set; }
        public virtual DbSet<TDondathangDoc> TDondathangDoc { get; set; }
        public virtual DbSet<TDondathangct> TDondathangct { get; set; }
        public virtual DbSet<TDondathangdk> TDondathangdk { get; set; }
        public virtual DbSet<TDubao> TDubao { get; set; }
        public virtual DbSet<TDubaoct> TDubaoct { get; set; }
        public virtual DbSet<TDubaoctngay> TDubaoctngay { get; set; }
        public virtual DbSet<TDubaots> TDubaots { get; set; }
        public virtual DbSet<TDubaotsdata> TDubaotsdata { get; set; }
        public virtual DbSet<TEdocDoctype> TEdocDoctype { get; set; }
        public virtual DbSet<TEdocSecurlevel> TEdocSecurlevel { get; set; }
        public virtual DbSet<TFnproductrelation> TFnproductrelation { get; set; }
        public virtual DbSet<TGbg> TGbg { get; set; }
        public virtual DbSet<TGbgdk> TGbgdk { get; set; }
        public virtual DbSet<TGbgvthh> TGbgvthh { get; set; }
        public virtual DbSet<TGiaydathang> TGiaydathang { get; set; }
        public virtual DbSet<TGiaydathangDoc> TGiaydathangDoc { get; set; }
        public virtual DbSet<TGiaydathangct> TGiaydathangct { get; set; }
        public virtual DbSet<TGiuhang> TGiuhang { get; set; }
        public virtual DbSet<TGvbqtc> TGvbqtc { get; set; }
        public virtual DbSet<THnAp> THnAp { get; set; }
        public virtual DbSet<THnApct> THnApct { get; set; }
        public virtual DbSet<THnBanghieuchinh> THnBanghieuchinh { get; set; }
        public virtual DbSet<THnBasx> THnBasx { get; set; }
        public virtual DbSet<THnBasxct> THnBasxct { get; set; }
        public virtual DbSet<THnBunloc> THnBunloc { get; set; }
        public virtual DbSet<THnBunlocct> THnBunlocct { get; set; }
        public virtual DbSet<THnCuongvikiem> THnCuongvikiem { get; set; }
        public virtual DbSet<THnCuongvikiemct> THnCuongvikiemct { get; set; }
        public virtual DbSet<THnDuongnon> THnDuongnon { get; set; }
        public virtual DbSet<THnDuongnonct> THnDuongnonct { get; set; }
        public virtual DbSet<THnDuongtp> THnDuongtp { get; set; }
        public virtual DbSet<THnDuongtpct> THnDuongtpct { get; set; }
        public virtual DbSet<THnNuoclo> THnNuoclo { get; set; }
        public virtual DbSet<THnNuocloct> THnNuocloct { get; set; }
        public virtual DbSet<THnThoigian> THnThoigian { get; set; }
        public virtual DbSet<THnThoigianct> THnThoigianct { get; set; }
        public virtual DbSet<THnXomia> THnXomia { get; set; }
        public virtual DbSet<TKetchuyen> TKetchuyen { get; set; }
        public virtual DbSet<TKiemke> TKiemke { get; set; }
        public virtual DbSet<TKiemketemp> TKiemketemp { get; set; }
        public virtual DbSet<TKyketoan> TKyketoan { get; set; }
        public virtual DbSet<TLich> TLich { get; set; }
        public virtual DbSet<TLichchitiet> TLichchitiet { get; set; }
        public virtual DbSet<TLsx> TLsx { get; set; }
        public virtual DbSet<TLsxct> TLsxct { get; set; }
        public virtual DbSet<TLsxctkh> TLsxctkh { get; set; }
        public virtual DbSet<TLsxnl> TLsxnl { get; set; }
        public virtual DbSet<TLsxnlct> TLsxnlct { get; set; }
        public virtual DbSet<TLsxqtsx> TLsxqtsx { get; set; }
        public virtual DbSet<TLsxqtsxct> TLsxqtsxct { get; set; }
        public virtual DbSet<TLuongNhanvienBhxh> TLuongNhanvienBhxh { get; set; }
        public virtual DbSet<TLuongNhanvienVisa> TLuongNhanvienVisa { get; set; }
        public virtual DbSet<TLuongPhanloainvCost> TLuongPhanloainvCost { get; set; }
        public virtual DbSet<TMrpdata> TMrpdata { get; set; }
        public virtual DbSet<TMrpoption> TMrpoption { get; set; }
        public virtual DbSet<TNam> TNam { get; set; }
        public virtual DbSet<TPdh> TPdh { get; set; }
        public virtual DbSet<TPdhct> TPdhct { get; set; }
        public virtual DbSet<TQlpx> TQlpx { get; set; }
        public virtual DbSet<TQlpxct> TQlpxct { get; set; }
        public virtual DbSet<TQlxDenghinhap> TQlxDenghinhap { get; set; }
        public virtual DbSet<TQlxDenghinhapCt> TQlxDenghinhapCt { get; set; }
        public virtual DbSet<TQlxDenghixuat> TQlxDenghixuat { get; set; }
        public virtual DbSet<TQlxDenghixuatCt> TQlxDenghixuatCt { get; set; }
        public virtual DbSet<TQlxDenghixuatDtcp> TQlxDenghixuatDtcp { get; set; }
        public virtual DbSet<TQlxDinhmuc> TQlxDinhmuc { get; set; }
        public virtual DbSet<TQlxDinhmucCt> TQlxDinhmucCt { get; set; }
        public virtual DbSet<TQlxSlvthhDtcp> TQlxSlvthhDtcp { get; set; }
        public virtual DbSet<TSmsConfig> TSmsConfig { get; set; }
        public virtual DbSet<TSmsContreleaseCt> TSmsContreleaseCt { get; set; }
        public virtual DbSet<TSmsScheduleSlotAllocation> TSmsScheduleSlotAllocation { get; set; }
        public virtual DbSet<TSupportSalaryToAgent> TSupportSalaryToAgent { get; set; }
        public virtual DbSet<TSysAccount> TSysAccount { get; set; }
        public virtual DbSet<TSysAlert> TSysAlert { get; set; }
        public virtual DbSet<TSysAllfield> TSysAllfield { get; set; }
        public virtual DbSet<TSysApprovalstatus> TSysApprovalstatus { get; set; }
        public virtual DbSet<TSysBackuplog> TSysBackuplog { get; set; }
        public virtual DbSet<TSysBackuprestore> TSysBackuprestore { get; set; }
        public virtual DbSet<TSysBomstatus> TSysBomstatus { get; set; }
        public virtual DbSet<TSysCapacitytype> TSysCapacitytype { get; set; }
        public virtual DbSet<TSysChitieu> TSysChitieu { get; set; }
        public virtual DbSet<TSysChuky> TSysChuky { get; set; }
        public virtual DbSet<TSysCommand> TSysCommand { get; set; }
        public virtual DbSet<TSysCommandtype> TSysCommandtype { get; set; }
        public virtual DbSet<TSysCtcdkt> TSysCtcdkt { get; set; }
        public virtual DbSet<TSysCtcdkt48> TSysCtcdkt48 { get; set; }
        public virtual DbSet<TSysCtkqkd> TSysCtkqkd { get; set; }
        public virtual DbSet<TSysCtkqkd48> TSysCtkqkd48 { get; set; }
        public virtual DbSet<TSysCtkqkdMw> TSysCtkqkdMw { get; set; }
        public virtual DbSet<TSysCtkqkdphan2> TSysCtkqkdphan2 { get; set; }
        public virtual DbSet<TSysCtkqkdphan3> TSysCtkqkdphan3 { get; set; }
        public virtual DbSet<TSysCtlcgt> TSysCtlcgt { get; set; }
        public virtual DbSet<TSysCtlctt> TSysCtlctt { get; set; }
        public virtual DbSet<TSysCusMerg> TSysCusMerg { get; set; }
        public virtual DbSet<TSysDeletelog> TSysDeletelog { get; set; }
        public virtual DbSet<TSysDeletelogtype> TSysDeletelogtype { get; set; }
        public virtual DbSet<TSysDictionary> TSysDictionary { get; set; }
        public virtual DbSet<TSysDonggoi> TSysDonggoi { get; set; }
        public virtual DbSet<TSysDynamicReportField> TSysDynamicReportField { get; set; }
        public virtual DbSet<TSysDynamicReportTemplate> TSysDynamicReportTemplate { get; set; }
        public virtual DbSet<TSysFile> TSysFile { get; set; }
        public virtual DbSet<TSysFormgrid> TSysFormgrid { get; set; }
        public virtual DbSet<TSysFormproperty> TSysFormproperty { get; set; }
        public virtual DbSet<TSysFormpropertycode> TSysFormpropertycode { get; set; }
        public virtual DbSet<TSysFormpropertyrep> TSysFormpropertyrep { get; set; }
        public virtual DbSet<TSysHnChitieu> TSysHnChitieu { get; set; }
        public virtual DbSet<TSysHnChitieuct> TSysHnChitieuct { get; set; }
        public virtual DbSet<TSysKetchuyenchitiet> TSysKetchuyenchitiet { get; set; }
        public virtual DbSet<TSysKhoasoketchyen> TSysKhoasoketchyen { get; set; }
        public virtual DbSet<TSysList> TSysList { get; set; }
        public virtual DbSet<TSysListdetail> TSysListdetail { get; set; }
        public virtual DbSet<TSysMessage> TSysMessage { get; set; }
        public virtual DbSet<TSysNguoncc> TSysNguoncc { get; set; }
        public virtual DbSet<TSysNhomketchuyen> TSysNhomketchuyen { get; set; }
        public virtual DbSet<TSysNhomketchuyenct> TSysNhomketchuyenct { get; set; }
        public virtual DbSet<TSysNotification> TSysNotification { get; set; }
        public virtual DbSet<TSysNotificationConfig> TSysNotificationConfig { get; set; }
        public virtual DbSet<TSysNotificationType> TSysNotificationType { get; set; }
        public virtual DbSet<TSysPhamvikhuyenmai> TSysPhamvikhuyenmai { get; set; }
        public virtual DbSet<TSysPhanbochitiet> TSysPhanbochitiet { get; set; }
        public virtual DbSet<TSysPpkhtscd> TSysPpkhtscd { get; set; }
        public virtual DbSet<TSysReplicationconfig> TSysReplicationconfig { get; set; }
        public virtual DbSet<TSysReplicationlog> TSysReplicationlog { get; set; }
        public virtual DbSet<TSysReplicationtable> TSysReplicationtable { get; set; }
        public virtual DbSet<TSysReport> TSysReport { get; set; }
        public virtual DbSet<TSysReportKh> TSysReportKh { get; set; }
        public virtual DbSet<TSysReportchart> TSysReportchart { get; set; }
        public virtual DbSet<TSysReportcolprop> TSysReportcolprop { get; set; }
        public virtual DbSet<TSysReportcondition> TSysReportcondition { get; set; }
        public virtual DbSet<TSysReportdetailcolprop> TSysReportdetailcolprop { get; set; }
        public virtual DbSet<TSysReportdetailpara> TSysReportdetailpara { get; set; }
        public virtual DbSet<TSysReportfield> TSysReportfield { get; set; }
        public virtual DbSet<TSysReportpara> TSysReportpara { get; set; }
        public virtual DbSet<TSysReportrelation> TSysReportrelation { get; set; }
        public virtual DbSet<TSysReporttable> TSysReporttable { get; set; }
        public virtual DbSet<TSysRestorelog> TSysRestorelog { get; set; }
        public virtual DbSet<TSysScheduletype> TSysScheduletype { get; set; }
        public virtual DbSet<TSysThuyetminhbctc1> TSysThuyetminhbctc1 { get; set; }
        public virtual DbSet<TSysThuyetminhbctc10> TSysThuyetminhbctc10 { get; set; }
        public virtual DbSet<TSysThuyetminhbctc11> TSysThuyetminhbctc11 { get; set; }
        public virtual DbSet<TSysThuyetminhbctc12> TSysThuyetminhbctc12 { get; set; }
        public virtual DbSet<TSysThuyetminhbctc2> TSysThuyetminhbctc2 { get; set; }
        public virtual DbSet<TSysThuyetminhbctc3> TSysThuyetminhbctc3 { get; set; }
        public virtual DbSet<TSysThuyetminhbctc4> TSysThuyetminhbctc4 { get; set; }
        public virtual DbSet<TSysThuyetminhbctc5> TSysThuyetminhbctc5 { get; set; }
        public virtual DbSet<TSysThuyetminhbctc6> TSysThuyetminhbctc6 { get; set; }
        public virtual DbSet<TSysThuyetminhbctc7> TSysThuyetminhbctc7 { get; set; }
        public virtual DbSet<TSysThuyetminhbctc8> TSysThuyetminhbctc8 { get; set; }
        public virtual DbSet<TSysThuyetminhbctc9> TSysThuyetminhbctc9 { get; set; }
        public virtual DbSet<TSysTieuthucpb> TSysTieuthucpb { get; set; }
        public virtual DbSet<TSysTmbctc> TSysTmbctc { get; set; }
        public virtual DbSet<TSysTmbctc48> TSysTmbctc48 { get; set; }
        public virtual DbSet<TSysUserconnecting> TSysUserconnecting { get; set; }
        public virtual DbSet<TSysUserlog> TSysUserlog { get; set; }
        public virtual DbSet<TSysView> TSysView { get; set; }
        public virtual DbSet<TTgkiemtra> TTgkiemtra { get; set; }
        public virtual DbSet<TTsht> TTsht { get; set; }
        public virtual DbSet<TTurTourchiphi> TTurTourchiphi { get; set; }
        public virtual DbSet<TTurYeucauChiphikhac> TTurYeucauChiphikhac { get; set; }
        public virtual DbSet<TUserMessageStatus> TUserMessageStatus { get; set; }
        public virtual DbSet<TWcfnrelation> TWcfnrelation { get; set; }
        public virtual DbSet<TXntc> TXntc { get; set; }
        public virtual DbSet<TXntcDtcp> TXntcDtcp { get; set; }
        public virtual DbSet<TXntcSerial> TXntcSerial { get; set; }
        public virtual DbSet<TXntcVthh> TXntcVthh { get; set; }
        public virtual DbSet<TXntcVuviec> TXntcVuviec { get; set; }
        public virtual DbSet<TXntcdichdanh> TXntcdichdanh { get; set; }
        public virtual DbSet<TXntclichtt> TXntclichtt { get; set; }
        public virtual DbSet<TXntcorder> TXntcorder { get; set; }
        public virtual DbSet<TYeucaumuahang> TYeucaumuahang { get; set; }
        public virtual DbSet<TYeucaumuahangct> TYeucaumuahangct { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
        public virtual DbSet<VBaocaosx> VBaocaosx { get; set; }
        public virtual DbSet<VBom> VBom { get; set; }
        public virtual DbSet<VChiPhiNvl> VChiPhiNvl { get; set; }
        public virtual DbSet<VChiPhiNvlDc> VChiPhiNvlDc { get; set; }
        public virtual DbSet<VChiphi622> VChiphi622 { get; set; }
        public virtual DbSet<VChiphi627> VChiphi627 { get; set; }
        public virtual DbSet<VChiphi627Phanxuong> VChiphi627Phanxuong { get; set; }
        public virtual DbSet<VCpodata> VCpodata { get; set; }
        public virtual DbSet<VCpodataedit> VCpodataedit { get; set; }
        public virtual DbSet<VCposchedule> VCposchedule { get; set; }
        public virtual DbSet<VDmKh> VDmKh { get; set; }
        public virtual DbSet<VDmKhgiaodich> VDmKhgiaodich { get; set; }
        public virtual DbSet<VDmKho> VDmKho { get; set; }
        public virtual DbSet<VDmNhomkh2> VDmNhomkh2 { get; set; }
        public virtual DbSet<VDmNhomkh3> VDmNhomkh3 { get; set; }
        public virtual DbSet<VDmNhomvattu2> VDmNhomvattu2 { get; set; }
        public virtual DbSet<VDmNhomvattu3> VDmNhomvattu3 { get; set; }
        public virtual DbSet<VDmTaikhoan> VDmTaikhoan { get; set; }
        public virtual DbSet<VDoituongPhanBoLaiCpVl> VDoituongPhanBoLaiCpVl { get; set; }
        public virtual DbSet<VDondathang> VDondathang { get; set; }
        public virtual DbSet<VDondathang2> VDondathang2 { get; set; }
        public virtual DbSet<VDubao> VDubao { get; set; }
        public virtual DbSet<VDubaots> VDubaots { get; set; }
        public virtual DbSet<VDubaotsdata> VDubaotsdata { get; set; }
        public virtual DbSet<VLsx> VLsx { get; set; }
        public virtual DbSet<VPhanBoCp627PhanXuongPvc> VPhanBoCp627PhanXuongPvc { get; set; }
        public virtual DbSet<VPhanBoCp627PhanXuongXlpe> VPhanBoCp627PhanXuongXlpe { get; set; }
        public virtual DbSet<VPhanBoKhongPhanxuong> VPhanBoKhongPhanxuong { get; set; }
        public virtual DbSet<VPhanBoKhongPhanxuong622> VPhanBoKhongPhanxuong622 { get; set; }
        public virtual DbSet<VPheduyetlsx> VPheduyetlsx { get; set; }
        public virtual DbSet<VRouting> VRouting { get; set; }
        public virtual DbSet<VSanPhamHoanThanh> VSanPhamHoanThanh { get; set; }
        public virtual DbSet<VSanPhamHoanThanhPhanxuong> VSanPhamHoanThanhPhanxuong { get; set; }
        public virtual DbSet<VSelectfunction> VSelectfunction { get; set; }
        public virtual DbSet<VSelectmakeitem> VSelectmakeitem { get; set; }
        public virtual DbSet<VSlip> VSlip { get; set; }
        public virtual DbSet<VSpHoanthanhVaRecycle> VSpHoanthanhVaRecycle { get; set; }
        public virtual DbSet<VTyLePhanBoCp> VTyLePhanBoCp { get; set; }
        public virtual DbSet<VVitriAll> VVitriAll { get; set; }
        public virtual DbSet<VVthh> VVthh { get; set; }
        public virtual DbSet<VVthhlaborexpense> VVthhlaborexpense { get; set; }
        public virtual DbSet<VVthhmachineexpense> VVthhmachineexpense { get; set; }
        public virtual DbSet<VVthhmaterialexpense> VVthhmaterialexpense { get; set; }
        public virtual DbSet<VVthhstdcost> VVthhstdcost { get; set; }
        public virtual DbSet<VXntc> VXntc { get; set; }
        public virtual DbSet<VXntccn> VXntccn { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-BE568U6\\SQLEXPRESS01;Initial Catalog=Cafe1;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dtcp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DTCP");

                entity.Property(e => e.CMa)
                    .HasColumnName("C_MA")
                    .HasMaxLength(255);

                entity.Property(e => e.CTen)
                    .HasColumnName("C_TEN")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TBanggiathanh>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_BANGGIATHANH");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CNguyenkhai).HasColumnName("C_NGUYENKHAI");

                entity.Property(e => e.CPsno)
                    .HasColumnName("C_PSNO")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CPsno2)
                    .HasColumnName("C_PSNO2")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CSoluong)
                    .HasColumnName("C_SOLUONG")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTungay)
                    .HasColumnName("C_TUNGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkDvt).HasColumnName("FK_DVT");

                entity.Property(e => e.FkKmp).HasColumnName("FK_KMP");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");

                entity.Property(e => e.FkTkco)
                    .HasColumnName("FK_TKCO")
                    .HasMaxLength(12);

                entity.Property(e => e.FkTkno)
                    .HasColumnName("FK_TKNO")
                    .HasMaxLength(12);

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.FkVuviec).HasColumnName("FK_VUVIEC");
            });

            modelBuilder.Entity<TBanggiathanhDtcp>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_BANGGIATHANH_DTCP");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CTungay)
                    .HasColumnName("C_TUNGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CTyle)
                    .HasColumnName("C_TYLE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");
            });

            modelBuilder.Entity<TBangketquaGiathanhct>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_BANGKETQUA_GIATHANHCT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDodangDauky).HasColumnName("C_DODANG_DAUKY");

                entity.Property(e => e.CGiatri)
                    .HasColumnName("C_GIATRI")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.CNgay)
                    .HasColumnName("C_NGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CSpPhu).HasColumnName("C_SP_PHU");

                entity.Property(e => e.FkCostCenter).HasColumnName("FK_CostCenter");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");

                entity.Property(e => e.FkTaikhoan)
                    .HasColumnName("FK_TAIKHOAN")
                    .HasMaxLength(15);

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<TBangketquaPhanbo>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_BANGKETQUA_PHANBO");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCongDoanTruoc)
                    .HasColumnName("C_CongDoanTruoc")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.CDauKy)
                    .HasColumnName("C_DauKy")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.CDoDang)
                    .HasColumnName("C_DoDang")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.CDoDangDauCd)
                    .HasColumnName("C_DoDangDauCD")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.CNgay)
                    .HasColumnName("C_NGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CSoLuongSx)
                    .HasColumnName("C_SoLuongSX")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.CSoluongTp)
                    .HasColumnName("C_SoluongTP")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.CTrongKy)
                    .HasColumnName("C_TrongKy")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.FkCostCenter).HasColumnName("FK_CostCenter");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkKmp).HasColumnName("FK_KMP");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");

                entity.Property(e => e.FkTaikhoan)
                    .HasColumnName("FK_TAIKHOAN")
                    .HasMaxLength(15);

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<TBangketquaPhanboct>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_BANGKETQUA_PHANBOCT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CInBom).HasColumnName("C_InBOM");

                entity.Property(e => e.CLaborTime)
                    .HasColumnName("C_LaborTime")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.CNgay)
                    .HasColumnName("C_NGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CQuantity)
                    .HasColumnName("C_Quantity")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.CSoCong)
                    .HasColumnName("C_SoCong")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.CSoluongSx)
                    .HasColumnName("C_SoluongSX")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.CSpPhu).HasColumnName("C_SP_PHU");

                entity.Property(e => e.CTongTien)
                    .HasColumnName("C_TongTien")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.FkCostCenter).HasColumnName("FK_CostCenter");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<TBangketquaTygia>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_BANGKETQUA_TYGIA");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CGiatri)
                    .HasColumnName("C_GIATRI")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.CNgay)
                    .HasColumnName("C_NGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkLoaitien).HasColumnName("FK_LOAITIEN");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");
            });

            modelBuilder.Entity<TBangphanboChiphi>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_BANGPHANBO_CHIPHI");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CGiaTri)
                    .HasColumnName("C_GiaTri")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.CNgay)
                    .HasColumnName("C_NGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CSpPhu).HasColumnName("C_SP_PHU");

                entity.Property(e => e.FkCostCenter).HasColumnName("FK_CostCenter");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkFromCostCenter).HasColumnName("FK_FromCostCenter");

                entity.Property(e => e.FkKmp).HasColumnName("FK_KMP");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");

                entity.Property(e => e.FkTaikhoan)
                    .HasColumnName("FK_TAIKHOAN")
                    .HasMaxLength(15);

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");
            });

            modelBuilder.Entity<TBangphanboChiphiTt>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_BANGPHANBO_CHIPHI_TT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CGiaTri)
                    .HasColumnName("C_GiaTri")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.CNgay)
                    .HasColumnName("C_NGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CSpPhu).HasColumnName("C_SP_PHU");

                entity.Property(e => e.FkCostCenter).HasColumnName("FK_CostCenter");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkFromCostCenter).HasColumnName("FK_FromCostCenter");

                entity.Property(e => e.FkKmp).HasColumnName("FK_KMP");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");

                entity.Property(e => e.FkTaikhoan)
                    .HasColumnName("FK_TAIKHOAN")
                    .HasMaxLength(15);

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");
            });

            modelBuilder.Entity<TBaocaosx>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_BAOCAOSX");

                entity.HasIndex(e => e.CNgaylap)
                    .HasName("IX_T_BAOCAOSX")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(100);

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CSophieu)
                    .IsRequired()
                    .HasColumnName("C_SOPHIEU")
                    .HasMaxLength(12);

                entity.Property(e => e.FkCa).HasColumnName("FK_CA");

                entity.Property(e => e.FkChucnang).HasColumnName("FK_CHUCNANG");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");

                entity.Property(e => e.FkTotruong).HasColumnName("FK_TOTRUONG");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");
            });

            modelBuilder.Entity<TBaocaosxct>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_BAOCAOSXCT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDengio)
                    .HasColumnName("C_DENGIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CThoigian).HasColumnName("C_THOIGIAN");

                entity.Property(e => e.CTugio)
                    .HasColumnName("C_TUGIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FkBaocaosx).HasColumnName("FK_BAOCAOSX");

                entity.Property(e => e.FkBaocaosxlydo).HasColumnName("FK_BAOCAOSXLYDO");
            });

            modelBuilder.Entity<TBaocaosxlydo>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_BAOCAOSXLYDO");

                entity.HasIndex(e => e.CMa)
                    .HasName("IX_T_BAOCAOSXLYDO")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.CXoa).HasColumnName("C_XOA");
            });

            modelBuilder.Entity<TCa>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_CA");

                entity.HasIndex(e => new { e.PkId, e.CMa })
                    .HasName("IX_T_CA")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDen01)
                    .HasColumnName("C_DEN01")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CDen02)
                    .HasColumnName("C_DEN02")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CDen03)
                    .HasColumnName("C_DEN03")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CDen04)
                    .HasColumnName("C_DEN04")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CDen05)
                    .HasColumnName("C_DEN05")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(50);

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(10);

                entity.Property(e => e.CThoigian).HasColumnName("C_THOIGIAN");

                entity.Property(e => e.CTu01)
                    .HasColumnName("C_TU01")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CTu02)
                    .HasColumnName("C_TU02")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CTu03)
                    .HasColumnName("C_TU03")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CTu04)
                    .HasColumnName("C_TU04")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CTu05)
                    .HasColumnName("C_TU05")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TCanGiaCcs>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_CAN_GIA_CCS");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CConggia)
                    .HasColumnName("C_CONGGIA")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CGia)
                    .HasColumnName("C_GIA")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CMota)
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(250);

                entity.Property(e => e.CMucduoi)
                    .HasColumnName("C_MUCDUOI")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CMuctren)
                    .HasColumnName("C_MUCTREN")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CNguon).HasColumnName("C_NGUON");

                entity.Property(e => e.CTile)
                    .HasColumnName("C_TILE")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CToithieu)
                    .HasColumnName("C_TOITHIEU")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.FkKh).HasColumnName("FK_KH");
            });

            modelBuilder.Entity<TCpobeginqty>(entity =>
            {
                entity.HasKey(e => new { e.FkMrpoption, e.FkVthh });

                entity.ToTable("T_CPOBEGINQTY");

                entity.Property(e => e.FkMrpoption).HasColumnName("FK_MRPOPTION");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.CSltondau)
                    .HasColumnName("C_SLTONDAU")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TCpocapacity>(entity =>
            {
                entity.HasKey(e => new { e.FkMrpoption, e.FkPhanxuong, e.CNgay, e.FkCa, e.CTugio, e.CDengio });

                entity.ToTable("T_CPOCAPACITY");

                entity.Property(e => e.FkMrpoption).HasColumnName("FK_MRPOPTION");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");

                entity.Property(e => e.CNgay)
                    .HasColumnName("C_NGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FkCa).HasColumnName("FK_CA");

                entity.Property(e => e.CTugio)
                    .HasColumnName("C_TUGIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CDengio)
                    .HasColumnName("C_DENGIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CConlai)
                    .HasColumnName("C_CONLAI")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CDadung)
                    .HasColumnName("C_DADUNG")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CHieusuat)
                    .HasColumnName("C_HIEUSUAT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CLoainangluc)
                    .HasColumnName("C_LOAINANGLUC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CNangluc)
                    .HasColumnName("C_NANGLUC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CNghi)
                    .IsRequired()
                    .HasColumnName("C_NGHI")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CSlmay)
                    .HasColumnName("C_SLMAY")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CSlnguoi)
                    .HasColumnName("C_SLNGUOI")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FkDvt).HasColumnName("FK_DVT");
            });

            modelBuilder.Entity<TCpodata>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_CPODATA");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CConvert).HasColumnName("C_CONVERT");

                entity.Property(e => e.CNgaybd)
                    .HasColumnName("C_NGAYBD")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CNgaynhan)
                    .HasColumnName("C_NGAYNHAN")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CSlconthieu).HasColumnName("C_SLCONTHIEU");

                entity.Property(e => e.CSlcungcap).HasColumnName("C_SLCUNGCAP");

                entity.Property(e => e.CSldalap).HasColumnName("C_SLDALAP");

                entity.Property(e => e.CSlyeucau).HasColumnName("C_SLYEUCAU");

                entity.Property(e => e.FkCpo).HasColumnName("FK_CPO");

                entity.Property(e => e.FkDondathangct).HasColumnName("FK_DONDATHANGCT");

                entity.Property(e => e.FkGiaydathang).HasColumnName("FK_GIAYDATHANG");

                entity.Property(e => e.FkLsxct).HasColumnName("FK_LSXCT");

                entity.Property(e => e.FkMrpoption).HasColumnName("FK_MRPOPTION");

                entity.Property(e => e.FkNguon).HasColumnName("FK_NGUON");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<TCposchedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_CPOSCHEDULE");

                entity.Property(e => e.CConvert)
                    .IsRequired()
                    .HasColumnName("C_CONVERT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CDengio)
                    .HasColumnName("C_DENGIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CNgay)
                    .HasColumnName("C_NGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CSoluong).HasColumnName("C_SOLUONG");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.CTugio)
                    .HasColumnName("C_TUGIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FkCa).HasColumnName("FK_CA");

                entity.Property(e => e.FkChucnang).HasColumnName("FK_CHUCNANG");

                entity.Property(e => e.FkCpodata).HasColumnName("FK_CPODATA");

                entity.Property(e => e.FkGiaydathang).HasColumnName("FK_GIAYDATHANG");

                entity.Property(e => e.FkLsx).HasColumnName("FK_LSX");

                entity.Property(e => e.FkMrpoption).HasColumnName("FK_MRPOPTION");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");
            });

            modelBuilder.Entity<TCposupply>(entity =>
            {
                entity.HasKey(e => new { e.FkMrpoption, e.CNgay, e.FkVthh });

                entity.ToTable("T_CPOSUPPLY");

                entity.Property(e => e.FkMrpoption).HasColumnName("FK_MRPOPTION");

                entity.Property(e => e.CNgay)
                    .HasColumnName("C_NGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.CSoluong).HasColumnName("C_SOLUONG");

                entity.Property(e => e.FkNguon).HasColumnName("FK_NGUON");
            });

            modelBuilder.Entity<TDmBpsd>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_BPSD__619B8048");

                entity.ToTable("T_DM_BPSD");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_BPSD_Index");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TDmChucnang>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_CHUCNANG__656C112C");

                entity.ToTable("T_DM_CHUCNANG");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_CHUCNANG_Index")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("UQ__T_DM_CHUCNANG__66603565")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMinruntime).HasColumnName("C_MINRUNTIME");

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TDmChucnangtgcb>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_CHUCNANGTGCB");

                entity.HasIndex(e => new { e.FkPhanxuong, e.FkChucnang, e.FkTrangthai, e.FkVthh })
                    .HasName("IX_T_DM_CHUCNANGTGCB")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CThoigian).HasColumnName("C_THOIGIAN");

                entity.Property(e => e.FkChucnang).HasColumnName("FK_CHUCNANG");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");

                entity.Property(e => e.FkTrangthai).HasColumnName("FK_TRANGTHAI");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<TDmChucnangtt>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_CHUCNANGTT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TDmChungtu>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_CHUNGTU");

                entity.HasIndex(e => e.CMa)
                    .HasName("IX_T_DM_CHUNGTU")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CAnotherentry)
                    .HasColumnName("C_ANOTHERENTRY")
                    .HasColumnType("ntext");

                entity.Property(e => e.CButtoanthem).HasColumnName("C_BUTTOANTHEM");

                entity.Property(e => e.CCheckPrice).HasColumnName("C_CheckPrice");

                entity.Property(e => e.CCheckquantity)
                    .HasColumnName("C_CHECKQUANTITY")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CControls)
                    .HasColumnName("C_CONTROLS")
                    .HasColumnType("ntext");

                entity.Property(e => e.CCtthuchi).HasColumnName("C_CTTHUCHI");

                entity.Property(e => e.CCustomization)
                    .HasColumnName("C_CUSTOMIZATION")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CDautkco)
                    .HasColumnName("C_DAUTKCO")
                    .HasMaxLength(10);

                entity.Property(e => e.CDautkno)
                    .HasColumnName("C_DAUTKNO")
                    .HasMaxLength(10);

                entity.Property(e => e.CDautkthue)
                    .HasColumnName("C_DAUTKTHUE")
                    .HasMaxLength(10);

                entity.Property(e => e.CDefault).HasColumnName("C_DEFAULT");

                entity.Property(e => e.CDescription)
                    .HasColumnName("C_DESCRIPTION")
                    .HasMaxLength(200);

                entity.Property(e => e.CDescriptionen)
                    .HasColumnName("C_DESCRIPTIONEN")
                    .HasMaxLength(200);

                entity.Property(e => e.CExchangerate)
                    .HasColumnName("C_EXCHANGERATE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CField1)
                    .HasColumnName("C_FIELD1")
                    .HasMaxLength(20);

                entity.Property(e => e.CField2)
                    .HasColumnName("C_FIELD2")
                    .HasMaxLength(20);

                entity.Property(e => e.CFulllen)
                    .HasColumnName("C_FULLLEN")
                    .HasDefaultValueSql("(12)");

                entity.Property(e => e.CGiavon).HasColumnName("C_GIAVON");

                entity.Property(e => e.CGridcolumns)
                    .HasColumnName("C_GRIDCOLUMNS")
                    .HasColumnType("ntext");

                entity.Property(e => e.CInsauluu).HasColumnName("C_INSAULUU");

                entity.Property(e => e.CLastexport)
                    .HasColumnName("C_LASTEXPORT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CLoaibt).HasColumnName("C_LOAIBT");

                entity.Property(e => e.CLoaict).HasColumnName("C_LOAICT");

                entity.Property(e => e.CLoaixn).HasColumnName("C_LOAIXN");

                entity.Property(e => e.CLopsided)
                    .HasColumnName("C_LOPSIDED")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CMa)
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMonth).HasColumnName("C_MONTH");

                entity.Property(e => e.CMonth2)
                    .HasColumnName("C_MONTH2")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CPrefix)
                    .HasColumnName("C_PREFIX")
                    .HasMaxLength(5);

                entity.Property(e => e.CPriceincludedtax)
                    .HasColumnName("C_PRICEINCLUDEDTAX")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CPromotion)
                    .HasColumnName("C_PROMOTION")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CRead)
                    .HasColumnName("C_READ")
                    .HasMaxLength(255);

                entity.Property(e => e.CRootId).HasColumnName("C_RootID");

                entity.Property(e => e.CSeparator)
                    .HasColumnName("C_SEPARATOR")
                    .HasMaxLength(1);

                entity.Property(e => e.CSmart).HasColumnName("C_SMART");

                entity.Property(e => e.CSobanin)
                    .HasColumnName("C_SOBANIN")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CStore)
                    .HasColumnName("C_STORE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.CTen)
                    .HasColumnName("C_TEN")
                    .HasMaxLength(100);

                entity.Property(e => e.CTenen)
                    .HasColumnName("C_TENEN")
                    .HasMaxLength(100);

                entity.Property(e => e.CTkgiavonco)
                    .HasColumnName("C_TKGIAVONCO")
                    .HasMaxLength(50);

                entity.Property(e => e.CTkgiavonno)
                    .HasColumnName("C_TKGIAVONNO")
                    .HasMaxLength(50);

                entity.Property(e => e.CUpdateLog)
                    .HasColumnName("C_UpdateLog")
                    .HasMaxLength(100);

                entity.Property(e => e.CVat).HasColumnName("C_VAT");

                entity.Property(e => e.CVisible)
                    .HasColumnName("C_VISIBLE")
                    .HasMaxLength(255);

                entity.Property(e => e.CVuviec).HasColumnName("C_VUVIEC");

                entity.Property(e => e.CWrite)
                    .HasColumnName("C_WRITE")
                    .HasMaxLength(255);

                entity.Property(e => e.CYear).HasColumnName("C_YEAR");

                entity.Property(e => e.CYear2)
                    .HasColumnName("C_YEAR2")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CYearlen)
                    .HasColumnName("C_YEARLEN")
                    .HasDefaultValueSql("(4)");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkDvtt).HasColumnName("FK_DVTT");

                entity.Property(e => e.FkKenhap).HasColumnName("FK_KENHAP");

                entity.Property(e => e.FkKetoan).HasColumnName("FK_KETOAN");

                entity.Property(e => e.FkKexuat).HasColumnName("FK_KEXUAT");

                entity.Property(e => e.FkKhoanmuc).HasColumnName("FK_KHOANMUC");

                entity.Property(e => e.FkKhonhap).HasColumnName("FK_KHONHAP");

                entity.Property(e => e.FkKhoxuat).HasColumnName("FK_KHOXUAT");

                entity.Property(e => e.FkKttruong).HasColumnName("FK_KTTRUONG");

                entity.Property(e => e.FkLoaihoadon).HasColumnName("FK_LOAIHOADON");

                entity.Property(e => e.FkNguoigiao).HasColumnName("FK_NGUOIGIAO");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");

                entity.Property(e => e.FkThukho).HasColumnName("FK_THUKHO");

                entity.Property(e => e.FkThuquy).HasColumnName("FK_THUQUY");

                entity.Property(e => e.FkThutruong).HasColumnName("FK_THUTRUONG");

                entity.Property(e => e.FkTiente).HasColumnName("FK_TIENTE");

                entity.Property(e => e.FkTkc)
                    .HasColumnName("FK_TKC")
                    .HasMaxLength(12);

                entity.Property(e => e.FkTkn)
                    .HasColumnName("FK_TKN")
                    .HasMaxLength(12);

                entity.Property(e => e.FkTkthue)
                    .HasColumnName("FK_TKTHUE")
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<TDmChungtuphieuin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_DM_CHUNGTUPHIEUIN");

                entity.Property(e => e.CDefault).HasColumnName("C_DEFAULT");

                entity.Property(e => e.CDescription)
                    .HasColumnName("C_DESCRIPTION")
                    .HasMaxLength(150);

                entity.Property(e => e.CFilename)
                    .HasColumnName("C_FILENAME")
                    .HasMaxLength(50);

                entity.Property(e => e.CPageSize)
                    .HasColumnName("C_PAGE_SIZE")
                    .HasMaxLength(100);

                entity.Property(e => e.CPortrait).HasColumnName("C_Portrait");

                entity.Property(e => e.CPrinterName)
                    .HasColumnName("C_PRINTER_NAME")
                    .HasMaxLength(150);

                entity.Property(e => e.FkChungtu).HasColumnName("FK_CHUNGTU");
            });

            modelBuilder.Entity<TDmCompara>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_COMPARA");

                entity.HasIndex(e => new { e.FkKhachhang, e.FkNhomvattu, e.FkVthh, e.CFromDate })
                    .HasName("IX_T_DM_COMPARA")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCom1)
                    .HasColumnName("C_Com1")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CCom2)
                    .HasColumnName("C_Com2")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CCom3)
                    .HasColumnName("C_Com3")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CCom4)
                    .HasColumnName("C_Com4")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CCom5)
                    .HasColumnName("C_Com5")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CFrom1)
                    .HasColumnName("C_From1")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CFrom2)
                    .HasColumnName("C_From2")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CFrom3)
                    .HasColumnName("C_From3")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CFrom4)
                    .HasColumnName("C_From4")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CFrom5)
                    .HasColumnName("C_From5")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CFromDate)
                    .HasColumnName("C_FromDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CTo1)
                    .HasColumnName("C_To1")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTo2)
                    .HasColumnName("C_To2")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTo3)
                    .HasColumnName("C_To3")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTo4)
                    .HasColumnName("C_To4")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTo5)
                    .HasColumnName("C_To5")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CToDate)
                    .HasColumnName("C_ToDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FkBonus).HasColumnName("FK_Bonus");

                entity.Property(e => e.FkConType).HasColumnName("FK_ConType");

                entity.Property(e => e.FkConValue).HasColumnName("FK_ConValue");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkKhachhang).HasColumnName("FK_KHACHHANG");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkNhomvattu).HasColumnName("FK_NHOMVATTU");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<TDmComparabonus>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_COMPARABONUS");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CEnglish)
                    .IsRequired()
                    .HasColumnName("C_ENGLISH")
                    .HasMaxLength(30);

                entity.Property(e => e.CVietnamese)
                    .IsRequired()
                    .HasColumnName("C_VIETNAMESE")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TDmComparacontype>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_COMPARACONTYPE");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CEnglish)
                    .IsRequired()
                    .HasColumnName("C_ENGLISH")
                    .HasMaxLength(30);

                entity.Property(e => e.CVietnamese)
                    .IsRequired()
                    .HasColumnName("C_VIETNAMESE")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TDmComparaconvalue>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_COMPARACONVALUE");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CEnglish)
                    .IsRequired()
                    .HasColumnName("C_ENGLISH")
                    .HasMaxLength(30);

                entity.Property(e => e.CVietnamese)
                    .IsRequired()
                    .HasColumnName("C_VIETNAMESE")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TDmCostCenter>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_CostCenter");

                entity.HasIndex(e => e.CMa)
                    .HasName("IX_T_DM_CostCenter")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CGtUti).HasColumnName("C_GT_UTI");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(20);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.CPbTong).HasColumnName("C_PB_TONG");

                entity.Property(e => e.CPrecostcenter)
                    .HasColumnName("C_PRECOSTCENTER")
                    .HasMaxLength(15);

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.CTheoKmp)
                    .HasColumnName("C_THEO_KMP")
                    .HasMaxLength(200);

                entity.Property(e => e.CTructiepsx).HasColumnName("C_TRUCTIEPSX");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");
            });

            modelBuilder.Entity<TDmCtg>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_CTG");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TDmCtkm>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_CTKM");

                entity.HasIndex(e => e.CMa)
                    .HasName("IX_T_DM_CTKM")
                    .IsUnique();

                entity.HasIndex(e => e.CTen)
                    .HasName("IX_T_DM_CTKM_1")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDenngay)
                    .HasColumnName("C_DENNGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMdut).HasColumnName("C_MDUT");

                entity.Property(e => e.CPheduyet).HasColumnName("C_PHEDUYET");

                entity.Property(e => e.CTen)
                    .IsRequired()
                    .HasColumnName("C_TEN")
                    .HasMaxLength(100);

                entity.Property(e => e.CTungay)
                    .HasColumnName("C_TUNGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TDmCtkmct>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_CTKMCT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CAndor).HasColumnName("C_ANDOR");

                entity.Property(e => e.CButtoan)
                    .HasColumnName("C_BUTTOAN")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CDoanhthu)
                    .HasColumnName("C_DOANHTHU")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CDoanhthu2)
                    .HasColumnName("C_DOANHTHU2")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CSoluong)
                    .HasColumnName("C_SOLUONG")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CSoluong2)
                    .HasColumnName("C_SOLUONG2")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FkCtkm).HasColumnName("FK_CTKM");

                entity.Property(e => e.FkDvt).HasColumnName("FK_DVT");

                entity.Property(e => e.FkDvt2).HasColumnName("FK_DVT2");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.FkVthh2).HasColumnName("FK_VTHH2");
            });

            modelBuilder.Entity<TDmCtkmvung>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_CTKMVUNG");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.FkCtkm).HasColumnName("FK_CTKM");

                entity.Property(e => e.FkVung).HasColumnName("FK_VUNG");
            });

            modelBuilder.Entity<TDmCuocvanchuyenct>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_CUOCVANCHUYENCT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDenngay)
                    .HasColumnName("C_DENNGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CGiacuoc).HasColumnName("C_GIACUOC");

                entity.Property(e => e.CTungay)
                    .HasColumnName("C_TUNGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FkHangvanchuyen).HasColumnName("FK_HANGVANCHUYEN");

                entity.Property(e => e.FkKhdiachi).HasColumnName("FK_KHDIACHI");

                entity.Property(e => e.FkLoaixe).HasColumnName("FK_LOAIXE");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<TDmDkbg>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_DKBG__693CA210");

                entity.ToTable("T_DM_DKBG");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_DKBG_Index")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("UQ__T_DM_DKBG__6A30C649")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.CXoa).HasColumnName("C_XOA");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TDmDktt>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_DKTT__6D0D32F4");

                entity.ToTable("T_DM_DKTT");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_DKTT_Index")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("UQ__T_DM_DKTT__6E01572D")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TDmDtcp>(entity =>
            {
                entity.HasKey(e => e.CMa);

                entity.ToTable("T_DM_DTCP");

                entity.Property(e => e.CMa)
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CAn).HasColumnName("C_AN");

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CCapsp)
                    .HasColumnName("C_CAPSP")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CDoanhthu)
                    .HasColumnName("C_DOANHTHU")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CDoanhthuUsd)
                    .HasColumnName("C_DOANHTHU_USD")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CDoanhthuUsdVat)
                    .HasColumnName("C_DOANHTHU_USD_VAT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CDoanhthuVat)
                    .HasColumnName("C_DOANHTHU_VAT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CLastexport)
                    .HasColumnName("C_LASTEXPORT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CNhomdtcp).HasColumnName("C_NHOMDTCP");

                entity.Property(e => e.CTen)
                    .IsRequired()
                    .HasColumnName("C_TEN")
                    .HasMaxLength(100);

                entity.Property(e => e.CValueUsd)
                    .HasColumnName("C_VALUE_USD")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CValueUsdVat)
                    .HasColumnName("C_VALUE_USD_VAT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CValueVat)
                    .HasColumnName("C_VALUE_VAT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkDvt).HasColumnName("FK_DVT");

                entity.Property(e => e.FkNhomvattu).HasColumnName("FK_NHOMVATTU");

                entity.Property(e => e.FkTkno)
                    .HasColumnName("FK_TKNO")
                    .HasMaxLength(12);

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TDmDtcpthoigian>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_DM_DTCPTHOIGIAN");

                entity.Property(e => e.CCat1)
                    .HasColumnName("C_Cat1")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CCat2)
                    .HasColumnName("C_Cat2")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CCat3)
                    .HasColumnName("C_Cat3")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CCat4)
                    .HasColumnName("C_Cat4")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CCat5)
                    .HasColumnName("C_Cat5")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CCat6)
                    .HasColumnName("C_Cat6")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CCat7)
                    .HasColumnName("C_Cat7")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CDate)
                    .HasColumnName("C_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkProstatus).HasColumnName("FK_PROSTATUS");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TDmDvcs>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_DVCS__70DDC3D8");

                entity.ToTable("T_DM_DVCS");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_DVCS_Index")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("UQ__T_DM_DVCS__71D1E811")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDefault).HasColumnName("C_DEFAULT");

                entity.Property(e => e.CDiachi)
                    .HasColumnName("C_DIACHI")
                    .HasMaxLength(255);

                entity.Property(e => e.CDienthoai)
                    .HasColumnName("C_DIENTHOAI")
                    .HasMaxLength(25);

                entity.Property(e => e.CEmail)
                    .HasColumnName("C_EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.CFax)
                    .HasColumnName("C_FAX")
                    .HasMaxLength(25);

                entity.Property(e => e.CGiamdoc)
                    .HasColumnName("C_GIAMDOC")
                    .HasMaxLength(50);

                entity.Property(e => e.CKetoantruong)
                    .HasColumnName("C_KETOANTRUONG")
                    .HasMaxLength(50);

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(255);

                entity.Property(e => e.CMst)
                    .HasColumnName("C_MST")
                    .HasMaxLength(30);

                entity.Property(e => e.CTaikhoan)
                    .HasColumnName("C_TAIKHOAN")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TDmDvcsThem>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_DVCS_THEM");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CThukho)
                    .HasColumnName("C_THUKHO")
                    .HasMaxLength(35);

                entity.Property(e => e.CThuqui)
                    .HasColumnName("C_THUQUI")
                    .HasMaxLength(35);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TDmDvt>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_DVT__74AE54BC");

                entity.ToTable("T_DM_DVT");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_DVT_Index")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("UQ__T_DM_DVT__75A278F5")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CChoxoa).HasColumnName("C_CHOXOA");

                entity.Property(e => e.CLastexport)
                    .HasColumnName("C_LASTEXPORT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.CSmsUnit).HasColumnName("C_SMS_UNIT");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TDmDvtcd>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_DVTCD__787EE5A0");

                entity.ToTable("T_DM_DVTCD");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_DVTCD_Index")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("UQ__T_DM_DVTCD__797309D9")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CLastexport)
                    .HasColumnName("C_LASTEXPORT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.CTile).HasColumnName("C_TILE");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkDvra).HasColumnName("FK_DVRA");

                entity.Property(e => e.FkDvvao).HasColumnName("FK_DVVAO");
            });

            modelBuilder.Entity<TDmDvtg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_DM_DVTG");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.PkId).HasColumnName("PK_ID");
            });

            modelBuilder.Entity<TDmHoadon>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_HOADON");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDadung).HasColumnName("C_DADUNG");

                entity.Property(e => e.CDoidaiSeri).HasColumnName("C_DOIDAI_SERI");

                entity.Property(e => e.CLien1)
                    .HasColumnName("C_LIEN1")
                    .HasMaxLength(100);

                entity.Property(e => e.CLien2)
                    .HasColumnName("C_LIEN2")
                    .HasMaxLength(100);

                entity.Property(e => e.CLien3)
                    .HasColumnName("C_LIEN3")
                    .HasMaxLength(100);

                entity.Property(e => e.CLien4)
                    .HasColumnName("C_LIEN4")
                    .HasMaxLength(100);

                entity.Property(e => e.CLien5)
                    .HasColumnName("C_LIEN5")
                    .HasMaxLength(100);

                entity.Property(e => e.CMauhoadon)
                    .HasColumnName("C_MAUHOADON")
                    .HasMaxLength(10);

                entity.Property(e => e.CQuyen)
                    .HasColumnName("C_QUYEN")
                    .HasMaxLength(50);

                entity.Property(e => e.CSeriDau).HasColumnName("C_SERI_DAU");

                entity.Property(e => e.CSolienin).HasColumnName("C_SOLIENIN");

                entity.Property(e => e.CSoluong).HasColumnName("C_SOLUONG");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TDmHsx>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_HSX__7C4F7684");

                entity.ToTable("T_DM_HSX");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_HSX_Index")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("UQ__T_DM_HSX__7D439ABD")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CChoxoa).HasColumnName("C_CHOXOA");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TDmHuyen>(entity =>
            {
                entity.HasKey(e => e.CMa);

                entity.ToTable("T_DM_HUYEN");

                entity.HasIndex(e => e.CTen)
                    .HasName("IX_T_DM_HUYEN")
                    .IsUnique();

                entity.Property(e => e.CMa)
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CTen)
                    .IsRequired()
                    .HasColumnName("C_TEN")
                    .HasMaxLength(50);

                entity.Property(e => e.FkTtp).HasColumnName("FK_TTP");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TDmHvt>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_HVT__00200768");

                entity.ToTable("T_DM_HVT");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_HVT_Index")
                    .IsUnique();

                entity.HasIndex(e => e.CTen)
                    .HasName("UQ__T_DM_HVT__01142BA1")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CTen)
                    .IsRequired()
                    .HasColumnName("C_TEN")
                    .HasMaxLength(100);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TDmKehang>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_KEHANG__03F0984C");

                entity.ToTable("T_DM_KEHANG");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_KEHANG_Index")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCao).HasColumnName("C_CAO");

                entity.Property(e => e.CDai).HasColumnName("C_DAI");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.CRong).HasColumnName("C_RONG");

                entity.Property(e => e.FkDonvi).HasColumnName("FK_DONVI");

                entity.Property(e => e.FkKho).HasColumnName("FK_KHO");
            });

            modelBuilder.Entity<TDmKh>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_KH");

                entity.HasIndex(e => e.CMa)
                    .HasName("IX_T_DM_KH")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CChoxoa).HasColumnName("C_CHOXOA");

                entity.Property(e => e.CCmnd)
                    .HasColumnName("C_CMND")
                    .HasMaxLength(12);

                entity.Property(e => e.CContCleaning)
                    .HasColumnName("C_ContCleaning")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CConvert).HasColumnName("C_CONVERT");

                entity.Property(e => e.CCuoc)
                    .HasColumnName("C_CUOC")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CDiachi)
                    .HasColumnName("C_DIACHI")
                    .HasMaxLength(150);

                entity.Property(e => e.CDiachiGd)
                    .HasColumnName("C_DIACHI_GD")
                    .HasMaxLength(250);

                entity.Property(e => e.CDiachitaikhoan)
                    .HasColumnName("C_DIACHITAIKHOAN")
                    .HasMaxLength(200);

                entity.Property(e => e.CDienthoai)
                    .HasColumnName("C_DIENTHOAI")
                    .HasMaxLength(50);

                entity.Property(e => e.CEffectid).HasColumnName("C_EFFECTID");

                entity.Property(e => e.CEmail)
                    .HasColumnName("C_EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.CFax)
                    .HasColumnName("C_FAX")
                    .HasMaxLength(50);

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(2000);

                entity.Property(e => e.CGiamdoc)
                    .HasColumnName("C_GIAMDOC")
                    .HasMaxLength(50);

                entity.Property(e => e.CGiaodich)
                    .IsRequired()
                    .HasColumnName("C_GIAODICH")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CGrossweightCont20).HasColumnName("C_GrossweightCont20");

                entity.Property(e => e.CGrossweightCont40).HasColumnName("C_GrossweightCont40");

                entity.Property(e => e.CInboundDemurrage).HasColumnName("C_InboundDemurrage");

                entity.Property(e => e.CInboundHandling).HasColumnName("C_InboundHandling");

                entity.Property(e => e.CKhoangcach)
                    .HasColumnName("C_KHOANGCACH")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CKtt)
                    .HasColumnName("C_KTT")
                    .HasMaxLength(50);

                entity.Property(e => e.CLastexport)
                    .HasColumnName("C_LASTEXPORT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CMa)
                    .HasColumnName("C_MA")
                    .HasMaxLength(50);

                entity.Property(e => e.CMathang)
                    .HasColumnName("C_MATHANG")
                    .HasMaxLength(50);

                entity.Property(e => e.CMauso)
                    .HasColumnName("C_MAUSO")
                    .HasMaxLength(20);

                entity.Property(e => e.CMax)
                    .HasColumnName("C_MAX")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CMerTypeBilling)
                    .HasColumnName("C_MerTypeBilling")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CMerTypeConsignee)
                    .HasColumnName("C_MerTypeConsignee")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CMerTypeFeeder)
                    .HasColumnName("C_MerTypeFeeder")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CMerTypeForwarder)
                    .HasColumnName("C_MerTypeForwarder")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CMerTypeNotify)
                    .HasColumnName("C_MerTypeNotify")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CMerTypeOther)
                    .HasColumnName("C_MerTypeOther")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CMerTypeShipper)
                    .HasColumnName("C_MerTypeShipper")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CMerTypeSlotOwner)
                    .HasColumnName("C_MerTypeSlotOwner")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CMerTypeSubleasee)
                    .HasColumnName("C_MerTypeSubleasee")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CMst)
                    .HasColumnName("C_MST")
                    .HasMaxLength(50);

                entity.Property(e => e.CMucno)
                    .HasColumnName("C_MUCNO")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CNgayCmnd)
                    .HasColumnName("C_NGAY_CMND")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CNgayThanhLap)
                    .HasColumnName("C_NgayThanhLap")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CNgaythietlap)
                    .HasColumnName("C_NGAYTHIETLAP")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CNguoiDaiDienPhapLuat)
                    .HasColumnName("C_NguoiDaiDienPhapLuat")
                    .HasMaxLength(50);

                entity.Property(e => e.CNguoimua)
                    .IsRequired()
                    .HasColumnName("C_NGUOIMUA")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CNhacungcap)
                    .IsRequired()
                    .HasColumnName("C_NHACUNGCAP")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CNhanvien).HasColumnName("C_NHANVIEN");

                entity.Property(e => e.CNoicapCmnd)
                    .HasColumnName("C_NOICAP_CMND")
                    .HasMaxLength(50);

                entity.Property(e => e.CNote)
                    .HasColumnName("C_Note")
                    .HasMaxLength(150);

                entity.Property(e => e.COutboundDemurrage).HasColumnName("C_OutboundDemurrage");

                entity.Property(e => e.COutboundHandling).HasColumnName("C_OutboundHandling");

                entity.Property(e => e.CQtyCont20).HasColumnName("C_QtyCont20");

                entity.Property(e => e.CQtyCont40).HasColumnName("C_QtyCont40");

                entity.Property(e => e.CQtyTeus).HasColumnName("C_QtyTEUs");

                entity.Property(e => e.CSndn).HasColumnName("C_SNDN");

                entity.Property(e => e.CSoDangKyKd)
                    .HasColumnName("C_SoDangKyKD")
                    .HasMaxLength(20);

                entity.Property(e => e.CSonha)
                    .HasColumnName("C_SONHA")
                    .HasMaxLength(30);

                entity.Property(e => e.CTaikhoan)
                    .HasColumnName("C_TAIKHOAN")
                    .HasMaxLength(150);

                entity.Property(e => e.CTccn)
                    .IsRequired()
                    .HasColumnName("C_TCCN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CTen)
                    .HasColumnName("C_TEN")
                    .HasMaxLength(250);

                entity.Property(e => e.CTenTat)
                    .HasColumnName("C_TEN_TAT")
                    .HasMaxLength(250);

                entity.Property(e => e.CTenen)
                    .HasColumnName("C_TENEN")
                    .HasMaxLength(255);

                entity.Property(e => e.CTentaikhoan)
                    .HasColumnName("C_TENTAIKHOAN")
                    .HasMaxLength(200);

                entity.Property(e => e.CTieuDeThu)
                    .HasColumnName("C_TieuDeThu")
                    .HasMaxLength(150);

                entity.Property(e => e.CTongno)
                    .HasColumnName("C_TONGNO")
                    .HasColumnType("money");

                entity.Property(e => e.CTrietkhau)
                    .HasColumnName("C_TRIETKHAU")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CTvt)
                    .HasColumnName("C_TVT")
                    .HasMaxLength(50);

                entity.Property(e => e.CVonDieuLeUsd)
                    .HasColumnName("C_VonDieuLeUSD")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.CVonDieuLeVnd)
                    .HasColumnName("C_VonDieuLeVND")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.CWebsite)
                    .HasColumnName("C_WEBSITE")
                    .HasMaxLength(50);

                entity.Property(e => e.FkCommodity).HasColumnName("FK_Commodity");

                entity.Property(e => e.FkDktt).HasColumnName("FK_DKTT");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkHuyen).HasColumnName("FK_HUYEN");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkNhomkh).HasColumnName("FK_NHOMKH");

                entity.Property(e => e.FkNhomkh2).HasColumnName("FK_NHOMKH2");

                entity.Property(e => e.FkNhomkh3).HasColumnName("FK_NHOMKH3");

                entity.Property(e => e.FkPttt).HasColumnName("FK_PTTT");

                entity.Property(e => e.FkQuocgia).HasColumnName("FK_QUOCGIA");

                entity.Property(e => e.FkTaikhoan)
                    .HasColumnName("FK_TAIKHOAN")
                    .HasMaxLength(12);

                entity.Property(e => e.FkTtp).HasColumnName("FK_TTP");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVung).HasColumnName("FK_VUNG");

                entity.Property(e => e.FkXa).HasColumnName("FK_XA");

                entity.Property(e => e.FkXom).HasColumnName("FK_XOM");
            });

            modelBuilder.Entity<TDmKhDoc>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_KH_DOC");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CContent)
                    .IsRequired()
                    .HasColumnName("C_Content")
                    .HasColumnType("image");

                entity.Property(e => e.CFileName)
                    .IsRequired()
                    .HasColumnName("C_FileName")
                    .HasMaxLength(300);

                entity.Property(e => e.FkKhachHang).HasColumnName("FK_KhachHang");

                entity.HasOne(d => d.FkKhachHangNavigation)
                    .WithMany(p => p.TDmKhDoc)
                    .HasForeignKey(d => d.FkKhachHang)
                    .HasConstraintName("FK_T_DM_KH_DOC_T_DM_KH");
            });

            modelBuilder.Entity<TDmKhcuocvc>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK_T_DM_KHCUOCVANCHUYEN");

                entity.ToTable("T_DM_KHCUOCVC");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CGiacuoc).HasColumnName("C_GIACUOC");

                entity.Property(e => e.CHieuluc)
                    .HasColumnName("C_HIEULUC")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CTrongluong).HasColumnName("C_TRONGLUONG");

                entity.Property(e => e.FkKhdiachi).HasColumnName("FK_KHDIACHI");
            });

            modelBuilder.Entity<TDmKhdanhgia>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_KHDANHGIA");

                entity.HasIndex(e => e.CMa)
                    .HasName("IX_T_DM_KHDANHGIA")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("IX_T_DM_KHDANHGIA_1")
                    .IsUnique();

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(20);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");
            });

            modelBuilder.Entity<TDmKhdiachi>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_KHDIACHI");

                entity.HasIndex(e => new { e.FkKhachhang, e.CDiachi })
                    .HasName("IX_T_DM_KHDIACHI")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDiachi)
                    .IsRequired()
                    .HasColumnName("C_DIACHI")
                    .HasMaxLength(150);

                entity.Property(e => e.CDienthoai)
                    .HasColumnName("C_DIENTHOAI")
                    .HasMaxLength(50);

                entity.Property(e => e.CNguoilh)
                    .HasColumnName("C_NGUOILH")
                    .HasMaxLength(50);

                entity.Property(e => e.FkKhachhang).HasColumnName("FK_KHACHHANG");

                entity.HasOne(d => d.FkKhachhangNavigation)
                    .WithMany(p => p.TDmKhdiachi)
                    .HasForeignKey(d => d.FkKhachhang)
                    .HasConstraintName("FK_T_DM_KHDIACHI_T_DM_KH");
            });

            modelBuilder.Entity<TDmKhgiaodich>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_KHGIAODICH");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CContactName)
                    .HasColumnName("C_ContactName")
                    .HasMaxLength(50);

                entity.Property(e => e.CContent)
                    .HasColumnName("C_Content")
                    .HasMaxLength(200);

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CFeedBack)
                    .HasColumnName("C_FeedBack")
                    .HasMaxLength(200);

                entity.Property(e => e.CMa)
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CNextContent)
                    .HasColumnName("C_NextContent")
                    .HasMaxLength(200);

                entity.Property(e => e.CNextDate)
                    .HasColumnName("C_NextDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CNextTime)
                    .HasColumnName("C_NextTime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CRemindDate)
                    .HasColumnName("C_RemindDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CRemindTime)
                    .HasColumnName("C_RemindTime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CStopRemind).HasColumnName("C_StopRemind");

                entity.Property(e => e.CTransDate)
                    .HasColumnName("C_TransDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CTransTime)
                    .HasColumnName("C_TransTime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FkDanhgia).HasColumnName("FK_DANHGIA");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkKhachhang).HasColumnName("FK_KHACHHANG");

                entity.Property(e => e.FkLoaigd).HasColumnName("FK_LOAIGD");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");
            });

            modelBuilder.Entity<TDmKhloaigd>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_KHLOAIGD");

                entity.HasIndex(e => e.CMa)
                    .HasName("IX_T_DM_KHLOAIGD")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("IX_T_DM_KHLOAIGD_1")
                    .IsUnique();

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(20);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TDmKhnlh>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_KHNLH__57DD0BE4");

                entity.ToTable("T_DM_KHNLH");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CChucvu)
                    .HasColumnName("C_CHUCVU")
                    .HasMaxLength(20);

                entity.Property(e => e.CEmail)
                    .HasColumnName("C_EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(100);

                entity.Property(e => e.CGioiTinh).HasColumnName("C_GioiTinh");

                entity.Property(e => e.CMobile)
                    .HasColumnName("C_MOBILE")
                    .HasMaxLength(15);

                entity.Property(e => e.CNgaySinh)
                    .HasColumnName("C_NgaySinh")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CPhongBan)
                    .HasColumnName("C_PhongBan")
                    .HasMaxLength(20);

                entity.Property(e => e.CSonoibo)
                    .HasColumnName("C_SONOIBO")
                    .HasMaxLength(6);

                entity.Property(e => e.CTen)
                    .HasColumnName("C_TEN")
                    .HasMaxLength(255);

                entity.Property(e => e.FkKh).HasColumnName("FK_KH");
            });

            modelBuilder.Entity<TDmKho>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_KHO__06CD04F7");

                entity.ToTable("T_DM_KHO");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_KHO_Index")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("UQ__T_DM_KHO__07C12930")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CBanhang).HasColumnName("C_BANHANG");

                entity.Property(e => e.CCap)
                    .HasColumnName("C_CAP")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CChoxoa).HasColumnName("C_CHOXOA");

                entity.Property(e => e.CKehang).HasColumnName("C_KEHANG");

                entity.Property(e => e.CKhoangcach).HasColumnName("C_KHOANGCACH");

                entity.Property(e => e.CLastexport)
                    .HasColumnName("C_LASTEXPORT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CLoaikho)
                    .IsRequired()
                    .HasColumnName("C_LOAIKHO")
                    .HasMaxLength(5);

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.CSanxuat).HasColumnName("C_SANXUAT");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkTongkho).HasColumnName("FK_TONGKHO");
            });

            modelBuilder.Entity<TDmKhts>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_KHTS__55009F39");

                entity.ToTable("T_DM_KHTS");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_KHTS_Index")
                    .IsUnique();

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CDiachi)
                    .HasColumnName("C_DIACHI")
                    .HasMaxLength(100);

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CTen)
                    .IsRequired()
                    .HasColumnName("C_TEN")
                    .HasMaxLength(100);

                entity.Property(e => e.CTvt)
                    .HasColumnName("C_TVT")
                    .HasMaxLength(50);

                entity.Property(e => e.FkQuocgia).HasColumnName("FK_QUOCGIA");

                entity.Property(e => e.FkTtp).HasColumnName("FK_TTP");
            });

            modelBuilder.Entity<TDmKhvthh>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_KHVTHH");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCk)
                    .HasColumnName("C_CK")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CCongthuc)
                    .HasColumnName("C_CONGTHUC")
                    .HasMaxLength(50);

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CDenngay)
                    .HasColumnName("C_DENNGAY")
                    .HasColumnType("datetime");

                entity.Property(e => e.CDongia)
                    .HasColumnName("C_DONGIA")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.CDongiathue)
                    .HasColumnName("C_DONGIATHUE")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CGiamgia)
                    .HasColumnName("C_GIAMGIA")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CKhuyenmai).HasColumnName("C_KHUYENMAI");

                entity.Property(e => e.CTungay)
                    .HasColumnName("C_TUNGAY")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkDvt).HasColumnName("FK_DVT");

                entity.Property(e => e.FkKh).HasColumnName("FK_KH");

                entity.Property(e => e.FkNhomgia).HasColumnName("FK_NHOMGIA");

                entity.Property(e => e.FkNhomkh).HasColumnName("FK_NHOMKH");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.FkVung).HasColumnName("FK_VUNG");
            });

            modelBuilder.Entity<TDmKieuyeucau>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_KIEUYEUCAU");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .HasMaxLength(5);

                entity.Property(e => e.CMota)
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TDmKmp>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_KMP__0A9D95DB");

                entity.ToTable("T_DM_KMP");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_KMP_Index")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("UQ__T_DM_KMP__0B91BA14")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CAn).HasColumnName("C_AN");

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CDongia)
                    .HasColumnName("C_DONGIA")
                    .HasColumnType("decimal(19, 2)");

                entity.Property(e => e.CLastexport)
                    .HasColumnName("C_LASTEXPORT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.CTinhlai)
                    .HasColumnName("C_TINHLAI")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CVattu).HasColumnName("C_VATTU");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkTkco)
                    .HasColumnName("FK_TKCO")
                    .HasMaxLength(12);

                entity.Property(e => e.FkTkno)
                    .HasColumnName("FK_TKNO")
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<TDmKykiemke>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_KYKIEMKE");

                entity.HasIndex(e => e.CTen)
                    .HasName("IX_T_DM_KYKIEMKE")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDenngay)
                    .HasColumnName("C_DENNGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CDieuchinh).HasColumnName("C_DIEUCHINH");

                entity.Property(e => e.CNgaydieuchinh)
                    .HasColumnName("C_NGAYDIEUCHINH")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CTen)
                    .IsRequired()
                    .HasColumnName("C_TEN")
                    .HasMaxLength(50);

                entity.Property(e => e.CTungay)
                    .HasColumnName("C_TUNGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FkChungtu).HasColumnName("FK_CHUNGTU");
            });

            modelBuilder.Entity<TDmLdd>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_LDD__0E6E26BF");

                entity.ToTable("T_DM_LDD");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_LDD_Index")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("UQ__T_DM_LDD__0F624AF8")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TDmLdhh>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_LDHH");

                entity.HasIndex(e => e.CMa)
                    .HasName("IX_T_DM_LDHH")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TDmLdtg>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_LDTG__123EB7A3");

                entity.ToTable("T_DM_LDTG");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_LDTG_Index")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("UQ__T_DM_LDTG__1332DBDC")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TDmLoaibg>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_LOAIBG");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CLength).HasColumnName("C_LENGTH");

                entity.Property(e => e.CMa).HasColumnName("C_MA");

                entity.Property(e => e.CMota)
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(255);

                entity.Property(e => e.CPrefix)
                    .HasColumnName("C_PREFIX")
                    .HasMaxLength(4);

                entity.Property(e => e.CRead)
                    .HasColumnName("C_READ")
                    .HasMaxLength(255);

                entity.Property(e => e.CSeparator)
                    .HasColumnName("C_SEPARATOR")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('.')");

                entity.Property(e => e.CVisible)
                    .HasColumnName("C_VISIBLE")
                    .HasMaxLength(255);

                entity.Property(e => e.CWrite)
                    .HasColumnName("C_WRITE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TDmLoaibt>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_LOAIBT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CTen)
                    .IsRequired()
                    .HasColumnName("C_TEN")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TDmLoaict>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_LOAICT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CTen)
                    .IsRequired()
                    .HasColumnName("C_TEN")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TDmLoaidl>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_LOAIDL");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CTen)
                    .HasColumnName("C_TEN")
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<TDmLoaikho>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_LOAIKHO");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TDmLoaixe>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_LOAIXE");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TDmLoaixn>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_LOAIXN");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CTen)
                    .IsRequired()
                    .HasColumnName("C_TEN")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TDmMahoadon>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_MAHOADON");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .HasColumnName("C_MA")
                    .HasMaxLength(20);

                entity.Property(e => e.CMauso)
                    .HasColumnName("C_MAUSO")
                    .HasMaxLength(20);

                entity.Property(e => e.CTen)
                    .HasColumnName("C_TEN")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<TDmMauHn>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK_DM_MAU_HN");

                entity.ToTable("T_DM_MAU_HN");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(1000);

                entity.Property(e => e.CHsphaloang)
                    .HasColumnName("C_HSPHALOANG")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CMa)
                    .HasColumnName("C_MA")
                    .HasMaxLength(100);

                entity.Property(e => e.CNhomhn).HasColumnName("C_NHOMHN");

                entity.Property(e => e.CTenloai)
                    .IsRequired()
                    .HasColumnName("C_TENLOAI")
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<TDmMdsd>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_MDSD__160F4887");

                entity.ToTable("T_DM_MDSD");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_MDSD_Index")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("UQ__T_DM_MDSD__17036CC0")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CLastexport)
                    .HasColumnName("C_LASTEXPORT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TDmMocthoigian>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_DM_MOCTHOIGIAN");

                entity.Property(e => e.CMa)
                    .HasColumnName("C_MA")
                    .HasMaxLength(10);

                entity.Property(e => e.CMota)
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TDmMpd>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_MPD__19DFD96B");

                entity.ToTable("T_DM_MPD");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CBanhang)
                    .HasColumnName("C_BANHANG")
                    .HasColumnType("money");

                entity.Property(e => e.CChitien)
                    .HasColumnName("C_CHITIEN")
                    .HasColumnType("money");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(50);

                entity.Property(e => e.CMuahang)
                    .HasColumnName("C_MUAHANG")
                    .HasColumnType("money");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");
            });

            modelBuilder.Entity<TDmNganhang>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_NGANHANG");

                entity.HasIndex(e => e.CMa)
                    .HasName("IX_T_DM_NGANHANG")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("IX_T_DM_NGANHANG_1")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(300);

                entity.Property(e => e.CSotaikhoan)
                    .HasColumnName("C_SOTAIKHOAN")
                    .HasMaxLength(25);

                entity.Property(e => e.CTentaikhoan)
                    .HasColumnName("C_TENTAIKHOAN")
                    .HasMaxLength(50);

                entity.Property(e => e.CTtp)
                    .HasColumnName("C_TTP")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TDmNguonvon>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_NGUONVON__1BC821DD");

                entity.ToTable("T_DM_NGUONVON");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_NGUONVON_Index")
                    .IsUnique();

                entity.HasIndex(e => e.CTen)
                    .HasName("UQ__T_DM_NGUONVON__1CBC4616")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CTen)
                    .IsRequired()
                    .HasColumnName("C_TEN")
                    .HasMaxLength(100);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TDmNhomdmcp>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_NHOMDMCP");

                entity.HasIndex(e => e.CMa)
                    .HasName("IX_T_DM_NHOMDMCP")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("IX_T_DM_NHOMDMCP_1")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(50);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TDmNhomdmcpct>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_NHOMDMCPCT");

                entity.HasIndex(e => new { e.FkNhomdmcp, e.FkKmp })
                    .HasName("IX_T_DM_NHOMDMCPCT")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CSotien)
                    .HasColumnName("C_SOTIEN")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.FkKmp).HasColumnName("FK_KMP");

                entity.Property(e => e.FkNhomdmcp).HasColumnName("FK_NHOMDMCP");

                entity.HasOne(d => d.FkNhomdmcpNavigation)
                    .WithMany(p => p.TDmNhomdmcpct)
                    .HasForeignKey(d => d.FkNhomdmcp)
                    .HasConstraintName("FK_T_DM_NHOMDMCPCT_T_DM_NHOMDMCP");
            });

            modelBuilder.Entity<TDmNhomgia>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_NHOMGIA");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(50);

                entity.Property(e => e.CMucuutien).HasColumnName("C_MUCUUTIEN");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TDmNhomgt>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_NHOMGT__22751F6C");

                entity.ToTable("T_DM_NHOMGT");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_NHOMGT_Index")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("UQ__T_DM_NHOMGT__236943A5")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TDmNhomkh>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_NHOMKH__2645B050");

                entity.ToTable("T_DM_NHOMKH");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_NHOMKH_Index")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("UQ__T_DM_NHOMKH__2739D489");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCap)
                    .HasColumnName("C_CAP")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CLastexport)
                    .HasColumnName("C_LASTEXPORT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CLoai)
                    .HasColumnName("C_LOAI")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TDmNhomts>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_NHOMTS");

                entity.HasIndex(e => e.CMa)
                    .HasName("IX_T_DM_NHOMTS")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CLastexport)
                    .HasColumnName("C_LASTEXPORT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CLoainhom).HasColumnName("C_LOAINHOM");

                entity.Property(e => e.CMa)
                    .HasColumnName("C_MA")
                    .HasMaxLength(20);

                entity.Property(e => e.CTen)
                    .HasColumnName("C_TEN")
                    .HasMaxLength(50);

                entity.Property(e => e.CTenen)
                    .HasColumnName("C_TENEN")
                    .HasMaxLength(50);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TDmNhomvattu>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_NHOMVATTU");

                entity.HasIndex(e => new { e.FkDvcs, e.CMa, e.CMota })
                    .HasName("IX_T_DM_NHOMVATTU")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCap)
                    .HasColumnName("C_CAP")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CChoxoa).HasColumnName("C_CHOXOA");

                entity.Property(e => e.CConvert).HasColumnName("C_CONVERT");

                entity.Property(e => e.CLastexport)
                    .HasColumnName("C_LASTEXPORT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CLoai)
                    .HasColumnName("C_LOAI")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkParent).HasColumnName("FK_PARENT");
            });

            modelBuilder.Entity<TDmNs>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_NS__1F98B2C1");

                entity.ToTable("T_DM_NS");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_NS_Index")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CBanhang).HasColumnName("C_BANHANG");

                entity.Property(e => e.CHoten)
                    .IsRequired()
                    .HasColumnName("C_HOTEN")
                    .HasMaxLength(40);

                entity.Property(e => e.CKiemtra).HasColumnName("C_KIEMTRA");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMuahang).HasColumnName("C_MUAHANG");

                entity.Property(e => e.CNguyenlieu).HasColumnName("C_NGUYENLIEU");

                entity.Property(e => e.CPhantich).HasColumnName("C_PHANTICH");

                entity.Property(e => e.CPheduyet).HasColumnName("C_PHEDUYET");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");
            });

            modelBuilder.Entity<TDmNtscd>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_NTSCD__2A164134");

                entity.ToTable("T_DM_NTSCD");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_NTSCD_Index")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("UQ__T_DM_NTSCD__2B0A656D")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TDmPhache>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_PHACHE");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CSl)
                    .HasColumnName("C_SL")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.FkVuviec).HasColumnName("FK_VUVIEC");
            });

            modelBuilder.Entity<TDmPhanxuong>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_PHANXUONG__3587F3E0");

                entity.ToTable("T_DM_PHANXUONG");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_PHANXUONG_Index")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("UQ__T_DM_PHANXUONG__367C1819")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CAn).HasColumnName("C_AN");

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CDaidien1)
                    .HasColumnName("C_DAIDIEN1")
                    .HasMaxLength(20);

                entity.Property(e => e.CDaidien2)
                    .HasColumnName("C_DAIDIEN2")
                    .HasMaxLength(20);

                entity.Property(e => e.CDaidien3)
                    .HasColumnName("C_DAIDIEN3")
                    .HasMaxLength(20);

                entity.Property(e => e.CDienthoai1)
                    .HasColumnName("C_DIENTHOAI1")
                    .HasMaxLength(20);

                entity.Property(e => e.CDienthoai2)
                    .HasColumnName("C_DIENTHOAI2")
                    .HasMaxLength(20);

                entity.Property(e => e.CDienthoai3)
                    .HasColumnName("C_DIENTHOAI3")
                    .HasMaxLength(20);

                entity.Property(e => e.CFax)
                    .HasColumnName("C_FAX")
                    .HasMaxLength(20);

                entity.Property(e => e.CLastexport)
                    .HasColumnName("C_LASTEXPORT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.CRead)
                    .HasColumnName("C_READ")
                    .HasMaxLength(500);

                entity.Property(e => e.CSanxuat).HasColumnName("C_SANXUAT");

                entity.Property(e => e.CSelect)
                    .HasColumnName("C_SELECT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CSeq).HasColumnName("C_SEQ");

                entity.Property(e => e.CVisible)
                    .HasColumnName("C_VISIBLE")
                    .HasMaxLength(500);

                entity.Property(e => e.CWrite)
                    .HasColumnName("C_WRITE")
                    .HasMaxLength(500);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");
            });

            modelBuilder.Entity<TDmPhanxuongca>(entity =>
            {
                entity.HasKey(e => new { e.FkPhanxuongnangluc, e.FkCa });

                entity.ToTable("T_DM_PHANXUONGCA");

                entity.Property(e => e.FkPhanxuongnangluc).HasColumnName("FK_PHANXUONGNANGLUC");

                entity.Property(e => e.FkCa).HasColumnName("FK_CA");
            });

            modelBuilder.Entity<TDmPhanxuongnangluc>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_PHANXUONGNANGLUC");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCa)
                    .IsRequired()
                    .HasColumnName("C_CA")
                    .HasMaxLength(100);

                entity.Property(e => e.CDenngay)
                    .HasColumnName("C_DENNGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CHieusuat).HasColumnName("C_HIEUSUAT");

                entity.Property(e => e.CLoainangluc).HasColumnName("C_LOAINANGLUC");

                entity.Property(e => e.CNangluc).HasColumnName("C_NANGLUC");

                entity.Property(e => e.CSlmay).HasColumnName("C_SLMAY");

                entity.Property(e => e.CSlnguoi).HasColumnName("C_SLNGUOI");

                entity.Property(e => e.CTungay)
                    .HasColumnName("C_TUNGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FkDvt).HasColumnName("FK_DVT");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");
            });

            modelBuilder.Entity<TDmPhanxuongngay>(entity =>
            {
                entity.HasKey(e => new { e.FkPhanxuong, e.CNgay, e.FkCa, e.CTugio, e.CDengio });

                entity.ToTable("T_DM_PHANXUONGNGAY");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");

                entity.Property(e => e.CNgay)
                    .HasColumnName("C_NGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FkCa).HasColumnName("FK_CA");

                entity.Property(e => e.CTugio)
                    .HasColumnName("C_TUGIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CDengio)
                    .HasColumnName("C_DENGIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CConlai)
                    .HasColumnName("C_CONLAI")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CDadung)
                    .HasColumnName("C_DADUNG")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CHieusuat)
                    .HasColumnName("C_HIEUSUAT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CLoainangluc)
                    .HasColumnName("C_LOAINANGLUC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CNangluc)
                    .HasColumnName("C_NANGLUC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CNghi)
                    .IsRequired()
                    .HasColumnName("C_NGHI")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CSlmay)
                    .HasColumnName("C_SLMAY")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CSlnguoi)
                    .HasColumnName("C_SLNGUOI")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FkDvt).HasColumnName("FK_DVT");
            });

            modelBuilder.Entity<TDmPhongban>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_PHONGBAN__395884C4");

                entity.ToTable("T_DM_PHONGBAN");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_PHONGBAN_Index")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("UQ__T_DM_PHONGBAN__3A4CA8FD")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCap)
                    .HasColumnName("C_CAP")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CDaidien1)
                    .HasColumnName("C_DAIDIEN1")
                    .HasMaxLength(20);

                entity.Property(e => e.CDaidien2)
                    .HasColumnName("C_DAIDIEN2")
                    .HasMaxLength(20);

                entity.Property(e => e.CDaidien3)
                    .HasColumnName("C_DAIDIEN3")
                    .HasMaxLength(20);

                entity.Property(e => e.CDiachi)
                    .HasColumnName("C_DIACHI")
                    .HasMaxLength(250);

                entity.Property(e => e.CDienthoai)
                    .HasColumnName("C_DIENTHOAI")
                    .HasMaxLength(20);

                entity.Property(e => e.CDienthoai2)
                    .HasColumnName("C_DIENTHOAI2")
                    .HasMaxLength(20);

                entity.Property(e => e.CDienthoai3)
                    .HasColumnName("C_DIENTHOAI3")
                    .HasMaxLength(20);

                entity.Property(e => e.CFax)
                    .HasColumnName("C_FAX")
                    .HasMaxLength(20);

                entity.Property(e => e.CLastexport)
                    .HasColumnName("C_LASTEXPORT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.CMst)
                    .HasColumnName("C_MST")
                    .HasMaxLength(20);

                entity.Property(e => e.CNhomkethue)
                    .HasColumnName("C_NHOMKETHUE")
                    .HasMaxLength(100);

                entity.Property(e => e.CTen)
                    .HasColumnName("C_TEN")
                    .HasMaxLength(200);

                entity.Property(e => e.CWrite)
                    .HasColumnName("C_WRITE")
                    .HasMaxLength(500);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TDmPlabc>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_PLABC__31B762FC");

                entity.ToTable("T_DM_PLABC");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_PLABC_Index")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("UQ__T_DM_PLABC__32AB8735")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TDmPpvc>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_PPVC");

                entity.HasIndex(e => e.CMa)
                    .HasName("IX_T_DM_PPVC")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("IX_T_DM_PPVC_1")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TDmPttt>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_PTTT__3D2915A8");

                entity.ToTable("T_DM_PTTT");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_PTTT_Index")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("UQ__T_DM_PTTT__3E1D39E1")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.CSoNgay).HasColumnName("C_SoNgay");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TDmPtvt>(entity =>
            {
                entity.HasKey(e => e.PkBienso);

                entity.ToTable("T_DM_PTVT");

                entity.Property(e => e.PkBienso)
                    .HasColumnName("PK_BIENSO")
                    .HasMaxLength(50);

                entity.Property(e => e.CDiachi)
                    .HasColumnName("C_DIACHI")
                    .HasMaxLength(255);

                entity.Property(e => e.CDienthoai)
                    .HasColumnName("C_DIENTHOAI")
                    .HasMaxLength(50);

                entity.Property(e => e.CDmthnl)
                    .HasColumnName("C_DMTHNL")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CLaixe)
                    .HasColumnName("C_LAIXE")
                    .HasMaxLength(50);

                entity.Property(e => e.CTenxe)
                    .HasColumnName("C_TENXE")
                    .HasMaxLength(50);

                entity.Property(e => e.CTinhtrang).HasColumnName("C_TINHTRANG");

                entity.Property(e => e.CTrongtai)
                    .HasColumnName("C_TRONGTAI")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TDmQuicachdg>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_QUICACHDG");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CLastexport)
                    .HasColumnName("C_LASTEXPORT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CMa)
                    .HasColumnName("C_MA")
                    .HasMaxLength(20);

                entity.Property(e => e.CMota)
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(50);

                entity.Property(e => e.CTile)
                    .HasColumnName("C_TILE")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkDvt).HasColumnName("FK_DVT");
            });

            modelBuilder.Entity<TDmQuocgia>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_QUOCGIA");

                entity.HasIndex(e => e.CMa)
                    .HasName("IX_T_DM_QUOCGIA")
                    .IsUnique();

                entity.HasIndex(e => e.CTen)
                    .HasName("IX_T_DM_QUOCGIA_1")
                    .IsUnique();

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CLastexport)
                    .HasColumnName("C_LASTEXPORT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CTen)
                    .IsRequired()
                    .HasColumnName("C_TEN")
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<TDmTaikhoan>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_TAIKHOAN");

                entity.HasIndex(e => e.CMa)
                    .HasName("IX_T_DM_TAIKHOAN")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CDiachitaikhoan)
                    .HasColumnName("C_DIACHITAIKHOAN")
                    .HasMaxLength(200);

                entity.Property(e => e.CLastexport)
                    .HasColumnName("C_LASTEXPORT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CLoaitk).HasColumnName("C_LOAITK");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CRead)
                    .HasColumnName("C_READ")
                    .HasMaxLength(500);

                entity.Property(e => e.CTaikhoan)
                    .HasColumnName("C_TAIKHOAN")
                    .HasMaxLength(20);

                entity.Property(e => e.CTen)
                    .IsRequired()
                    .HasColumnName("C_TEN")
                    .HasMaxLength(100);

                entity.Property(e => e.CTenen)
                    .HasColumnName("C_TENEN")
                    .HasMaxLength(100);

                entity.Property(e => e.CTentaikhoan)
                    .HasColumnName("C_TENTAIKHOAN")
                    .HasMaxLength(200);

                entity.Property(e => e.CTkcn).HasColumnName("C_TKCN");

                entity.Property(e => e.CTkme).HasColumnName("C_TKME");

                entity.Property(e => e.CTksc)
                    .HasColumnName("C_TKSC")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CTktdcn).HasColumnName("C_TKTDCN");

                entity.Property(e => e.CVisible)
                    .HasColumnName("C_VISIBLE")
                    .HasMaxLength(500);

                entity.Property(e => e.CWrite)
                    .HasColumnName("C_WRITE")
                    .HasMaxLength(500);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkNgoaite).HasColumnName("FK_NGOAITE");
            });

            modelBuilder.Entity<TDmTiente>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_TIENTE");

                entity.HasIndex(e => e.CMa)
                    .HasName("IX_T_DM_TIENTE")
                    .IsUnique();

                entity.HasIndex(e => e.CTen)
                    .HasName("IX_T_DM_TIENTE_1")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDinhdang)
                    .IsRequired()
                    .HasColumnName("C_DINHDANG")
                    .HasMaxLength(50);

                entity.Property(e => e.CDocx).HasColumnName("C_DOCX");

                entity.Property(e => e.CKyhieu)
                    .IsRequired()
                    .HasColumnName("C_KYHIEU")
                    .HasMaxLength(5);

                entity.Property(e => e.CLastexport)
                    .HasColumnName("C_LASTEXPORT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CTen)
                    .IsRequired()
                    .HasColumnName("C_TEN")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TDmTigia>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_TIGIA");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CNgay)
                    .HasColumnName("C_NGAY")
                    .HasColumnType("datetime");

                entity.Property(e => e.CTigia)
                    .HasColumnName("C_TIGIA")
                    .HasColumnType("money");

                entity.Property(e => e.FkLoaitien).HasColumnName("FK_LOAITIEN");
            });

            modelBuilder.Entity<TDmTongkho>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_TONGKHO__42E1EEFE");

                entity.ToTable("T_DM_TONGKHO");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_TONGKHO_Index")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("UQ__T_DM_TONGKHO__43D61337")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TDmTotruong>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_TOTRUONG");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CTen)
                    .IsRequired()
                    .HasColumnName("C_TEN")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TDmTrangthai>(entity =>
            {
                entity.HasKey(e => e.CMa);

                entity.ToTable("T_DM_TRANGTHAI");

                entity.Property(e => e.CMa)
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");
            });

            modelBuilder.Entity<TDmTscd>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_TSCD");

                entity.HasIndex(e => e.CMa)
                    .HasName("IX_T_DM_TSCD")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CCongsuat)
                    .HasColumnName("C_CONGSUAT")
                    .HasMaxLength(200);

                entity.Property(e => e.CConvert).HasColumnName("C_CONVERT");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(300);

                entity.Property(e => e.CHopdong)
                    .HasColumnName("C_HOPDONG")
                    .HasMaxLength(30);

                entity.Property(e => e.CLastexport)
                    .HasColumnName("C_LASTEXPORT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CNamsx).HasColumnName("C_NAMSX");

                entity.Property(e => e.CNgaybd)
                    .HasColumnName("C_NGAYBD")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNgaybdkh)
                    .HasColumnName("C_NGAYBDKH")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNgaygt)
                    .HasColumnName("C_NGAYGT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNgaykt)
                    .HasColumnName("C_NGAYKT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CPpkh).HasColumnName("C_PPKH");

                entity.Property(e => e.CSerialno)
                    .HasColumnName("C_SERIALNO")
                    .HasMaxLength(30);

                entity.Property(e => e.CSohd)
                    .HasColumnName("C_SOHD")
                    .HasMaxLength(20);

                entity.Property(e => e.CSoluongtp).HasColumnName("C_SOLUONGTP");

                entity.Property(e => e.CStkh)
                    .HasColumnName("C_STKH")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CTailieukt)
                    .HasColumnName("C_TAILIEUKT")
                    .HasMaxLength(300);

                entity.Property(e => e.CTen)
                    .HasColumnName("C_TEN")
                    .HasMaxLength(200);

                entity.Property(e => e.CTenncc)
                    .HasColumnName("C_TENNCC")
                    .HasMaxLength(100);

                entity.Property(e => e.CThoigianbaohanh).HasColumnName("C_THOIGIANBAOHANH");

                entity.Property(e => e.CTieuthuckh).HasColumnName("C_TIEUTHUCKH");

                entity.Property(e => e.CTkh).HasColumnName("C_TKH");

                entity.Property(e => e.CTongtieuthuc).HasColumnName("C_TONGTIEUTHUC");

                entity.Property(e => e.FkBpsd).HasColumnName("FK_BPSD");

                entity.Property(e => e.FkCostCenter).HasColumnName("FK_CostCenter");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkDvt).HasColumnName("FK_DVT");

                entity.Property(e => e.FkKmp).HasColumnName("FK_KMP");

                entity.Property(e => e.FkLdtg).HasColumnName("FK_LDTG");

                entity.Property(e => e.FkMdsd).HasColumnName("FK_MDSD");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkNguoiql).HasColumnName("FK_NGUOIQL");

                entity.Property(e => e.FkNhomts1).HasColumnName("FK_NHOMTS1");

                entity.Property(e => e.FkNhomts2).HasColumnName("FK_NHOMTS2");

                entity.Property(e => e.FkNuocsx).HasColumnName("FK_NUOCSX");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");

                entity.Property(e => e.FkPpkh).HasColumnName("FK_PPKH");

                entity.Property(e => e.FkTinhtrang).HasColumnName("FK_TINHTRANG");

                entity.Property(e => e.FkTkcp)
                    .HasColumnName("FK_TKCP")
                    .HasMaxLength(12);

                entity.Property(e => e.FkTkhm)
                    .HasColumnName("FK_TKHM")
                    .HasMaxLength(12);

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVuviec).HasColumnName("FK_VUVIEC");
            });

            modelBuilder.Entity<TDmTscdDtcp>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_TSCD_DTCP");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMota)
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(50);

                entity.Property(e => e.CNgay)
                    .HasColumnName("C_NGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CSanluong)
                    .HasColumnName("C_SANLUONG")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.CTile)
                    .HasColumnName("C_TILE")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");

                entity.Property(e => e.FkTkco)
                    .HasColumnName("FK_TKCO")
                    .HasMaxLength(10);

                entity.Property(e => e.FkTkno)
                    .HasColumnName("FK_TKNO")
                    .HasMaxLength(10);

                entity.Property(e => e.FkTscd).HasColumnName("FK_TSCD");
            });

            modelBuilder.Entity<TDmTscdSanluongnam>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_TSCD_SANLUONGNAM");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CNam).HasColumnName("C_NAM");

                entity.Property(e => e.CSanluong)
                    .HasColumnName("C_SANLUONG")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FkTscd).HasColumnName("FK_TSCD");
            });

            modelBuilder.Entity<TDmTscdnv>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_TSCDNV");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CGiatri)
                    .HasColumnName("C_GIATRI")
                    .HasColumnType("money");

                entity.Property(e => e.FkNguonvon).HasColumnName("FK_NGUONVON");

                entity.Property(e => e.FkTscd).HasColumnName("FK_TSCD");
            });

            modelBuilder.Entity<TDmTscdpt>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_TSCDPT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CGiatri)
                    .HasColumnName("C_GIATRI")
                    .HasColumnType("money");

                entity.Property(e => e.CQuycach)
                    .HasColumnName("C_QUYCACH")
                    .HasColumnType("text");

                entity.Property(e => e.CSoluong).HasColumnName("C_SOLUONG");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.FkDvt).HasColumnName("FK_DVT");

                entity.Property(e => e.FkTscd).HasColumnName("FK_TSCD");
            });

            modelBuilder.Entity<TDmTscdtinhtrang>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_TSCDTINHTRANG");

                entity.HasIndex(e => e.CMa)
                    .HasName("IX_T_DM_TSCDTINHTRANG")
                    .IsUnique();

                entity.HasIndex(e => e.CTen)
                    .HasName("IX_T_DM_TSCDTINHTRANG_1")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CLastexport)
                    .HasColumnName("C_LASTEXPORT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CTen)
                    .IsRequired()
                    .HasColumnName("C_TEN")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TDmTscdtl>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_TSCDTL");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CGiatri)
                    .HasColumnName("C_GIATRI")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CGiatri2)
                    .HasColumnName("C_GIATRI2")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CNamsx).HasColumnName("C_NAMSX");

                entity.Property(e => e.CNgay)
                    .HasColumnName("C_NGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CSerialno)
                    .HasColumnName("C_SERIALNO")
                    .HasMaxLength(30);

                entity.Property(e => e.CSohd)
                    .HasColumnName("C_SOHD")
                    .HasMaxLength(20);

                entity.Property(e => e.CSoluong).HasColumnName("C_SOLUONG");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.CTen)
                    .IsRequired()
                    .HasColumnName("C_TEN")
                    .HasMaxLength(100);

                entity.Property(e => e.FkDvt).HasColumnName("FK_DVT");

                entity.Property(e => e.FkMdsd).HasColumnName("FK_MDSD");

                entity.Property(e => e.FkNuocsx).HasColumnName("FK_NUOCSX");

                entity.Property(e => e.FkTscd).HasColumnName("FK_TSCD");
            });

            modelBuilder.Entity<TDmTtp>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK_TTP");

                entity.ToTable("T_DM_TTP");

                entity.HasIndex(e => e.CMa)
                    .HasName("IX_TTP")
                    .IsUnique();

                entity.HasIndex(e => e.CTen)
                    .HasName("IX_TTP_1")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CLastexport)
                    .HasColumnName("C_LASTEXPORT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CQuocgia).HasColumnName("C_QUOCGIA");

                entity.Property(e => e.CTen)
                    .IsRequired()
                    .HasColumnName("C_TEN")
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<TDmVitri>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_VITRI");

                entity.HasIndex(e => e.CMa)
                    .HasName("IX_T_DM_VITRI")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CAnh)
                    .HasColumnName("C_ANH")
                    .HasColumnType("image");

                entity.Property(e => e.CCao)
                    .HasColumnName("C_CAO")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CDai)
                    .HasColumnName("C_DAI")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CGiadehang)
                    .HasColumnName("C_GIADEHANG")
                    .HasMaxLength(100);

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(20);

                entity.Property(e => e.CMota)
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(50);

                entity.Property(e => e.CNgaytl)
                    .HasColumnName("C_NGAYTL")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CRong)
                    .HasColumnName("C_RONG")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkHsx).HasColumnName("FK_HSX");

                entity.Property(e => e.FkKhohang).HasColumnName("FK_KHOHANG");

                entity.Property(e => e.FkNhomvt).HasColumnName("FK_NHOMVT");

                entity.Property(e => e.FkQuicach).HasColumnName("FK_QUICACH");
            });

            modelBuilder.Entity<TDmVthh>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_VTHH__46B27FE2");

                entity.ToTable("T_DM_VTHH");

                entity.HasIndex(e => new { e.FkDvcs, e.CMa, e.CMaphu })
                    .HasName("IX_T_DM_VTHH")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CAnh)
                    .HasColumnName("C_ANH")
                    .HasColumnType("image");

                entity.Property(e => e.CBanboiso)
                    .HasColumnName("C_BANBOISO")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CBandenngay)
                    .HasColumnName("C_BANDENNGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CBandonggoi).HasColumnName("C_BANDONGGOI");

                entity.Property(e => e.CBanphamvi).HasColumnName("C_BANPHAMVI");

                entity.Property(e => e.CBantungay)
                    .HasColumnName("C_BANTUNGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CChieucao).HasColumnName("C_CHIEUCAO");

                entity.Property(e => e.CChieudai).HasColumnName("C_CHIEUDAI");

                entity.Property(e => e.CChieurong).HasColumnName("C_CHIEURONG");

                entity.Property(e => e.CChoxoa).HasColumnName("C_CHOXOA");

                entity.Property(e => e.CConvert).HasColumnName("C_CONVERT");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CDodangdt).HasColumnName("C_DODANGDT");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(100);

                entity.Property(e => e.CGiachuan)
                    .HasColumnName("C_GIACHUAN")
                    .HasColumnType("money");

                entity.Property(e => e.CGiasan)
                    .HasColumnName("C_GIASAN")
                    .HasColumnType("money");

                entity.Property(e => e.CGiatran)
                    .HasColumnName("C_GIATRAN")
                    .HasColumnType("money");

                entity.Property(e => e.CGrossweight).HasColumnName("C_GROSSWEIGHT");

                entity.Property(e => e.CHotrovc).HasColumnName("C_HOTROVC");

                entity.Property(e => e.CHsThuhoi)
                    .HasColumnName("C_HS_THUHOI")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CKttsx).HasColumnName("C_KTTSX");

                entity.Property(e => e.CLastexport)
                    .HasColumnName("C_LASTEXPORT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMaphu)
                    .HasColumnName("C_MAPHU")
                    .HasMaxLength(12);

                entity.Property(e => e.CMavach)
                    .HasColumnName("C_MAVACH")
                    .HasMaxLength(50);

                entity.Property(e => e.CNetweight).HasColumnName("C_NETWEIGHT");

                entity.Property(e => e.CNgaytl)
                    .HasColumnName("C_NGAYTL")
                    .HasColumnType("datetime");

                entity.Property(e => e.CPhichuan).HasColumnName("C_PHICHUAN");

                entity.Property(e => e.CPolastPrice).HasColumnName("C_POLastPrice");

                entity.Property(e => e.CPoleadTime)
                    .HasColumnName("C_POLeadTime")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CPomaxOrder)
                    .HasColumnName("C_POMaxOrder")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CPominOrder)
                    .HasColumnName("C_POMinOrder")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CPomultiple)
                    .HasColumnName("C_POMultiple")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CPoprice)
                    .HasColumnName("C_POPrice")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CProleadTime)
                    .HasColumnName("C_PROLeadTime")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CPromaxOrder)
                    .HasColumnName("C_PROMaxOrder")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CProminOrder)
                    .HasColumnName("C_PROMinOrder")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CPromultiple)
                    .HasColumnName("C_PROMultiple")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CQcdg)
                    .HasColumnName("C_QCDG")
                    .HasMaxLength(500);

                entity.Property(e => e.CSanxuat).HasColumnName("C_SANXUAT");

                entity.Property(e => e.CSelect)
                    .HasColumnName("C_SELECT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CSeq).HasColumnName("C_SEQ");

                entity.Property(e => e.CSize)
                    .HasColumnName("C_SIZE")
                    .HasMaxLength(10);

                entity.Property(e => e.CSlttd).HasColumnName("C_SLTTD");

                entity.Property(e => e.CSlttt).HasColumnName("C_SLTTT");

                entity.Property(e => e.CSogia).HasColumnName("C_SOGIA");

                entity.Property(e => e.CSpPhu).HasColumnName("C_SP_PHU");

                entity.Property(e => e.CTdtk).HasColumnName("C_TDTK");

                entity.Property(e => e.CTelehongsx).HasColumnName("C_TELEHONGSX");

                entity.Property(e => e.CTen)
                    .HasColumnName("C_TEN")
                    .HasMaxLength(100);

                entity.Property(e => e.CTgbh).HasColumnName("C_TGBH");

                entity.Property(e => e.CThuenk)
                    .HasColumnName("C_THUENK")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CThuevat).HasColumnName("C_THUEVAT");

                entity.Property(e => e.CTilehongvc).HasColumnName("C_TILEHONGVC");

                entity.Property(e => e.CTrongcongdoan).HasColumnName("C_TRONGCONGDOAN");

                entity.Property(e => e.CTskt)
                    .HasColumnName("C_TSKT")
                    .HasMaxLength(500);

                entity.Property(e => e.CUpdatedate)
                    .HasColumnName("C_UPDATEDATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CXoa).HasColumnName("C_XOA");

                entity.Property(e => e.FkCtg)
                    .HasColumnName("FK_CTG")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkDvban).HasColumnName("FK_DVBAN");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkDvmua).HasColumnName("FK_DVMUA");

                entity.Property(e => e.FkDvtonkho).HasColumnName("FK_DVTONKHO");

                entity.Property(e => e.FkHsx).HasColumnName("FK_HSX");

                entity.Property(e => e.FkKhohang).HasColumnName("FK_KHOHANG");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkNhomvt).HasColumnName("FK_NHOMVT");

                entity.Property(e => e.FkNhomvt2).HasColumnName("FK_NHOMVT2");

                entity.Property(e => e.FkNhomvt3).HasColumnName("FK_NHOMVT3");

                entity.Property(e => e.FkNoisx).HasColumnName("FK_NOISX");

                entity.Property(e => e.FkPoprimaryVendor).HasColumnName("FK_POPrimaryVendor");

                entity.Property(e => e.FkQuicach).HasColumnName("FK_QUICACH");

                entity.Property(e => e.FkSptieuChuan).HasColumnName("FK_SPTieuChuan");

                entity.Property(e => e.FkTkgvon)
                    .HasColumnName("FK_TKGVON")
                    .HasMaxLength(12);

                entity.Property(e => e.FkTkkho)
                    .HasColumnName("FK_TKKHO")
                    .HasMaxLength(12);

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVitri).HasColumnName("FK_VITRI");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<TDmVthhChuyendoi>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_VTHH_CHUYENDOI");

                entity.HasIndex(e => new { e.FkPhanxuong, e.FkChucnang, e.FkVthh1, e.FkVthh2 })
                    .HasName("IX_T_DM_VTHH_CHUYENDOI")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CThoigian).HasColumnName("C_THOIGIAN");

                entity.Property(e => e.FkChucnang).HasColumnName("FK_CHUCNANG");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");

                entity.Property(e => e.FkVthh1).HasColumnName("FK_VTHH1");

                entity.Property(e => e.FkVthh2).HasColumnName("FK_VTHH2");
            });

            modelBuilder.Entity<TDmVthhDtcp>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_VTHH_DTCP");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CTyle)
                    .HasColumnName("C_TYLE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<TDmVthhLuu>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_VTHH_LUU");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CNote)
                    .HasColumnName("C_NOTE")
                    .HasMaxLength(250);

                entity.Property(e => e.CTen)
                    .HasColumnName("C_TEN")
                    .HasMaxLength(200);

                entity.Property(e => e.CVitri).HasColumnName("C_VITRI");

                entity.Property(e => e.FkCreateUser).HasColumnName("FK_CREATE_USER");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkDvban).HasColumnName("FK_DVBAN");

                entity.Property(e => e.FkDvmua).HasColumnName("FK_DVMUA");

                entity.Property(e => e.FkDvtonkho).HasColumnName("FK_DVTONKHO");

                entity.Property(e => e.FkHsx).HasColumnName("FK_HSX");

                entity.Property(e => e.FkKhohang).HasColumnName("FK_KHOHANG");

                entity.Property(e => e.FkNhomvt).HasColumnName("FK_NHOMVT");

                entity.Property(e => e.FkNhomvt2).HasColumnName("FK_NHOMVT2");

                entity.Property(e => e.FkNhomvt3).HasColumnName("FK_NHOMVT3");

                entity.Property(e => e.FkTkkho)
                    .HasColumnName("FK_TKKHO")
                    .HasMaxLength(12);

                entity.Property(e => e.FkVitri).HasColumnName("FK_VITRI");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<TDmVthhVitri>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_VTHH_VITRI");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CSoluong)
                    .HasColumnName("C_SOLUONG")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.FkCreateuser).HasColumnName("FK_CREATEUSER");

                entity.Property(e => e.FkVitri).HasColumnName("FK_VITRI");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<TDmVthhbom>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_VTHHBOM");

                entity.HasIndex(e => new { e.FkVthh, e.FkVthhnl, e.PkId })
                    .HasName("IX_T_DM_VTHHBOM")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CActive).HasColumnName("C_ACTIVE");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.FkVthhnl).HasColumnName("FK_VTHHNL");
            });

            modelBuilder.Entity<TDmVthhdvt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_DM_VTHHDVT");

                entity.HasIndex(e => new { e.FkVthh, e.FkDvt })
                    .HasName("IX_T_DM_VTHHDVT")
                    .IsUnique();

                entity.Property(e => e.CHidden).HasColumnName("C_HIDDEN");

                entity.Property(e => e.FkDvt).HasColumnName("FK_DVT");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TDmVthhgia>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_DM_VTHHGIA");

                entity.Property(e => e.CCpmc)
                    .HasColumnName("C_CPMC")
                    .HasColumnType("money");

                entity.Property(e => e.CCpnc)
                    .HasColumnName("C_CPNC")
                    .HasColumnType("money");

                entity.Property(e => e.CCpnl)
                    .HasColumnName("C_CPNL")
                    .HasColumnType("money");

                entity.Property(e => e.CCpnnc)
                    .HasColumnName("C_CPNNC")
                    .HasColumnType("money");

                entity.Property(e => e.CCpntb)
                    .HasColumnName("C_CPNTB")
                    .HasColumnType("money");

                entity.Property(e => e.CNgay)
                    .HasColumnName("C_NGAY")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TDmVthhkhuyenmai>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_VTHHKHUYENMAI");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CSoluong)
                    .HasColumnName("C_SOLUONG")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FkSanpham).HasColumnName("FK_SANPHAM");
            });

            modelBuilder.Entity<TDmVthhkmp>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_VTHHKMP");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCpdinhmuc)
                    .HasColumnName("C_CPDINHMUC")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.FkDvt).HasColumnName("FK_DVT");

                entity.Property(e => e.FkKmp).HasColumnName("FK_KMP");

                entity.Property(e => e.FkVthhid).HasColumnName("FK_VTHHID");
            });

            modelBuilder.Entity<TDmVthhnl>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK_T_DM_VTHHNL_1");

                entity.ToTable("T_DM_VTHHNL");

                entity.HasIndex(e => new { e.CMa, e.CMaphu })
                    .HasName("IX_T_DM_VTHHNL")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(200);

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(20);

                entity.Property(e => e.CMaphu).HasColumnName("C_MAPHU");

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CSltp)
                    .HasColumnName("C_SLTP")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.CSogia).HasColumnName("C_SOGIA");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkDvttp).HasColumnName("FK_DVTTP");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkTrangthai).HasColumnName("FK_TRANGTHAI");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");
            });

            modelBuilder.Entity<TDmVthhnlct>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK_T_DM_VTHHNL");

                entity.ToTable("T_DM_VTHHNLCT");

                entity.HasIndex(e => new { e.FkVthhnl, e.FkVthh })
                    .HasName("IX_T_DM_VTHHNLCT")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CLtoffset)
                    .HasColumnName("C_LTOffset")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CPromotionType).HasColumnName("C_PromotionType");

                entity.Property(e => e.CScrapPercent)
                    .HasColumnName("C_ScrapPercent")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CSoluong).HasColumnName("C_SOLUONG");

                entity.Property(e => e.CSoluong2)
                    .HasColumnName("C_SOLUONG2")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.FkChucnang).HasColumnName("FK_CHUCNANG");

                entity.Property(e => e.FkDvt).HasColumnName("FK_DVT");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.FkVthhnl).HasColumnName("FK_VTHHNL");

                entity.HasOne(d => d.FkVthhnlNavigation)
                    .WithMany(p => p.TDmVthhnlct)
                    .HasForeignKey(d => d.FkVthhnl)
                    .HasConstraintName("FK_T_DM_VTHHNLCT_T_DM_VTHHNL");
            });

            modelBuilder.Entity<TDmVthhqtsx>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK_T_DM_VTHHQTSX_1");

                entity.ToTable("T_DM_VTHHQTSX");

                entity.HasIndex(e => new { e.CMa, e.CMaphu })
                    .HasName("IX_T_DM_VTHHQTSX")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(200);

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(20);

                entity.Property(e => e.CMaphu).HasColumnName("C_MAPHU");

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CSogia).HasColumnName("C_SOGIA");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkTrangthai).HasColumnName("FK_TRANGTHAI");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");
            });

            modelBuilder.Entity<TDmVthhqtsxct>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK_T_DM_VTHHQTSX");

                entity.ToTable("T_DM_VTHHQTSXCT");

                entity.HasIndex(e => new { e.FkVthhqtsx, e.CStt })
                    .HasName("IX_T_DM_VTHHQTSXCT")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CKieu).HasColumnName("C_KIEU");

                entity.Property(e => e.CLaborTime)
                    .HasColumnName("C_LaborTime")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CMachineTime)
                    .HasColumnName("C_MachineTime")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.COverlapQuantity)
                    .HasColumnName("C_OverlapQuantity")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CPacer).HasColumnName("C_Pacer");

                entity.Property(e => e.CQuantity)
                    .HasColumnName("C_Quantity")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.FkChucnang).HasColumnName("FK_CHUCNANG");

                entity.Property(e => e.FkCostCenter).HasColumnName("FK_CostCenter");

                entity.Property(e => e.FkLaborrate).HasColumnName("FK_LABORRATE");

                entity.Property(e => e.FkLabortimeuom).HasColumnName("FK_LABORTIMEUOM");

                entity.Property(e => e.FkMachinerate).HasColumnName("FK_MACHINERATE");

                entity.Property(e => e.FkMachinetimeuom).HasColumnName("FK_MACHINETIMEUOM");

                entity.Property(e => e.FkNcc).HasColumnName("FK_NCC");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");

                entity.Property(e => e.FkVthhqtsx).HasColumnName("FK_VTHHQTSX");

                entity.HasOne(d => d.FkVthhqtsxNavigation)
                    .WithMany(p => p.TDmVthhqtsxct)
                    .HasForeignKey(d => d.FkVthhqtsx)
                    .HasConstraintName("FK_T_DM_VTHHQTSXCT_T_DM_VTHHQTSX");
            });

            modelBuilder.Entity<TDmVthhrouting>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_VTHHROUTING");

                entity.HasIndex(e => new { e.FkVthh, e.FkVthhqtsx })
                    .HasName("IX_T_DM_VTHHROUTING")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CActive).HasColumnName("C_ACTIVE");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.FkVthhqtsx).HasColumnName("FK_VTHHQTSX");
            });

            modelBuilder.Entity<TDmVthhspp>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_VTHHSPP");

                entity.HasIndex(e => new { e.FkVthh, e.FkSanphamphu })
                    .HasName("IX_T_DM_VTHHSPP")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CSoluong).HasColumnName("C_SOLUONG");

                entity.Property(e => e.FkChucnang).HasColumnName("FK_CHUCNANG");

                entity.Property(e => e.FkDvt).HasColumnName("FK_DVT");

                entity.Property(e => e.FkSanphamphu).HasColumnName("FK_SANPHAMPHU");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<TDmVthhstdcost>(entity =>
            {
                entity.HasKey(e => new { e.FkVthh, e.CRollupdate, e.FkKmp });

                entity.ToTable("T_DM_VTHHSTDCOST");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.CRollupdate)
                    .HasColumnName("C_ROLLUPDATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FkKmp).HasColumnName("FK_KMP");

                entity.Property(e => e.CSotien)
                    .HasColumnName("C_SOTIEN")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TDmVung>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_VUNG__4F47C5E3");

                entity.ToTable("T_DM_VUNG");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_VUNG_Index")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("UQ__T_DM_VUNG__503BEA1C")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CLastexport)
                    .HasColumnName("C_LASTEXPORT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TDmVuviec>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__T_DM_VUVIEC__4B7734FF");

                entity.ToTable("T_DM_VUVIEC");

                entity.HasIndex(e => e.CMa)
                    .HasName("T_DM_VUVIEC_Index")
                    .IsUnique();

                entity.HasIndex(e => e.CMota)
                    .HasName("UQ__T_DM_VUVIEC__4C6B5938")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CChoxoa).HasColumnName("C_CHOXOA");

                entity.Property(e => e.CDoanhthuUsdVat)
                    .HasColumnName("C_DOANHTHU_USD_VAT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CDoanhthuVat)
                    .HasColumnName("C_DOANHTHU_VAT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CGhiam).HasColumnName("C_GHIAM");

                entity.Property(e => e.CGiatri)
                    .HasColumnName("C_GIATRI")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CGiatri2)
                    .HasColumnName("C_GIATRI2")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CIn).HasColumnName("C_IN");

                entity.Property(e => e.CKmp).HasColumnName("C_KMP");

                entity.Property(e => e.CLastexport)
                    .HasColumnName("C_LASTEXPORT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(20);

                entity.Property(e => e.CMaDuan)
                    .HasColumnName("C_MA_DUAN")
                    .HasMaxLength(40);

                entity.Property(e => e.CMota)
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.CNgaybd)
                    .HasColumnName("C_NGAYBD")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNgaykt)
                    .HasColumnName("C_NGAYKT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNgayky)
                    .HasColumnName("C_NGAYKY")
                    .HasColumnType("datetime");

                entity.Property(e => e.CPhanxuong).HasColumnName("C_PHANXUONG");

                entity.Property(e => e.CPhongban).HasColumnName("C_PHONGBAN");

                entity.Property(e => e.CSoluong)
                    .HasColumnName("C_SOLUONG")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CSudung).HasColumnName("C_SUDUNG");

                entity.Property(e => e.CThoigiankh).HasColumnName("C_THOIGIANKH");

                entity.Property(e => e.CTkco)
                    .HasColumnName("C_TKCO")
                    .HasMaxLength(12);

                entity.Property(e => e.CTkno)
                    .HasColumnName("C_TKNO")
                    .HasMaxLength(12);

                entity.Property(e => e.CValueUsdVat)
                    .HasColumnName("C_VALUE_USD_VAT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CValueVat)
                    .HasColumnName("C_VALUE_VAT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FkCostCenter).HasColumnName("FK_CostCenter");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkKh).HasColumnName("FK_KH");

                entity.Property(e => e.FkKmp).HasColumnName("FK_KMP");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");

                entity.Property(e => e.FkTkno)
                    .HasColumnName("FK_TKNO")
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<TDmVuviecDtcp>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_VUVIEC_DTCP");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMota)
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(50);

                entity.Property(e => e.CNgay)
                    .HasColumnName("C_NGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CSanluong)
                    .HasColumnName("C_SANLUONG")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.CTile)
                    .HasColumnName("C_TILE")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkVuviec).HasColumnName("FK_VUVIEC");
            });

            modelBuilder.Entity<TDmXa>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_XA");

                entity.HasIndex(e => e.CMa)
                    .HasName("IX_T_DM_XA")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CTen)
                    .IsRequired()
                    .HasColumnName("C_TEN")
                    .HasMaxLength(50);

                entity.Property(e => e.FkHuyen).HasColumnName("FK_HUYEN");
            });

            modelBuilder.Entity<TDmXe>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_XE");

                entity.HasIndex(e => e.CSoxe)
                    .HasName("IX_T_DM_XE")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CLaixe)
                    .IsRequired()
                    .HasColumnName("C_LAIXE")
                    .HasMaxLength(50);

                entity.Property(e => e.CSoxe)
                    .IsRequired()
                    .HasColumnName("C_SOXE")
                    .HasMaxLength(30);

                entity.Property(e => e.FkKh).HasColumnName("FK_KH");

                entity.Property(e => e.FkLoaixe).HasColumnName("FK_LOAIXE");
            });

            modelBuilder.Entity<TDmXom>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DM_XOM");

                entity.HasIndex(e => e.CMa)
                    .HasName("IX_T_DM_XOM")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CTen)
                    .IsRequired()
                    .HasColumnName("C_TEN")
                    .HasMaxLength(50);

                entity.Property(e => e.FkXa).HasColumnName("FK_XA");
            });

            modelBuilder.Entity<TDomDubao>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DOM_DUBAO");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CNam).HasColumnName("C_NAM");

                entity.Property(e => e.CSoluong)
                    .HasColumnName("C_SOLUONG")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CThang).HasColumnName("C_THANG");

                entity.Property(e => e.FkNhomkh).HasColumnName("FK_NHOMKH");
            });

            modelBuilder.Entity<TDondathang>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DONDATHANG");

                entity.HasIndex(e => new { e.FkDvcs, e.CSophieu })
                    .HasName("IX_T_DONDATHANG")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDaban).HasColumnName("C_DABAN");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CDiengiai)
                    .HasColumnName("C_DIENGIAI")
                    .HasMaxLength(255);

                entity.Property(e => e.CField1)
                    .HasColumnName("C_FIELD1")
                    .HasMaxLength(12);

                entity.Property(e => e.CField2)
                    .HasColumnName("C_FIELD2")
                    .HasMaxLength(12);

                entity.Property(e => e.CKhdk)
                    .HasColumnName("C_KHDK")
                    .HasMaxLength(100);

                entity.Property(e => e.CKhdkdc)
                    .HasColumnName("C_KHDKDC")
                    .HasMaxLength(100);

                entity.Property(e => e.CKhdkdt)
                    .HasColumnName("C_KHDKDT")
                    .HasMaxLength(20);

                entity.Property(e => e.CKhdkemail)
                    .HasColumnName("C_KHDKEMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.CKhdkfax)
                    .HasColumnName("C_KHDKFAX")
                    .HasMaxLength(20);

                entity.Property(e => e.CKhdknlh)
                    .HasColumnName("C_KHDKNLH")
                    .HasMaxLength(40);

                entity.Property(e => e.CNgayhethan)
                    .HasColumnName("C_NGAYHETHAN")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNgaynhan)
                    .HasColumnName("C_NGAYNHAN")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNguoivanchuyen)
                    .HasColumnName("C_NGUOIVANCHUYEN")
                    .HasMaxLength(70);

                entity.Property(e => e.CSophieu)
                    .IsRequired()
                    .HasColumnName("C_SOPHIEU")
                    .HasMaxLength(12);

                entity.Property(e => e.CTigia)
                    .HasColumnName("C_TIGIA")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CVat).HasColumnName("C_VAT");

                entity.Property(e => e.FkCuocvanchuyen).HasColumnName("FK_CUOCVANCHUYEN");

                entity.Property(e => e.FkDdct).HasColumnName("FK_DDCT");

                entity.Property(e => e.FkDondathang).HasColumnName("FK_DONDATHANG");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkHangvanchuyen).HasColumnName("FK_HANGVANCHUYEN");

                entity.Property(e => e.FkKhachhang).HasColumnName("FK_KHACHHANG");

                entity.Property(e => e.FkKmp).HasColumnName("FK_KMP");

                entity.Property(e => e.FkLoaibg).HasColumnName("FK_LOAIBG");

                entity.Property(e => e.FkLoaitien).HasColumnName("FK_LOAITIEN");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkNguoilh).HasColumnName("FK_NGUOILH");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");

                entity.Property(e => e.FkPpvc).HasColumnName("FK_PPVC");

                entity.Property(e => e.FkPttt).HasColumnName("FK_PTTT");

                entity.Property(e => e.FkSochuyen).HasColumnName("FK_SOCHUYEN");

                entity.Property(e => e.FkSoxe).HasColumnName("FK_SOXE");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVuviec).HasColumnName("FK_VUVIEC");
            });

            modelBuilder.Entity<TDondathangDoc>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DONDATHANG_DOC");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CContent)
                    .IsRequired()
                    .HasColumnName("C_CONTENT")
                    .HasColumnType("image");

                entity.Property(e => e.CFilename)
                    .IsRequired()
                    .HasColumnName("C_FILENAME")
                    .HasMaxLength(300);

                entity.Property(e => e.FkDondathang).HasColumnName("FK_DONDATHANG");
            });

            modelBuilder.Entity<TDondathangct>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DONDATHANGCT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDaban).HasColumnName("C_DABAN");

                entity.Property(e => e.CDongia)
                    .HasColumnName("C_DONGIA")
                    .HasColumnType("money");

                entity.Property(e => e.CDongia2)
                    .HasColumnName("C_DONGIA2")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CDongiatc)
                    .HasColumnName("C_DONGIATC")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CKhuyenmai).HasColumnName("C_KHUYENMAI");

                entity.Property(e => e.CNgaydukien)
                    .HasColumnName("C_NGAYDUKIEN")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CNgaynhan)
                    .HasColumnName("C_NGAYNHAN")
                    .HasColumnType("datetime");

                entity.Property(e => e.CPheduyet).HasColumnName("C_PHEDUYET");

                entity.Property(e => e.CSoluong)
                    .HasColumnName("C_SOLUONG")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CStopRemind).HasColumnName("C_StopRemind");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.CTinhthue).HasColumnName("C_TINHTHUE");

                entity.Property(e => e.FkDondathang).HasColumnName("FK_DONDATHANG");

                entity.Property(e => e.FkDvban).HasColumnName("FK_DVBAN");

                entity.Property(e => e.FkNguoipd).HasColumnName("FK_NGUOIPD");

                entity.Property(e => e.FkNguoncc).HasColumnName("FK_NGUONCC");

                entity.Property(e => e.FkTrangthai).HasColumnName("FK_TRANGTHAI");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<TDondathangdk>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DONDATHANGDK");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.FkDkbg).HasColumnName("FK_DKBG");

                entity.Property(e => e.FkDondathang).HasColumnName("FK_DONDATHANG");

                entity.HasOne(d => d.FkDondathangNavigation)
                    .WithMany(p => p.TDondathangdk)
                    .HasForeignKey(d => d.FkDondathang)
                    .HasConstraintName("FK_T_DONDATHANGDK_T_DONDATHANG");
            });

            modelBuilder.Entity<TDubao>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK_T_FORECAST");

                entity.ToTable("T_DUBAO");

                entity.HasIndex(e => new { e.FkDvcs, e.CNam, e.CThang, e.FkPhongban, e.FkKhachhang })
                    .HasName("IX_T_DUBAO")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CNam).HasColumnName("C_NAM");

                entity.Property(e => e.CThang).HasColumnName("C_THANG");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkKhachhang).HasColumnName("FK_KHACHHANG");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");
            });

            modelBuilder.Entity<TDubaoct>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DUBAOCT");

                entity.HasIndex(e => new { e.FkDubao, e.FkVthh })
                    .HasName("IX_T_DUBAOCT")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CSoluong)
                    .HasColumnName("C_SOLUONG")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FkDubao).HasColumnName("FK_DUBAO");

                entity.Property(e => e.FkDvban).HasColumnName("FK_DVBAN");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.HasOne(d => d.FkDubaoNavigation)
                    .WithMany(p => p.TDubaoct)
                    .HasForeignKey(d => d.FkDubao)
                    .HasConstraintName("FK_T_DUBAOCT_T_DUBAO");
            });

            modelBuilder.Entity<TDubaoctngay>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DUBAOCTNGAY");

                entity.HasIndex(e => new { e.FkDubaoct, e.CNgay })
                    .HasName("IX_T_DUBAOCTNGAY")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CNgay)
                    .HasColumnName("C_NGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CSoluong)
                    .HasColumnName("C_SOLUONG")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FkDubaoct).HasColumnName("FK_DUBAOCT");

                entity.HasOne(d => d.FkDubaoctNavigation)
                    .WithMany(p => p.TDubaoctngay)
                    .HasForeignKey(d => d.FkDubaoct)
                    .HasConstraintName("FK_T_DUBAOCTNGAY_T_DUBAOCT");
            });

            modelBuilder.Entity<TDubaots>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DUBAOTS");

                entity.HasIndex(e => e.CMa)
                    .HasName("IX_T_DUBAOTS")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CDenngay)
                    .HasColumnName("C_DENNGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(100);

                entity.Property(e => e.CHeso).HasColumnName("C_HESO");

                entity.Property(e => e.CKytruoc).HasColumnName("C_KYTRUOC");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CSokytruoc).HasColumnName("C_SOKYTRUOC");

                entity.Property(e => e.CTheokh).HasColumnName("C_THEOKH");

                entity.Property(e => e.CTungay)
                    .HasColumnName("C_TUNGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");
            });

            modelBuilder.Entity<TDubaotsdata>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_DUBAOTSDATA");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CHeso).HasColumnName("C_HESO");

                entity.Property(e => e.CSlban)
                    .HasColumnName("C_SLBAN")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CSltk)
                    .HasColumnName("C_SLTK")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FkDubaots).HasColumnName("FK_DUBAOTS");

                entity.Property(e => e.FkDvban).HasColumnName("FK_DVBAN");

                entity.Property(e => e.FkDvtk).HasColumnName("FK_DVTK");

                entity.Property(e => e.FkKhachhang).HasColumnName("FK_KHACHHANG");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.HasOne(d => d.FkDubaotsNavigation)
                    .WithMany(p => p.TDubaotsdata)
                    .HasForeignKey(d => d.FkDubaots)
                    .HasConstraintName("FK_T_DUBAOTSDATA_T_DUBAOTS");
            });

            modelBuilder.Entity<TEdocDoctype>(entity =>
            {
                entity.HasKey(e => e.CCode);

                entity.ToTable("T_EDOC_DOCTYPE");

                entity.Property(e => e.CCode)
                    .HasColumnName("C_CODE")
                    .HasMaxLength(12);

                entity.Property(e => e.CDescription)
                    .HasColumnName("C_DESCRIPTION")
                    .HasMaxLength(50);

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TEdocSecurlevel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_EDOC_SECURLEVEL");

                entity.Property(e => e.CDescription)
                    .IsRequired()
                    .HasColumnName("C_DESCRIPTION")
                    .HasMaxLength(50);

                entity.Property(e => e.PkId).HasColumnName("PK_ID");
            });

            modelBuilder.Entity<TFnproductrelation>(entity =>
            {
                entity.HasKey(e => new { e.FkChucnang, e.FkVthh });

                entity.ToTable("T_FNPRODUCTRELATION");

                entity.Property(e => e.FkChucnang).HasColumnName("FK_CHUCNANG");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<TGbg>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_GBG");

                entity.HasIndex(e => new { e.CSophieu, e.FkDvcs })
                    .HasName("IX_T_GBG")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDamua).HasColumnName("C_DAMUA");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CDenngay)
                    .HasColumnName("C_DENNGAY")
                    .HasColumnType("datetime");

                entity.Property(e => e.CKhdk)
                    .HasColumnName("C_KHDK")
                    .HasMaxLength(100);

                entity.Property(e => e.CKhdkdc)
                    .HasColumnName("C_KHDKDC")
                    .HasMaxLength(200);

                entity.Property(e => e.CKhdkdt)
                    .HasColumnName("C_KHDKDT")
                    .HasMaxLength(20);

                entity.Property(e => e.CKhdkemail)
                    .HasColumnName("C_KHDKEMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.CKhdkfax)
                    .HasColumnName("C_KHDKFAX")
                    .HasMaxLength(20);

                entity.Property(e => e.CKhdknlh)
                    .HasColumnName("C_KHDKNLH")
                    .HasMaxLength(50);

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNguoilh)
                    .HasColumnName("C_NGUOILH")
                    .HasMaxLength(40);

                entity.Property(e => e.CSophieu)
                    .IsRequired()
                    .HasColumnName("C_SOPHIEU")
                    .HasMaxLength(12);

                entity.Property(e => e.CTigia)
                    .HasColumnName("C_TIGIA")
                    .HasColumnType("money");

                entity.Property(e => e.CTungay)
                    .HasColumnName("C_TUNGAY")
                    .HasColumnType("datetime");

                entity.Property(e => e.CVat).HasColumnName("C_VAT");

                entity.Property(e => e.FkDdct).HasColumnName("FK_DDCT");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkHdbh)
                    .HasColumnName("FK_HDBH")
                    .HasMaxLength(12);

                entity.Property(e => e.FkKhachhang).HasColumnName("FK_KHACHHANG");

                entity.Property(e => e.FkLoaitien).HasColumnName("FK_LOAITIEN");

                entity.Property(e => e.FkNguoilh).HasColumnName("FK_NGUOILH");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVuviec).HasColumnName("FK_VUVIEC");
            });

            modelBuilder.Entity<TGbgdk>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_GBGDK");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .HasColumnName("C_MOTA")
                    .HasColumnType("ntext");

                entity.Property(e => e.FkDkbg).HasColumnName("FK_DKBG");

                entity.Property(e => e.FkGbg).HasColumnName("FK_GBG");
            });

            modelBuilder.Entity<TGbgvthh>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_GBGVTHH");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDongia)
                    .HasColumnName("C_DONGIA")
                    .HasColumnType("money");

                entity.Property(e => e.CSoluong).HasColumnName("C_SOLUONG");

                entity.Property(e => e.FkDvt).HasColumnName("FK_DVT");

                entity.Property(e => e.FkGbg).HasColumnName("FK_GBG");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<TGiaydathang>(entity =>
            {
                entity.HasKey(e => new { e.CSophieu, e.FkDvcs });

                entity.ToTable("T_GIAYDATHANG");

                entity.Property(e => e.CSophieu)
                    .HasColumnName("C_SOPHIEU")
                    .HasMaxLength(12);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.CDanhan).HasColumnName("C_DANHAN");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CDiengiai)
                    .HasColumnName("C_DIENGIAI")
                    .HasMaxLength(255);

                entity.Property(e => e.CKhdk)
                    .HasColumnName("C_KHDK")
                    .HasMaxLength(100);

                entity.Property(e => e.CKhdkdc)
                    .HasColumnName("C_KHDKDC")
                    .HasMaxLength(100);

                entity.Property(e => e.CKhdkdt)
                    .HasColumnName("C_KHDKDT")
                    .HasMaxLength(20);

                entity.Property(e => e.CKhdkemail)
                    .HasColumnName("C_KHDKEMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.CKhdkfax)
                    .HasColumnName("C_KHDKFAX")
                    .HasMaxLength(20);

                entity.Property(e => e.CKhdknlh)
                    .HasColumnName("C_KHDKNLH")
                    .HasMaxLength(40);

                entity.Property(e => e.CNgaygui)
                    .HasColumnName("C_NGAYGUI")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNgayhethan)
                    .HasColumnName("C_NGAYHETHAN")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.CTigia).HasColumnName("C_TIGIA");

                entity.Property(e => e.CVat).HasColumnName("C_VAT");

                entity.Property(e => e.FkDdct).HasColumnName("FK_DDCT");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkKhachhang).HasColumnName("FK_KHACHHANG");

                entity.Property(e => e.FkKmp).HasColumnName("FK_KMP");

                entity.Property(e => e.FkLoaitien).HasColumnName("FK_LOAITIEN");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkNguoilh)
                    .HasColumnName("FK_NGUOILH")
                    .HasMaxLength(255);

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");

                entity.Property(e => e.FkPttt).HasColumnName("FK_PTTT");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVuviec).HasColumnName("FK_VUVIEC");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TGiaydathangDoc>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_GIAYDATHANG_DOC");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CContent)
                    .IsRequired()
                    .HasColumnName("C_CONTENT")
                    .HasColumnType("image");

                entity.Property(e => e.CFilename)
                    .IsRequired()
                    .HasColumnName("C_FILENAME")
                    .HasMaxLength(300);

                entity.Property(e => e.FkDondathang).HasColumnName("FK_DONDATHANG");
            });

            modelBuilder.Entity<TGiaydathangct>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_GIAYDATHANGCT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDamua).HasColumnName("C_DAMUA");

                entity.Property(e => e.CDongia)
                    .HasColumnName("C_DONGIA")
                    .HasColumnType("money");

                entity.Property(e => e.CDongia2)
                    .HasColumnName("C_DONGIA2")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CNgaynhan)
                    .HasColumnName("C_NGAYNHAN")
                    .HasColumnType("datetime");

                entity.Property(e => e.CPheduyet)
                    .IsRequired()
                    .HasColumnName("C_PHEDUYET")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CSoluong).HasColumnName("C_SOLUONG");

                entity.Property(e => e.CStopRemind).HasColumnName("C_StopRemind");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.FkDvmua).HasColumnName("FK_DVMUA");

                entity.Property(e => e.FkGiaydathang).HasColumnName("FK_GIAYDATHANG");

                entity.Property(e => e.FkNguoipd).HasColumnName("FK_NGUOIPD");

                entity.Property(e => e.FkTrangthai).HasColumnName("FK_TRANGTHAI");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<TGiuhang>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_GIUHANG");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(100);

                entity.Property(e => e.CNgay)
                    .HasColumnName("C_NGAY")
                    .HasColumnType("datetime");

                entity.Property(e => e.CSoluong).HasColumnName("C_SOLUONG");

                entity.Property(e => e.CSophieu)
                    .HasColumnName("C_SOPHIEU")
                    .HasMaxLength(12);

                entity.Property(e => e.FkDongnhap).HasColumnName("FK_DONGNHAP");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkKenhap).HasColumnName("FK_KENHAP");

                entity.Property(e => e.FkKhonhap).HasColumnName("FK_KHONHAP");

                entity.Property(e => e.FkKieuyeucau)
                    .HasColumnName("FK_KIEUYEUCAU")
                    .HasMaxLength(5);

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.FkVuviec).HasColumnName("FK_VUVIEC");
            });

            modelBuilder.Entity<TGvbqtc>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_GVBQTC");

                entity.HasIndex(e => e.FkVthh)
                    .HasName("IX_T_GVBQTC");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDongia)
                    .HasColumnName("C_DONGIA")
                    .HasColumnType("money");

                entity.Property(e => e.CSoluong)
                    .HasColumnName("C_SOLUONG")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkKho).HasColumnName("FK_KHO");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.FkVuviec).HasColumnName("FK_VUVIEC");
            });

            modelBuilder.Entity<THnAp>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_HN_AP");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCreatetime)
                    .HasColumnName("C_CREATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(1000);

                entity.Property(e => e.CNgaythuchien)
                    .HasColumnName("C_NGAYTHUCHIEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkCa).HasColumnName("FK_CA");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVuep)
                    .IsRequired()
                    .HasColumnName("FK_VUEP")
                    .HasMaxLength(20);

                entity.HasOne(d => d.FkCaNavigation)
                    .WithMany(p => p.THnAp)
                    .HasForeignKey(d => d.FkCa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HN_AP_CA");
            });

            modelBuilder.Entity<THnApct>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK_HN_APCT");

                entity.ToTable("T_HN_APCT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CAp)
                    .HasColumnName("C_AP")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CBxcc)
                    .HasColumnName("C_BXCC")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CBxqs)
                    .HasColumnName("C_BXQS")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(1000);

                entity.Property(e => e.CGiothuchien)
                    .IsRequired()
                    .HasColumnName("C_GIOTHUCHIEN")
                    .HasMaxLength(20);

                entity.Property(e => e.CNhietdo)
                    .HasColumnName("C_NHIETDO")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CPolcc)
                    .HasColumnName("C_POLCC")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CPolqs)
                    .HasColumnName("C_POLQS")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FkDmMauHn).HasColumnName("FK_DM_MAU_HN");

                entity.Property(e => e.FkHnAp).HasColumnName("FK_HN_AP");

                entity.HasOne(d => d.FkDmMauHnNavigation)
                    .WithMany(p => p.THnApct)
                    .HasForeignKey(d => d.FkDmMauHn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HN_APCT_DM_MAU");

                entity.HasOne(d => d.FkHnApNavigation)
                    .WithMany(p => p.THnApct)
                    .HasForeignKey(d => d.FkHnAp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HN_APCT_AP");
            });

            modelBuilder.Entity<THnBanghieuchinh>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK_HN_BANGHIEUCHINH");

                entity.ToTable("T_HN_BANGHIEUCHINH");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CBxqs)
                    .HasColumnName("C_BXQS")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(1000);

                entity.Property(e => e.CGiaTri)
                    .HasColumnName("C_GiaTri")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CNhietdo)
                    .HasColumnName("C_NHIETDO")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<THnBasx>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK_HN_BASX");

                entity.ToTable("T_HN_BASX");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCreatetime)
                    .HasColumnName("C_CREATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(1000);

                entity.Property(e => e.CNgaythuchien)
                    .HasColumnName("C_NGAYTHUCHIEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkCa).HasColumnName("FK_CA");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVuep)
                    .IsRequired()
                    .HasColumnName("FK_VUEP")
                    .HasMaxLength(20);

                entity.HasOne(d => d.FkCaNavigation)
                    .WithMany(p => p.THnBasx)
                    .HasForeignKey(d => d.FkCa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HN_BASX_CA");
            });

            modelBuilder.Entity<THnBasxct>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_HN_BASXCT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(1000);

                entity.Property(e => e.CGiothuchien)
                    .IsRequired()
                    .HasColumnName("C_GIOTHUCHIEN")
                    .HasMaxLength(20);

                entity.Property(e => e.CNhietdonctt)
                    .HasColumnName("C_NHIETDONCTT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CPerw)
                    .HasColumnName("C_PERW")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CPolcc)
                    .HasColumnName("C_POLCC")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CPolqs)
                    .HasColumnName("C_POLQS")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTlddBaSkn)
                    .HasColumnName("C_TLDD_BA_SKN")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTlkhay)
                    .HasColumnName("C_TLKHAY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTlmauN)
                    .HasColumnName("C_TLMAU_N")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTlmauS)
                    .HasColumnName("C_TLMAU_S")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTlnoinau)
                    .HasColumnName("C_TLNOINAU")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTlnuocthamthau)
                    .HasColumnName("C_TLNUOCTHAMTHAU")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTlskn)
                    .HasColumnName("C_TLSKN")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTlsks)
                    .HasColumnName("C_TLSKS")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTltkn)
                    .HasColumnName("C_TLTKN")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTltks)
                    .HasColumnName("C_TLTKS")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FkHnBasx).HasColumnName("FK_HN_BASX");

                entity.HasOne(d => d.FkHnBasxNavigation)
                    .WithMany(p => p.THnBasxct)
                    .HasForeignKey(d => d.FkHnBasx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("T_HN_BASXCT_BASX");
            });

            modelBuilder.Entity<THnBunloc>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK_HN_BUNLOC");

                entity.ToTable("T_HN_BUNLOC");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCreatetime)
                    .HasColumnName("C_CREATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(1000);

                entity.Property(e => e.CNgaythuchien)
                    .HasColumnName("C_NGAYTHUCHIEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkCa).HasColumnName("FK_CA");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVuep)
                    .IsRequired()
                    .HasColumnName("FK_VUEP")
                    .HasMaxLength(20);

                entity.HasOne(d => d.FkCaNavigation)
                    .WithMany(p => p.THnBunloc)
                    .HasForeignKey(d => d.FkCa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HN_BUNLOC_CA");
            });

            modelBuilder.Entity<THnBunlocct>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK_HN_BUNLOCCT");

                entity.ToTable("T_HN_BUNLOCCT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(1000);

                entity.Property(e => e.CGiothuchien)
                    .IsRequired()
                    .HasColumnName("C_GIOTHUCHIEN")
                    .HasMaxLength(20);

                entity.Property(e => e.CPerw)
                    .HasColumnName("C_PERW")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CPolcc)
                    .HasColumnName("C_POLCC")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CPolkho)
                    .HasColumnName("C_POLKHO")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CPolqs)
                    .HasColumnName("C_POLQS")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTlbun)
                    .HasColumnName("C_TLBUN")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTlkhay)
                    .HasColumnName("C_TLKHAY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTlsks)
                    .HasColumnName("C_TLSKS")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTltks)
                    .HasColumnName("C_TLTKS")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FkHnBunloc).HasColumnName("FK_HN_BUNLOC");

                entity.HasOne(d => d.FkHnBunlocNavigation)
                    .WithMany(p => p.THnBunlocct)
                    .HasForeignKey(d => d.FkHnBunloc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HN_BUNLOCCT_BUNLOC");
            });

            modelBuilder.Entity<THnCuongvikiem>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK_HN_CUONGVIKIEM");

                entity.ToTable("T_HN_CUONGVIKIEM");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCreatetime)
                    .HasColumnName("C_CREATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(1000);

                entity.Property(e => e.CNgaythuchien)
                    .HasColumnName("C_NGAYTHUCHIEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkCa).HasColumnName("FK_CA");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVuep)
                    .IsRequired()
                    .HasColumnName("FK_VUEP")
                    .HasMaxLength(20);

                entity.HasOne(d => d.FkCaNavigation)
                    .WithMany(p => p.THnCuongvikiem)
                    .HasForeignKey(d => d.FkCa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HN_CUONGVIKIEM_CA");
            });

            modelBuilder.Entity<THnCuongvikiemct>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK_HN_CUONGVIKIEMCT");

                entity.ToTable("T_HN_CUONGVIKIEMCT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CBe)
                    .HasColumnName("C_BE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(1000);

                entity.Property(e => e.CGiothuchien)
                    .IsRequired()
                    .HasColumnName("C_GIOTHUCHIEN")
                    .HasMaxLength(20);

                entity.Property(e => e.CIu)
                    .HasColumnName("C_IU")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CP2o5)
                    .HasColumnName("C_P2O5")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CPh)
                    .HasColumnName("C_PH")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CRs)
                    .HasColumnName("C_RS")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CSo2)
                    .HasColumnName("C_SO2")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FkDmMauHn).HasColumnName("FK_DM_MAU_HN");

                entity.Property(e => e.FkHnCuongvikiem).HasColumnName("FK_HN_CUONGVIKIEM");

                entity.HasOne(d => d.FkDmMauHnNavigation)
                    .WithMany(p => p.THnCuongvikiemct)
                    .HasForeignKey(d => d.FkDmMauHn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HN_CUONGVIKIEMCT_DM_MAU");

                entity.HasOne(d => d.FkHnCuongvikiemNavigation)
                    .WithMany(p => p.THnCuongvikiemct)
                    .HasForeignKey(d => d.FkHnCuongvikiem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HN_CUONGVIKIEMCT_CUONGVIKIEM");
            });

            modelBuilder.Entity<THnDuongnon>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_HN_DUONGNON");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCreatetime)
                    .HasColumnName("C_CREATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(1000);

                entity.Property(e => e.CNgaythuchien)
                    .HasColumnName("C_NGAYTHUCHIEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkCa).HasColumnName("FK_CA");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVuep)
                    .IsRequired()
                    .HasColumnName("FK_VUEP")
                    .HasMaxLength(20);

                entity.HasOne(d => d.FkCaNavigation)
                    .WithMany(p => p.THnDuongnon)
                    .HasForeignKey(d => d.FkCa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HN_DUONGNON_CA");
            });

            modelBuilder.Entity<THnDuongnonct>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK_HN_DUONGNONCT");

                entity.ToTable("T_HN_DUONGNONCT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CAp)
                    .HasColumnName("C_AP")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CBxcc)
                    .HasColumnName("C_BXCC")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CBxqs)
                    .HasColumnName("C_BXQS")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(1000);

                entity.Property(e => e.CGionha)
                    .IsRequired()
                    .HasColumnName("C_GIONHA")
                    .HasMaxLength(20);

                entity.Property(e => e.CGiothuchien)
                    .IsRequired()
                    .HasColumnName("C_GIOTHUCHIEN")
                    .HasMaxLength(20);

                entity.Property(e => e.CNhietdo)
                    .HasColumnName("C_NHIETDO")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CPolcc)
                    .HasColumnName("C_POLCC")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CPolqs)
                    .HasColumnName("C_POLQS")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CSonoi).HasColumnName("C_SONOI");

                entity.Property(e => e.CThetich)
                    .HasColumnName("C_THETICH")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FkDmMauHn).HasColumnName("FK_DM_MAU_HN");

                entity.Property(e => e.FkHnDuongnon).HasColumnName("FK_HN_DUONGNON");

                entity.HasOne(d => d.FkDmMauHnNavigation)
                    .WithMany(p => p.THnDuongnonct)
                    .HasForeignKey(d => d.FkDmMauHn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HN_DUONGNONCT_DM_MAU");

                entity.HasOne(d => d.FkHnDuongnonNavigation)
                    .WithMany(p => p.THnDuongnonct)
                    .HasForeignKey(d => d.FkHnDuongnon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HN_DUONGNONCT_DUONGNON");
            });

            modelBuilder.Entity<THnDuongtp>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK_HN_DUONGTP");

                entity.ToTable("T_HN_DUONGTP");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCreatetime)
                    .HasColumnName("C_CREATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(1000);

                entity.Property(e => e.CNgaythuchien)
                    .HasColumnName("C_NGAYTHUCHIEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkCa).HasColumnName("FK_CA");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVuep)
                    .IsRequired()
                    .HasColumnName("FK_VUEP")
                    .HasMaxLength(20);

                entity.HasOne(d => d.FkCaNavigation)
                    .WithMany(p => p.THnDuongtp)
                    .HasForeignKey(d => d.FkCa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HN_DUONGTP_CA");
            });

            modelBuilder.Entity<THnDuongtpct>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK_HN_DUONGTPCT");

                entity.ToTable("T_HN_DUONGTPCT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(1000);

                entity.Property(e => e.CGiothuchien)
                    .IsRequired()
                    .HasColumnName("C_GIOTHUCHIEN")
                    .HasMaxLength(20);

                entity.Property(e => e.CIu)
                    .HasColumnName("C_IU")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CNhietdo)
                    .HasColumnName("C_NHIETDO")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CPersacc)
                    .HasColumnName("C_PERSACC")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CPertapchat)
                    .HasColumnName("C_PERTAPCHAT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CPerw)
                    .HasColumnName("C_PERW")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CPolqs)
                    .HasColumnName("C_POLQS")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CRs)
                    .HasColumnName("C_RS")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CSluongnoinau)
                    .IsRequired()
                    .HasColumnName("C_SLUONGNOINAU")
                    .HasMaxLength(100);

                entity.Property(e => e.CTlmatdi)
                    .HasColumnName("C_TLMATDI")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CTlsks)
                    .HasColumnName("C_TLSKS")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CTltks)
                    .HasColumnName("C_TLTKS")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.FkHnDuongtp).HasColumnName("FK_HN_DUONGTP");

                entity.HasOne(d => d.FkHnDuongtpNavigation)
                    .WithMany(p => p.THnDuongtpct)
                    .HasForeignKey(d => d.FkHnDuongtp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HN_DUONGTPCT_DUONGTP");
            });

            modelBuilder.Entity<THnNuoclo>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK_HN_NUOCLO");

                entity.ToTable("T_HN_NUOCLO");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCreatetime)
                    .HasColumnName("C_CREATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(1000);

                entity.Property(e => e.CNgaythuchien)
                    .HasColumnName("C_NGAYTHUCHIEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkCa).HasColumnName("FK_CA");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVuep)
                    .IsRequired()
                    .HasColumnName("FK_VUEP")
                    .HasMaxLength(20);

                entity.HasOne(d => d.FkCaNavigation)
                    .WithMany(p => p.THnNuoclo)
                    .HasForeignKey(d => d.FkCa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HN_NUOCLO_CA");
            });

            modelBuilder.Entity<THnNuocloct>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK_HN_NUOCLOCT");

                entity.ToTable("T_HN_NUOCLOCT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CB3Edta)
                    .HasColumnName("C_B3_EDTA")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CB4Edta)
                    .HasColumnName("C_B4_EDTA")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CB5Edta)
                    .HasColumnName("C_B5_EDTA")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CB6Edta)
                    .HasColumnName("C_B6_EDTA")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CCl1)
                    .HasColumnName("C_CL1")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CCl2)
                    .HasColumnName("C_CL2")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CCl3)
                    .HasColumnName("C_CL3")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CCl4)
                    .HasColumnName("C_CL4")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CEdta1)
                    .HasColumnName("C_EDTA1")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CEdta2)
                    .HasColumnName("C_EDTA2")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CEdta3)
                    .HasColumnName("C_EDTA3")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CEdta4)
                    .HasColumnName("C_EDTA4")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(1000);

                entity.Property(e => e.CGiothuchien)
                    .IsRequired()
                    .HasColumnName("C_GIOTHUCHIEN")
                    .HasMaxLength(20);

                entity.Property(e => e.CMo3)
                    .HasColumnName("C_MO3")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CMo4)
                    .HasColumnName("C_MO4")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CNngungduong)
                    .HasColumnName("C_NNGUNGDUONG")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CNnguonEdta)
                    .HasColumnName("C_NNGUON_EDTA")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CNthaiph)
                    .HasColumnName("C_NTHAIPH")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CPh1)
                    .HasColumnName("C_PH1")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CPh2)
                    .HasColumnName("C_PH2")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CPh3)
                    .HasColumnName("C_PH3")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CPh4)
                    .HasColumnName("C_PH4")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CPo43)
                    .HasColumnName("C_PO43")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CPo44)
                    .HasColumnName("C_PO44")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CPp3)
                    .HasColumnName("C_PP3")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CPp4)
                    .HasColumnName("C_PP4")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FkHnNuoclo).HasColumnName("FK_HN_NUOCLO");

                entity.HasOne(d => d.FkHnNuocloNavigation)
                    .WithMany(p => p.THnNuocloct)
                    .HasForeignKey(d => d.FkHnNuoclo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HN_NUOCLOCT_NUOCLO");
            });

            modelBuilder.Entity<THnThoigian>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_HN_THOIGIAN");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCreatetime)
                    .HasColumnName("C_CREATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(1000);

                entity.Property(e => e.CNgaythuchien)
                    .HasColumnName("C_NGAYTHUCHIEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkCa).HasColumnName("FK_CA");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVuep)
                    .IsRequired()
                    .HasColumnName("FK_VUEP")
                    .HasMaxLength(20);

                entity.HasOne(d => d.FkCaNavigation)
                    .WithMany(p => p.THnThoigian)
                    .HasForeignKey(d => d.FkCa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HN_THOIGIAN_CA");
            });

            modelBuilder.Entity<THnThoigianct>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_HN_THOIGIANCT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCreatetime)
                    .HasColumnName("C_CREATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CDothieudien)
                    .HasColumnName("C_DOTHIEUDIEN")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CDothieunhienlieu)
                    .HasColumnName("C_DOTHIEUNHIENLIEU")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CDothieunuoc)
                    .HasColumnName("C_DOTHIEUNUOC")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(1000);

                entity.Property(e => e.CGiothuchien)
                    .HasColumnName("C_GIOTHUCHIEN")
                    .HasMaxLength(10);

                entity.Property(e => e.CTgchomia).HasColumnName("C_TGCHOMIA");

                entity.Property(e => e.CTgepmia).HasColumnName("C_TGEPMIA");

                entity.Property(e => e.CTghongmaycd).HasColumnName("C_TGHONGMAYCD");

                entity.Property(e => e.CTghongmaycdluyen).HasColumnName("C_TGHONGMAYCDLUYEN");

                entity.Property(e => e.CTgkhac).HasColumnName("C_TGKHAC");

                entity.Property(e => e.CTgktradinhky).HasColumnName("C_TGKTRADINHKY");

                entity.Property(e => e.CTgngungep).HasColumnName("C_TGNGUNGEP");

                entity.Property(e => e.CTgsucolohoi).HasColumnName("C_TGSUCOLOHOI");

                entity.Property(e => e.CTgxulycongnghe).HasColumnName("C_TGXULYCONGNGHE");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkHnThoigian).HasColumnName("FK_HN_THOIGIAN");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVuep)
                    .IsRequired()
                    .HasColumnName("FK_VUEP")
                    .HasMaxLength(20);

                entity.HasOne(d => d.FkHnThoigianNavigation)
                    .WithMany(p => p.THnThoigianct)
                    .HasForeignKey(d => d.FkHnThoigian)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HN_THOIGIANCT_THOIGIAN");
            });

            modelBuilder.Entity<THnXomia>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_HN_XOMIA");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CBxba)
                    .HasColumnName("C_BXBA")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CBxddskn)
                    .HasColumnName("C_BXDDSKN")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CBxqsddskn)
                    .HasColumnName("C_BXQSDDSKN")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(1000);

                entity.Property(e => e.CNgaythuchien)
                    .HasColumnName("C_NGAYTHUCHIEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNhietdo)
                    .HasColumnName("C_NHIETDO")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CPerw)
                    .HasColumnName("C_PERW")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CPerxomia)
                    .HasColumnName("C_PERXOMIA")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CPolba)
                    .HasColumnName("C_POLBA")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CPolqsddskn)
                    .HasColumnName("C_POLQSDDSKN")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CTlba)
                    .HasColumnName("C_TLBA")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CTlddmatdi)
                    .HasColumnName("C_TLDDMATDI")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CTlmia)
                    .HasColumnName("C_TLMIA")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CTlnuocmia)
                    .HasColumnName("C_TLNUOCMIA")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CTlskn)
                    .HasColumnName("C_TLSKN")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CTlsks)
                    .HasColumnName("C_TLSKS")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CTltkn)
                    .HasColumnName("C_TLTKN")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CTltks)
                    .HasColumnName("C_TLTKS")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FkCa).HasColumnName("FK_CA");

                entity.Property(e => e.FkVuep)
                    .IsRequired()
                    .HasColumnName("FK_VUEP")
                    .HasMaxLength(20);

                entity.HasOne(d => d.FkCaNavigation)
                    .WithMany(p => p.THnXomia)
                    .HasForeignKey(d => d.FkCa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HN_XOMIA_CA");
            });

            modelBuilder.Entity<TKetchuyen>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_KETCHUYEN");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDiengiai)
                    .HasColumnName("C_DIENGIAI")
                    .HasMaxLength(50);

                entity.Property(e => e.CLanthu).HasColumnName("C_LANTHU");

                entity.Property(e => e.CSangtk)
                    .HasColumnName("C_SANGTK")
                    .HasMaxLength(12);

                entity.Property(e => e.CTuben).HasColumnName("C_TUBEN");

                entity.Property(e => e.CTutk)
                    .HasColumnName("C_TUTK")
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<TKiemke>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_KIEMKE");

                entity.HasIndex(e => new { e.FkKykiemke, e.FkKhohang, e.FkVthh })
                    .HasName("IX_T_KIEMKE")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CSlchenhlech).HasColumnName("C_SLCHENHLECH");

                entity.Property(e => e.CSlsosach).HasColumnName("C_SLSOSACH");

                entity.Property(e => e.CSlthucte).HasColumnName("C_SLTHUCTE");

                entity.Property(e => e.FkDvt).HasColumnName("FK_DVT");

                entity.Property(e => e.FkKhohang).HasColumnName("FK_KHOHANG");

                entity.Property(e => e.FkKykiemke).HasColumnName("FK_KYKIEMKE");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<TKiemketemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_KIEMKETEMP");

                entity.Property(e => e.CDvt)
                    .HasColumnName("C_DVT")
                    .HasMaxLength(20);

                entity.Property(e => e.CKhohang)
                    .HasColumnName("C_KHOHANG")
                    .HasMaxLength(50);

                entity.Property(e => e.CKykiemke)
                    .HasColumnName("C_KYKIEMKE")
                    .HasMaxLength(50);

                entity.Property(e => e.CMa)
                    .HasColumnName("C_MA")
                    .HasMaxLength(20);

                entity.Property(e => e.CMaphu)
                    .HasColumnName("C_MAPHU")
                    .HasMaxLength(12);

                entity.Property(e => e.CTen)
                    .HasColumnName("C_TEN")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TKyketoan>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_KYKETOAN");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDenngay)
                    .HasColumnName("C_DENNGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CHientai).HasColumnName("C_HIENTAI");

                entity.Property(e => e.CKhoa).HasColumnName("C_KHOA");

                entity.Property(e => e.CTen)
                    .IsRequired()
                    .HasColumnName("C_TEN")
                    .HasMaxLength(50);

                entity.Property(e => e.CTiGiaHachToan)
                    .HasColumnName("C_TiGiaHachToan")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTungay)
                    .HasColumnName("C_TUNGAY")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TLich>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK_T_LICHLAMVIEC");

                entity.ToTable("T_LICH");

                entity.HasIndex(e => new { e.FkDvcs, e.CNam })
                    .HasName("IX_T_LICHLAMVIEC")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CChuNhat).HasColumnName("C_ChuNhat");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CNam).HasColumnName("C_Nam");

                entity.Property(e => e.CThuBa).HasColumnName("C_ThuBa");

                entity.Property(e => e.CThuBay).HasColumnName("C_ThuBay");

                entity.Property(e => e.CThuHai).HasColumnName("C_ThuHai");

                entity.Property(e => e.CThuNam).HasColumnName("C_ThuNam");

                entity.Property(e => e.CThuSau).HasColumnName("C_ThuSau");

                entity.Property(e => e.CThuTu).HasColumnName("C_ThuTu");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");
            });

            modelBuilder.Entity<TLichchitiet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_LICHCHITIET");

                entity.HasIndex(e => new { e.FkLich, e.CNgay })
                    .HasName("IX_T_LICHCHITIET")
                    .IsUnique();

                entity.Property(e => e.CGhiChu)
                    .IsRequired()
                    .HasColumnName("C_GhiChu")
                    .HasMaxLength(100);

                entity.Property(e => e.CNgay)
                    .HasColumnName("C_Ngay")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FkLich).HasColumnName("FK_LICH");

                entity.HasOne(d => d.FkLichNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.FkLich)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_LICHCHITIET_T_LICH");
            });

            modelBuilder.Entity<TLsx>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_LSX");

                entity.HasIndex(e => new { e.CMa, e.FkDvcs })
                    .HasName("IX_T_LSX")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CKtsx).HasColumnName("C_KTSX");

                entity.Property(e => e.CKttc).HasColumnName("C_KTTC");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(50);

                entity.Property(e => e.CMota)
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.CNgaykt)
                    .HasColumnName("C_NGAYKT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkKhachhang).HasColumnName("FK_KHACHHANG");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");
            });

            modelBuilder.Entity<TLsxct>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_LSXCT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CHtsx)
                    .IsRequired()
                    .HasColumnName("C_HTSX")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CNgaybd)
                    .HasColumnName("C_NGAYBD")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNgaygh)
                    .HasColumnName("C_NGAYGH")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNgayht)
                    .HasColumnName("C_NGAYHT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CPheduyet)
                    .IsRequired()
                    .HasColumnName("C_PHEDUYET")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CSlhoanthanh)
                    .HasColumnName("C_SLHOANTHANH")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CSoluong).HasColumnName("C_SOLUONG");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.FkDvt).HasColumnName("FK_DVT");

                entity.Property(e => e.FkLsx).HasColumnName("FK_LSX");

                entity.Property(e => e.FkTkno)
                    .HasColumnName("FK_TKNO")
                    .HasMaxLength(12);

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<TLsxctkh>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_LSXCTKH");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CHtsx).HasColumnName("C_HTSX");

                entity.Property(e => e.CNgaybd)
                    .HasColumnName("C_NGAYBD")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CNgayht)
                    .HasColumnName("C_NGAYHT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CSoluong).HasColumnName("C_SOLUONG");

                entity.Property(e => e.CSoluonghong).HasColumnName("C_SOLUONGHONG");

                entity.Property(e => e.CSoluongtot).HasColumnName("C_SOLUONGTOT");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.FkCa).HasColumnName("FK_CA");

                entity.Property(e => e.FkChucnang).HasColumnName("FK_CHUCNANG");

                entity.Property(e => e.FkLsxct).HasColumnName("FK_LSXCT");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");

                entity.HasOne(d => d.FkLsxctNavigation)
                    .WithMany(p => p.TLsxctkh)
                    .HasForeignKey(d => d.FkLsxct)
                    .HasConstraintName("FK_T_LSXCTKH_T_LSXCT");
            });

            modelBuilder.Entity<TLsxnl>(entity =>
            {
                entity.HasKey(e => e.FkLsxct)
                    .HasName("PK_T_LSXNL_1");

                entity.ToTable("T_LSXNL");

                entity.Property(e => e.FkLsxct)
                    .HasColumnName("FK_LSXCT")
                    .ValueGeneratedNever();

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(200);

                entity.Property(e => e.CLtoffset)
                    .HasColumnName("C_LTOffset")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(20);

                entity.Property(e => e.CMaphu).HasColumnName("C_MAPHU");

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CScrapPercent)
                    .HasColumnName("C_ScrapPercent")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CSltp)
                    .HasColumnName("C_SLTP")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.CSogia).HasColumnName("C_SOGIA");

                entity.Property(e => e.FkChucnang).HasColumnName("FK_CHUCNANG");

                entity.Property(e => e.FkDvttp).HasColumnName("FK_DVTTP");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkTrangthai).HasColumnName("FK_TRANGTHAI");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");
            });

            modelBuilder.Entity<TLsxnlct>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK_T_LSXNL");

                entity.ToTable("T_LSXNLCT");

                entity.HasIndex(e => new { e.FkLsxct, e.CStt })
                    .HasName("IX_T_LSXNLCT")
                    .IsUnique();

                entity.HasIndex(e => new { e.FkLsxct, e.FkVthh })
                    .HasName("IX_T_LSXNLCT_1")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CLtoffset)
                    .HasColumnName("C_LTOffset")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CPromotionType).HasColumnName("C_PromotionType");

                entity.Property(e => e.CScrapPercent)
                    .HasColumnName("C_ScrapPercent")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CSoluong).HasColumnName("C_SOLUONG");

                entity.Property(e => e.CSoluong2)
                    .HasColumnName("C_SOLUONG2")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.FkChucnang).HasColumnName("FK_CHUCNANG");

                entity.Property(e => e.FkDvt).HasColumnName("FK_DVT");

                entity.Property(e => e.FkLsxct).HasColumnName("FK_LSXCT");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.HasOne(d => d.FkLsxctNavigation)
                    .WithMany(p => p.TLsxnlct)
                    .HasForeignKey(d => d.FkLsxct)
                    .HasConstraintName("FK_T_LSXNLCT_T_LSXNL");
            });

            modelBuilder.Entity<TLsxqtsx>(entity =>
            {
                entity.HasKey(e => e.FkLsxct)
                    .HasName("PK_T_LSXQTSX2");

                entity.ToTable("T_LSXQTSX");

                entity.Property(e => e.FkLsxct)
                    .HasColumnName("FK_LSXCT")
                    .ValueGeneratedNever();

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(200);

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(20);

                entity.Property(e => e.CMaphu).HasColumnName("C_MAPHU");

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CSogia).HasColumnName("C_SOGIA");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkTrangthai).HasColumnName("FK_TRANGTHAI");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");
            });

            modelBuilder.Entity<TLsxqtsxct>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK_T_LSXQTSX");

                entity.ToTable("T_LSXQTSXCT");

                entity.HasIndex(e => new { e.FkLsxct, e.CStt })
                    .HasName("IX_T_LSXQTSXCT")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CEndTime)
                    .HasColumnName("C_EndTime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CKieu).HasColumnName("C_KIEU");

                entity.Property(e => e.CLaborTime)
                    .HasColumnName("C_LaborTime")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CMachineTime)
                    .HasColumnName("C_MachineTime")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.COverlapQuantity)
                    .HasColumnName("C_OverlapQuantity")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CPacer).HasColumnName("C_Pacer");

                entity.Property(e => e.CQuantity)
                    .HasColumnName("C_Quantity")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CStartTime)
                    .HasColumnName("C_StartTime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.FkChucnang).HasColumnName("FK_CHUCNANG");

                entity.Property(e => e.FkCostCenter).HasColumnName("FK_CostCenter");

                entity.Property(e => e.FkLaborrate).HasColumnName("FK_LABORRATE");

                entity.Property(e => e.FkLabortimeuom).HasColumnName("FK_LABORTIMEUOM");

                entity.Property(e => e.FkLsxct).HasColumnName("FK_LSXCT");

                entity.Property(e => e.FkMachinerate).HasColumnName("FK_MACHINERATE");

                entity.Property(e => e.FkMachinetimeuom).HasColumnName("FK_MACHINETIMEUOM");

                entity.Property(e => e.FkNcc).HasColumnName("FK_NCC");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");

                entity.HasOne(d => d.FkLsxctNavigation)
                    .WithMany(p => p.TLsxqtsxct)
                    .HasForeignKey(d => d.FkLsxct)
                    .HasConstraintName("FK_T_LSXQTSXCT_T_LSXQTSX");
            });

            modelBuilder.Entity<TLuongNhanvienBhxh>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_LUONG_NHANVIEN_BHXH");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDiengiai)
                    .HasColumnName("C_DIENGIAI")
                    .HasMaxLength(255);

                entity.Property(e => e.CHeso)
                    .HasColumnName("C_HESO")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CMaso)
                    .HasColumnName("C_MASO")
                    .HasMaxLength(25);

                entity.Property(e => e.CMucluong)
                    .HasColumnName("C_MUCLUONG")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CNgay)
                    .HasColumnName("C_NGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CPhantram).HasColumnName("C_PHANTRAM");

                entity.Property(e => e.CSongay).HasColumnName("C_SONGAY");

                entity.Property(e => e.CSongayBh).HasColumnName("C_SONGAY_BH");

                entity.Property(e => e.CTienBhtra)
                    .HasColumnName("C_TIEN_BHTRA")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTienDntra)
                    .HasColumnName("C_TIEN_DNTRA")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TLuongNhanvienVisa>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_LUONG_NHANVIEN_VISA");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(50);

                entity.Property(e => e.CMaso)
                    .HasColumnName("C_MASO")
                    .HasMaxLength(30);

                entity.Property(e => e.CNgayhethan)
                    .HasColumnName("C_NGAYHETHAN")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FkNhanvien).HasColumnName("FK_NHANVIEN");
            });

            modelBuilder.Entity<TLuongPhanloainvCost>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_LUONG_PHANLOAINV_COST");

                entity.HasIndex(e => new { e.CNgay, e.FkPhanloainv })
                    .HasName("IX_T_LUONG_PHANLOAINV_COST")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CGiantiep)
                    .HasColumnName("C_GIANTIEP")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CNgay)
                    .HasColumnName("C_NGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CTructiep)
                    .HasColumnName("C_TRUCTIEP")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FkPhanloainv).HasColumnName("FK_PHANLOAINV");
            });

            modelBuilder.Entity<TMrpdata>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_MRPDATA");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CConverted).HasColumnName("C_CONVERTED");

                entity.Property(e => e.CDemandforecast)
                    .HasColumnName("C_DEMANDFORECAST")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CDemandsafety)
                    .HasColumnName("C_DEMANDSAFETY")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CDemandso)
                    .HasColumnName("C_DEMANDSO")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CDemandwo)
                    .HasColumnName("C_DEMANDWO")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CDuedate)
                    .HasColumnName("C_DUEDATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.COrder)
                    .HasColumnName("C_ORDER")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CStartdate)
                    .HasColumnName("C_STARTDATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CSupplypo)
                    .HasColumnName("C_SUPPLYPO")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CSupplystock)
                    .HasColumnName("C_SUPPLYSTOCK")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CSupplywo)
                    .HasColumnName("C_SUPPLYWO")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.FkMrpoption).HasColumnName("FK_MRPOPTION");

                entity.Property(e => e.FkProduct).HasColumnName("FK_PRODUCT");

                entity.Property(e => e.FkPurchaseorder).HasColumnName("FK_PURCHASEORDER");

                entity.Property(e => e.FkSource).HasColumnName("FK_SOURCE");

                entity.Property(e => e.FkWorkorder).HasColumnName("FK_WORKORDER");
            });

            modelBuilder.Entity<TMrpoption>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_MRPOPTION");

                entity.HasIndex(e => new { e.CCode, e.CVersion })
                    .HasName("IX_T_MRPOPTION")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCheckpoint).HasColumnName("C_CHECKPOINT");

                entity.Property(e => e.CCode)
                    .IsRequired()
                    .HasColumnName("C_CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CDemandworkorder).HasColumnName("C_DEMANDWORKORDER");

                entity.Property(e => e.CDescription)
                    .HasColumnName("C_DESCRIPTION")
                    .HasMaxLength(200);

                entity.Property(e => e.CForecast).HasColumnName("C_FORECAST");

                entity.Property(e => e.CFromdate)
                    .HasColumnName("C_FROMDATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CLastupdate)
                    .HasColumnName("C_LASTUPDATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.COnhand).HasColumnName("C_ONHAND");

                entity.Property(e => e.CPurchaseorder).HasColumnName("C_PURCHASEORDER");

                entity.Property(e => e.CSafetystock).HasColumnName("C_SAFETYSTOCK");

                entity.Property(e => e.CSalesorder).HasColumnName("C_SALESORDER");

                entity.Property(e => e.CScheduletype).HasColumnName("C_SCHEDULETYPE");

                entity.Property(e => e.CSupplyworkorder).HasColumnName("C_SUPPLYWORKORDER");

                entity.Property(e => e.CTodate)
                    .HasColumnName("C_TODATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CVersion).HasColumnName("C_VERSION");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");
            });

            modelBuilder.Entity<TNam>(entity =>
            {
                entity.HasKey(e => e.CNam);

                entity.ToTable("T_NAM");

                entity.Property(e => e.CNam)
                    .HasColumnName("C_Nam")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TPdh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_PDH");

                entity.Property(e => e.CDiengiai)
                    .HasColumnName("C_DIENGIAI")
                    .HasMaxLength(255);

                entity.Property(e => e.CKhdk)
                    .HasColumnName("C_KHDK")
                    .HasMaxLength(100);

                entity.Property(e => e.CKhdkdc)
                    .HasColumnName("C_KHDKDC")
                    .HasMaxLength(100);

                entity.Property(e => e.CKhdkdt)
                    .HasColumnName("C_KHDKDT")
                    .HasMaxLength(20);

                entity.Property(e => e.CKhdkemail)
                    .HasColumnName("C_KHDKEMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.CKhdkfax)
                    .HasColumnName("C_KHDKFAX")
                    .HasMaxLength(20);

                entity.Property(e => e.CKhdknlh)
                    .HasColumnName("C_KHDKNLH")
                    .HasMaxLength(40);

                entity.Property(e => e.CNgaygui)
                    .HasColumnName("C_NGAYGUI")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNgayhethan)
                    .HasColumnName("C_NGAYHETHAN")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNguoimh)
                    .HasColumnName("C_NGUOIMH")
                    .HasMaxLength(40);

                entity.Property(e => e.CPheduyet).HasColumnName("C_PHEDUYET");

                entity.Property(e => e.CSophieu)
                    .IsRequired()
                    .HasColumnName("C_SOPHIEU")
                    .HasMaxLength(12);

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkKhachhang).HasColumnName("FK_KHACHHANG");

                entity.Property(e => e.FkKmp).HasColumnName("FK_KMP");

                entity.Property(e => e.FkLoaitien).HasColumnName("FK_LOAITIEN");

                entity.Property(e => e.FkNguoilh).HasColumnName("FK_NGUOILH");

                entity.Property(e => e.FkNguoipd).HasColumnName("FK_NGUOIPD");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");

                entity.Property(e => e.FkVuviec).HasColumnName("FK_VUVIEC");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TPdhct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_PDHCT");

                entity.Property(e => e.CGia)
                    .HasColumnName("C_GIA")
                    .HasColumnType("money");

                entity.Property(e => e.CNgaynhan)
                    .HasColumnName("C_NGAYNHAN")
                    .HasColumnType("datetime");

                entity.Property(e => e.CSoluong).HasColumnName("C_SOLUONG");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.CTrangthai).HasColumnName("C_TRANGTHAI");

                entity.Property(e => e.FkDvmua).HasColumnName("FK_DVMUA");

                entity.Property(e => e.FkPdh).HasColumnName("FK_PDH");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");
            });

            modelBuilder.Entity<TQlpx>(entity =>
            {
                entity.HasKey(e => new { e.CSophieu, e.FkDvcs });

                entity.ToTable("T_QLPX");

                entity.HasIndex(e => e.PkId)
                    .HasName("IX_T_QLPX")
                    .IsUnique();

                entity.Property(e => e.CSophieu)
                    .HasColumnName("C_SOPHIEU")
                    .HasMaxLength(12);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.CTheolsx).HasColumnName("C_THEOLSX");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TQlpxct>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_QLPXCT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCa).HasColumnName("C_CA");

                entity.Property(e => e.CNgaybd)
                    .HasColumnName("C_NGAYBD")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNgayht)
                    .HasColumnName("C_NGAYHT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CSoluong).HasColumnName("C_SOLUONG");

                entity.Property(e => e.CSoluongvao).HasColumnName("C_SOLUONGVAO");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.FkChucnang).HasColumnName("FK_CHUCNANG");

                entity.Property(e => e.FkLsx).HasColumnName("FK_LSX");

                entity.Property(e => e.FkLsxct).HasColumnName("FK_LSXCT");

                entity.Property(e => e.FkQlpx).HasColumnName("FK_QLPX");
            });

            modelBuilder.Entity<TQlxDenghinhap>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_QLX_DENGHINHAP");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(250);

                entity.Property(e => e.CMa)
                    .HasColumnName("C_MA")
                    .HasMaxLength(50);

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FkCreateuser).HasColumnName("FK_CREATEUSER");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TQlxDenghinhapCt>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_QLX_DENGHINHAP_CT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMaVthh)
                    .HasColumnName("C_MA_VTHH")
                    .HasMaxLength(50);

                entity.Property(e => e.CSoluong)
                    .HasColumnName("C_SOLUONG")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CTenVthh)
                    .HasColumnName("C_TEN_VTHH")
                    .HasMaxLength(250);

                entity.Property(e => e.FkDenghinhap).HasColumnName("FK_DENGHINHAP");

                entity.Property(e => e.FkVitri1).HasColumnName("FK_VITRI1");

                entity.Property(e => e.FkVitri10).HasColumnName("FK_VITRI10");

                entity.Property(e => e.FkVitri11).HasColumnName("FK_VITRI11");

                entity.Property(e => e.FkVitri12).HasColumnName("FK_VITRI12");

                entity.Property(e => e.FkVitri13).HasColumnName("FK_VITRI13");

                entity.Property(e => e.FkVitri14).HasColumnName("FK_VITRI14");

                entity.Property(e => e.FkVitri15).HasColumnName("FK_VITRI15");

                entity.Property(e => e.FkVitri2).HasColumnName("FK_VITRI2");

                entity.Property(e => e.FkVitri3).HasColumnName("FK_VITRI3");

                entity.Property(e => e.FkVitri4).HasColumnName("FK_VITRI4");

                entity.Property(e => e.FkVitri5).HasColumnName("FK_VITRI5");

                entity.Property(e => e.FkVitri6).HasColumnName("FK_VITRI6");

                entity.Property(e => e.FkVitri7).HasColumnName("FK_VITRI7");

                entity.Property(e => e.FkVitri8).HasColumnName("FK_VITRI8");

                entity.Property(e => e.FkVitri9).HasColumnName("FK_VITRI9");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<TQlxDenghixuat>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_QLX_DENGHIXUAT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(250);

                entity.Property(e => e.CMa)
                    .HasColumnName("C_MA")
                    .HasMaxLength(50);

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FkCreateuser).HasColumnName("FK_CREATEUSER");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");
            });

            modelBuilder.Entity<TQlxDenghixuatCt>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_QLX_DENGHIXUAT_CT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CDinhmuc)
                    .HasColumnName("C_DINHMUC")
                    .HasMaxLength(50);

                entity.Property(e => e.CDongia)
                    .HasColumnName("C_DONGIA")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CDtcp).HasColumnName("C_DTCP");

                entity.Property(e => e.CDtcpMa)
                    .HasColumnName("C_DTCP_MA")
                    .HasMaxLength(50);

                entity.Property(e => e.CDtcpTen)
                    .HasColumnName("C_DTCP_TEN")
                    .HasMaxLength(250);

                entity.Property(e => e.CDtcpcoMa)
                    .HasColumnName("C_DTCPCO_MA")
                    .HasMaxLength(50);

                entity.Property(e => e.CDvt)
                    .HasColumnName("C_DVT")
                    .HasMaxLength(50);

                entity.Property(e => e.CDvtMa)
                    .HasColumnName("C_DVT_MA")
                    .HasMaxLength(250);

                entity.Property(e => e.CErrors)
                    .HasColumnName("C_ERRORS")
                    .HasMaxLength(500);

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(250);

                entity.Property(e => e.CHoanthanh).HasColumnName("C_HOANTHANH");

                entity.Property(e => e.CKho)
                    .HasColumnName("C_KHO")
                    .HasMaxLength(250);

                entity.Property(e => e.CKmp)
                    .HasColumnName("C_KMP")
                    .HasMaxLength(250);

                entity.Property(e => e.CKmpMota)
                    .HasColumnName("C_KMP_MOTA")
                    .HasMaxLength(250);

                entity.Property(e => e.CMa)
                    .HasColumnName("C_MA")
                    .HasMaxLength(50);

                entity.Property(e => e.CMagop)
                    .HasColumnName("C_MAGOP")
                    .HasMaxLength(50);

                entity.Property(e => e.CNhh)
                    .HasColumnName("C_NHH")
                    .HasMaxLength(250);

                entity.Property(e => e.CSau)
                    .HasColumnName("C_SAU")
                    .HasMaxLength(50);

                entity.Property(e => e.CSlTontong)
                    .HasColumnName("C_SL_TONTONG")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CSoluong)
                    .HasColumnName("C_SOLUONG")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CSoluongDaxuat)
                    .HasColumnName("C_SOLUONG_DAXUAT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CSoluongTon)
                    .HasColumnName("C_SOLUONG_TON")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.CSttDm).HasColumnName("C_STT_DM");

                entity.Property(e => e.CTaikhoan)
                    .HasColumnName("C_TAIKHOAN")
                    .HasMaxLength(250);

                entity.Property(e => e.CTen)
                    .HasColumnName("C_TEN")
                    .HasMaxLength(250);

                entity.Property(e => e.CThanhtien)
                    .HasColumnName("C_THANHTIEN")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CThongbao)
                    .HasColumnName("C_THONGBAO")
                    .HasMaxLength(250);

                entity.Property(e => e.CTienthue)
                    .HasColumnName("C_TIENTHUE")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CTon)
                    .HasColumnName("C_TON")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CTontong)
                    .HasColumnName("C_TONTONG")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CTruoc)
                    .HasColumnName("C_TRUOC")
                    .HasMaxLength(50);

                entity.Property(e => e.CVthhMa)
                    .HasColumnName("C_VTHH_MA")
                    .HasMaxLength(50);

                entity.Property(e => e.CVthhMaphu)
                    .HasColumnName("C_VTHH_MAPHU")
                    .HasMaxLength(50);

                entity.Property(e => e.CVthhTen)
                    .HasColumnName("C_VTHH_TEN")
                    .HasMaxLength(250);

                entity.Property(e => e.CXuatqua).HasColumnName("C_XUATQUA");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkDtcpco).HasColumnName("FK_DTCPCO");

                entity.Property(e => e.FkDvt).HasColumnName("FK_DVT");

                entity.Property(e => e.FkKhonhap).HasColumnName("FK_KHONHAP");

                entity.Property(e => e.FkKmp).HasColumnName("FK_KMP");

                entity.Property(e => e.FkNhh).HasColumnName("FK_NHH");

                entity.Property(e => e.FkQlxDenghixuat).HasColumnName("FK_QLX_DENGHIXUAT");

                entity.Property(e => e.FkQlxDinhmuc).HasColumnName("FK_QLX_DINHMUC");

                entity.Property(e => e.FkTaikhoan).HasColumnName("FK_TAIKHOAN");

                entity.Property(e => e.FkTkno)
                    .HasColumnName("FK_TKNO")
                    .HasMaxLength(20);

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<TQlxDenghixuatDtcp>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_QLX_DENGHIXUAT_DTCP");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CDinhmuc)
                    .HasColumnName("C_DINHMUC")
                    .HasMaxLength(50);

                entity.Property(e => e.CDtcp)
                    .HasColumnName("C_DTCP")
                    .HasMaxLength(50);

                entity.Property(e => e.CDtcpTen)
                    .HasColumnName("C_DTCP_TEN")
                    .HasMaxLength(250);

                entity.Property(e => e.CDvt)
                    .HasColumnName("C_DVT")
                    .HasMaxLength(50);

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(250);

                entity.Property(e => e.CHoanthanh).HasColumnName("C_HOANTHANH");

                entity.Property(e => e.CKmp)
                    .HasColumnName("C_KMP")
                    .HasMaxLength(50);

                entity.Property(e => e.CSoluong)
                    .HasColumnName("C_SOLUONG")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.CTaikhoan)
                    .HasColumnName("C_TAIKHOAN")
                    .HasMaxLength(50);

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkDvt).HasColumnName("FK_DVT");

                entity.Property(e => e.FkQlxDenghixuat).HasColumnName("FK_QLX_DENGHIXUAT");
            });

            modelBuilder.Entity<TQlxDinhmuc>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_QLX_DINHMUC");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CChoxoa).HasColumnName("C_CHOXOA");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CDtcp)
                    .HasColumnName("C_DTCP")
                    .HasMaxLength(50);

                entity.Property(e => e.CDvdm)
                    .HasColumnName("C_DVDM")
                    .HasMaxLength(50);

                entity.Property(e => e.CNgaytao)
                    .HasColumnName("C_NGAYTAO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CNgayupdate)
                    .HasColumnName("C_NGAYUPDATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CSldm)
                    .HasColumnName("C_SLDM")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CTenDinhmuc)
                    .HasColumnName("C_TEN_DINHMUC")
                    .HasMaxLength(250);

                entity.Property(e => e.FkCreateuser).HasColumnName("FK_CREATEUSER");
            });

            modelBuilder.Entity<TQlxDinhmucCt>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_QLX_DINHMUC_CT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDvt)
                    .HasColumnName("C_DVT")
                    .HasMaxLength(50);

                entity.Property(e => e.CHangsx)
                    .HasColumnName("C_HANGSX")
                    .HasMaxLength(100);

                entity.Property(e => e.CKho)
                    .HasColumnName("C_KHO")
                    .HasMaxLength(250);

                entity.Property(e => e.CNhh)
                    .HasColumnName("C_NHH")
                    .HasMaxLength(250);

                entity.Property(e => e.CSau)
                    .HasColumnName("C_SAU")
                    .HasMaxLength(30);

                entity.Property(e => e.CSoluong)
                    .HasColumnName("C_SOLUONG")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.CTaikhoan)
                    .HasColumnName("C_TAIKHOAN")
                    .HasMaxLength(250);

                entity.Property(e => e.CTenVthh)
                    .HasColumnName("C_TEN_VTHH")
                    .HasMaxLength(250);

                entity.Property(e => e.CTlhh)
                    .HasColumnName("C_TLHH")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CTnk)
                    .HasColumnName("C_TNK")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CTruoc)
                    .HasColumnName("C_TRUOC")
                    .HasMaxLength(30);

                entity.Property(e => e.CVthh)
                    .HasColumnName("C_VTHH")
                    .HasMaxLength(50);

                entity.Property(e => e.CVthhMaphu)
                    .HasColumnName("C_VTHH_MAPHU")
                    .HasMaxLength(50);

                entity.Property(e => e.CXoa).HasColumnName("C_XOA");

                entity.Property(e => e.FkDvt).HasColumnName("FK_DVT");

                entity.Property(e => e.FkQlxDinhmuc).HasColumnName("FK_QLX_DINHMUC");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<TQlxSlvthhDtcp>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_QLX_SLVTHH_DTCP");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(250);

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CSoluong)
                    .HasColumnName("C_SOLUONG")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FkCreateuser).HasColumnName("FK_CREATEUSER");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<TSmsConfig>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SMS_CONFIG");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CVat)
                    .HasColumnName("C_VAT")
                    .HasColumnType("decimal(18, 1)");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkLoaitien).HasColumnName("FK_LOAITIEN");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");
            });

            modelBuilder.Entity<TSmsContreleaseCt>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SMS_CONTRELEASE_CT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CNote)
                    .HasColumnName("C_NOTE")
                    .HasMaxLength(250);

                entity.Property(e => e.CPacked).HasColumnName("C_PACKED");

                entity.Property(e => e.CSeal)
                    .HasColumnName("C_SEAL")
                    .HasMaxLength(30);

                entity.Property(e => e.CSoluong)
                    .HasColumnName("C_SOLUONG")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.FkCommodity).HasColumnName("FK_COMMODITY");

                entity.Property(e => e.FkCont).HasColumnName("FK_CONT");

                entity.Property(e => e.FkContrelease).HasColumnName("FK_CONTRELEASE");
            });

            modelBuilder.Entity<TSmsScheduleSlotAllocation>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SMS_Schedule_SlotAllocation");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCocsoc).HasColumnName("C_COCSOC");

                entity.Property(e => e.CLaden).HasColumnName("C_LADEN");

                entity.Property(e => e.CSoluong)
                    .HasColumnName("C_SOLUONG")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.CTaitrong)
                    .HasColumnName("C_TAITRONG")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.FkContType).HasColumnName("FK_ContType");

                entity.Property(e => e.FkDepartment).HasColumnName("FK_DEPARTMENT");

                entity.Property(e => e.FkPod).HasColumnName("FK_POD");

                entity.Property(e => e.FkPol).HasColumnName("FK_POL");

                entity.Property(e => e.FkSchedule).HasColumnName("FK_Schedule");
            });

            modelBuilder.Entity<TSupportSalaryToAgent>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SupportSalaryToAgent");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCollection)
                    .HasColumnName("C_Collection")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CFrom1)
                    .HasColumnName("C_From1")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CFrom2)
                    .HasColumnName("C_From2")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CFrom3)
                    .HasColumnName("C_From3")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CFrom4)
                    .HasColumnName("C_From4")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CFrom5)
                    .HasColumnName("C_From5")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CFromDate)
                    .HasColumnName("C_FromDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CSalary1)
                    .HasColumnName("C_Salary1")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CSalary2)
                    .HasColumnName("C_Salary2")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CSalary3)
                    .HasColumnName("C_Salary3")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CSalary4)
                    .HasColumnName("C_Salary4")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CSalary5)
                    .HasColumnName("C_Salary5")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTo1)
                    .HasColumnName("C_To1")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTo2)
                    .HasColumnName("C_To2")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTo3)
                    .HasColumnName("C_To3")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTo4)
                    .HasColumnName("C_To4")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTo5)
                    .HasColumnName("C_To5")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CToDate)
                    .HasColumnName("C_ToDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkKhachhang).HasColumnName("FK_KHACHHANG");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkNhomvattu).HasColumnName("FK_NHOMVATTU");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<TSysAccount>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_ACCOUNT");

                entity.HasIndex(e => e.CMa)
                    .HasName("IX_T_SYS_ACCOUNT")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CAlertTime).HasColumnName("C_AlertTime");

                entity.Property(e => e.CAutoAlert).HasColumnName("C_AutoAlert");

                entity.Property(e => e.CBom).HasColumnName("C_BOM");

                entity.Property(e => e.CCurrentTheme).HasColumnName("C_CurrentTheme");

                entity.Property(e => e.CDbadmin).HasColumnName("C_DBADMIN");

                entity.Property(e => e.CDoimk).HasColumnName("C_DOIMK");

                entity.Property(e => e.CExpandAll).HasColumnName("C_ExpandAll");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(255);

                entity.Property(e => e.CGranted)
                    .HasColumnName("C_GRANTED")
                    .HasMaxLength(200);

                entity.Property(e => e.CGrantedccn)
                    .HasColumnName("C_GRANTEDCCN")
                    .HasMaxLength(150);

                entity.Property(e => e.CGrantedread)
                    .HasColumnName("C_GRANTEDREAD")
                    .HasMaxLength(400);

                entity.Property(e => e.CHsd).HasColumnName("C_HSD");

                entity.Property(e => e.CKhoadulieu).HasColumnName("C_KHOADULIEU");

                entity.Property(e => e.CKhoatk).HasColumnName("C_KHOATK");

                entity.Property(e => e.CLastexport)
                    .HasColumnName("C_LASTEXPORT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CLocalDictionary).HasColumnName("C_LocalDictionary");

                entity.Property(e => e.CLockAfterSave)
                    .HasColumnName("C_LockAfterSave")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(20);

                entity.Property(e => e.CMatkhau)
                    .IsRequired()
                    .HasColumnName("C_MATKHAU")
                    .HasMaxLength(200);

                entity.Property(e => e.CModifylayout).HasColumnName("C_MODIFYLAYOUT");

                entity.Property(e => e.CPotimer).HasColumnName("C_POTimer");

                entity.Property(e => e.CSingleClick).HasColumnName("C_SingleClick");

                entity.Property(e => e.CSotimer).HasColumnName("C_SOTimer");

                entity.Property(e => e.CTen)
                    .HasColumnName("C_TEN")
                    .HasMaxLength(35);

                entity.Property(e => e.FkDomat).HasColumnName("FK_DOMAT");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkNhanvien).HasColumnName("FK_NHANVIEN");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");
            });

            modelBuilder.Entity<TSysAlert>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_ALERT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CEventStart)
                    .HasColumnName("C_EVENT_START")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CFromdate)
                    .HasColumnName("C_FROMDATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CKey01).HasColumnName("C_KEY01");

                entity.Property(e => e.CKey02).HasColumnName("C_KEY02");

                entity.Property(e => e.CTodate)
                    .HasColumnName("C_TODATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CUserlist)
                    .HasColumnName("C_USERLIST")
                    .HasMaxLength(200);

                entity.Property(e => e.FkNotificationConfig).HasColumnName("FK_NOTIFICATION_CONFIG");
            });

            modelBuilder.Entity<TSysAllfield>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_ALLFIELD");

                entity.HasIndex(e => e.CField)
                    .HasName("IX_T_SYS_ALLFIELD_1");

                entity.HasIndex(e => e.CTable)
                    .HasName("IX_T_SYS_ALLFIELD");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDiscription)
                    .HasColumnName("C_DISCRIPTION")
                    .HasMaxLength(50);

                entity.Property(e => e.CEnglish)
                    .HasColumnName("C_ENGLISH")
                    .HasMaxLength(50);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CField)
                    .HasColumnName("C_FIELD")
                    .HasMaxLength(50);

                entity.Property(e => e.CTable)
                    .HasColumnName("C_TABLE")
                    .HasMaxLength(50);

                entity.Property(e => e.CVietnamese)
                    .HasColumnName("C_VIETNAMESE")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TSysApprovalstatus>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_APPROVALSTATUS");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CApproved).HasColumnName("C_APPROVED");

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TSysBackuplog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_SYS_BACKUPLOG");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CPath)
                    .HasColumnName("C_PATH")
                    .HasMaxLength(255);

                entity.Property(e => e.CStatus).HasColumnName("C_STATUS");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TSysBackuprestore>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_SYS_BACKUPRESTORE");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CFri).HasColumnName("C_FRI");

                entity.Property(e => e.CMon).HasColumnName("C_MON");

                entity.Property(e => e.CPath)
                    .HasColumnName("C_PATH")
                    .HasMaxLength(255);

                entity.Property(e => e.CSat).HasColumnName("C_SAT");

                entity.Property(e => e.CSun).HasColumnName("C_SUN");

                entity.Property(e => e.CThu).HasColumnName("C_THU");

                entity.Property(e => e.CTue).HasColumnName("C_TUE");

                entity.Property(e => e.CWed).HasColumnName("C_WED");
            });

            modelBuilder.Entity<TSysBomstatus>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_BOMSTATUS");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(20);

                entity.Property(e => e.CMotaen)
                    .IsRequired()
                    .HasColumnName("C_MOTAEN")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TSysCapacitytype>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_SYS_CAPACITYTYPE");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(10);

                entity.Property(e => e.PkId).HasColumnName("PK_ID");
            });

            modelBuilder.Entity<TSysChitieu>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_CHITIEU");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CMa)
                    .HasColumnName("C_MA")
                    .HasMaxLength(10);

                entity.Property(e => e.CMota)
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TSysChuky>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_CHUKY");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TSysCommand>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_COMMAND");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CChungtu)
                    .HasColumnName("C_CHUNGTU")
                    .HasMaxLength(50);

                entity.Property(e => e.CCommand)
                    .HasColumnName("C_COMMAND")
                    .HasMaxLength(50);

                entity.Property(e => e.CDescription)
                    .HasColumnName("C_DESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.CDescriptionen)
                    .HasColumnName("C_DESCRIPTIONEN")
                    .HasMaxLength(255);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CFormtype).HasColumnName("C_FORMTYPE");

                entity.Property(e => e.CImageIndex).HasColumnName("C_ImageIndex");

                entity.Property(e => e.CIsGroup).HasColumnName("C_IsGroup");

                entity.Property(e => e.CMenu)
                    .HasColumnName("C_MENU")
                    .HasMaxLength(50);

                entity.Property(e => e.CMenuen)
                    .HasColumnName("C_MENUEN")
                    .HasMaxLength(50);

                entity.Property(e => e.CMenuindex)
                    .HasColumnName("C_MENUINDEX")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.CMenulevel).HasColumnName("C_MENULEVEL");

                entity.Property(e => e.CMenuparent)
                    .HasColumnName("C_MENUPARENT")
                    .HasMaxLength(50);

                entity.Property(e => e.CObject)
                    .HasColumnName("C_OBJECT")
                    .HasMaxLength(50);

                entity.Property(e => e.CRead)
                    .HasColumnName("C_READ")
                    .HasMaxLength(255);

                entity.Property(e => e.CReport)
                    .HasColumnName("C_REPORT")
                    .HasMaxLength(50);

                entity.Property(e => e.CShortcut)
                    .HasColumnName("C_SHORTCUT")
                    .HasMaxLength(10);

                entity.Property(e => e.CStdMenu).HasColumnName("C_StdMenu");

                entity.Property(e => e.CSubcommand)
                    .HasColumnName("C_SUBCOMMAND")
                    .HasMaxLength(50);

                entity.Property(e => e.CTablename)
                    .HasColumnName("C_TABLENAME")
                    .HasMaxLength(50);

                entity.Property(e => e.CTreeMenu).HasColumnName("C_TreeMenu");

                entity.Property(e => e.CType).HasColumnName("C_Type");

                entity.Property(e => e.CVisible)
                    .HasColumnName("C_VISIBLE")
                    .HasMaxLength(255);

                entity.Property(e => e.CWrite)
                    .HasColumnName("C_WRITE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TSysCommandtype>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_COMMANDTYPE");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TSysCtcdkt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_SYS_CTCDKT");

                entity.Property(e => e.CCachtinh)
                    .HasColumnName("C_CACHTINH")
                    .HasMaxLength(255);

                entity.Property(e => e.CChitieu)
                    .HasColumnName("C_CHITIEU")
                    .HasMaxLength(255);

                entity.Property(e => e.CChitieuen)
                    .HasColumnName("C_CHITIEUEN")
                    .HasMaxLength(255);

                entity.Property(e => e.CDkco)
                    .HasColumnName("C_DKCO")
                    .HasMaxLength(500);

                entity.Property(e => e.CDkno)
                    .HasColumnName("C_DKNO")
                    .HasMaxLength(500);

                entity.Property(e => e.CIn).HasColumnName("C_IN");

                entity.Property(e => e.CIndam).HasColumnName("C_INDAM");

                entity.Property(e => e.CMaso)
                    .HasColumnName("C_MASO")
                    .HasMaxLength(255);

                entity.Property(e => e.CNgoaibang).HasColumnName("C_NGOAIBANG");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.CTaikhoan)
                    .HasColumnName("C_TAIKHOAN")
                    .HasMaxLength(255);

                entity.Property(e => e.CThuyetminh)
                    .HasColumnName("C_THUYETMINH")
                    .HasMaxLength(30);

                entity.Property(e => e.CTsnv)
                    .HasColumnName("C_TSNV")
                    .HasMaxLength(255);

                entity.Property(e => e.CongNo)
                    .HasColumnName("cong_no")
                    .HasMaxLength(255);

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TSysCtcdkt48>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_SYS_CTCDKT48");

                entity.Property(e => e.CCachtinh)
                    .HasColumnName("C_CACHTINH")
                    .HasMaxLength(255);

                entity.Property(e => e.CChitieu)
                    .HasColumnName("C_CHITIEU")
                    .HasMaxLength(255);

                entity.Property(e => e.CChitieuen)
                    .HasColumnName("C_CHITIEUEN")
                    .HasMaxLength(255);

                entity.Property(e => e.CDkco)
                    .HasColumnName("C_DKCO")
                    .HasMaxLength(500);

                entity.Property(e => e.CDkno)
                    .HasColumnName("C_DKNO")
                    .HasMaxLength(500);

                entity.Property(e => e.CIn).HasColumnName("C_IN");

                entity.Property(e => e.CIndam).HasColumnName("C_INDAM");

                entity.Property(e => e.CMaso)
                    .HasColumnName("C_MASO")
                    .HasMaxLength(255);

                entity.Property(e => e.CNgoaibang).HasColumnName("C_NGOAIBANG");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.CTaikhoan)
                    .HasColumnName("C_TAIKHOAN")
                    .HasMaxLength(255);

                entity.Property(e => e.CThuyetminh)
                    .HasColumnName("C_THUYETMINH")
                    .HasMaxLength(30);

                entity.Property(e => e.CTsnv)
                    .HasColumnName("C_TSNV")
                    .HasMaxLength(255);

                entity.Property(e => e.CongNo)
                    .HasColumnName("cong_no")
                    .HasMaxLength(255);

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TSysCtkqkd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_SYS_CTKQKD");

                entity.Property(e => e.CCachtinh)
                    .HasColumnName("C_CACHTINH")
                    .HasMaxLength(255);

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CChitieu)
                    .HasColumnName("C_CHITIEU")
                    .HasMaxLength(255);

                entity.Property(e => e.CChitieuen)
                    .HasColumnName("C_CHITIEUEN")
                    .HasMaxLength(255);

                entity.Property(e => e.CDieukienthem)
                    .HasColumnName("C_DIEUKIENTHEM")
                    .HasMaxLength(300);

                entity.Property(e => e.CDkco)
                    .HasColumnName("C_DKCO")
                    .HasMaxLength(500);

                entity.Property(e => e.CDkno)
                    .HasColumnName("C_DKNO")
                    .HasMaxLength(500);

                entity.Property(e => e.CGiamtru)
                    .HasColumnName("C_GIAMTRU")
                    .HasMaxLength(255);

                entity.Property(e => e.CIndam).HasColumnName("C_INDAM");

                entity.Property(e => e.CMaso)
                    .HasColumnName("C_MASO")
                    .HasMaxLength(255);

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.CThuyetminh)
                    .HasColumnName("C_THUYETMINH")
                    .HasMaxLength(30);

                entity.Property(e => e.CTkco)
                    .HasColumnName("C_TKCO")
                    .HasMaxLength(255);

                entity.Property(e => e.CTkno)
                    .HasColumnName("C_TKNO")
                    .HasMaxLength(255);

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TSysCtkqkd48>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_SYS_CTKQKD48");

                entity.Property(e => e.CCachtinh)
                    .HasColumnName("C_CACHTINH")
                    .HasMaxLength(255);

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CChitieu)
                    .HasColumnName("C_CHITIEU")
                    .HasMaxLength(255);

                entity.Property(e => e.CChitieuen)
                    .HasColumnName("C_CHITIEUEN")
                    .HasMaxLength(255);

                entity.Property(e => e.CDieukienthem)
                    .HasColumnName("C_DIEUKIENTHEM")
                    .HasMaxLength(300);

                entity.Property(e => e.CDkco)
                    .HasColumnName("C_DKCO")
                    .HasMaxLength(500);

                entity.Property(e => e.CDkno)
                    .HasColumnName("C_DKNO")
                    .HasMaxLength(500);

                entity.Property(e => e.CGiamtru)
                    .HasColumnName("C_GIAMTRU")
                    .HasMaxLength(255);

                entity.Property(e => e.CIndam).HasColumnName("C_INDAM");

                entity.Property(e => e.CMaso)
                    .HasColumnName("C_MASO")
                    .HasMaxLength(255);

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.CThuyetminh)
                    .HasColumnName("C_THUYETMINH")
                    .HasMaxLength(30);

                entity.Property(e => e.CTkco)
                    .HasColumnName("C_TKCO")
                    .HasMaxLength(255);

                entity.Property(e => e.CTkno)
                    .HasColumnName("C_TKNO")
                    .HasMaxLength(255);

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TSysCtkqkdMw>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_CTKQKD_MW");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCachtinh)
                    .HasColumnName("C_CACHTINH")
                    .HasMaxLength(255);

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CChitieu)
                    .HasColumnName("C_CHITIEU")
                    .HasMaxLength(255);

                entity.Property(e => e.CChitieuen)
                    .HasColumnName("C_CHITIEUEN")
                    .HasMaxLength(255);

                entity.Property(e => e.CDieukienthem)
                    .HasColumnName("C_DIEUKIENTHEM")
                    .HasMaxLength(300);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CGiamtru)
                    .HasColumnName("C_GIAMTRU")
                    .HasMaxLength(255);

                entity.Property(e => e.CIndam).HasColumnName("C_INDAM");

                entity.Property(e => e.CMaso)
                    .HasColumnName("C_MASO")
                    .HasMaxLength(255);

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.CTkco)
                    .HasColumnName("C_TKCO")
                    .HasMaxLength(255);

                entity.Property(e => e.CTkno)
                    .HasColumnName("C_TKNO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TSysCtkqkdphan2>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_CTKQKDPHAN2");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCachtinh)
                    .HasColumnName("C_CACHTINH")
                    .HasMaxLength(255);

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CChitieu)
                    .HasColumnName("C_CHITIEU")
                    .HasMaxLength(255);

                entity.Property(e => e.CChitieuen)
                    .HasColumnName("C_CHITIEUEN")
                    .HasMaxLength(255);

                entity.Property(e => e.CDieukienthem)
                    .HasColumnName("C_DIEUKIENTHEM")
                    .HasMaxLength(300);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CGiamtru)
                    .HasColumnName("C_GIAMTRU")
                    .HasMaxLength(255);

                entity.Property(e => e.CIndam).HasColumnName("C_INDAM");

                entity.Property(e => e.CMaso)
                    .HasColumnName("C_MASO")
                    .HasMaxLength(255);

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.CTkco)
                    .HasColumnName("C_TKCO")
                    .HasMaxLength(255);

                entity.Property(e => e.CTkno)
                    .HasColumnName("C_TKNO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TSysCtkqkdphan3>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_CTKQKDPHAN3");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCachtinh)
                    .HasColumnName("C_CACHTINH")
                    .HasMaxLength(255);

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CChitieu)
                    .HasColumnName("C_CHITIEU")
                    .HasMaxLength(255);

                entity.Property(e => e.CChitieuen)
                    .HasColumnName("C_CHITIEUEN")
                    .HasMaxLength(255);

                entity.Property(e => e.CDieukienthem)
                    .HasColumnName("C_DIEUKIENTHEM")
                    .HasMaxLength(300);

                entity.Property(e => e.CDuco).HasColumnName("C_DUCO");

                entity.Property(e => e.CDuno).HasColumnName("C_DUNO");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CGiamtru)
                    .HasColumnName("C_GIAMTRU")
                    .HasMaxLength(255);

                entity.Property(e => e.CIndam).HasColumnName("C_INDAM");

                entity.Property(e => e.CMaso)
                    .HasColumnName("C_MASO")
                    .HasMaxLength(255);

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.CTkco)
                    .HasColumnName("C_TKCO")
                    .HasMaxLength(255);

                entity.Property(e => e.CTkno)
                    .HasColumnName("C_TKNO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TSysCtlcgt>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_CTLCGT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCachtinh)
                    .HasColumnName("C_CACHTINH")
                    .HasMaxLength(255);

                entity.Property(e => e.CChitieu)
                    .HasColumnName("C_CHITIEU")
                    .HasMaxLength(255);

                entity.Property(e => e.CChitieuen)
                    .HasColumnName("C_CHITIEUEN")
                    .HasMaxLength(255);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CIndam).HasColumnName("C_INDAM");

                entity.Property(e => e.CMaso)
                    .HasColumnName("C_MASO")
                    .HasMaxLength(255);

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.CTkco)
                    .HasColumnName("C_TKCO")
                    .HasMaxLength(255);

                entity.Property(e => e.CTkno)
                    .HasColumnName("C_TKNO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TSysCtlctt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_SYS_CTLCTT");

                entity.Property(e => e.CCachtinh)
                    .HasColumnName("C_CACHTINH")
                    .HasMaxLength(255);

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CChitieu)
                    .HasColumnName("C_CHITIEU")
                    .HasMaxLength(255);

                entity.Property(e => e.CChitieuen)
                    .HasColumnName("C_CHITIEUEN")
                    .HasMaxLength(255);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CGhiam).HasColumnName("C_GHIAM");

                entity.Property(e => e.CIndam).HasColumnName("C_INDAM");

                entity.Property(e => e.CKodoiung).HasColumnName("C_KODOIUNG");

                entity.Property(e => e.CMaso)
                    .HasColumnName("C_MASO")
                    .HasMaxLength(255);

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.CThuyetminh)
                    .HasColumnName("C_THUYETMINH")
                    .HasMaxLength(20);

                entity.Property(e => e.CTkco)
                    .HasColumnName("C_TKCO")
                    .HasMaxLength(255);

                entity.Property(e => e.CTkno)
                    .HasColumnName("C_TKNO")
                    .HasMaxLength(255);

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TSysCusMerg>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_CUS_MERG");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CMaNew)
                    .HasColumnName("C_MA_NEW")
                    .HasMaxLength(50);

                entity.Property(e => e.CMakh)
                    .HasColumnName("C_MAKH")
                    .HasMaxLength(50);

                entity.Property(e => e.CNote)
                    .HasColumnName("C_NOTE")
                    .HasMaxLength(200);

                entity.Property(e => e.CTenNew)
                    .HasColumnName("C_TEN_NEW")
                    .HasMaxLength(250);

                entity.Property(e => e.CTenkh)
                    .HasColumnName("C_TENKH")
                    .HasMaxLength(250);

                entity.Property(e => e.FkCreateUser).HasColumnName("FK_CREATE_USER");

                entity.Property(e => e.FkKh).HasColumnName("FK_KH");

                entity.Property(e => e.FkNewKh).HasColumnName("FK_NEW_KH");
            });

            modelBuilder.Entity<TSysDeletelog>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_DELETELOG");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCode)
                    .IsRequired()
                    .HasColumnName("C_CODE")
                    .HasMaxLength(20);

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CDescription)
                    .HasColumnName("C_DESCRIPTION")
                    .HasMaxLength(500);

                entity.Property(e => e.CDescription2)
                    .HasColumnName("C_DESCRIPTION2")
                    .HasMaxLength(500);

                entity.Property(e => e.CForm).HasColumnName("C_FORM");

                entity.Property(e => e.CUsername)
                    .IsRequired()
                    .HasColumnName("C_USERNAME")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TSysDeletelogtype>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_DELETELOGTYPE");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(10);

                entity.Property(e => e.CTen)
                    .IsRequired()
                    .HasColumnName("C_TEN")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TSysDictionary>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_DICTIONARY");

                entity.HasIndex(e => e.CKey)
                    .HasName("IX_T_SYS_DICTIONARY")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CEnglish)
                    .IsRequired()
                    .HasColumnName("C_ENGLISH")
                    .HasMaxLength(400);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CKey)
                    .IsRequired()
                    .HasColumnName("C_KEY")
                    .HasMaxLength(400);

                entity.Property(e => e.CVietnamese)
                    .IsRequired()
                    .HasColumnName("C_VIETNAMESE")
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<TSysDonggoi>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_DONGGOI");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TSysDynamicReportField>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_DynamicReportField");

                entity.HasIndex(e => new { e.FkReport, e.CTableName, e.CFieldCaption })
                    .HasName("IX_T_SYS_DynamicReportField_1")
                    .IsUnique();

                entity.HasIndex(e => new { e.FkReport, e.CTableName, e.CFieldName })
                    .HasName("IX_T_SYS_DynamicReportField")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CFieldCaption)
                    .HasColumnName("C_FieldCaption")
                    .HasMaxLength(100);

                entity.Property(e => e.CFieldName)
                    .HasColumnName("C_FieldName")
                    .HasMaxLength(100);

                entity.Property(e => e.CFormula)
                    .HasColumnName("C_Formula")
                    .HasMaxLength(500);

                entity.Property(e => e.CFunction)
                    .HasColumnName("C_Function")
                    .HasMaxLength(50);

                entity.Property(e => e.CGroupOrder).HasColumnName("C_GroupOrder");

                entity.Property(e => e.COperand)
                    .HasColumnName("C_Operand")
                    .HasMaxLength(10);

                entity.Property(e => e.COrder).HasColumnName("C_Order");

                entity.Property(e => e.CPostfix)
                    .HasColumnName("C_Postfix")
                    .HasMaxLength(10);

                entity.Property(e => e.CPrefix)
                    .HasColumnName("C_Prefix")
                    .HasMaxLength(10);

                entity.Property(e => e.CSortOrder).HasColumnName("C_SortOrder");

                entity.Property(e => e.CSortType)
                    .HasColumnName("C_SortType")
                    .HasMaxLength(10);

                entity.Property(e => e.CTableName)
                    .HasColumnName("C_TableName")
                    .HasMaxLength(100);

                entity.Property(e => e.FkReport).HasColumnName("FK_Report");
            });

            modelBuilder.Entity<TSysDynamicReportTemplate>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_DynamicReportTemplate");

                entity.HasIndex(e => new { e.CGroupName, e.CTableName, e.CFieldName })
                    .HasName("IX_T_SYS_DynamicReportTemplate")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CFieldCaption)
                    .HasColumnName("C_FieldCaption")
                    .HasMaxLength(100);

                entity.Property(e => e.CFieldName)
                    .HasColumnName("C_FieldName")
                    .HasMaxLength(100);

                entity.Property(e => e.CGroupName)
                    .HasColumnName("C_GroupName")
                    .HasMaxLength(50);

                entity.Property(e => e.CTableCaption)
                    .HasColumnName("C_TableCaption")
                    .HasMaxLength(100);

                entity.Property(e => e.CTableName)
                    .HasColumnName("C_TableName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TSysFile>(entity =>
            {
                entity.HasKey(e => e.CFilename);

                entity.ToTable("T_SYS_FILE");

                entity.Property(e => e.CFilename)
                    .HasColumnName("C_FILENAME")
                    .HasMaxLength(150);

                entity.Property(e => e.CClientname)
                    .HasColumnName("C_CLIENTNAME")
                    .HasMaxLength(1000);

                entity.Property(e => e.CContent)
                    .HasColumnName("C_Content")
                    .HasColumnType("image");

                entity.Property(e => e.CDownload).HasColumnName("C_DOWNLOAD");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CModifydate)
                    .HasColumnName("C_MODIFYDATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CUpdate).HasColumnName("C_UPDATE");
            });

            modelBuilder.Entity<TSysFormgrid>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_SYS_FORMGRID");

                entity.Property(e => e.CAlign).HasColumnName("C_ALIGN");

                entity.Property(e => e.CCase).HasColumnName("C_CASE");

                entity.Property(e => e.CColumnname)
                    .IsRequired()
                    .HasColumnName("C_COLUMNNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.CEnglish)
                    .IsRequired()
                    .HasColumnName("C_ENGLISH")
                    .HasMaxLength(50);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CFormat)
                    .HasColumnName("C_FORMAT")
                    .HasMaxLength(50);

                entity.Property(e => e.CGridname)
                    .IsRequired()
                    .HasColumnName("C_GRIDNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.CHidden).HasColumnName("C_HIDDEN");

                entity.Property(e => e.CMaskinput)
                    .HasColumnName("C_MASKINPUT")
                    .HasMaxLength(20);

                entity.Property(e => e.CReadonly).HasColumnName("C_READONLY");

                entity.Property(e => e.CVietnamese)
                    .IsRequired()
                    .HasColumnName("C_VIETNAMESE")
                    .HasMaxLength(50);

                entity.Property(e => e.CWidth).HasColumnName("C_WIDTH");

                entity.Property(e => e.PkFormname)
                    .IsRequired()
                    .HasColumnName("PK_FORMNAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TSysFormproperty>(entity =>
            {
                entity.HasKey(e => e.PkFormname);

                entity.ToTable("T_SYS_FORMPROPERTY");

                entity.Property(e => e.PkFormname)
                    .HasColumnName("PK_FORMNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.CControlcaption)
                    .HasColumnName("C_CONTROLCAPTION")
                    .HasMaxLength(4000);

                entity.Property(e => e.CDefault).HasColumnName("C_DEFAULT");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CProperty)
                    .HasColumnName("C_PROPERTY")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<TSysFormpropertycode>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_FORMPROPERTYCODE");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CControl)
                    .IsRequired()
                    .HasColumnName("C_CONTROL")
                    .HasMaxLength(50);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CLabel)
                    .IsRequired()
                    .HasColumnName("C_LABEL")
                    .HasMaxLength(50);

                entity.Property(e => e.CSeq).HasColumnName("C_SEQ");

                entity.Property(e => e.FkFormname)
                    .IsRequired()
                    .HasColumnName("FK_FORMNAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TSysFormpropertyrep>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_FORMPROPERTYREP");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDefault).HasColumnName("C_DEFAULT");

                entity.Property(e => e.CDescription)
                    .HasColumnName("C_DESCRIPTION")
                    .HasMaxLength(200);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CFilename)
                    .IsRequired()
                    .HasColumnName("C_FILENAME")
                    .HasMaxLength(255);

                entity.Property(e => e.CFormname)
                    .IsRequired()
                    .HasColumnName("C_FORMNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.CPageSize)
                    .HasColumnName("C_PAGE_SIZE")
                    .HasMaxLength(100);

                entity.Property(e => e.CPortrait).HasColumnName("C_Portrait");

                entity.Property(e => e.CPrinterName)
                    .HasColumnName("C_PRINTER_NAME")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<TSysHnChitieu>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK_SYS_HN_CHITIEU");

                entity.ToTable("T_SYS_HN_CHITIEU");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TSysHnChitieuct>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK_SYS_HN_CHITIEUCT");

                entity.ToTable("T_SYS_HN_CHITIEUCT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDvt)
                    .HasColumnName("C_DVT")
                    .HasMaxLength(100);

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(100);

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.CTenct)
                    .HasColumnName("C_TENCT")
                    .HasMaxLength(100);

                entity.Property(e => e.FkHnSysChitieu)
                    .HasColumnName("FK_HN_SYS_CHITIEU")
                    .HasMaxLength(10);

                entity.HasOne(d => d.FkHnSysChitieuNavigation)
                    .WithMany(p => p.TSysHnChitieuct)
                    .HasForeignKey(d => d.FkHnSysChitieu)
                    .HasConstraintName("FK_HN_SYS_CHITIEUCT_CHITIEU");
            });

            modelBuilder.Entity<TSysKetchuyenchitiet>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_KETCHUYENCHITIET");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CChon).HasColumnName("C_CHON");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CTen)
                    .IsRequired()
                    .HasColumnName("C_TEN")
                    .HasMaxLength(50);

                entity.Property(e => e.CTentruong)
                    .HasColumnName("C_TENTRUONG")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TSysKhoasoketchyen>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_KHOASOKETCHYEN");

                entity.HasIndex(e => e.CTaikhoan)
                    .HasName("IX_T_SYS_KHOASOKETCHYEN")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDtcp).HasColumnName("C_DTCP");

                entity.Property(e => e.CKhachhang).HasColumnName("C_KHACHHANG");

                entity.Property(e => e.CKho).HasColumnName("C_KHO");

                entity.Property(e => e.CKhoanmuc).HasColumnName("C_KHOANMUC");

                entity.Property(e => e.CNguonvon).HasColumnName("C_NGUONVON");

                entity.Property(e => e.CPhanxuong).HasColumnName("C_PHANXUONG");

                entity.Property(e => e.CPhongban)
                    .HasColumnName("C_PHONGBAN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.CTaikhoan)
                    .IsRequired()
                    .HasColumnName("C_TAIKHOAN")
                    .HasMaxLength(10);

                entity.Property(e => e.CTscd).HasColumnName("C_TSCD");

                entity.Property(e => e.CVthh).HasColumnName("C_VTHH");

                entity.Property(e => e.CVuviec).HasColumnName("C_VUVIEC");
            });

            modelBuilder.Entity<TSysList>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_LIST");

                entity.HasIndex(e => e.CTable)
                    .HasName("IX_T_SYS_LIST")
                    .IsUnique();

                entity.HasIndex(e => e.CVietnamese)
                    .HasName("IX_T_SYS_LIST_1")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CAdvanced).HasColumnName("C_ADVANCED");

                entity.Property(e => e.CDeletetrigger)
                    .HasColumnName("C_DELETETRIGGER")
                    .HasColumnType("text");

                entity.Property(e => e.CDescription)
                    .HasColumnName("C_DESCRIPTION")
                    .HasMaxLength(200);

                entity.Property(e => e.CDescriptionen)
                    .HasColumnName("C_DESCRIPTIONEN")
                    .HasMaxLength(200);

                entity.Property(e => e.CEnglish)
                    .HasColumnName("C_ENGLISH")
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CHeight)
                    .HasColumnName("C_HEIGHT")
                    .HasDefaultValueSql("(300)");

                entity.Property(e => e.CIsgroup).HasColumnName("C_ISGROUP");

                entity.Property(e => e.CKeyfield)
                    .HasColumnName("C_KEYFIELD")
                    .HasMaxLength(50);

                entity.Property(e => e.CLabelsize)
                    .HasColumnName("C_LABELSIZE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CParent)
                    .HasColumnName("C_PARENT")
                    .HasMaxLength(20);

                entity.Property(e => e.CRead)
                    .HasColumnName("C_READ")
                    .HasMaxLength(255);

                entity.Property(e => e.CRootId).HasColumnName("C_RootID");

                entity.Property(e => e.CSeq)
                    .HasColumnName("C_SEQ")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CSortclause)
                    .HasColumnName("C_SORTCLAUSE")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CTable)
                    .IsRequired()
                    .HasColumnName("C_TABLE")
                    .HasMaxLength(50);

                entity.Property(e => e.CTextsize)
                    .HasColumnName("C_TEXTSIZE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CVietnamese)
                    .IsRequired()
                    .HasColumnName("C_VIETNAMESE")
                    .HasMaxLength(150);

                entity.Property(e => e.CViewtype).HasColumnName("C_VIEWTYPE");

                entity.Property(e => e.CVisible)
                    .HasColumnName("C_VISIBLE")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CWrite)
                    .HasColumnName("C_WRITE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TSysListdetail>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_LISTDETAIL");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CAlias)
                    .HasColumnName("C_ALIAS")
                    .HasMaxLength(50);

                entity.Property(e => e.CAlias2)
                    .HasColumnName("C_ALIAS2")
                    .HasMaxLength(50);

                entity.Property(e => e.CAlign)
                    .HasColumnName("C_ALIGN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CAllownull).HasColumnName("C_ALLOWNULL");

                entity.Property(e => e.CCase).HasColumnName("C_CASE");

                entity.Property(e => e.CCodefield)
                    .HasColumnName("C_CODEFIELD")
                    .HasMaxLength(50);

                entity.Property(e => e.CDropcaption)
                    .HasColumnName("C_DROPCAPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.CDropcaptionen)
                    .HasColumnName("C_DROPCAPTIONEN")
                    .HasMaxLength(500);

                entity.Property(e => e.CDropsql)
                    .HasColumnName("C_DROPSQL")
                    .HasColumnType("ntext");

                entity.Property(e => e.CEnglish)
                    .HasColumnName("C_ENGLISH")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CFilterfield)
                    .HasColumnName("C_FILTERFIELD")
                    .HasMaxLength(50);

                entity.Property(e => e.CFilterfield2)
                    .HasColumnName("C_FILTERFIELD2")
                    .HasMaxLength(30);

                entity.Property(e => e.CFormat)
                    .HasColumnName("C_FORMAT")
                    .HasMaxLength(50);

                entity.Property(e => e.CFromfield)
                    .HasColumnName("C_FROMFIELD")
                    .HasMaxLength(50);

                entity.Property(e => e.CFromlist)
                    .HasColumnName("C_FROMLIST")
                    .HasColumnType("ntext");

                entity.Property(e => e.CFromtable)
                    .HasColumnName("C_FROMTABLE")
                    .HasMaxLength(50);

                entity.Property(e => e.CIdentity).HasColumnName("C_IDENTITY");

                entity.Property(e => e.CLevelfield)
                    .HasColumnName("C_LEVELFIELD")
                    .HasMaxLength(50);

                entity.Property(e => e.CMask)
                    .HasColumnName("C_MASK")
                    .HasMaxLength(50);

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasColumnName("C_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.CNdecimal)
                    .HasColumnName("C_NDECIMAL")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CPermit)
                    .HasColumnName("C_PERMIT")
                    .HasMaxLength(50);

                entity.Property(e => e.CReadonly)
                    .HasColumnName("C_READONLY")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CSeq)
                    .HasColumnName("C_SEQ")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CTreefield).HasColumnName("C_TREEFIELD");

                entity.Property(e => e.CUnique).HasColumnName("C_UNIQUE");

                entity.Property(e => e.CVietnamese)
                    .IsRequired()
                    .HasColumnName("C_VIETNAMESE")
                    .HasMaxLength(50);

                entity.Property(e => e.CView).HasColumnName("C_VIEW");

                entity.Property(e => e.CVisible)
                    .HasColumnName("C_VISIBLE")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CWidth)
                    .HasColumnName("C_WIDTH")
                    .HasDefaultValueSql("(100)");

                entity.Property(e => e.CWidth2).HasColumnName("C_WIDTH2");

                entity.Property(e => e.FkList).HasColumnName("FK_LIST");
            });

            modelBuilder.Entity<TSysMessage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_SYS_MESSAGE");

                entity.Property(e => e.CEnglish)
                    .HasColumnName("C_ENGLISH")
                    .HasMaxLength(255);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(50);

                entity.Property(e => e.CVietnamese)
                    .HasColumnName("C_VIETNAMESE")
                    .HasMaxLength(255);

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TSysNguoncc>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_NGUONCC");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(15);

                entity.Property(e => e.CMotaen)
                    .HasColumnName("C_MOTAEN")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<TSysNhomketchuyen>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_NHOMKETCHUYEN");

                entity.HasIndex(e => e.CMa)
                    .HasName("IX_T_SYS_NHOMKETCHUYEN")
                    .IsUnique();

                entity.HasIndex(e => e.CTen)
                    .HasName("IX_T_SYS_NHOMKETCHUYEN_1")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCoDtcpLuu).HasColumnName("C_CO_DTCP_LUU");

                entity.Property(e => e.CCongthuc)
                    .HasColumnName("C_CONGTHUC")
                    .HasMaxLength(4000);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CGiatriVthh)
                    .HasColumnName("C_GIATRI_VTHH")
                    .HasMaxLength(1000);

                entity.Property(e => e.CKetchuyen)
                    .HasColumnName("C_KETCHUYEN")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CLechve).HasColumnName("C_LECHVE");

                entity.Property(e => e.CLuuDtcp)
                    .HasColumnName("C_LUU_DTCP")
                    .HasMaxLength(300);

                entity.Property(e => e.CLuutk).HasColumnName("C_LUUTK");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CPbCapsp).HasColumnName("C_PB_CAPSP");

                entity.Property(e => e.CPhanbo)
                    .HasColumnName("C_PHANBO")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CSothanglamviec).HasColumnName("C_SOTHANGLAMVIEC");

                entity.Property(e => e.CTen)
                    .IsRequired()
                    .HasColumnName("C_TEN")
                    .HasMaxLength(200);

                entity.Property(e => e.CThanhpham)
                    .HasColumnName("C_THANHPHAM")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CTile)
                    .HasColumnName("C_TILE")
                    .HasMaxLength(1000);

                entity.Property(e => e.CTt)
                    .HasColumnName("C_TT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CUpdate).HasColumnName("C_UPDATE");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkKetchuyenchitiet)
                    .HasColumnName("FK_KETCHUYENCHITIET")
                    .HasMaxLength(50);

                entity.Property(e => e.FkNhomKc).HasColumnName("FK_NHOM_KC");

                entity.Property(e => e.FkPhanbochitiet)
                    .HasColumnName("FK_PHANBOCHITIET")
                    .HasMaxLength(50);

                entity.Property(e => e.FkTieuthucpb)
                    .HasColumnName("FK_TIEUTHUCPB")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TSysNhomketchuyenct>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_NHOMKETCHUYENCT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(200);

                entity.Property(e => e.CGiatri)
                    .HasColumnName("C_GIATRI")
                    .HasMaxLength(1000);

                entity.Property(e => e.CSangtaikhoan)
                    .IsRequired()
                    .HasColumnName("C_SANGTAIKHOAN")
                    .HasMaxLength(12);

                entity.Property(e => e.CTentruong)
                    .HasColumnName("C_TENTRUONG")
                    .HasMaxLength(100);

                entity.Property(e => e.CTutaikhoan)
                    .IsRequired()
                    .HasColumnName("C_TUTAIKHOAN")
                    .HasMaxLength(12);

                entity.Property(e => e.CUpdate)
                    .HasColumnName("C_UPDATE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FkNhomketchuyen).HasColumnName("FK_NHOMKETCHUYEN");
            });

            modelBuilder.Entity<TSysNotification>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_NOTIFICATION");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CFromdate)
                    .HasColumnName("C_FROMDATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CKey)
                    .HasColumnName("C_KEY")
                    .HasMaxLength(35);

                entity.Property(e => e.COpenlist)
                    .HasColumnName("C_OPENLIST")
                    .HasMaxLength(200);

                entity.Property(e => e.CTodate)
                    .HasColumnName("C_TODATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CUserlist)
                    .HasColumnName("C_USERLIST")
                    .HasMaxLength(200);

                entity.Property(e => e.CValiddate)
                    .HasColumnName("C_VALIDDATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FkAccount).HasColumnName("FK_ACCOUNT");

                entity.Property(e => e.FkBookingnote).HasColumnName("FK_BOOKINGNOTE");

                entity.Property(e => e.FkCustomer).HasColumnName("FK_CUSTOMER");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkFromport).HasColumnName("FK_FROMPORT");

                entity.Property(e => e.FkKho).HasColumnName("FK_KHO");

                entity.Property(e => e.FkKmp).HasColumnName("FK_KMP");

                entity.Property(e => e.FkNotificationConfig).HasColumnName("FK_NOTIFICATION_CONFIG");

                entity.Property(e => e.FkSender).HasColumnName("FK_SENDER");

                entity.Property(e => e.FkToport).HasColumnName("FK_TOPORT");

                entity.Property(e => e.FkVessel).HasColumnName("FK_VESSEL");

                entity.Property(e => e.FkVoyage).HasColumnName("FK_VOYAGE");

                entity.Property(e => e.FkVuviec).HasColumnName("FK_VUVIEC");
            });

            modelBuilder.Entity<TSysNotificationConfig>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_NOTIFICATION_CONFIG");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CAlert).HasColumnName("C_ALERT");

                entity.Property(e => e.CDaily)
                    .HasColumnName("C_DAILY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CDelayTime).HasColumnName("C_Delay_time");

                entity.Property(e => e.CDeleteAfterReceive).HasColumnName("C_DELETE_AFTER_RECEIVE");

                entity.Property(e => e.CDuration).HasColumnName("C_Duration");

                entity.Property(e => e.CEffective).HasColumnName("C_EFFECTIVE");

                entity.Property(e => e.CMessage)
                    .HasColumnName("C_MESSAGE")
                    .HasMaxLength(255);

                entity.Property(e => e.CReceiver)
                    .HasColumnName("C_RECEIVER")
                    .HasMaxLength(200);

                entity.Property(e => e.CSender).HasColumnName("C_SENDER");

                entity.Property(e => e.CStartTime).HasColumnName("C_StartTime");

                entity.Property(e => e.FkCreateUser).HasColumnName("FK_CREATE_USER");

                entity.Property(e => e.FkNotificationType).HasColumnName("FK_NOTIFICATION_TYPE");
            });

            modelBuilder.Entity<TSysNotificationType>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_NOTIFICATION_TYPE");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CAccount).HasColumnName("C_ACCOUNT");

                entity.Property(e => e.CAlert).HasColumnName("C_ALERT");

                entity.Property(e => e.CBookingnote).HasColumnName("C_BOOKINGNOTE");

                entity.Property(e => e.CCode)
                    .HasColumnName("C_CODE")
                    .HasMaxLength(35);

                entity.Property(e => e.CCustomer).HasColumnName("C_CUSTOMER");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CDescription)
                    .HasColumnName("C_DESCRIPTION")
                    .HasMaxLength(150);

                entity.Property(e => e.CDtcp).HasColumnName("C_DTCP");

                entity.Property(e => e.CEvent)
                    .HasColumnName("C_EVENT")
                    .HasMaxLength(10);

                entity.Property(e => e.CFromdate).HasColumnName("C_FROMDATE");

                entity.Property(e => e.CFromport).HasColumnName("C_FROMPORT");

                entity.Property(e => e.CKho).HasColumnName("C_KHO");

                entity.Property(e => e.CKmp).HasColumnName("C_KMP");

                entity.Property(e => e.CMessage)
                    .HasColumnName("C_MESSAGE")
                    .HasMaxLength(255);

                entity.Property(e => e.CObject).HasColumnName("C_OBJECT");

                entity.Property(e => e.CReportcode)
                    .HasColumnName("C_REPORTCODE")
                    .HasMaxLength(100);

                entity.Property(e => e.CTodate).HasColumnName("C_TODATE");

                entity.Property(e => e.CToport).HasColumnName("C_TOPORT");

                entity.Property(e => e.CVessel).HasColumnName("C_VESSEL");

                entity.Property(e => e.CVoyage).HasColumnName("C_VOYAGE");

                entity.Property(e => e.CVuviec).HasColumnName("C_VUVIEC");

                entity.Property(e => e.FkCreator).HasColumnName("FK_CREATOR");
            });

            modelBuilder.Entity<TSysPhamvikhuyenmai>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_PHAMVIKHUYENMAI");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TSysPhanbochitiet>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_PHANBOCHITIET");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CBang)
                    .HasColumnName("C_BANG")
                    .HasMaxLength(50);

                entity.Property(e => e.CChon).HasColumnName("C_CHON");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CHienthi)
                    .HasColumnName("C_HIENTHI")
                    .HasMaxLength(50);

                entity.Property(e => e.CTen)
                    .IsRequired()
                    .HasColumnName("C_TEN")
                    .HasMaxLength(50);

                entity.Property(e => e.CTentruong)
                    .HasColumnName("C_TENTRUONG")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TSysPpkhtscd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_SYS_PPKHTSCD");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CTen)
                    .IsRequired()
                    .HasColumnName("C_TEN")
                    .HasMaxLength(50);

                entity.Property(e => e.PkId).HasColumnName("PK_ID");
            });

            modelBuilder.Entity<TSysReplicationconfig>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_SYS_REPLICATIONCONFIG");

                entity.Property(e => e.CDatabasefolder)
                    .HasColumnName("C_DATABASEFOLDER")
                    .HasMaxLength(250);

                entity.Property(e => e.CDatabasename)
                    .HasColumnName("C_DATABASENAME")
                    .HasMaxLength(50);

                entity.Property(e => e.CDatabasetype).HasColumnName("C_DATABASETYPE");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CPassword)
                    .HasColumnName("C_PASSWORD")
                    .HasMaxLength(50);

                entity.Property(e => e.CServername)
                    .HasColumnName("C_SERVERNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.CUsername)
                    .HasColumnName("C_USERNAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TSysReplicationlog>(entity =>
            {
                entity.HasKey(e => e.CDatetime);

                entity.ToTable("T_SYS_REPLICATIONLOG");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CErrorsql)
                    .HasColumnName("C_ERRORSQL")
                    .HasMaxLength(1000);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CTablename)
                    .HasColumnName("C_TABLENAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TSysReplicationtable>(entity =>
            {
                entity.HasKey(e => e.CTablename)
                    .HasName("PK_T_SYS_REPLICATION");

                entity.ToTable("T_SYS_REPLICATIONTABLE");

                entity.Property(e => e.CTablename)
                    .HasColumnName("C_TABLENAME")
                    .HasMaxLength(50);

                entity.Property(e => e.CAllowexport).HasColumnName("C_ALLOWEXPORT");

                entity.Property(e => e.CAllowimport).HasColumnName("C_ALLOWIMPORT");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CLastexporttime)
                    .HasColumnName("C_LASTEXPORTTIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CLastimporttime)
                    .HasColumnName("C_LASTIMPORTTIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CSeq).HasColumnName("C_SEQ");

                entity.Property(e => e.CTimefield)
                    .HasColumnName("C_TIMEFIELD")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CUniquefield1)
                    .HasColumnName("C_UNIQUEFIELD1")
                    .HasMaxLength(50);

                entity.Property(e => e.CUniquefield2)
                    .HasColumnName("C_UNIQUEFIELD2")
                    .HasMaxLength(50);

                entity.Property(e => e.CUniquefield3)
                    .HasColumnName("C_UNIQUEFIELD3")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TSysReport>(entity =>
            {
                entity.HasKey(e => new { e.PkId, e.CKey })
                    .HasName("PK_TREE")
                    .IsClustered(false);

                entity.ToTable("T_SYS_REPORT");

                entity.HasIndex(e => e.CKey)
                    .HasName("IX_KEY1")
                    .IsUnique();

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CKey).HasColumnName("C_KEY");

                entity.Property(e => e.CA4)
                    .IsRequired()
                    .HasColumnName("C_A4")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CAutocolumns)
                    .IsRequired()
                    .HasColumnName("C_AUTOCOLUMNS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CBangcongthuc)
                    .HasColumnName("C_BANGCONGTHUC")
                    .HasMaxLength(30);

                entity.Property(e => e.CBoldcolumns)
                    .IsRequired()
                    .HasColumnName("C_BOLDCOLUMNS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CBoldcontent)
                    .IsRequired()
                    .HasColumnName("C_BOLDCONTENT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CBoldtitlereport)
                    .IsRequired()
                    .HasColumnName("C_BOLDTITLEREPORT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CBottommargin)
                    .HasColumnName("C_BOTTOMMARGIN")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CCaption)
                    .HasColumnName("C_CAPTION")
                    .HasColumnType("ntext");

                entity.Property(e => e.CCmddel)
                    .IsRequired()
                    .HasColumnName("C_CMDDEL")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CColNumbering).HasColumnName("C_ColNumbering");

                entity.Property(e => e.CColorcolumns)
                    .IsRequired()
                    .HasColumnName("C_COLORCOLUMNS")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'0#0#0')");

                entity.Property(e => e.CColorcontent)
                    .IsRequired()
                    .HasColumnName("C_COLORCONTENT")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'0#0#0')");

                entity.Property(e => e.CColortitlereport)
                    .IsRequired()
                    .HasColumnName("C_COLORTITLEREPORT")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'0#0#0')");

                entity.Property(e => e.CCondition)
                    .IsRequired()
                    .HasColumnName("C_CONDITION")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CDateinreport).HasColumnName("C_DATEINREPORT");

                entity.Property(e => e.CDelete)
                    .IsRequired()
                    .HasColumnName("C_DELETE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CDescription)
                    .HasColumnName("C_DESCRIPTION")
                    .HasMaxLength(200);

                entity.Property(e => e.CDescriptionen)
                    .HasColumnName("C_DESCRIPTIONEN")
                    .HasMaxLength(200);

                entity.Property(e => e.CDetailcode)
                    .HasColumnName("C_DETAILCODE")
                    .HasMaxLength(20);

                entity.Property(e => e.CDetailfont)
                    .HasColumnName("C_DETAILFONT")
                    .HasMaxLength(50);

                entity.Property(e => e.CDetailheight)
                    .HasColumnName("C_DETAILHEIGHT")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CDetailreport).HasColumnName("C_DETAILREPORT");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CFontcontent)
                    .IsRequired()
                    .HasColumnName("C_FONTCONTENT")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CFonttitlecolumns)
                    .IsRequired()
                    .HasColumnName("C_FONTTITLECOLUMNS")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CFonttitlereport)
                    .IsRequired()
                    .HasColumnName("C_FONTTITLEREPORT")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CFormula)
                    .IsRequired()
                    .HasColumnName("C_FORMULA")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CGrid).HasColumnName("C_GRID");

                entity.Property(e => e.CGroupby)
                    .IsRequired()
                    .HasColumnName("C_GROUPBY")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CGroupfont)
                    .HasColumnName("C_GROUPFONT")
                    .HasMaxLength(50);

                entity.Property(e => e.CGroupheight)
                    .HasColumnName("C_GROUPHEIGHT")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CGroupreport)
                    .HasColumnName("C_GROUPREPORT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CHeaderfooterfont)
                    .HasColumnName("C_HEADERFOOTERFONT")
                    .HasMaxLength(50);

                entity.Property(e => e.CHeaderheight)
                    .HasColumnName("C_HEADERHEIGHT")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CIndex).HasColumnName("C_INDEX");

                entity.Property(e => e.CIso)
                    .HasColumnName("C_ISO")
                    .HasMaxLength(100);

                entity.Property(e => e.CIsroot).HasColumnName("C_ISROOT");

                entity.Property(e => e.CItaniccolumns)
                    .IsRequired()
                    .HasColumnName("C_ITANICCOLUMNS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CItaniccontent)
                    .IsRequired()
                    .HasColumnName("C_ITANICCONTENT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CItanictitlereport)
                    .IsRequired()
                    .HasColumnName("C_ITANICTITLEREPORT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CLabel)
                    .IsRequired()
                    .HasColumnName("C_LABEL")
                    .HasMaxLength(100);

                entity.Property(e => e.CLabelen)
                    .HasColumnName("C_LABELEN")
                    .HasMaxLength(100);

                entity.Property(e => e.CLandcape).HasColumnName("C_LANDCAPE");

                entity.Property(e => e.CLeftmargin)
                    .HasColumnName("C_LEFTMARGIN")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CLinestyle).HasColumnName("C_LINESTYLE");

                entity.Property(e => e.CLineweight).HasColumnName("C_LINEWEIGHT");

                entity.Property(e => e.CLocalreport)
                    .HasColumnName("C_LOCALREPORT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CNote)
                    .IsRequired()
                    .HasColumnName("C_NOTE")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.COrderby)
                    .IsRequired()
                    .HasColumnName("C_ORDERBY")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CPage)
                    .IsRequired()
                    .HasColumnName("C_PAGE")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CPapersize)
                    .HasColumnName("C_PAPERSIZE")
                    .HasMaxLength(50);

                entity.Property(e => e.CParameter)
                    .HasColumnName("C_PARAMETER")
                    .HasColumnType("ntext");

                entity.Property(e => e.CParameterfont)
                    .HasColumnName("C_PARAMETERFONT")
                    .HasMaxLength(50);

                entity.Property(e => e.CParent).HasColumnName("C_PARENT");

                entity.Property(e => e.CPicture)
                    .IsRequired()
                    .HasColumnName("C_PICTURE")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CPicture1)
                    .IsRequired()
                    .HasColumnName("C_PICTURE1")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CPostSql)
                    .HasColumnName("C_PostSQL")
                    .HasMaxLength(1000);

                entity.Property(e => e.CPrintcolumns)
                    .IsRequired()
                    .HasColumnName("C_PRINTCOLUMNS")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CPrintdate)
                    .IsRequired()
                    .HasColumnName("C_PRINTDATE")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CPrinterName)
                    .HasColumnName("C_PRINTER_NAME")
                    .HasMaxLength(150);

                entity.Property(e => e.CRead)
                    .IsRequired()
                    .HasColumnName("C_READ")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CReport)
                    .IsRequired()
                    .HasColumnName("C_REPORT")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CReporter)
                    .IsRequired()
                    .HasColumnName("C_REPORTER")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CReportfile)
                    .IsRequired()
                    .HasColumnName("C_REPORTFILE")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CReportfooter)
                    .HasColumnName("C_REPORTFOOTER")
                    .HasMaxLength(255);

                entity.Property(e => e.CReportfooterfont)
                    .HasColumnName("C_REPORTFOOTERFONT")
                    .HasMaxLength(50);

                entity.Property(e => e.CReporttitlefont)
                    .HasColumnName("C_REPORTTITLEFONT")
                    .HasMaxLength(50);

                entity.Property(e => e.CReporttype).HasColumnName("C_REPORTTYPE");

                entity.Property(e => e.CRightmargin)
                    .HasColumnName("C_RIGHTMARGIN")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CRootId).HasColumnName("C_RootID");

                entity.Property(e => e.CSignature)
                    .HasColumnName("C_SIGNATURE")
                    .HasMaxLength(250);

                entity.Property(e => e.CSignatureen)
                    .HasColumnName("C_SIGNATUREen")
                    .HasMaxLength(250);

                entity.Property(e => e.CSizecontent)
                    .HasColumnName("C_SIZECONTENT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CSizefontcolumns)
                    .HasColumnName("C_SIZEFONTCOLUMNS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CSizefontreport)
                    .HasColumnName("C_SIZEFONTREPORT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CSoPhatSinh).HasColumnName("C_SoPhatSinh");

                entity.Property(e => e.CSql)
                    .IsRequired()
                    .HasColumnName("C_SQL")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CStrfrom)
                    .IsRequired()
                    .HasColumnName("C_STRFROM")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CStrgroup)
                    .IsRequired()
                    .HasColumnName("C_STRGROUP")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CStrorder)
                    .IsRequired()
                    .HasColumnName("C_STRORDER")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CStrselect)
                    .IsRequired()
                    .HasColumnName("C_STRSELECT")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CStrwhere)
                    .IsRequired()
                    .HasColumnName("C_STRWHERE")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CSystem)
                    .IsRequired()
                    .HasColumnName("C_SYSTEM")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CTemplateGroup)
                    .HasColumnName("C_TemplateGroup")
                    .HasMaxLength(100);

                entity.Property(e => e.CTheoTaiKhoan).HasColumnName("C_TheoTaiKhoan");

                entity.Property(e => e.CTop)
                    .HasColumnName("C_TOP")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CTopmargin)
                    .HasColumnName("C_TOPMARGIN")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CTopvalue)
                    .HasColumnName("C_TOPVALUE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CUndercolumns)
                    .IsRequired()
                    .HasColumnName("C_UNDERCOLUMNS")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CUndercontent)
                    .IsRequired()
                    .HasColumnName("C_UNDERCONTENT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CUndertitlereport)
                    .IsRequired()
                    .HasColumnName("C_UNDERTITLEREPORT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CValue)
                    .IsRequired()
                    .HasColumnName("C_VALUE")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CVisible)
                    .HasColumnName("C_VISIBLE")
                    .HasMaxLength(255);

                entity.Property(e => e.CVisiblefields)
                    .IsRequired()
                    .HasColumnName("C_VISIBLEFIELDS")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CWrite)
                    .IsRequired()
                    .HasColumnName("C_WRITE")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CX)
                    .HasColumnName("C_X")
                    .HasMaxLength(50);

                entity.Property(e => e.CY)
                    .HasColumnName("C_Y")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TSysReportKh>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_REPORT_KH");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CPhieuin)
                    .HasColumnName("C_PHIEUIN")
                    .HasMaxLength(50);

                entity.Property(e => e.CTenviettat).HasColumnName("C_TENVIETTAT");

                entity.Property(e => e.FkReport).HasColumnName("FK_REPORT");
            });

            modelBuilder.Entity<TSysReportchart>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_REPORTCHART");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CAxiscaptionx)
                    .HasColumnName("C_AXISCAPTIONX")
                    .HasMaxLength(50);

                entity.Property(e => e.CAxiscaptiony)
                    .HasColumnName("C_AXISCAPTIONY")
                    .HasMaxLength(50);

                entity.Property(e => e.CChartname)
                    .IsRequired()
                    .HasColumnName("C_CHARTNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.CCharttype).HasColumnName("C_CHARTTYPE");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CHeight).HasColumnName("C_HEIGHT");

                entity.Property(e => e.CKeycolumn)
                    .HasColumnName("C_KEYCOLUMN")
                    .HasMaxLength(50);

                entity.Property(e => e.CKeyvalue)
                    .HasColumnName("C_KEYVALUE")
                    .HasMaxLength(500);

                entity.Property(e => e.CSeq).HasColumnName("C_SEQ");

                entity.Property(e => e.CSeriesx)
                    .IsRequired()
                    .HasColumnName("C_SERIESX")
                    .HasMaxLength(500);

                entity.Property(e => e.CSeriesy)
                    .IsRequired()
                    .HasColumnName("C_SERIESY")
                    .HasMaxLength(500);

                entity.Property(e => e.CSourcetype)
                    .HasColumnName("C_SOURCETYPE")
                    .HasComment("by column; by row");

                entity.Property(e => e.CWidth).HasColumnName("C_WIDTH");

                entity.Property(e => e.FkReport).HasColumnName("FK_REPORT");
            });

            modelBuilder.Entity<TSysReportcolprop>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_REPORTCOLPROP");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CAlign).HasColumnName("C_ALIGN");

                entity.Property(e => e.CBold).HasColumnName("C_BOLD");

                entity.Property(e => e.CCaptionen)
                    .HasColumnName("C_CAPTIONEN")
                    .HasMaxLength(100);

                entity.Property(e => e.CCaptiontype).HasColumnName("C_CAPTIONTYPE");

                entity.Property(e => e.CCaptionvn)
                    .HasColumnName("C_CAPTIONVN")
                    .HasMaxLength(100);

                entity.Property(e => e.CColNumber)
                    .HasColumnName("C_ColNumber")
                    .HasMaxLength(100);

                entity.Property(e => e.CColname)
                    .IsRequired()
                    .HasColumnName("C_COLNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.CColor)
                    .HasColumnName("C_COLOR")
                    .HasMaxLength(20);

                entity.Property(e => e.CColsummaryposition).HasColumnName("C_COLSUMMARYPOSITION");

                entity.Property(e => e.CContentangle).HasColumnName("C_CONTENTANGLE");

                entity.Property(e => e.CCrlf).HasColumnName("C_CRLF");

                entity.Property(e => e.CDecimaldigits).HasColumnName("C_DECIMALDIGITS");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CFf1)
                    .HasColumnName("C_FF1")
                    .HasMaxLength(30);

                entity.Property(e => e.CFf2)
                    .HasColumnName("C_FF2")
                    .HasMaxLength(30);

                entity.Property(e => e.CFf3)
                    .HasColumnName("C_FF3")
                    .HasMaxLength(30);

                entity.Property(e => e.CFormat)
                    .HasColumnName("C_FORMAT")
                    .HasMaxLength(50);

                entity.Property(e => e.CGroupalign)
                    .HasColumnName("C_GROUPALIGN")
                    .HasMaxLength(150);

                entity.Property(e => e.CGroupby).HasColumnName("C_GROUPBY");

                entity.Property(e => e.CGroupposition).HasColumnName("C_GROUPPOSITION");

                entity.Property(e => e.CHeaderangle).HasColumnName("C_HEADERANGLE");

                entity.Property(e => e.CHeaderheight).HasColumnName("C_HEADERHEIGHT");

                entity.Property(e => e.CHeight)
                    .HasColumnName("C_HEIGHT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CHidegrid).HasColumnName("C_HIDEGRID");

                entity.Property(e => e.CInword).HasColumnName("C_INWORD");

                entity.Property(e => e.CIsgroup).HasColumnName("C_ISGROUP");

                entity.Property(e => e.COnfooter).HasColumnName("C_ONFOOTER");

                entity.Property(e => e.COnheader).HasColumnName("C_ONHEADER");

                entity.Property(e => e.COrder).HasColumnName("C_ORDER");

                entity.Property(e => e.COutlookGroupBy).HasColumnName("C_OutlookGroupBy");

                entity.Property(e => e.COverride).HasColumnName("C_OVERRIDE");

                entity.Property(e => e.CPagesummaryposition).HasColumnName("C_PAGESUMMARYPOSITION");

                entity.Property(e => e.CParent)
                    .HasColumnName("C_PARENT")
                    .HasMaxLength(50);

                entity.Property(e => e.CReportsummaryposition).HasColumnName("C_REPORTSUMMARYPOSITION");

                entity.Property(e => e.CSubreport).HasColumnName("C_SUBREPORT");

                entity.Property(e => e.CSumgrid).HasColumnName("C_SUMGRID");

                entity.Property(e => e.CTf1)
                    .HasColumnName("C_TF1")
                    .HasMaxLength(30);

                entity.Property(e => e.CTf2)
                    .HasColumnName("C_TF2")
                    .HasMaxLength(30);

                entity.Property(e => e.CTf3)
                    .HasColumnName("C_TF3")
                    .HasMaxLength(30);

                entity.Property(e => e.CType).HasColumnName("C_TYPE");

                entity.Property(e => e.CUsd).HasColumnName("C_USD");

                entity.Property(e => e.CVisible).HasColumnName("C_VISIBLE");

                entity.Property(e => e.CWidth).HasColumnName("C_WIDTH");

                entity.Property(e => e.FkReport).HasColumnName("FK_REPORT");
            });

            modelBuilder.Entity<TSysReportcondition>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_SYS_REPORTCONDITION");

                entity.HasIndex(e => e.FkReport)
                    .HasName("IX_KEY1");

                entity.Property(e => e.CAdd)
                    .IsRequired()
                    .HasColumnName("C_ADD")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CExpression)
                    .IsRequired()
                    .HasColumnName("C_EXPRESSION")
                    .HasMaxLength(50);

                entity.Property(e => e.CFieldname)
                    .IsRequired()
                    .HasColumnName("C_FIELDNAME")
                    .HasMaxLength(255);

                entity.Property(e => e.CJoin)
                    .IsRequired()
                    .HasColumnName("C_JOIN")
                    .HasMaxLength(50);

                entity.Property(e => e.CTablename)
                    .IsRequired()
                    .HasColumnName("C_TABLENAME")
                    .HasMaxLength(50);

                entity.Property(e => e.CValue)
                    .IsRequired()
                    .HasColumnName("C_VALUE")
                    .HasMaxLength(100);

                entity.Property(e => e.FkReport).HasColumnName("FK_REPORT");
            });

            modelBuilder.Entity<TSysReportdetailcolprop>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_REPORTDETAILCOLPROP");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CColname)
                    .IsRequired()
                    .HasColumnName("C_COLNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.CDecimaldigits).HasColumnName("C_DECIMALDIGITS");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CWidth).HasColumnName("C_WIDTH");

                entity.Property(e => e.FkReport).HasColumnName("FK_REPORT");
            });

            modelBuilder.Entity<TSysReportdetailpara>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_SYS_REPORTDETAILPARA");

                entity.Property(e => e.CColname)
                    .IsRequired()
                    .HasColumnName("C_COLNAME")
                    .HasMaxLength(30);

                entity.Property(e => e.CDatatype)
                    .IsRequired()
                    .HasColumnName("C_DATATYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CFromcol).HasColumnName("C_FROMCOL");

                entity.Property(e => e.CParaname)
                    .IsRequired()
                    .HasColumnName("C_PARANAME")
                    .HasMaxLength(30);

                entity.Property(e => e.FkReport).HasColumnName("FK_REPORT");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TSysReportfield>(entity =>
            {
                entity.ToTable("T_SYS_REPORTFIELD");

                entity.HasIndex(e => e.FkReport)
                    .HasName("IX_KEY1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CAlignment)
                    .HasColumnName("C_ALIGNMENT")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CCaption)
                    .HasColumnName("C_CAPTION")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CCondition)
                    .HasColumnName("C_CONDITION")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CDatatype)
                    .HasColumnName("C_DATATYPE")
                    .HasMaxLength(20);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CFieldname)
                    .IsRequired()
                    .HasColumnName("C_FIELDNAME")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CFormat)
                    .HasColumnName("C_FORMAT")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CFormula)
                    .HasColumnName("C_FORMULA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CGroupby)
                    .HasColumnName("C_GROUPBY")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.COrderby)
                    .HasColumnName("C_ORDERBY")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CSelected)
                    .IsRequired()
                    .HasColumnName("C_SELECTED")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CSeq)
                    .HasColumnName("C_SEQ")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CTablefield)
                    .HasColumnName("C_TABLEFIELD")
                    .HasMaxLength(50);

                entity.Property(e => e.CWidth)
                    .HasColumnName("C_WIDTH")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FkReport)
                    .HasColumnName("FK_REPORT")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TSysReportpara>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_REPORTPARA");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CBrowlist)
                    .HasColumnName("C_BROWLIST")
                    .HasMaxLength(50);

                entity.Property(e => e.CCaption)
                    .HasColumnName("C_CAPTION")
                    .HasMaxLength(40);

                entity.Property(e => e.CCaptionen)
                    .HasColumnName("C_CAPTIONEN")
                    .HasMaxLength(40);

                entity.Property(e => e.CCodefield)
                    .HasColumnName("C_CODEFIELD")
                    .HasMaxLength(50);

                entity.Property(e => e.CColsize)
                    .HasColumnName("C_COLSIZE")
                    .HasMaxLength(50);

                entity.Property(e => e.CContinuous).HasColumnName("C_CONTINUOUS");

                entity.Property(e => e.CDatatype)
                    .IsRequired()
                    .HasColumnName("C_DATATYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.CDefaultvalue)
                    .HasColumnName("C_DEFAULTVALUE")
                    .HasMaxLength(100);

                entity.Property(e => e.CDisplayfield)
                    .HasColumnName("C_DISPLAYFIELD")
                    .HasMaxLength(40);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CHidden).HasColumnName("C_HIDDEN");

                entity.Property(e => e.CKeycontrol)
                    .HasColumnName("C_KEYCONTROL")
                    .HasMaxLength(50);

                entity.Property(e => e.CKeyfield)
                    .HasColumnName("C_KEYFIELD")
                    .HasMaxLength(50);

                entity.Property(e => e.CMultivalue)
                    .HasColumnName("C_MULTIVALUE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CNamecontrol)
                    .HasColumnName("C_NAMECONTROL")
                    .HasMaxLength(50);

                entity.Property(e => e.CNamefield)
                    .HasColumnName("C_NAMEFIELD")
                    .HasMaxLength(50);

                entity.Property(e => e.CNamefield2)
                    .HasColumnName("C_NAMEFIELD2")
                    .HasMaxLength(50);

                entity.Property(e => e.CNotop).HasColumnName("C_NOTOP");

                entity.Property(e => e.CNotprint).HasColumnName("C_NOTPRINT");

                entity.Property(e => e.CParamertname)
                    .IsRequired()
                    .HasColumnName("C_PARAMERTNAME")
                    .HasMaxLength(40);

                entity.Property(e => e.CSamerow).HasColumnName("C_SAMEROW");

                entity.Property(e => e.CSql)
                    .HasColumnName("C_SQL")
                    .HasColumnType("ntext");

                entity.Property(e => e.CTagvalue).HasColumnName("C_TAGVALUE");

                entity.Property(e => e.CUpper).HasColumnName("C_UPPER");

                entity.Property(e => e.CWhereclause)
                    .HasColumnName("C_WHERECLAUSE")
                    .HasMaxLength(1000);

                entity.Property(e => e.CWidth)
                    .HasColumnName("C_WIDTH")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FkReport).HasColumnName("FK_REPORT");
            });

            modelBuilder.Entity<TSysReportrelation>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK_TREE_RELATION")
                    .IsClustered(false);

                entity.ToTable("T_SYS_REPORTRELATION");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CFieldname1)
                    .IsRequired()
                    .HasColumnName("C_FIELDNAME1")
                    .HasMaxLength(50);

                entity.Property(e => e.CFieldname2)
                    .IsRequired()
                    .HasColumnName("C_FIELDNAME2")
                    .HasMaxLength(50);

                entity.Property(e => e.CJointype)
                    .IsRequired()
                    .HasColumnName("C_JOINTYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.CTablename1)
                    .IsRequired()
                    .HasColumnName("C_TABLENAME1")
                    .HasMaxLength(50);

                entity.Property(e => e.CTablename2)
                    .IsRequired()
                    .HasColumnName("C_TABLENAME2")
                    .HasMaxLength(50);

                entity.Property(e => e.FkReport).HasColumnName("FK_REPORT");
            });

            modelBuilder.Entity<TSysReporttable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_SYS_REPORTTABLE");

                entity.HasIndex(e => e.FkReport)
                    .HasName("IX_TREE");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CTablename)
                    .HasColumnName("C_TABLENAME")
                    .HasMaxLength(50);

                entity.Property(e => e.FkReport).HasColumnName("FK_REPORT");
            });

            modelBuilder.Entity<TSysRestorelog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_SYS_RESTORELOG");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CPath)
                    .HasColumnName("C_PATH")
                    .HasMaxLength(255);

                entity.Property(e => e.CStatus).HasColumnName("C_STATUS");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TSysScheduletype>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_SCHEDULETYPE");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDescription)
                    .IsRequired()
                    .HasColumnName("C_DESCRIPTION")
                    .HasMaxLength(10);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");
            });

            modelBuilder.Entity<TSysThuyetminhbctc1>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_THUYETMINHBCTC1");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CContent)
                    .HasColumnName("C_CONTENT")
                    .HasMaxLength(500);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CLabel)
                    .HasColumnName("C_LABEL")
                    .HasMaxLength(200);

                entity.Property(e => e.CLabelen)
                    .HasColumnName("C_LABELEN")
                    .HasMaxLength(200);

                entity.Property(e => e.COrder).HasColumnName("C_ORDER");
            });

            modelBuilder.Entity<TSysThuyetminhbctc10>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_THUYETMINHBCTC10");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CChitieu)
                    .HasColumnName("C_CHITIEU")
                    .HasMaxLength(200);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CLabelen)
                    .HasColumnName("C_LABELEN")
                    .HasMaxLength(200);

                entity.Property(e => e.COrder).HasColumnName("C_ORDER");

                entity.Property(e => e.CSotien)
                    .HasColumnName("C_SOTIEN")
                    .HasColumnType("numeric(19, 4)");
            });

            modelBuilder.Entity<TSysThuyetminhbctc11>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_THUYETMINHBCTC11");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CChitieu)
                    .HasColumnName("C_CHITIEU")
                    .HasMaxLength(200);

                entity.Property(e => e.CDvt)
                    .HasColumnName("C_DVT")
                    .HasMaxLength(100);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CLabelen)
                    .HasColumnName("C_LABELEN")
                    .HasMaxLength(200);

                entity.Property(e => e.CNamnay)
                    .HasColumnName("C_NAMNAY")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.CNamtruoc)
                    .HasColumnName("C_NAMTRUOC")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.COrder).HasColumnName("C_ORDER");
            });

            modelBuilder.Entity<TSysThuyetminhbctc12>(entity =>
            {
                entity.ToTable("T_SYS_THUYETMINHBCTC12");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CDvt)
                    .HasColumnName("C_DVT")
                    .HasMaxLength(50);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CGiaban)
                    .HasColumnName("C_GIABAN")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CGiavon)
                    .HasColumnName("C_GIAVON")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CLabelen)
                    .HasColumnName("C_LABELEN")
                    .HasMaxLength(200);

                entity.Property(e => e.CLailo1)
                    .HasColumnName("C_LAILO1")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CLailo2)
                    .HasColumnName("C_LAILO2")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CSanluong)
                    .HasColumnName("C_SANLUONG")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CTenvthh)
                    .HasColumnName("C_TENVTHH")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TSysThuyetminhbctc2>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_THUYETMINHBCTC2");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CKynay)
                    .HasColumnName("C_KYNAY")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.CLabelen)
                    .HasColumnName("C_LABELEN")
                    .HasMaxLength(200);

                entity.Property(e => e.CLuyketudaunam)
                    .HasColumnName("C_LUYKETUDAUNAM")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.COrder).HasColumnName("C_ORDER");

                entity.Property(e => e.CYeutochiphi)
                    .HasColumnName("C_YEUTOCHIPHI")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TSysThuyetminhbctc3>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_THUYETMINHBCTC3");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CChitieu)
                    .HasColumnName("C_CHITIEU")
                    .HasMaxLength(200);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CLabelen)
                    .HasColumnName("C_LABELEN")
                    .HasMaxLength(200);

                entity.Property(e => e.CMaso)
                    .HasColumnName("C_MASO")
                    .HasMaxLength(12);

                entity.Property(e => e.COrder).HasColumnName("C_ORDER");

                entity.Property(e => e.CSotien)
                    .HasColumnName("C_SOTIEN")
                    .HasColumnType("numeric(19, 4)");
            });

            modelBuilder.Entity<TSysThuyetminhbctc4>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_THUYETMINHBCTC4");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CCaylaunam)
                    .HasColumnName("C_CAYLAUNAM")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CChitieu)
                    .HasColumnName("C_CHITIEU")
                    .HasMaxLength(200);

                entity.Property(e => e.CDungcu)
                    .HasColumnName("C_DUNGCU")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CLabelen)
                    .HasColumnName("C_LABELEN")
                    .HasMaxLength(200);

                entity.Property(e => e.CMaymoc)
                    .HasColumnName("C_MAYMOC")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.CNhacua)
                    .HasColumnName("C_NHACUA")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.COrder).HasColumnName("C_ORDER");

                entity.Property(e => e.CPhuongtien)
                    .HasColumnName("C_PHUONGTIEN")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.CTong)
                    .HasColumnName("C_TONG")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.CTscdkhac)
                    .HasColumnName("C_TSCDKHAC")
                    .HasColumnType("numeric(19, 4)");
            });

            modelBuilder.Entity<TSysThuyetminhbctc5>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_THUYETMINHBCTC5");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CChitieu)
                    .HasColumnName("C_CHITIEU")
                    .HasMaxLength(200);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CLabelen)
                    .HasColumnName("C_LABELEN")
                    .HasMaxLength(200);

                entity.Property(e => e.COrder).HasColumnName("C_ORDER");

                entity.Property(e => e.CTong)
                    .HasColumnName("C_TONG")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.CTscdvohinh)
                    .HasColumnName("C_TSCDVOHINH")
                    .HasColumnType("numeric(19, 4)");
            });

            modelBuilder.Entity<TSysThuyetminhbctc6>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_THUYETMINHBCTC6");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CChitieu)
                    .HasColumnName("C_CHITIEU")
                    .HasMaxLength(200);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CKehoach)
                    .HasColumnName("C_KEHOACH")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.CKynay)
                    .HasColumnName("C_KYNAY")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.CKytruoc)
                    .HasColumnName("C_KYTRUOC")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.CLabelen)
                    .HasColumnName("C_LABELEN")
                    .HasMaxLength(200);

                entity.Property(e => e.COrder).HasColumnName("C_ORDER");
            });

            modelBuilder.Entity<TSysThuyetminhbctc7>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_THUYETMINHBCTC7");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CChitieu)
                    .HasColumnName("C_CHITIEU")
                    .HasMaxLength(200);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CGiam)
                    .HasColumnName("C_GIAM")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.CLabelen)
                    .HasColumnName("C_LABELEN")
                    .HasMaxLength(200);

                entity.Property(e => e.COrder).HasColumnName("C_ORDER");

                entity.Property(e => e.CSocuoi)
                    .HasColumnName("C_SOCUOI")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.CSodau)
                    .HasColumnName("C_SODAU")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.CTang)
                    .HasColumnName("C_TANG")
                    .HasColumnType("numeric(19, 4)");
            });

            modelBuilder.Entity<TSysThuyetminhbctc8>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_THUYETMINHBCTC8");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CChitieu)
                    .HasColumnName("C_CHITIEU")
                    .HasMaxLength(200);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CGiam)
                    .HasColumnName("C_GIAM")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.CKetqua)
                    .HasColumnName("C_KETQUA")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.CLabelen)
                    .HasColumnName("C_LABELEN")
                    .HasMaxLength(200);

                entity.Property(e => e.COrder).HasColumnName("C_ORDER");

                entity.Property(e => e.CSocuoi)
                    .HasColumnName("C_SOCUOI")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.CSodau)
                    .HasColumnName("C_SODAU")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.CTang)
                    .HasColumnName("C_TANG")
                    .HasColumnType("numeric(19, 4)");
            });

            modelBuilder.Entity<TSysThuyetminhbctc9>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_THUYETMINHBCTC9");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CChitieu)
                    .HasColumnName("C_CHITIEU")
                    .HasMaxLength(200);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CLabelen)
                    .HasColumnName("C_LABELEN")
                    .HasMaxLength(200);

                entity.Property(e => e.COrder).HasColumnName("C_ORDER");

                entity.Property(e => e.CQuahan1)
                    .HasColumnName("C_QUAHAN1")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.CQuahan2)
                    .HasColumnName("C_QUAHAN2")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.CTongso1)
                    .HasColumnName("C_TONGSO1")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.CTongso2)
                    .HasColumnName("C_TONGSO2")
                    .HasColumnType("numeric(19, 4)");

                entity.Property(e => e.CTongso3)
                    .HasColumnName("C_TONGSO3")
                    .HasColumnType("numeric(19, 4)");
            });

            modelBuilder.Entity<TSysTieuthucpb>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_SYS_TIEUTHUCPB");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CBangthaytheXntc)
                    .HasColumnName("C_BANGTHAYTHE_XNTC")
                    .HasMaxLength(500);

                entity.Property(e => e.CDk)
                    .HasColumnName("C_DK")
                    .HasMaxLength(1000);

                entity.Property(e => e.CDk2)
                    .HasColumnName("C_DK2")
                    .HasMaxLength(1000);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CGiatri)
                    .HasColumnName("C_GIATRI")
                    .HasMaxLength(255);

                entity.Property(e => e.CGiatriDinhmuc)
                    .HasColumnName("C_GIATRI_DINHMUC")
                    .HasMaxLength(4000);

                entity.Property(e => e.CTen)
                    .HasColumnName("C_TEN")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TSysTmbctc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_SYS_TMBCTC");

                entity.Property(e => e.CAm).HasColumnName("C_AM");

                entity.Property(e => e.CCachtinh).HasColumnName("C_CACHTINH");

                entity.Property(e => e.CChitieuen)
                    .HasColumnName("C_CHITIEUEN")
                    .HasMaxLength(300);

                entity.Property(e => e.CChitieuvn)
                    .HasColumnName("C_CHITIEUVN")
                    .HasMaxLength(300);

                entity.Property(e => e.CCongthuc)
                    .HasColumnName("C_CONGTHUC")
                    .HasMaxLength(300);

                entity.Property(e => e.CCtco).HasColumnName("C_CTCO");

                entity.Property(e => e.CCtno).HasColumnName("C_CTNO");

                entity.Property(e => e.CGiatri1)
                    .HasColumnName("C_GIATRI1")
                    .HasMaxLength(50);

                entity.Property(e => e.CGiatri10)
                    .HasColumnName("C_GIATRI10")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CGiatri2)
                    .HasColumnName("C_GIATRI2")
                    .HasMaxLength(50);

                entity.Property(e => e.CGiatri3)
                    .HasColumnName("C_GIATRI3")
                    .HasMaxLength(50);

                entity.Property(e => e.CGiatri4)
                    .HasColumnName("C_GIATRI4")
                    .HasMaxLength(50);

                entity.Property(e => e.CGiatri5)
                    .HasColumnName("C_GIATRI5")
                    .HasMaxLength(50);

                entity.Property(e => e.CGiatri6)
                    .HasColumnName("C_GIATRI6")
                    .HasMaxLength(50);

                entity.Property(e => e.CGiatri7)
                    .HasColumnName("C_GIATRI7")
                    .HasMaxLength(50);

                entity.Property(e => e.CGiatri8)
                    .HasColumnName("C_GIATRI8")
                    .HasMaxLength(50);

                entity.Property(e => e.CGiatri9)
                    .HasColumnName("C_GIATRI9")
                    .HasMaxLength(50);

                entity.Property(e => e.CIn).HasColumnName("C_IN");

                entity.Property(e => e.CIndam).HasColumnName("C_INDAM");

                entity.Property(e => e.CKodoiung).HasColumnName("C_KODOIUNG");

                entity.Property(e => e.CKy)
                    .HasColumnName("C_KY")
                    .HasMaxLength(10);

                entity.Property(e => e.CMaso)
                    .HasColumnName("C_MASO")
                    .HasMaxLength(50);

                entity.Property(e => e.CMuc)
                    .IsRequired()
                    .HasColumnName("C_MUC")
                    .HasMaxLength(20);

                entity.Property(e => e.CSql)
                    .HasColumnName("C_SQL")
                    .HasMaxLength(3000);

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.CSttsx)
                    .HasColumnName("C_STTSX")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CSttth)
                    .HasColumnName("C_STTTH")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CTkco)
                    .HasColumnName("C_TKCO")
                    .HasMaxLength(150);

                entity.Property(e => e.CTkno)
                    .HasColumnName("C_TKNO")
                    .HasMaxLength(150);

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TSysTmbctc48>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_SYS_TMBCTC48");

                entity.Property(e => e.CAm).HasColumnName("C_AM");

                entity.Property(e => e.CCachtinh).HasColumnName("C_CACHTINH");

                entity.Property(e => e.CChitieuen)
                    .HasColumnName("C_CHITIEUEN")
                    .HasMaxLength(300);

                entity.Property(e => e.CChitieuvn)
                    .HasColumnName("C_CHITIEUVN")
                    .HasMaxLength(300);

                entity.Property(e => e.CCongthuc)
                    .HasColumnName("C_CONGTHUC")
                    .HasMaxLength(300);

                entity.Property(e => e.CCtco).HasColumnName("C_CTCO");

                entity.Property(e => e.CCtno).HasColumnName("C_CTNO");

                entity.Property(e => e.CGiatri1)
                    .HasColumnName("C_GIATRI1")
                    .HasMaxLength(50);

                entity.Property(e => e.CGiatri10)
                    .HasColumnName("C_GIATRI10")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CGiatri2)
                    .HasColumnName("C_GIATRI2")
                    .HasMaxLength(50);

                entity.Property(e => e.CGiatri3)
                    .HasColumnName("C_GIATRI3")
                    .HasMaxLength(50);

                entity.Property(e => e.CGiatri4)
                    .HasColumnName("C_GIATRI4")
                    .HasMaxLength(50);

                entity.Property(e => e.CGiatri5)
                    .HasColumnName("C_GIATRI5")
                    .HasMaxLength(50);

                entity.Property(e => e.CGiatri6)
                    .HasColumnName("C_GIATRI6")
                    .HasMaxLength(50);

                entity.Property(e => e.CGiatri7)
                    .HasColumnName("C_GIATRI7")
                    .HasMaxLength(50);

                entity.Property(e => e.CGiatri8)
                    .HasColumnName("C_GIATRI8")
                    .HasMaxLength(50);

                entity.Property(e => e.CGiatri9)
                    .HasColumnName("C_GIATRI9")
                    .HasMaxLength(50);

                entity.Property(e => e.CIn).HasColumnName("C_IN");

                entity.Property(e => e.CIndam).HasColumnName("C_INDAM");

                entity.Property(e => e.CKodoiung).HasColumnName("C_KODOIUNG");

                entity.Property(e => e.CKy)
                    .HasColumnName("C_KY")
                    .HasMaxLength(10);

                entity.Property(e => e.CMaso)
                    .HasColumnName("C_MASO")
                    .HasMaxLength(50);

                entity.Property(e => e.CMuc)
                    .IsRequired()
                    .HasColumnName("C_MUC")
                    .HasMaxLength(20);

                entity.Property(e => e.CSql)
                    .HasColumnName("C_SQL")
                    .HasMaxLength(3000);

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.CSttsx)
                    .HasColumnName("C_STTSX")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CSttth)
                    .HasColumnName("C_STTTH")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CTkco)
                    .HasColumnName("C_TKCO")
                    .HasMaxLength(150);

                entity.Property(e => e.CTkno)
                    .HasColumnName("C_TKNO")
                    .HasMaxLength(150);

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TSysUserconnecting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_SYS_USERCONNECTING");

                entity.Property(e => e.CComputername)
                    .HasColumnName("C_COMPUTERNAME")
                    .HasMaxLength(30);

                entity.Property(e => e.CDisconnect).HasColumnName("C_DISCONNECT");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CIpaddress)
                    .HasColumnName("C_IPADDRESS")
                    .HasMaxLength(30);

                entity.Property(e => e.CLogintime)
                    .HasColumnName("C_LOGINTIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CLogouttime).HasColumnName("C_LOGOUTTIME");

                entity.Property(e => e.CMessage)
                    .HasColumnName("C_MESSAGE")
                    .HasMaxLength(100);

                entity.Property(e => e.CUsername)
                    .HasColumnName("C_USERNAME")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TSysUserlog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_SYS_USERLOG");

                entity.Property(e => e.CComputername)
                    .HasColumnName("C_COMPUTERNAME")
                    .HasMaxLength(30);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CIpaddress)
                    .HasColumnName("C_IPADDRESS")
                    .HasMaxLength(30);

                entity.Property(e => e.CLogintime)
                    .HasColumnName("C_LOGINTIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CLogouttime)
                    .HasColumnName("C_LOGOUTTIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CUsername)
                    .HasColumnName("C_USERNAME")
                    .HasMaxLength(30);

                entity.Property(e => e.CVersion)
                    .HasColumnName("C_VERSION")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TSysView>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_SYS_VIEW");

                entity.Property(e => e.CViewid).HasColumnName("C_VIEWID");
            });

            modelBuilder.Entity<TTgkiemtra>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_TGKIEMTRA");

                entity.HasIndex(e => new { e.FkPhanxuong, e.FkVthh })
                    .HasName("IX_T_TGKIEMTRA")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CLoai).HasColumnName("C_LOAI");

                entity.Property(e => e.CThoigian).HasColumnName("C_THOIGIAN");

                entity.Property(e => e.CTile).HasColumnName("C_TILE");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<TTsht>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_TSHT");

                entity.Property(e => e.CCl)
                    .HasColumnName("C_CL")
                    .HasMaxLength(2000);

                entity.Property(e => e.CClgtkh).HasColumnName("C_CLGTKH");

                entity.Property(e => e.CCnngaybao)
                    .HasColumnName("C_CNNGAYBAO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CCntudong).HasColumnName("C_CNTUDONG");

                entity.Property(e => e.CCopyreport)
                    .HasColumnName("C_COPYREPORT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CCs)
                    .HasColumnName("C_CS")
                    .HasMaxLength(50);

                entity.Property(e => e.CCt)
                    .HasColumnName("C_CT")
                    .HasMaxLength(200);

                entity.Property(e => e.CCtgtnt)
                    .HasColumnName("C_CTGTNT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CCtkhts).HasColumnName("C_CTKHTS");

                entity.Property(e => e.CDiachi)
                    .HasColumnName("C_DIACHI")
                    .HasMaxLength(200);

                entity.Property(e => e.CDienthoai)
                    .HasColumnName("C_DIENTHOAI")
                    .HasMaxLength(15);

                entity.Property(e => e.CDinhmucPath)
                    .HasColumnName("C_DINHMUC_PATH")
                    .HasMaxLength(300);

                entity.Property(e => e.CDisplayname)
                    .HasColumnName("C_DISPLAYNAME")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CDochinhxac).HasColumnName("C_DOCHINHXAC");

                entity.Property(e => e.CDochinhxac2).HasColumnName("C_DOCHINHXAC2");

                entity.Property(e => e.CDvcsso).HasColumnName("C_DVCSSO");

                entity.Property(e => e.CEffectid).HasColumnName("C_EFFECTID");

                entity.Property(e => e.CFax)
                    .HasColumnName("C_FAX")
                    .HasMaxLength(15);

                entity.Property(e => e.CHailoaitien).HasColumnName("C_HAILOAITIEN");

                entity.Property(e => e.CHangnghin)
                    .HasColumnName("C_HANGNGHIN")
                    .HasMaxLength(3);

                entity.Property(e => e.CHangnghin2)
                    .HasColumnName("C_HANGNGHIN2")
                    .HasMaxLength(3);

                entity.Property(e => e.CHeadcompany)
                    .HasColumnName("C_HEADCOMPANY")
                    .HasMaxLength(200);

                entity.Property(e => e.CHoadontuin).HasColumnName("C_HOADONTUIN");

                entity.Property(e => e.CHtgs).HasColumnName("C_HTGS");

                entity.Property(e => e.CIncreasefontsize)
                    .HasColumnName("C_INCREASEFONTSIZE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CKhauhaotscd)
                    .HasColumnName("C_KHAUHAOTSCD")
                    .HasMaxLength(50);

                entity.Property(e => e.CKtcn)
                    .HasColumnName("C_KTCN")
                    .HasMaxLength(100);

                entity.Property(e => e.CKtt)
                    .HasColumnName("C_KTT")
                    .HasMaxLength(100);

                entity.Property(e => e.CLastlockdate)
                    .HasColumnName("C_LASTLOCKDATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CLct).HasColumnName("C_LCT");

                entity.Property(e => e.CLockdate).HasColumnName("C_LOCKDATE");

                entity.Property(e => e.CLogo)
                    .HasColumnName("C_LOGO")
                    .HasColumnType("image");

                entity.Property(e => e.CMactChiphi)
                    .HasColumnName("C_MACT_CHIPHI")
                    .HasMaxLength(12);

                entity.Property(e => e.CMactKhauhao)
                    .HasColumnName("C_MACT_KHAUHAO")
                    .HasMaxLength(12);

                entity.Property(e => e.CMactKho)
                    .HasColumnName("C_MACT_KHO")
                    .HasMaxLength(20);

                entity.Property(e => e.CMaster).HasColumnName("C_MASTER");

                entity.Property(e => e.CMavach).HasColumnName("C_MAVACH");

                entity.Property(e => e.CMixedfont).HasColumnName("C_MIXEDFONT");

                entity.Property(e => e.CMst)
                    .HasColumnName("C_MST")
                    .HasMaxLength(30);

                entity.Property(e => e.CNgonngu).HasColumnName("C_NGONNGU");

                entity.Property(e => e.CNguyengiatscd)
                    .HasColumnName("C_NGUYENGIATSCD")
                    .HasMaxLength(50);

                entity.Property(e => e.CNotifitime).HasColumnName("C_NOTIFITIME");

                entity.Property(e => e.CPptltg).HasColumnName("C_PPTLTG");

                entity.Property(e => e.CPricelist).HasColumnName("C_PRICELIST");

                entity.Property(e => e.CPrintSignDate).HasColumnName("C_PrintSignDate");

                entity.Property(e => e.CReportLockedData).HasColumnName("C_ReportLockedData");

                entity.Property(e => e.CReseeded).HasColumnName("C_RESEEDED");

                entity.Property(e => e.CSeparator)
                    .HasColumnName("C_SEPARATOR")
                    .HasMaxLength(3);

                entity.Property(e => e.CTen)
                    .HasColumnName("C_TEN")
                    .HasMaxLength(200);

                entity.Property(e => e.CThapphan)
                    .HasColumnName("C_THAPPHAN")
                    .HasMaxLength(3);

                entity.Property(e => e.CThapphan2)
                    .HasColumnName("C_THAPPHAN2")
                    .HasMaxLength(3);

                entity.Property(e => e.CTheonam).HasColumnName("C_THEONAM");

                entity.Property(e => e.CTheonam2)
                    .HasColumnName("C_THEONAM2")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CTheothang).HasColumnName("C_THEOTHANG");

                entity.Property(e => e.CTheothang2)
                    .HasColumnName("C_THEOTHANG2")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CTigiahachtoan).HasColumnName("C_TIGIAHACHTOAN");

                entity.Property(e => e.CTk154)
                    .HasColumnName("C_TK154")
                    .HasMaxLength(50);

                entity.Property(e => e.CTk155)
                    .HasColumnName("C_TK155")
                    .HasMaxLength(50);

                entity.Property(e => e.CTk413)
                    .HasColumnName("C_TK413")
                    .HasMaxLength(12);

                entity.Property(e => e.CTk911)
                    .HasColumnName("C_TK911")
                    .HasMaxLength(50);

                entity.Property(e => e.CTkcpbh)
                    .HasColumnName("C_TKCPBH")
                    .HasMaxLength(50);

                entity.Property(e => e.CTkgvbqgq)
                    .HasColumnName("C_TKGVBQGQ")
                    .HasMaxLength(50);

                entity.Property(e => e.CTkgvbqgqdm).HasColumnName("C_TKGVBQGQDM");

                entity.Property(e => e.CTkgvbqtc)
                    .HasColumnName("C_TKGVBQTC")
                    .HasMaxLength(50);

                entity.Property(e => e.CTkgvbqtcdm).HasColumnName("C_TKGVBQTCDM");

                entity.Property(e => e.CTkgvhb)
                    .HasColumnName("C_TKGVHB")
                    .HasMaxLength(50);

                entity.Property(e => e.CTkgvntxt)
                    .HasColumnName("C_TKGVNTXT")
                    .HasMaxLength(50);

                entity.Property(e => e.CTkgvntxtdm).HasColumnName("C_TKGVNTXTDM");

                entity.Property(e => e.CTkkcsd)
                    .HasColumnName("C_TKKCSD")
                    .HasMaxLength(50);

                entity.Property(e => e.CTkkmnvl)
                    .HasColumnName("C_TKKMNVL")
                    .HasMaxLength(50);

                entity.Property(e => e.CTkkqkd)
                    .HasColumnName("C_TKKQKD")
                    .HasMaxLength(50);

                entity.Property(e => e.CTkkt)
                    .HasColumnName("C_TKKT")
                    .HasMaxLength(255);

                entity.Property(e => e.CTknt)
                    .HasColumnName("C_TKNT")
                    .HasMaxLength(200);

                entity.Property(e => e.CTktgco)
                    .HasColumnName("C_TKTGCO")
                    .HasMaxLength(50);

                entity.Property(e => e.CTktgno)
                    .HasColumnName("C_TKTGNO")
                    .HasMaxLength(50);

                entity.Property(e => e.CTktienmat)
                    .HasColumnName("C_TKTIENMAT")
                    .HasMaxLength(50);

                entity.Property(e => e.CTkvnd)
                    .HasColumnName("C_TKVND")
                    .HasMaxLength(200);

                entity.Property(e => e.CTop)
                    .HasColumnName("C_TOP")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CVersion)
                    .HasColumnName("C_VERSION")
                    .HasMaxLength(10);

                entity.Property(e => e.CVietdate).HasColumnName("C_VIETDATE");

                entity.Property(e => e.CYearlen)
                    .HasColumnName("C_YEARLEN")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FkMdtgd).HasColumnName("FK_MDTGD");

                entity.Property(e => e.FkMdtht).HasColumnName("FK_MDTHT");
            });

            modelBuilder.Entity<TTurTourchiphi>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_TUR_TOURCHIPHI");

                entity.HasIndex(e => new { e.FkTour, e.FkYeucau, e.FkKmp })
                    .HasName("IX_T_TUR_TOURCHIPHI")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDongia)
                    .HasColumnName("C_DONGIA")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CDongiausd)
                    .HasColumnName("C_DONGIAUSD")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(50);

                entity.Property(e => e.CNgayct)
                    .HasColumnName("C_NGAYCT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CPsno)
                    .HasColumnName("C_PSNO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CPsno2)
                    .HasColumnName("C_PSNO2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CSoct)
                    .HasColumnName("C_SOCT")
                    .HasMaxLength(25);

                entity.Property(e => e.CSohdgtgt)
                    .HasColumnName("C_SOHDGTGT")
                    .HasMaxLength(25);

                entity.Property(e => e.CTienthue)
                    .HasColumnName("C_TIENTHUE")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CTienthueusd)
                    .HasColumnName("C_TIENTHUEUSD")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CTygia)
                    .HasColumnName("C_TYGIA")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CVat)
                    .HasColumnName("C_VAT")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FkKhachhang).HasColumnName("FK_KHACHHANG");

                entity.Property(e => e.FkKmp).HasColumnName("FK_KMP");

                entity.Property(e => e.FkLoaitien).HasColumnName("FK_LOAITIEN");

                entity.Property(e => e.FkTour).HasColumnName("FK_TOUR");

                entity.Property(e => e.FkYeucau).HasColumnName("FK_YEUCAU");
            });

            modelBuilder.Entity<TTurYeucauChiphikhac>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_TUR_YEUCAU_CHIPHIKHAC");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(50);

                entity.Property(e => e.CPsno)
                    .HasColumnName("C_PSNO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CPsno2)
                    .HasColumnName("C_PSNO2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FkKmp).HasColumnName("FK_KMP");

                entity.Property(e => e.FkYeucau).HasColumnName("FK_YEUCAU");
            });

            modelBuilder.Entity<TUserMessageStatus>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_USER_MESSAGE_STATUS");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CAlertText)
                    .HasColumnName("C_ALERT_TEXT")
                    .HasMaxLength(1000);

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CDeletedAlert).HasColumnName("C_DELETED_ALERT");

                entity.Property(e => e.CDeletedNotif).HasColumnName("C_DELETED_NOTIF");

                entity.Property(e => e.CNewAlert).HasColumnName("C_NEW_ALERT");

                entity.Property(e => e.CNewNotif).HasColumnName("C_NEW_NOTIF");

                entity.Property(e => e.COldAlert).HasColumnName("C_OLD_ALERT");

                entity.Property(e => e.COldNotif).HasColumnName("C_OLD_NOTIF");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");
            });

            modelBuilder.Entity<TWcfnrelation>(entity =>
            {
                entity.HasKey(e => new { e.FkPhanxuong, e.FkChucnang });

                entity.ToTable("T_WCFNRELATION");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");

                entity.Property(e => e.FkChucnang).HasColumnName("FK_CHUCNANG");
            });

            modelBuilder.Entity<TXntc>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_XNTC");

                entity.HasIndex(e => e.CDgdong)
                    .HasName("IX_T_XNTC_10");

                entity.HasIndex(e => e.CDiengiai)
                    .HasName("IX_T_XNTC_9");

                entity.HasIndex(e => e.CNgayct)
                    .HasName("IX_T_XNTC_4");

                entity.HasIndex(e => e.CNgaylap)
                    .HasName("IX_T_XNTC_3");

                entity.HasIndex(e => e.CSoct)
                    .HasName("IX_T_XNTC_5");

                entity.HasIndex(e => e.CSophieu)
                    .HasName("IX_T_XNTC");

                entity.HasIndex(e => e.FkDvcs)
                    .HasName("IX_T_XNTC_1");

                entity.HasIndex(e => e.FkDvt)
                    .HasName("IX_T_XNTC_14");

                entity.HasIndex(e => e.FkKhachhang)
                    .HasName("IX_T_XNTC_6");

                entity.HasIndex(e => e.FkKhonhap)
                    .HasName("IX_T_XNTC_12");

                entity.HasIndex(e => e.FkKhoxuat)
                    .HasName("IX_T_XNTC_11");

                entity.HasIndex(e => e.FkTkco)
                    .HasName("IX_T_XNTC_8");

                entity.HasIndex(e => e.FkTkno)
                    .HasName("IX_T_XNTC_7");

                entity.HasIndex(e => e.FkVthh)
                    .HasName("IX_T_XNTC_13");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .HasColumnType("numeric(19, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CBillOflading)
                    .HasColumnName("C_BIllOFLADING")
                    .HasMaxLength(30);

                entity.Property(e => e.CBookingnote)
                    .HasColumnName("C_BOOKINGNOTE")
                    .HasMaxLength(30);

                entity.Property(e => e.CButtoanthem).HasColumnName("C_BUTTOANTHEM");

                entity.Property(e => e.CChatluong).HasColumnName("C_CHATLUONG");

                entity.Property(e => e.CChietkhau)
                    .HasColumnName("C_CHIETKHAU")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CCif)
                    .HasColumnName("C_CIF")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CCif2)
                    .HasColumnName("C_CIF2")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CCkTienmat)
                    .HasColumnName("C_CK_TIENMAT")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CCopy).HasColumnName("C_COPY");

                entity.Property(e => e.CCpbanhang).HasColumnName("C_CPBANHANG");

                entity.Property(e => e.CCpsx).HasColumnName("C_CPSX");

                entity.Property(e => e.CDain).HasColumnName("C_DAIN");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CDgdong)
                    .HasColumnName("C_DGDONG")
                    .HasMaxLength(300);

                entity.Property(e => e.CDiengiai)
                    .HasColumnName("C_DIENGIAI")
                    .HasMaxLength(300);

                entity.Property(e => e.CDiengiai2)
                    .HasColumnName("C_DIENGIAI2")
                    .HasMaxLength(300);

                entity.Property(e => e.CDongia)
                    .HasColumnName("C_DONGIA")
                    .HasColumnType("money");

                entity.Property(e => e.CDongiatc)
                    .HasColumnName("C_DONGIATC")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CEta)
                    .HasColumnName("C_ETA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CExtraentry).HasColumnName("C_EXTRAENTRY");

                entity.Property(e => e.CF)
                    .HasColumnName("C_F")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CField1)
                    .HasColumnName("C_FIELD1")
                    .HasMaxLength(12);

                entity.Property(e => e.CField2)
                    .HasColumnName("C_FIELD2")
                    .HasMaxLength(12);

                entity.Property(e => e.CFob)
                    .HasColumnName("C_FOB")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CGttruocthue)
                    .HasColumnName("C_GTTRUOCTHUE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CGttruocthue2)
                    .HasColumnName("C_GTTRUOCTHUE2")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CHansudung)
                    .HasColumnName("C_HANSUDUNG")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CHantt).HasColumnName("C_HANTT");

                entity.Property(e => e.CHantt2)
                    .HasColumnName("C_HANTT2")
                    .HasColumnType("datetime");

                entity.Property(e => e.CHetSl).HasColumnName("C_HET_SL");

                entity.Property(e => e.CHoadon).HasColumnName("C_HOADON");

                entity.Property(e => e.CI)
                    .HasColumnName("C_I")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CImportData).HasColumnName("C_ImportData");

                entity.Property(e => e.CImportXuat).HasColumnName("C_IMPORT_XUAT");

                entity.Property(e => e.CKhdiachi)
                    .HasColumnName("C_KHDIACHI")
                    .HasMaxLength(50);

                entity.Property(e => e.CKhthue)
                    .HasColumnName("C_KHTHUE")
                    .HasMaxLength(100);

                entity.Property(e => e.CKhuco)
                    .HasColumnName("C_KHUCO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CKhuno)
                    .HasColumnName("C_KHUNO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CKm)
                    .HasColumnName("C_KM")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CKyhieumau)
                    .HasColumnName("C_KYHIEUMAU")
                    .HasMaxLength(30);

                entity.Property(e => e.CLaphd).HasColumnName("C_LAPHD");

                entity.Property(e => e.CLastexport)
                    .HasColumnName("C_LASTEXPORT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CLoaibt).HasColumnName("C_LOAIBT");

                entity.Property(e => e.CLoaict).HasColumnName("C_LOAICT");

                entity.Property(e => e.CLoaixn).HasColumnName("C_LOAIXN");

                entity.Property(e => e.CMahoadon)
                    .HasColumnName("C_MAHOADON")
                    .HasMaxLength(30);

                entity.Property(e => e.CMathang)
                    .HasColumnName("C_MATHANG")
                    .HasMaxLength(200);

                entity.Property(e => e.CMauso)
                    .HasColumnName("C_MAUSO")
                    .HasMaxLength(20);

                entity.Property(e => e.CMrb).HasColumnName("C_MRB");

                entity.Property(e => e.CMst)
                    .HasColumnName("C_MST")
                    .HasMaxLength(20);

                entity.Property(e => e.CNgayct)
                    .HasColumnName("C_NGAYCT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNguoilh)
                    .HasColumnName("C_NGUOILH")
                    .HasMaxLength(255);

                entity.Property(e => e.CNguoivanchuyen)
                    .HasColumnName("C_NGUOIVANCHUYEN")
                    .HasMaxLength(70);

                entity.Property(e => e.CNguyengia)
                    .HasColumnName("C_NGUYENGIA")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CNote)
                    .HasColumnName("C_NOTE")
                    .HasMaxLength(1000);

                entity.Property(e => e.CPod)
                    .HasColumnName("C_POD")
                    .HasMaxLength(50);

                entity.Property(e => e.CPodelivery)
                    .HasColumnName("C_PODelivery")
                    .HasMaxLength(50);

                entity.Property(e => e.CPol)
                    .HasColumnName("C_POL")
                    .HasMaxLength(50);

                entity.Property(e => e.CPoreceive)
                    .HasColumnName("C_POReceive")
                    .HasMaxLength(50);

                entity.Property(e => e.CPosted).HasColumnName("C_POSTED");

                entity.Property(e => e.CPoster).HasColumnName("C_POSTER");

                entity.Property(e => e.CPromo).HasColumnName("C_PROMO");

                entity.Property(e => e.CPsco)
                    .HasColumnName("C_PSCO")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CPsco2)
                    .HasColumnName("C_PSCO2")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CPsno)
                    .HasColumnName("C_PSNO")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CPsno2)
                    .HasColumnName("C_PSNO2")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CSlkiemtra)
                    .HasColumnName("C_SLKIEMTRA")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CSlthung)
                    .HasColumnName("C_SLTHUNG")
                    .HasColumnType("decimal(19, 3)");

                entity.Property(e => e.CSoct)
                    .HasColumnName("C_SOCT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CSohdgtgt)
                    .HasColumnName("C_SOHDGTGT")
                    .HasMaxLength(10);

                entity.Property(e => e.CSolo)
                    .HasColumnName("C_SOLO")
                    .HasMaxLength(30);

                entity.Property(e => e.CSoluong).HasColumnName("C_SOLUONG");

                entity.Property(e => e.CSoluongxuat)
                    .HasColumnName("C_SOLUONGXUAT")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CSophieu)
                    .IsRequired()
                    .HasColumnName("C_SOPHIEU")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.CSophieucu)
                    .HasColumnName("C_SOPHIEUCU")
                    .HasMaxLength(120);

                entity.Property(e => e.CSophieutralai)
                    .HasColumnName("C_SOPHIEUTRALAI")
                    .HasMaxLength(20);

                entity.Property(e => e.CSotknh)
                    .HasColumnName("C_SOTKNH")
                    .HasMaxLength(251);

                entity.Property(e => e.CSoxe)
                    .HasColumnName("C_SOXE")
                    .HasMaxLength(30);

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.CThanhtoan)
                    .HasColumnName("C_THANHTOAN")
                    .HasMaxLength(1000);

                entity.Property(e => e.CTheobo)
                    .HasColumnName("C_THEOBO")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CThuenk)
                    .HasColumnName("C_THUENK")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTienhang)
                    .HasColumnName("C_TIENHANG")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTienhangvanchuyen)
                    .HasColumnName("C_TIENHANGVANCHUYEN")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CTienthue)
                    .HasColumnName("C_TIENTHUE")
                    .HasColumnType("money");

                entity.Property(e => e.CTienthue2)
                    .HasColumnName("C_TIENTHUE2")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CTigia).HasColumnName("C_TIGIA");

                entity.Property(e => e.CTk)
                    .HasColumnName("C_TK")
                    .HasMaxLength(20);

                entity.Property(e => e.CTmpdichdanh)
                    .HasColumnName("C_TMPDICHDANH")
                    .HasMaxLength(20);

                entity.Property(e => e.CTrong).HasColumnName("C_TRONG");

                entity.Property(e => e.CUpdate).HasColumnName("C_UPDATE");

                entity.Property(e => e.CVat).HasColumnName("C_VAT");

                entity.Property(e => e.CVessel)
                    .HasColumnName("C_VESSEL")
                    .HasMaxLength(30);

                entity.Property(e => e.CVoyage)
                    .HasColumnName("C_VOYAGE")
                    .HasMaxLength(30);

                entity.Property(e => e.FkBillOflading).HasColumnName("FK_BIllOFLADING");

                entity.Property(e => e.FkBookingnote).HasColumnName("FK_BOOKINGNOTE");

                entity.Property(e => e.FkCa).HasColumnName("FK_CA");

                entity.Property(e => e.FkChucnang).HasColumnName("FK_CHUCNANG");

                entity.Property(e => e.FkChungtu).HasColumnName("FK_CHUNGTU");

                entity.Property(e => e.FkCostCenter).HasColumnName("FK_CostCenter");

                entity.Property(e => e.FkCuocvanchuyen).HasColumnName("FK_CUOCVANCHUYEN");

                entity.Property(e => e.FkDondathang).HasColumnName("FK_DONDATHANG");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkDtcpLuu).HasColumnName("FK_DTCP_LUU");

                entity.Property(e => e.FkDtcpco).HasColumnName("FK_DTCPCO");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkDvt).HasColumnName("FK_DVT");

                entity.Property(e => e.FkHangvanchuyen).HasColumnName("FK_HANGVANCHUYEN");

                entity.Property(e => e.FkKenhap).HasColumnName("FK_KENHAP");

                entity.Property(e => e.FkKetoan).HasColumnName("FK_KETOAN");

                entity.Property(e => e.FkKetoan02).HasColumnName("FK_KETOAN02");

                entity.Property(e => e.FkKexuat).HasColumnName("FK_KEXUAT");

                entity.Property(e => e.FkKhachhang).HasColumnName("FK_KHACHHANG");

                entity.Property(e => e.FkKhachhangco).HasColumnName("FK_KHACHHANGCO");

                entity.Property(e => e.FkKhonhap).HasColumnName("FK_KHONHAP");

                entity.Property(e => e.FkKhoxuat).HasColumnName("FK_KHOXUAT");

                entity.Property(e => e.FkKmp).HasColumnName("FK_KMP");

                entity.Property(e => e.FkKmpc).HasColumnName("FK_KMPC");

                entity.Property(e => e.FkKttruong).HasColumnName("FK_KTTRUONG");

                entity.Property(e => e.FkKttruong02).HasColumnName("FK_KTTRUONG02");

                entity.Property(e => e.FkLdhh).HasColumnName("FK_LDHH");

                entity.Property(e => e.FkLdtg).HasColumnName("FK_LDTG");

                entity.Property(e => e.FkLoaidl)
                    .HasColumnName("FK_LOAIDL")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.FkLoaitien).HasColumnName("FK_LOAITIEN");

                entity.Property(e => e.FkLsx).HasColumnName("FK_LSX");

                entity.Property(e => e.FkLsxct).HasColumnName("FK_LSXCT");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkNguoigiao).HasColumnName("FK_NGUOIGIAO");

                entity.Property(e => e.FkNguoigiao02).HasColumnName("FK_NGUOIGIAO02");

                entity.Property(e => e.FkNguoilap).HasColumnName("FK_NGUOILAP");

                entity.Property(e => e.FkNguoilap02).HasColumnName("FK_NGUOILAP02");

                entity.Property(e => e.FkNguoilh).HasColumnName("FK_NGUOILH");

                entity.Property(e => e.FkNguonvon).HasColumnName("FK_NGUONVON");

                entity.Property(e => e.FkNhomKc).HasColumnName("FK_NHOM_KC");

                entity.Property(e => e.FkNvkd).HasColumnName("FK_NVKD");

                entity.Property(e => e.FkOrder).HasColumnName("FK_ORDER");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");

                entity.Property(e => e.FkPttt).HasColumnName("FK_PTTT");

                entity.Property(e => e.FkQlxDenghixuat).HasColumnName("FK_QLX_DENGHIXUAT");

                entity.Property(e => e.FkQuicach).HasColumnName("FK_QUICACH");

                entity.Property(e => e.FkSochuyen).HasColumnName("FK_SOCHUYEN");

                entity.Property(e => e.FkSoxe).HasColumnName("FK_SOXE");

                entity.Property(e => e.FkThukho).HasColumnName("FK_THUKHO");

                entity.Property(e => e.FkThukho02).HasColumnName("FK_THUKHO02");

                entity.Property(e => e.FkThuquy).HasColumnName("FK_THUQUY");

                entity.Property(e => e.FkThuquy02).HasColumnName("FK_THUQUY02");

                entity.Property(e => e.FkThutruong).HasColumnName("FK_THUTRUONG");

                entity.Property(e => e.FkThutruong02).HasColumnName("FK_THUTRUONG02");

                entity.Property(e => e.FkTkco)
                    .HasColumnName("FK_TKCO")
                    .HasMaxLength(12);

                entity.Property(e => e.FkTkno)
                    .HasColumnName("FK_TKNO")
                    .HasMaxLength(12);

                entity.Property(e => e.FkTotruong).HasColumnName("FK_TOTRUONG");

                entity.Property(e => e.FkTour).HasColumnName("FK_TOUR");

                entity.Property(e => e.FkTruso).HasColumnName("FK_TRUSO");

                entity.Property(e => e.FkTscd).HasColumnName("FK_TSCD");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVitri).HasColumnName("FK_VITRI");

                entity.Property(e => e.FkVoyage).HasColumnName("FK_VOYAGE");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.FkVthhLuu).HasColumnName("FK_VTHH_LUU");

                entity.Property(e => e.FkVuviec).HasColumnName("FK_VUVIEC");
            });

            modelBuilder.Entity<TXntcDtcp>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_XNTC_DTCP");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CPsno)
                    .HasColumnName("C_PSNO")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CSoluong)
                    .HasColumnName("C_SOLUONG")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CTk)
                    .HasColumnName("C_TK")
                    .HasMaxLength(20);

                entity.Property(e => e.CUpdatedate)
                    .HasColumnName("C_UPDATEDATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<TXntcSerial>(entity =>
            {
                entity.HasKey(e => e.CSerial);

                entity.ToTable("T_XNTC_SERIAL");

                entity.Property(e => e.CSerial)
                    .HasColumnName("C_SERIAL")
                    .HasMaxLength(30);

                entity.Property(e => e.CSerial2)
                    .HasColumnName("C_SERIAL2")
                    .HasMaxLength(100);

                entity.Property(e => e.CSerial3)
                    .HasColumnName("C_SERIAL3")
                    .HasMaxLength(100);

                entity.Property(e => e.FkNhap).HasColumnName("FK_NHAP");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.FkXuat).HasColumnName("FK_XUAT");
            });

            modelBuilder.Entity<TXntcVthh>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_XNTC_VTHH");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<TXntcVuviec>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_XNTC_VUVIEC");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.FkVuviec).HasColumnName("FK_VUVIEC");
            });

            modelBuilder.Entity<TXntcdichdanh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_XNTCDICHDANH");

                entity.Property(e => e.CDongia)
                    .HasColumnName("C_DONGIA")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.CPhieunhap)
                    .HasColumnName("C_PHIEUNHAP")
                    .HasMaxLength(20);

                entity.Property(e => e.CSoluong).HasColumnName("C_SOLUONG");

                entity.Property(e => e.FkNhap).HasColumnName("FK_NHAP");

                entity.Property(e => e.FkOrderxuat).HasColumnName("FK_ORDERXUAT");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.FkXuat).HasColumnName("FK_XUAT");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TXntclichtt>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_XNTCLICHTT");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CDatt)
                    .HasColumnName("C_DATT")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(150);

                entity.Property(e => e.CGhichu02)
                    .HasColumnName("C_GHICHU02")
                    .HasMaxLength(150);

                entity.Property(e => e.CNgay)
                    .HasColumnName("C_NGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CNhacno)
                    .HasColumnName("C_NHACNO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CPsno)
                    .HasColumnName("C_PSNO")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.CPsno2)
                    .HasColumnName("C_PSNO2")
                    .HasColumnType("numeric(18, 3)");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.FkOrder).HasColumnName("FK_ORDER");
            });

            modelBuilder.Entity<TXntcorder>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("T_XNTCORDER");

                entity.HasIndex(e => new { e.CSophieu, e.FkDvcs, e.PkId })
                    .HasName("IX_T_XNTCORDER")
                    .IsUnique();

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.CSophieu)
                    .IsRequired()
                    .HasColumnName("C_SOPHIEU")
                    .HasMaxLength(14);

                entity.Property(e => e.CTtkhuyenmai)
                    .HasColumnName("C_TTKHUYENMAI")
                    .HasMaxLength(200);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkOrder).HasColumnName("FK_ORDER");
            });

            modelBuilder.Entity<TYeucaumuahang>(entity =>
            {
                entity.HasKey(e => new { e.CSophieu, e.FkDvcs });

                entity.ToTable("T_YEUCAUMUAHANG");

                entity.Property(e => e.CSophieu)
                    .HasColumnName("C_SOPHIEU")
                    .HasMaxLength(12);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CDiengiai)
                    .HasColumnName("C_DIENGIAI")
                    .HasMaxLength(255);

                entity.Property(e => e.CKhdk)
                    .HasColumnName("C_KHDK")
                    .HasMaxLength(100);

                entity.Property(e => e.CKhdkdc)
                    .HasColumnName("C_KHDKDC")
                    .HasMaxLength(100);

                entity.Property(e => e.CKhdkdt)
                    .HasColumnName("C_KHDKDT")
                    .HasMaxLength(20);

                entity.Property(e => e.CKhdkemail)
                    .HasColumnName("C_KHDKEMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.CKhdkfax)
                    .HasColumnName("C_KHDKFAX")
                    .HasMaxLength(20);

                entity.Property(e => e.CKhdknlh)
                    .HasColumnName("C_KHDKNLH")
                    .HasMaxLength(40);

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.CTigia)
                    .HasColumnName("C_TIGIA")
                    .HasColumnType("money");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkKhachhang).HasColumnName("FK_KHACHHANG");

                entity.Property(e => e.FkKmp).HasColumnName("FK_KMP");

                entity.Property(e => e.FkLoaitien).HasColumnName("FK_LOAITIEN");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkNguoilh).HasColumnName("FK_NGUOILH");

                entity.Property(e => e.FkNguoimh).HasColumnName("FK_NGUOIMH");

                entity.Property(e => e.FkNguoiyc).HasColumnName("FK_NGUOIYC");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVuviec).HasColumnName("FK_VUVIEC");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TYeucaumuahangct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_YEUCAUMUAHANGCT");

                entity.Property(e => e.CDongia)
                    .HasColumnName("C_DONGIA")
                    .HasColumnType("money");

                entity.Property(e => e.CNgaynhan)
                    .HasColumnName("C_NGAYNHAN")
                    .HasColumnType("datetime");

                entity.Property(e => e.CPheduyet)
                    .IsRequired()
                    .HasColumnName("C_PHEDUYET")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CSoluong).HasColumnName("C_SOLUONG");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.FkDvmua).HasColumnName("FK_DVMUA");

                entity.Property(e => e.FkNguoipd).HasColumnName("FK_NGUOIPD");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.FkYeucaumuahang).HasColumnName("FK_YEUCAUMUAHANG");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CMa)
                    .HasColumnName("C_MA")
                    .HasMaxLength(255);

                entity.Property(e => e.CTen)
                    .HasColumnName("C_TEN")
                    .HasMaxLength(255);

                entity.Property(e => e.CTenen)
                    .HasColumnName("C_TENEN")
                    .HasMaxLength(255);

                entity.Property(e => e.CTktdcn).HasColumnName("C_TKTDCN");
            });

            modelBuilder.Entity<VBaocaosx>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_BAOCAOSX");

                entity.Property(e => e.CCa)
                    .HasColumnName("C_CA")
                    .HasMaxLength(10);

                entity.Property(e => e.CDvcs)
                    .IsRequired()
                    .HasColumnName("C_DVCS")
                    .HasMaxLength(12);

                entity.Property(e => e.CMacn)
                    .HasColumnName("C_MACN")
                    .HasMaxLength(12);

                entity.Property(e => e.CMapx)
                    .HasColumnName("C_MAPX")
                    .HasMaxLength(12);

                entity.Property(e => e.CMatt)
                    .HasColumnName("C_MATT")
                    .HasMaxLength(12);

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CSophieu)
                    .IsRequired()
                    .HasColumnName("C_SOPHIEU")
                    .HasMaxLength(12);

                entity.Property(e => e.CTencn)
                    .HasColumnName("C_TENCN")
                    .HasMaxLength(100);

                entity.Property(e => e.CTenpx)
                    .HasColumnName("C_TENPX")
                    .HasMaxLength(100);

                entity.Property(e => e.CTentt)
                    .HasColumnName("C_TENTT")
                    .HasMaxLength(50);

                entity.Property(e => e.PkId).HasColumnName("PK_ID");
            });

            modelBuilder.Entity<VBom>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_BOM");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CDvcs)
                    .IsRequired()
                    .HasColumnName("C_DVCS")
                    .HasMaxLength(12);

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(200);

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(20);

                entity.Property(e => e.CMaphu).HasColumnName("C_MAPHU");

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CSogia).HasColumnName("C_SOGIA");

                entity.Property(e => e.CTrangthai)
                    .HasColumnName("C_TRANGTHAI")
                    .HasMaxLength(20);

                entity.Property(e => e.CUser)
                    .HasColumnName("C_USER")
                    .HasMaxLength(20);

                entity.Property(e => e.PkId).HasColumnName("PK_ID");
            });

            modelBuilder.Entity<VChiPhiNvl>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ChiPhi_NVL");

                entity.Property(e => e.CDiengiai)
                    .HasColumnName("C_DIENGIAI")
                    .HasMaxLength(300);

                entity.Property(e => e.CDiengiai2)
                    .HasColumnName("C_DIENGIAI2")
                    .HasMaxLength(300);

                entity.Property(e => e.CPsno)
                    .HasColumnName("C_PSNO")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.CSoluong).HasColumnName("C_SOLUONG");

                entity.Property(e => e.CTigia).HasColumnName("C_TIGIA");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkDtpb).HasColumnName("FK_DTPB");

                entity.Property(e => e.FkDvt).HasColumnName("FK_DVT");

                entity.Property(e => e.FkKhoxuat).HasColumnName("FK_KHOXUAT");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");

                entity.Property(e => e.FkTkco)
                    .HasColumnName("FK_TKCO")
                    .HasMaxLength(12);

                entity.Property(e => e.FkTkno)
                    .HasColumnName("FK_TKNO")
                    .HasMaxLength(12);

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<VChiPhiNvlDc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ChiPhi_NVL_DC");

                entity.Property(e => e.CDiengiai)
                    .HasColumnName("C_DIENGIAI")
                    .HasMaxLength(300);

                entity.Property(e => e.CDiengiai2)
                    .HasColumnName("C_DIENGIAI2")
                    .HasMaxLength(300);

                entity.Property(e => e.CPsno)
                    .HasColumnName("C_PSNO")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.CSoluong).HasColumnName("C_SOLUONG");

                entity.Property(e => e.CTigia).HasColumnName("C_TIGIA");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkDtpb).HasColumnName("FK_DTPB");

                entity.Property(e => e.FkDvt).HasColumnName("FK_DVT");

                entity.Property(e => e.FkKhoxuat).HasColumnName("FK_KHOXUAT");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");

                entity.Property(e => e.FkTkco)
                    .HasColumnName("FK_TKCO")
                    .HasMaxLength(12);

                entity.Property(e => e.FkTkno)
                    .HasColumnName("FK_TKNO")
                    .HasMaxLength(12);

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<VChiphi622>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Chiphi622");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.FkTkno)
                    .HasColumnName("FK_TKNO")
                    .HasMaxLength(12);

                entity.Property(e => e.Months).HasColumnName("MONTHS");

                entity.Property(e => e.Years).HasColumnName("YEARS");
            });

            modelBuilder.Entity<VChiphi627>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Chiphi627");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.FkTkno)
                    .HasColumnName("FK_TKNO")
                    .HasMaxLength(12);

                entity.Property(e => e.Months).HasColumnName("MONTHS");

                entity.Property(e => e.Years).HasColumnName("YEARS");
            });

            modelBuilder.Entity<VChiphi627Phanxuong>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Chiphi627_PHANXUONG");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");

                entity.Property(e => e.FkTkno)
                    .HasColumnName("FK_TKNO")
                    .HasMaxLength(12);

                entity.Property(e => e.Months).HasColumnName("MONTHS");

                entity.Property(e => e.Years).HasColumnName("YEARS");
            });

            modelBuilder.Entity<VCpodata>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CPODATA");

                entity.Property(e => e.CConvert).HasColumnName("C_CONVERT");

                entity.Property(e => e.CDvt)
                    .IsRequired()
                    .HasColumnName("C_DVT")
                    .HasMaxLength(12);

                entity.Property(e => e.CMancc)
                    .HasColumnName("C_MANCC")
                    .HasMaxLength(50);

                entity.Property(e => e.CMaphu)
                    .HasColumnName("C_MAPHU")
                    .HasMaxLength(12);

                entity.Property(e => e.CMavthh)
                    .IsRequired()
                    .HasColumnName("C_MAVTHH")
                    .HasMaxLength(12);

                entity.Property(e => e.CNgaybd)
                    .HasColumnName("C_NGAYBD")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CNgaynhan)
                    .HasColumnName("C_NGAYNHAN")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CPolastPrice).HasColumnName("C_POLastPrice");

                entity.Property(e => e.CSlyeucau).HasColumnName("C_SLYEUCAU");

                entity.Property(e => e.CSophieu)
                    .HasColumnName("C_SOPHIEU")
                    .HasMaxLength(12);

                entity.Property(e => e.CTenncc)
                    .HasColumnName("C_TENNCC")
                    .HasMaxLength(150);

                entity.Property(e => e.CTenvthh)
                    .HasColumnName("C_TENVTHH")
                    .HasMaxLength(100);

                entity.Property(e => e.FkDvmua).HasColumnName("FK_DVMUA");

                entity.Property(e => e.FkDvtonkho).HasColumnName("FK_DVTONKHO");

                entity.Property(e => e.FkGiaydathang).HasColumnName("FK_GIAYDATHANG");

                entity.Property(e => e.FkMrpoption).HasColumnName("FK_MRPOPTION");

                entity.Property(e => e.FkPoprimaryVendor).HasColumnName("FK_POPrimaryVendor");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");
            });

            modelBuilder.Entity<VCpodataedit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CPODATAEDIT");

                entity.Property(e => e.CConvert).HasColumnName("C_CONVERT");

                entity.Property(e => e.CDvt)
                    .IsRequired()
                    .HasColumnName("C_DVT")
                    .HasMaxLength(12);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CMaphu)
                    .HasColumnName("C_MAPHU")
                    .HasMaxLength(12);

                entity.Property(e => e.CMavthh)
                    .IsRequired()
                    .HasColumnName("C_MAVTHH")
                    .HasMaxLength(12);

                entity.Property(e => e.CNgaybd)
                    .HasColumnName("C_NGAYBD")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CNgaynhan)
                    .HasColumnName("C_NGAYNHAN")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CNguon)
                    .HasColumnName("C_NGUON")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CSlconthieu).HasColumnName("C_SLCONTHIEU");

                entity.Property(e => e.CSlcungcap).HasColumnName("C_SLCUNGCAP");

                entity.Property(e => e.CSldalap).HasColumnName("C_SLDALAP");

                entity.Property(e => e.CSlyeucau).HasColumnName("C_SLYEUCAU");

                entity.Property(e => e.CTenvthh)
                    .HasColumnName("C_TENVTHH")
                    .HasMaxLength(100);

                entity.Property(e => e.FkCpo).HasColumnName("FK_CPO");

                entity.Property(e => e.FkDondathangct).HasColumnName("FK_DONDATHANGCT");

                entity.Property(e => e.FkGiaydathang).HasColumnName("FK_GIAYDATHANG");

                entity.Property(e => e.FkLsxct).HasColumnName("FK_LSXCT");

                entity.Property(e => e.FkMrpoption).HasColumnName("FK_MRPOPTION");

                entity.Property(e => e.FkNguon).HasColumnName("FK_NGUON");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");
            });

            modelBuilder.Entity<VCposchedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CPOSCHEDULE");

                entity.Property(e => e.CCa)
                    .HasColumnName("C_CA")
                    .HasMaxLength(10);

                entity.Property(e => e.CConvert).HasColumnName("C_CONVERT");

                entity.Property(e => e.CDengio)
                    .HasColumnName("C_DENGIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CDvt)
                    .IsRequired()
                    .HasColumnName("C_DVT")
                    .HasMaxLength(12);

                entity.Property(e => e.CMaChucNang)
                    .HasColumnName("C_MaChucNang")
                    .HasMaxLength(12);

                entity.Property(e => e.CMaLsx)
                    .HasColumnName("C_MaLSX")
                    .HasMaxLength(50);

                entity.Property(e => e.CMaPhanXuong)
                    .HasColumnName("C_MaPhanXuong")
                    .HasMaxLength(12);

                entity.Property(e => e.CMaPhuVthh)
                    .HasColumnName("C_MaPhuVTHH")
                    .HasMaxLength(12);

                entity.Property(e => e.CMaVthh)
                    .IsRequired()
                    .HasColumnName("C_MaVTHH")
                    .HasMaxLength(12);

                entity.Property(e => e.CNgay)
                    .HasColumnName("C_NGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CSelect).HasColumnName("C_SELECT");

                entity.Property(e => e.CSoluong).HasColumnName("C_SOLUONG");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.CTenChucNang)
                    .HasColumnName("C_TenChucNang")
                    .HasMaxLength(100);

                entity.Property(e => e.CTenPhanXuong)
                    .HasColumnName("C_TenPhanXuong")
                    .HasMaxLength(100);

                entity.Property(e => e.CTenVthh)
                    .HasColumnName("C_TenVTHH")
                    .HasMaxLength(100);

                entity.Property(e => e.CTugio)
                    .HasColumnName("C_TUGIO")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FkChucnang).HasColumnName("FK_CHUCNANG");

                entity.Property(e => e.FkCpodata).HasColumnName("FK_CPODATA");

                entity.Property(e => e.FkGiaydathang).HasColumnName("FK_GIAYDATHANG");

                entity.Property(e => e.FkLsx).HasColumnName("FK_LSX");

                entity.Property(e => e.FkMrpoption).HasColumnName("FK_MRPOPTION");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");
            });

            modelBuilder.Entity<VDmKh>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DM_KH");

                entity.Property(e => e.CConvert).HasColumnName("C_CONVERT");

                entity.Property(e => e.CCuoc)
                    .HasColumnName("C_CUOC")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CDiachi)
                    .HasColumnName("C_DIACHI")
                    .HasMaxLength(150);

                entity.Property(e => e.CDienthoai)
                    .HasColumnName("C_DIENTHOAI")
                    .HasMaxLength(50);

                entity.Property(e => e.CEffectid).HasColumnName("C_EFFECTID");

                entity.Property(e => e.CEmail)
                    .HasColumnName("C_EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CFax)
                    .HasColumnName("C_FAX")
                    .HasMaxLength(50);

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(255);

                entity.Property(e => e.CGiamdoc)
                    .HasColumnName("C_GIAMDOC")
                    .HasMaxLength(50);

                entity.Property(e => e.CGiaodich).HasColumnName("C_GIAODICH");

                entity.Property(e => e.CKhoangcach)
                    .HasColumnName("C_KHOANGCACH")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CKtt)
                    .HasColumnName("C_KTT")
                    .HasMaxLength(50);

                entity.Property(e => e.CMa)
                    .HasColumnName("C_MA")
                    .HasMaxLength(50);

                entity.Property(e => e.CMathang)
                    .HasColumnName("C_MATHANG")
                    .HasMaxLength(50);

                entity.Property(e => e.CMax)
                    .HasColumnName("C_MAX")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CMst)
                    .HasColumnName("C_MST")
                    .HasMaxLength(50);

                entity.Property(e => e.CMucno)
                    .HasColumnName("C_MUCNO")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CNgaythietlap)
                    .HasColumnName("C_NGAYTHIETLAP")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CNguoimua).HasColumnName("C_NGUOIMUA");

                entity.Property(e => e.CNhacungcap).HasColumnName("C_NHACUNGCAP");

                entity.Property(e => e.CNhanvien).HasColumnName("C_NHANVIEN");

                entity.Property(e => e.CSndn).HasColumnName("C_SNDN");

                entity.Property(e => e.CTaikhoan)
                    .HasColumnName("C_TAIKHOAN")
                    .HasMaxLength(150);

                entity.Property(e => e.CTccn).HasColumnName("C_TCCN");

                entity.Property(e => e.CTen)
                    .HasColumnName("C_TEN")
                    .HasMaxLength(150);

                entity.Property(e => e.CTongno)
                    .HasColumnName("C_TONGNO")
                    .HasColumnType("money");

                entity.Property(e => e.CTrietkhau)
                    .HasColumnName("C_TRIETKHAU")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CTvt)
                    .HasColumnName("C_TVT")
                    .HasMaxLength(50);

                entity.Property(e => e.CWebsite)
                    .HasColumnName("C_WEBSITE")
                    .HasMaxLength(50);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkHuyen).HasColumnName("FK_HUYEN");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkNhomkh).HasColumnName("FK_NHOMKH");

                entity.Property(e => e.FkNhomkh2).HasColumnName("FK_NHOMKH2");

                entity.Property(e => e.FkNhomkh3).HasColumnName("FK_NHOMKH3");

                entity.Property(e => e.FkPttt).HasColumnName("FK_PTTT");

                entity.Property(e => e.FkQuocgia).HasColumnName("FK_QUOCGIA");

                entity.Property(e => e.FkTaikhoan)
                    .HasColumnName("FK_TAIKHOAN")
                    .HasMaxLength(12);

                entity.Property(e => e.FkTtp).HasColumnName("FK_TTP");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVung).HasColumnName("FK_VUNG");

                entity.Property(e => e.FkXa).HasColumnName("FK_XA");

                entity.Property(e => e.FkXom).HasColumnName("FK_XOM");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VDmKhgiaodich>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DM_KHGIAODICH");

                entity.Property(e => e.CContactName)
                    .HasColumnName("C_ContactName")
                    .HasMaxLength(50);

                entity.Property(e => e.CContent)
                    .HasColumnName("C_Content")
                    .HasMaxLength(200);

                entity.Property(e => e.CDanhgia)
                    .HasColumnName("C_DANHGIA")
                    .HasMaxLength(20);

                entity.Property(e => e.CFeedBack)
                    .HasColumnName("C_FeedBack")
                    .HasMaxLength(200);

                entity.Property(e => e.CLoaigd)
                    .HasColumnName("C_LOAIGD")
                    .HasMaxLength(20);

                entity.Property(e => e.CMa)
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMakh)
                    .HasColumnName("C_MAKH")
                    .HasMaxLength(50);

                entity.Property(e => e.CNextContent)
                    .HasColumnName("C_NextContent")
                    .HasMaxLength(200);

                entity.Property(e => e.CNextDate)
                    .HasColumnName("C_NextDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CNextTime)
                    .HasColumnName("C_NextTime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CNhanviengd)
                    .IsRequired()
                    .HasColumnName("C_NHANVIENGD")
                    .HasMaxLength(20);

                entity.Property(e => e.CPhongban)
                    .HasColumnName("C_PHONGBAN")
                    .HasMaxLength(12);

                entity.Property(e => e.CRemindDate)
                    .HasColumnName("C_RemindDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CRemindTime)
                    .HasColumnName("C_RemindTime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CStopRemind).HasColumnName("C_StopRemind");

                entity.Property(e => e.CTenkh)
                    .HasColumnName("C_TENKH")
                    .HasMaxLength(150);

                entity.Property(e => e.CTransDate)
                    .HasColumnName("C_TransDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CTransTime)
                    .HasColumnName("C_TransTime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");
            });

            modelBuilder.Entity<VDmKho>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DM_KHO");

                entity.Property(e => e.CBanhang).HasColumnName("C_BANHANG");

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CKehang).HasColumnName("C_KEHANG");

                entity.Property(e => e.CKhoangcach).HasColumnName("C_KHOANGCACH");

                entity.Property(e => e.CLoaikho)
                    .IsRequired()
                    .HasColumnName("C_LOAIKHO")
                    .HasMaxLength(5);

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.CSanxuat).HasColumnName("C_SANXUAT");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkTongkho).HasColumnName("FK_TONGKHO");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VDmNhomkh2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DM_NHOMKH2");

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CLoai).HasColumnName("C_LOAI");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VDmNhomkh3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DM_NHOMKH3");

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CLoai).HasColumnName("C_LOAI");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VDmNhomvattu2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DM_NHOMVATTU2");

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CConvert).HasColumnName("C_CONVERT");

                entity.Property(e => e.CLoai).HasColumnName("C_LOAI");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VDmNhomvattu3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DM_NHOMVATTU3");

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CConvert).HasColumnName("C_CONVERT");

                entity.Property(e => e.CLoai).HasColumnName("C_LOAI");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VDmTaikhoan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DM_TAIKHOAN");

                entity.Property(e => e.CCap).HasColumnName("C_CAP");

                entity.Property(e => e.CLoaitk).HasColumnName("C_LOAITK");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CRead)
                    .HasColumnName("C_READ")
                    .HasMaxLength(500);

                entity.Property(e => e.CTen)
                    .IsRequired()
                    .HasColumnName("C_TEN")
                    .HasMaxLength(100);

                entity.Property(e => e.CTenen)
                    .HasColumnName("C_TENEN")
                    .HasMaxLength(100);

                entity.Property(e => e.CTkme).HasColumnName("C_TKME");

                entity.Property(e => e.CTksc).HasColumnName("C_TKSC");

                entity.Property(e => e.CTktdcn).HasColumnName("C_TKTDCN");

                entity.Property(e => e.CVisible)
                    .HasColumnName("C_VISIBLE")
                    .HasMaxLength(500);

                entity.Property(e => e.CWrite)
                    .HasColumnName("C_WRITE")
                    .HasMaxLength(500);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkNgoaite).HasColumnName("FK_NGOAITE");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VDoituongPhanBoLaiCpVl>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DOITUONG_PhanBoLaiCP_VL");

                entity.Property(e => e.CMa)
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.CSoluong).HasColumnName("C_SOLUONG");

                entity.Property(e => e.CSophieu)
                    .IsRequired()
                    .HasColumnName("C_SOPHIEU")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.FkDtpb).HasColumnName("FK_DTPB");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<VDondathang>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DONDATHANG");

                entity.Property(e => e.CDaban).HasColumnName("C_DABAN");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CDiengiai)
                    .HasColumnName("C_DIENGIAI")
                    .HasMaxLength(255);

                entity.Property(e => e.CDongia)
                    .HasColumnName("C_DONGIA")
                    .HasColumnType("money");

                entity.Property(e => e.CDongia2)
                    .HasColumnName("C_DONGIA2")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CKhdk)
                    .HasColumnName("C_KHDK")
                    .HasMaxLength(100);

                entity.Property(e => e.CKhdkdc)
                    .HasColumnName("C_KHDKDC")
                    .HasMaxLength(100);

                entity.Property(e => e.CKhdkdt)
                    .HasColumnName("C_KHDKDT")
                    .HasMaxLength(20);

                entity.Property(e => e.CKhdkemail)
                    .HasColumnName("C_KHDKEMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.CKhdkfax)
                    .HasColumnName("C_KHDKFAX")
                    .HasMaxLength(20);

                entity.Property(e => e.CKhdknlh)
                    .HasColumnName("C_KHDKNLH")
                    .HasMaxLength(40);

                entity.Property(e => e.CNgayhethan)
                    .HasColumnName("C_NGAYHETHAN")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNgaynhan)
                    .HasColumnName("C_NGAYNHAN")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNgaynhan2)
                    .HasColumnName("C_NGAYNHAN2")
                    .HasColumnType("datetime");

                entity.Property(e => e.CPheduyet).HasColumnName("C_PHEDUYET");

                entity.Property(e => e.CSoluong)
                    .HasColumnName("C_SOLUONG")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CSophieu)
                    .IsRequired()
                    .HasColumnName("C_SOPHIEU")
                    .HasMaxLength(12);

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.CTigia)
                    .HasColumnName("C_TIGIA")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CVat).HasColumnName("C_VAT");

                entity.Property(e => e.FkDdct).HasColumnName("FK_DDCT");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkDvban).HasColumnName("FK_DVBAN");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkKhachhang).HasColumnName("FK_KHACHHANG");

                entity.Property(e => e.FkKmp).HasColumnName("FK_KMP");

                entity.Property(e => e.FkLoaibg).HasColumnName("FK_LOAIBG");

                entity.Property(e => e.FkLoaitien).HasColumnName("FK_LOAITIEN");

                entity.Property(e => e.FkNguoilh).HasColumnName("FK_NGUOILH");

                entity.Property(e => e.FkNguoipd).HasColumnName("FK_NGUOIPD");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");

                entity.Property(e => e.FkTrangthai).HasColumnName("FK_TRANGTHAI");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.FkVuviec).HasColumnName("FK_VUVIEC");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");
            });

            modelBuilder.Entity<VDondathang2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DONDATHANG2");

                entity.Property(e => e.CDelqty).HasColumnName("C_DELQTY");

                entity.Property(e => e.CDiachi)
                    .HasColumnName("C_DIACHI")
                    .HasMaxLength(150);

                entity.Property(e => e.CDiengiai)
                    .HasColumnName("C_DIENGIAI")
                    .HasMaxLength(255);

                entity.Property(e => e.CDvcs)
                    .IsRequired()
                    .HasColumnName("C_DVCS")
                    .HasMaxLength(12);

                entity.Property(e => e.CHangvc)
                    .HasColumnName("C_HANGVC")
                    .HasMaxLength(250);

                entity.Property(e => e.CMakh)
                    .HasColumnName("C_MAKH")
                    .HasMaxLength(50);

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNguoilh)
                    .HasColumnName("C_NGUOILH")
                    .HasMaxLength(255);

                entity.Property(e => e.CNguoivanchuyen)
                    .HasColumnName("C_NGUOIVANCHUYEN")
                    .HasMaxLength(70);

                entity.Property(e => e.COrderqty)
                    .HasColumnName("C_ORDERQTY")
                    .HasColumnType("decimal(38, 0)");

                entity.Property(e => e.CPhongban)
                    .HasColumnName("C_PHONGBAN")
                    .HasMaxLength(200);

                entity.Property(e => e.CRemain).HasColumnName("C_REMAIN");

                entity.Property(e => e.CSochi)
                    .HasColumnName("C_SOCHI")
                    .HasMaxLength(12);

                entity.Property(e => e.CSocont)
                    .HasColumnName("C_SOCONT")
                    .HasMaxLength(12);

                entity.Property(e => e.CSophieu)
                    .IsRequired()
                    .HasColumnName("C_SOPHIEU")
                    .HasMaxLength(12);

                entity.Property(e => e.CSoxe)
                    .HasColumnName("C_SOXE")
                    .HasMaxLength(30);

                entity.Property(e => e.CTenkh)
                    .HasColumnName("C_TENKH")
                    .HasMaxLength(250);

                entity.Property(e => e.CVat).HasColumnName("C_VAT");

                entity.Property(e => e.CVuviec)
                    .HasColumnName("C_VUVIEC")
                    .HasMaxLength(100);

                entity.Property(e => e.FkLoaibg).HasColumnName("FK_LOAIBG");

                entity.Property(e => e.FkSochuyen).HasColumnName("FK_SOCHUYEN");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");
            });

            modelBuilder.Entity<VDubao>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DUBAO");

                entity.Property(e => e.CDiachi)
                    .HasColumnName("C_DIACHI")
                    .HasMaxLength(150);

                entity.Property(e => e.CDvcs)
                    .IsRequired()
                    .HasColumnName("C_DVCS")
                    .HasMaxLength(12);

                entity.Property(e => e.CMakh)
                    .HasColumnName("C_MAKH")
                    .HasMaxLength(50);

                entity.Property(e => e.CMaphongban)
                    .HasColumnName("C_MAPHONGBAN")
                    .HasMaxLength(12);

                entity.Property(e => e.CNam).HasColumnName("C_NAM");

                entity.Property(e => e.CNguoilap)
                    .HasColumnName("C_NGUOILAP")
                    .HasMaxLength(20);

                entity.Property(e => e.CTenkh)
                    .HasColumnName("C_TENKH")
                    .HasMaxLength(150);

                entity.Property(e => e.CTenphongban)
                    .HasColumnName("C_TENPHONGBAN")
                    .HasMaxLength(100);

                entity.Property(e => e.CThang).HasColumnName("C_THANG");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");
            });

            modelBuilder.Entity<VDubaots>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DUBAOTS");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CDenngay)
                    .HasColumnName("C_DENNGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CDvcs)
                    .IsRequired()
                    .HasColumnName("C_DVCS")
                    .HasMaxLength(12);

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(100);

                entity.Property(e => e.CHeso).HasColumnName("C_HESO");

                entity.Property(e => e.CKytruoc).HasColumnName("C_KYTRUOC");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CSokytruoc).HasColumnName("C_SOKYTRUOC");

                entity.Property(e => e.CTheokh).HasColumnName("C_THEOKH");

                entity.Property(e => e.CTungay)
                    .HasColumnName("C_TUNGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CUser)
                    .HasColumnName("C_USER")
                    .HasMaxLength(20);

                entity.Property(e => e.PkId).HasColumnName("PK_ID");
            });

            modelBuilder.Entity<VDubaotsdata>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DUBAOTSDATA");

                entity.Property(e => e.CDvb)
                    .IsRequired()
                    .HasColumnName("C_DVB")
                    .HasMaxLength(12);

                entity.Property(e => e.CDvtk)
                    .IsRequired()
                    .HasColumnName("C_DVTK")
                    .HasMaxLength(12);

                entity.Property(e => e.CHeso).HasColumnName("C_HESO");

                entity.Property(e => e.CMakh)
                    .HasColumnName("C_MAKH")
                    .HasMaxLength(50);

                entity.Property(e => e.CMaphu)
                    .HasColumnName("C_MAPHU")
                    .HasMaxLength(12);

                entity.Property(e => e.CMavthh)
                    .IsRequired()
                    .HasColumnName("C_MAVTHH")
                    .HasMaxLength(12);

                entity.Property(e => e.CSlban)
                    .HasColumnName("C_SLBAN")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CSltk)
                    .HasColumnName("C_SLTK")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CTenkh)
                    .HasColumnName("C_TENKH")
                    .HasMaxLength(150);

                entity.Property(e => e.CTenvthh)
                    .HasColumnName("C_TENVTHH")
                    .HasMaxLength(100);

                entity.Property(e => e.FkDubaots).HasColumnName("FK_DUBAOTS");

                entity.Property(e => e.FkDvban).HasColumnName("FK_DVBAN");

                entity.Property(e => e.FkDvtk).HasColumnName("FK_DVTK");

                entity.Property(e => e.FkKhachhang).HasColumnName("FK_KHACHHANG");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");
            });

            modelBuilder.Entity<VLsx>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_LSX");

                entity.Property(e => e.CDiachi)
                    .HasColumnName("C_DIACHI")
                    .HasMaxLength(150);

                entity.Property(e => e.CDvcs)
                    .IsRequired()
                    .HasColumnName("C_DVCS")
                    .HasMaxLength(12);

                entity.Property(e => e.CKtsx).HasColumnName("C_KTSX");

                entity.Property(e => e.CKttc).HasColumnName("C_KTTC");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(50);

                entity.Property(e => e.CMakh)
                    .HasColumnName("C_MAKH")
                    .HasMaxLength(50);

                entity.Property(e => e.CMota)
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.CNgaykt)
                    .HasColumnName("C_NGAYKT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.CTenkh)
                    .HasColumnName("C_TENKH")
                    .HasMaxLength(150);

                entity.Property(e => e.PkId).HasColumnName("PK_ID");
            });

            modelBuilder.Entity<VPhanBoCp627PhanXuongPvc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_PhanBoCP_627_PhanXuong_PVC");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CpSauPhanBo).HasColumnName("CP_SauPhanBo");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.M).HasColumnName("m");

                entity.Property(e => e.SlHoanthanh).HasColumnName("SL_HOANTHANH");

                entity.Property(e => e.Y).HasColumnName("y");
            });

            modelBuilder.Entity<VPhanBoCp627PhanXuongXlpe>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_PhanBoCP_627_PhanXuong_XLPE");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CpSauPhanBo).HasColumnName("CP_SauPhanBo");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.M).HasColumnName("m");

                entity.Property(e => e.SlHoanthanh).HasColumnName("SL_HOANTHANH");

                entity.Property(e => e.Y).HasColumnName("y");
            });

            modelBuilder.Entity<VPhanBoKhongPhanxuong>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PhanBoKhongPhanxuong");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CTen)
                    .HasColumnName("C_TEN")
                    .HasMaxLength(100);

                entity.Property(e => e.CpSauPhanBo).HasColumnName("CP_SauPhanBo");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.M).HasColumnName("m");

                entity.Property(e => e.SlHoanthanh).HasColumnName("SL_HOANTHANH");

                entity.Property(e => e.TongCpkhauHao)
                    .HasColumnName("TONG_CPKHAU_HAO")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TongHoanThanh).HasColumnName("Tong_HoanThanh");

                entity.Property(e => e.Y).HasColumnName("y");
            });

            modelBuilder.Entity<VPhanBoKhongPhanxuong622>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PhanBoKhongPhanxuong_622");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CTen)
                    .HasColumnName("C_TEN")
                    .HasMaxLength(100);

                entity.Property(e => e.CpSauPhanBo).HasColumnName("CP_SauPhanBo");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.M).HasColumnName("m");

                entity.Property(e => e.SlHoanthanh).HasColumnName("SL_HOANTHANH");

                entity.Property(e => e.TongCpkhauHao)
                    .HasColumnName("TONG_CPKHAU_HAO")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TongHoanThanh).HasColumnName("Tong_HoanThanh");

                entity.Property(e => e.Y).HasColumnName("y");
            });

            modelBuilder.Entity<VPheduyetlsx>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PHEDUYETLSX");

                entity.Property(e => e.CDvt)
                    .IsRequired()
                    .HasColumnName("C_DVT")
                    .HasMaxLength(12);

                entity.Property(e => e.CKtsx).HasColumnName("C_KTSX");

                entity.Property(e => e.CMakh)
                    .HasColumnName("C_MAKH")
                    .HasMaxLength(50);

                entity.Property(e => e.CMalsx)
                    .IsRequired()
                    .HasColumnName("C_MALSX")
                    .HasMaxLength(50);

                entity.Property(e => e.CMaphu)
                    .HasColumnName("C_MAPHU")
                    .HasMaxLength(12);

                entity.Property(e => e.CMavthh)
                    .IsRequired()
                    .HasColumnName("C_MAVTHH")
                    .HasMaxLength(12);

                entity.Property(e => e.CMotalsx)
                    .HasColumnName("C_MOTALSX")
                    .HasMaxLength(100);

                entity.Property(e => e.CNgaybd)
                    .HasColumnName("C_NGAYBD")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNgaygh)
                    .HasColumnName("C_NGAYGH")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNgayht)
                    .HasColumnName("C_NGAYHT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.CPheduyet).HasColumnName("C_PHEDUYET");

                entity.Property(e => e.CSoluong).HasColumnName("C_SOLUONG");

                entity.Property(e => e.CTenkh)
                    .HasColumnName("C_TENKH")
                    .HasMaxLength(150);

                entity.Property(e => e.CTenvthh)
                    .HasColumnName("C_TENVTHH")
                    .HasMaxLength(100);

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkLsxct).HasColumnName("FK_LSXCT");
            });

            modelBuilder.Entity<VRouting>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ROUTING");

                entity.Property(e => e.CDvcs)
                    .HasColumnName("C_DVCS")
                    .HasMaxLength(12);

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(200);

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(20);

                entity.Property(e => e.CMaphu).HasColumnName("C_MAPHU");

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CTrangthai)
                    .HasColumnName("C_TRANGTHAI")
                    .HasMaxLength(20);

                entity.Property(e => e.CUser)
                    .HasColumnName("C_USER")
                    .HasMaxLength(20);

                entity.Property(e => e.PkId).HasColumnName("PK_ID");
            });

            modelBuilder.Entity<VSanPhamHoanThanh>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SanPhamHoanThanh");

                entity.Property(e => e.CDiengiai)
                    .HasColumnName("C_DIENGIAI")
                    .HasMaxLength(300);

                entity.Property(e => e.FkChungtu).HasColumnName("FK_CHUNGTU");

                entity.Property(e => e.FkTkco)
                    .HasColumnName("FK_TKCO")
                    .HasMaxLength(12);

                entity.Property(e => e.FkTkno)
                    .HasColumnName("FK_TKNO")
                    .HasMaxLength(12);

                entity.Property(e => e.Months).HasColumnName("MONTHS");

                entity.Property(e => e.SanphamId).HasColumnName("SANPHAM_ID");

                entity.Property(e => e.Tonghoanthanh).HasColumnName("TONGHOANTHANH");

                entity.Property(e => e.Years).HasColumnName("YEARS");
            });

            modelBuilder.Entity<VSanPhamHoanThanhPhanxuong>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SanPhamHoanThanh_phanxuong");

                entity.Property(e => e.CDiengiai)
                    .HasColumnName("C_DIENGIAI")
                    .HasMaxLength(300);

                entity.Property(e => e.FkChungtu).HasColumnName("FK_CHUNGTU");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");

                entity.Property(e => e.FkTkco)
                    .HasColumnName("FK_TKCO")
                    .HasMaxLength(12);

                entity.Property(e => e.FkTkno)
                    .HasColumnName("FK_TKNO")
                    .HasMaxLength(12);

                entity.Property(e => e.Months).HasColumnName("MONTHS");

                entity.Property(e => e.SanphamId).HasColumnName("SANPHAM_ID");

                entity.Property(e => e.Tonghoanthanh).HasColumnName("TONGHOANTHANH");

                entity.Property(e => e.Years).HasColumnName("YEARS");
            });

            modelBuilder.Entity<VSelectfunction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SELECTFUNCTION");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMinruntime).HasColumnName("C_MINRUNTIME");

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.CSelect).HasColumnName("C_SELECT");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VSelectmakeitem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SELECTMAKEITEM");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMaphu)
                    .HasColumnName("C_MAPHU")
                    .HasMaxLength(12);

                entity.Property(e => e.CSelect).HasColumnName("C_SELECT");

                entity.Property(e => e.CTen)
                    .HasColumnName("C_TEN")
                    .HasMaxLength(100);

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VSlip>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SLIP");

                entity.Property(e => e.CPscousd)
                    .HasColumnName("C_PSCOUSD")
                    .HasColumnType("decimal(38, 3)");

                entity.Property(e => e.CPscovnd)
                    .HasColumnName("C_PSCOVND")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.CPsnousd)
                    .HasColumnName("C_PSNOUSD")
                    .HasColumnType("decimal(38, 3)");

                entity.Property(e => e.CPsnovnd)
                    .HasColumnName("C_PSNOVND")
                    .HasColumnType("decimal(38, 4)");

                entity.Property(e => e.CSophieu)
                    .IsRequired()
                    .HasColumnName("C_SOPHIEU")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CTaikhoan)
                    .HasColumnName("C_TAIKHOAN")
                    .HasMaxLength(12);

                entity.Property(e => e.CTenen)
                    .HasColumnName("C_TENEN")
                    .HasMaxLength(100);

                entity.Property(e => e.CTigia).HasColumnName("C_TIGIA");
            });

            modelBuilder.Entity<VSpHoanthanhVaRecycle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SP_HOANTHANH_VA_RECYCLE");

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.CSophieu)
                    .IsRequired()
                    .HasColumnName("C_SOPHIEU")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.MaSp)
                    .IsRequired()
                    .HasColumnName("MA_SP")
                    .HasMaxLength(12);

                entity.Property(e => e.SlRec).HasColumnName("SL_REC");

                entity.Property(e => e.SlSpht).HasColumnName("SL_SPHT");

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.TenSp)
                    .HasColumnName("TEN_SP")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<VTyLePhanBoCp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TyLePhanBo_CP");

                entity.Property(e => e.FkDtpb).HasColumnName("FK_DTPB");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.Rate).HasColumnName("RATE");

                entity.Property(e => e.SoluongRc).HasColumnName("SOLUONG_RC");

                entity.Property(e => e.TongsoHt).HasColumnName("TONGSO_HT");
            });

            modelBuilder.Entity<VVitriAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_VITRI_ALL");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CVitri)
                    .HasColumnName("C_VITRI")
                    .HasMaxLength(4000);

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VVthh>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_VTHH");

                entity.Property(e => e.CAnh)
                    .HasColumnName("C_ANH")
                    .HasColumnType("image");

                entity.Property(e => e.CBanboiso)
                    .HasColumnName("C_BANBOISO")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CBandenngay)
                    .HasColumnName("C_BANDENNGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CBandonggoi).HasColumnName("C_BANDONGGOI");

                entity.Property(e => e.CBanphamvi).HasColumnName("C_BANPHAMVI");

                entity.Property(e => e.CBantungay)
                    .HasColumnName("C_BANTUNGAY")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CChieucao).HasColumnName("C_CHIEUCAO");

                entity.Property(e => e.CChieudai).HasColumnName("C_CHIEUDAI");

                entity.Property(e => e.CChieurong).HasColumnName("C_CHIEURONG");

                entity.Property(e => e.CConvert).HasColumnName("C_CONVERT");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CExported).HasColumnName("C_EXPORTED");

                entity.Property(e => e.CGhichu)
                    .HasColumnName("C_GHICHU")
                    .HasMaxLength(100);

                entity.Property(e => e.CGiachuan)
                    .HasColumnName("C_GIACHUAN")
                    .HasColumnType("money");

                entity.Property(e => e.CGiasan)
                    .HasColumnName("C_GIASAN")
                    .HasColumnType("money");

                entity.Property(e => e.CGiatran)
                    .HasColumnName("C_GIATRAN")
                    .HasColumnType("money");

                entity.Property(e => e.CGrossweight).HasColumnName("C_GROSSWEIGHT");

                entity.Property(e => e.CHotrovc).HasColumnName("C_HOTROVC");

                entity.Property(e => e.CKttsx).HasColumnName("C_KTTSX");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMaphu)
                    .HasColumnName("C_MAPHU")
                    .HasMaxLength(12);

                entity.Property(e => e.CMavach)
                    .HasColumnName("C_MAVACH")
                    .HasMaxLength(50);

                entity.Property(e => e.CNetweight).HasColumnName("C_NETWEIGHT");

                entity.Property(e => e.CNgaytl)
                    .HasColumnName("C_NGAYTL")
                    .HasColumnType("datetime");

                entity.Property(e => e.CPhichuan).HasColumnName("C_PHICHUAN");

                entity.Property(e => e.CPolastPrice).HasColumnName("C_POLastPrice");

                entity.Property(e => e.CPoleadTime)
                    .HasColumnName("C_POLeadTime")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CPomaxOrder)
                    .HasColumnName("C_POMaxOrder")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CPominOrder)
                    .HasColumnName("C_POMinOrder")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CPomultiple)
                    .HasColumnName("C_POMultiple")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CProleadTime)
                    .HasColumnName("C_PROLeadTime")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CPromaxOrder)
                    .HasColumnName("C_PROMaxOrder")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CProminOrder)
                    .HasColumnName("C_PROMinOrder")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CPromultiple)
                    .HasColumnName("C_PROMultiple")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CQcdg)
                    .HasColumnName("C_QCDG")
                    .HasColumnType("ntext");

                entity.Property(e => e.CSanxuat).HasColumnName("C_SANXUAT");

                entity.Property(e => e.CSlttd).HasColumnName("C_SLTTD");

                entity.Property(e => e.CSlttt).HasColumnName("C_SLTTT");

                entity.Property(e => e.CSogia).HasColumnName("C_SOGIA");

                entity.Property(e => e.CTdtk).HasColumnName("C_TDTK");

                entity.Property(e => e.CTelehongsx).HasColumnName("C_TELEHONGSX");

                entity.Property(e => e.CTen)
                    .HasColumnName("C_TEN")
                    .HasMaxLength(100);

                entity.Property(e => e.CTgbh).HasColumnName("C_TGBH");

                entity.Property(e => e.CThuenk)
                    .HasColumnName("C_THUENK")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CThuevat).HasColumnName("C_THUEVAT");

                entity.Property(e => e.CTilehongvc).HasColumnName("C_TILEHONGVC");

                entity.Property(e => e.CTskt)
                    .HasColumnName("C_TSKT")
                    .HasColumnType("ntext");

                entity.Property(e => e.CXoa).HasColumnName("C_XOA");

                entity.Property(e => e.FkCtg).HasColumnName("FK_CTG");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkDvban).HasColumnName("FK_DVBAN");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkDvmua).HasColumnName("FK_DVMUA");

                entity.Property(e => e.FkDvtonkho).HasColumnName("FK_DVTONKHO");

                entity.Property(e => e.FkHsx).HasColumnName("FK_HSX");

                entity.Property(e => e.FkKhohang).HasColumnName("FK_KHOHANG");

                entity.Property(e => e.FkModifyuser).HasColumnName("FK_MODIFYUSER");

                entity.Property(e => e.FkNhomvt).HasColumnName("FK_NHOMVT");

                entity.Property(e => e.FkNhomvt2).HasColumnName("FK_NHOMVT2");

                entity.Property(e => e.FkNhomvt3).HasColumnName("FK_NHOMVT3");

                entity.Property(e => e.FkPoprimaryVendor).HasColumnName("FK_POPrimaryVendor");

                entity.Property(e => e.FkQuicach).HasColumnName("FK_QUICACH");

                entity.Property(e => e.FkSptieuChuan).HasColumnName("FK_SPTieuChuan");

                entity.Property(e => e.FkTkgvon)
                    .HasColumnName("FK_TKGVON")
                    .HasMaxLength(12);

                entity.Property(e => e.FkTkkho)
                    .HasColumnName("FK_TKKHO")
                    .HasMaxLength(12);

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVitri).HasColumnName("FK_VITRI");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VVthhlaborexpense>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_VTHHLABOREXPENSE");

                entity.Property(e => e.CSotien)
                    .HasColumnName("C_SOTIEN")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.FkKmp).HasColumnName("FK_KMP");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<VVthhmachineexpense>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_VTHHMACHINEEXPENSE");

                entity.Property(e => e.CSotien)
                    .HasColumnName("C_SOTIEN")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.FkKmp).HasColumnName("FK_KMP");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<VVthhmaterialexpense>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_VTHHMATERIALEXPENSE");

                entity.Property(e => e.CSotien)
                    .HasColumnName("C_SOTIEN")
                    .HasColumnType("decimal(38, 3)");

                entity.Property(e => e.FkKmp).HasColumnName("FK_KMP");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<VVthhstdcost>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_VTHHSTDCOST");

                entity.Property(e => e.CMa)
                    .IsRequired()
                    .HasColumnName("C_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CMota)
                    .IsRequired()
                    .HasColumnName("C_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.CRollupdate)
                    .HasColumnName("C_ROLLUPDATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CSotien)
                    .HasColumnName("C_SOTIEN")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FkKmp).HasColumnName("FK_KMP");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");
            });

            modelBuilder.Entity<VXntc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_XNTC");

                entity.Property(e => e.CChungtuMa)
                    .HasColumnName("C_CHUNGTU_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CChungtuTen)
                    .HasColumnName("C_CHUNGTU_TEN")
                    .HasMaxLength(100);

                entity.Property(e => e.CCpsx).HasColumnName("C_CPSX");

                entity.Property(e => e.CDgdong)
                    .HasColumnName("C_DGDONG")
                    .HasMaxLength(300);

                entity.Property(e => e.CDiachi)
                    .HasColumnName("C_DIACHI")
                    .HasMaxLength(150);

                entity.Property(e => e.CDiengiai)
                    .HasColumnName("C_DIENGIAI")
                    .HasMaxLength(300);

                entity.Property(e => e.CDiengiai2)
                    .HasColumnName("C_DIENGIAI2")
                    .HasMaxLength(300);

                entity.Property(e => e.CDondathang)
                    .HasColumnName("C_DONDATHANG")
                    .HasMaxLength(12);

                entity.Property(e => e.CDongia)
                    .HasColumnName("C_DONGIA")
                    .HasColumnType("money");

                entity.Property(e => e.CDtcpMa)
                    .HasColumnName("C_DTCP_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CDtcpTen)
                    .HasColumnName("C_DTCP_TEN")
                    .HasMaxLength(100);

                entity.Property(e => e.CDvcsMa)
                    .HasColumnName("C_DVCS_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CDvtMa)
                    .HasColumnName("C_DVT_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CHantt).HasColumnName("C_HANTT");

                entity.Property(e => e.CHuyenMa)
                    .HasColumnName("C_HUYEN_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CHuyenTen)
                    .HasColumnName("C_HUYEN_TEN")
                    .HasMaxLength(50);

                entity.Property(e => e.CKenhapMa)
                    .HasColumnName("C_KENHAP_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CKexuatMa)
                    .HasColumnName("C_KEXUAT_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CKhMa)
                    .HasColumnName("C_KH_MA")
                    .HasMaxLength(50);

                entity.Property(e => e.CKhTen)
                    .HasColumnName("C_KH_TEN")
                    .HasMaxLength(250);

                entity.Property(e => e.CKhcMa)
                    .HasColumnName("C_KHC_MA")
                    .HasMaxLength(50);

                entity.Property(e => e.CKhcTen)
                    .HasColumnName("C_KHC_TEN")
                    .HasMaxLength(250);

                entity.Property(e => e.CKhnlhTen)
                    .HasColumnName("C_KHNLH_TEN")
                    .HasMaxLength(255);

                entity.Property(e => e.CKhonhapMa)
                    .HasColumnName("C_KHONHAP_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CKhoxuatMa)
                    .HasColumnName("C_KHOXUAT_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CKmpMa)
                    .HasColumnName("C_KMP_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CKmpMota)
                    .HasColumnName("C_KMP_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.CKmpcMa)
                    .HasColumnName("C_KMPC_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CKmpcMota)
                    .HasColumnName("C_KMPC_MOTA")
                    .HasMaxLength(12);

                entity.Property(e => e.CLaphd).HasColumnName("C_LAPHD");

                entity.Property(e => e.CLoaibt).HasColumnName("C_LOAIBT");

                entity.Property(e => e.CLoaixn).HasColumnName("C_LOAIXN");

                entity.Property(e => e.CNganhangMa)
                    .HasColumnName("C_NGANHANG_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CNganhangMota)
                    .HasColumnName("C_NGANHANG_MOTA")
                    .HasMaxLength(300);

                entity.Property(e => e.CNgayct)
                    .HasColumnName("C_NGAYCT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNote)
                    .HasColumnName("C_NOTE")
                    .HasMaxLength(1000);

                entity.Property(e => e.CNvkdTen)
                    .HasColumnName("C_NVKD_TEN")
                    .HasMaxLength(250);

                entity.Property(e => e.CPhanxuongMa)
                    .HasColumnName("C_PHANXUONG_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CPhanxuongMota)
                    .HasColumnName("C_PHANXUONG_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.CPhongbanMa)
                    .HasColumnName("C_PHONGBAN_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CPhongbanTen)
                    .HasColumnName("C_PHONGBAN_TEN")
                    .HasMaxLength(100);

                entity.Property(e => e.CPosted).HasColumnName("C_POSTED");

                entity.Property(e => e.CPsco)
                    .HasColumnName("C_PSCO")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CPsco2)
                    .HasColumnName("C_PSCO2")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CPsno)
                    .HasColumnName("C_PSNO")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CPsno2)
                    .HasColumnName("C_PSNO2")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CPtttMa)
                    .HasColumnName("C_PTTT_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CSlkiemtra)
                    .HasColumnName("C_SLKIEMTRA")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CSoct)
                    .HasColumnName("C_SOCT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CSohdgtgt)
                    .HasColumnName("C_SOHDGTGT")
                    .HasMaxLength(10);

                entity.Property(e => e.CSoluong).HasColumnName("C_SOLUONG");

                entity.Property(e => e.CSophieu)
                    .IsRequired()
                    .HasColumnName("C_SOPHIEU")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.CSophieucu)
                    .HasColumnName("C_SOPHIEUCU")
                    .HasMaxLength(120);

                entity.Property(e => e.CStt).HasColumnName("C_STT");

                entity.Property(e => e.CTiente)
                    .HasColumnName("C_TIENTE")
                    .HasMaxLength(12);

                entity.Property(e => e.CTigia).HasColumnName("C_TIGIA");

                entity.Property(e => e.CTscdMa)
                    .HasColumnName("C_TSCD_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CTscdTen)
                    .HasColumnName("C_TSCD_TEN")
                    .HasMaxLength(200);

                entity.Property(e => e.CVat).HasColumnName("C_VAT");

                entity.Property(e => e.CVthhMa)
                    .HasColumnName("C_VTHH_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CVthhTen)
                    .HasColumnName("C_VTHH_TEN")
                    .HasMaxLength(100);

                entity.Property(e => e.CVuviecMa)
                    .HasColumnName("C_VUVIEC_MA")
                    .HasMaxLength(20);

                entity.Property(e => e.CVuviecMota)
                    .HasColumnName("C_VUVIEC_MOTA")
                    .HasMaxLength(100);

                entity.Property(e => e.CXaMa)
                    .HasColumnName("C_XA_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CXaTen)
                    .HasColumnName("C_XA_TEN")
                    .HasMaxLength(50);

                entity.Property(e => e.CXomMa)
                    .HasColumnName("C_XOM_MA")
                    .HasMaxLength(12);

                entity.Property(e => e.CXomTen)
                    .HasColumnName("C_XOM_TEN")
                    .HasMaxLength(50);

                entity.Property(e => e.FkChungtu).HasColumnName("FK_CHUNGTU");

                entity.Property(e => e.FkOrder).HasColumnName("FK_ORDER");

                entity.Property(e => e.FkTkco)
                    .HasColumnName("FK_TKCO")
                    .HasMaxLength(12);

                entity.Property(e => e.FkTkno)
                    .HasColumnName("FK_TKNO")
                    .HasMaxLength(12);

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .HasColumnType("numeric(19, 0)");
            });

            modelBuilder.Entity<VXntccn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_XNTCCN");

                entity.Property(e => e.CChatluong).HasColumnName("C_CHATLUONG");

                entity.Property(e => e.CChietkhau)
                    .HasColumnName("C_CHIETKHAU")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CCopy).HasColumnName("C_COPY");

                entity.Property(e => e.CCpsx).HasColumnName("C_CPSX");

                entity.Property(e => e.CDatetime)
                    .HasColumnName("C_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.CDgdong)
                    .HasColumnName("C_DGDONG")
                    .HasMaxLength(300);

                entity.Property(e => e.CDiengiai)
                    .HasColumnName("C_DIENGIAI")
                    .HasMaxLength(300);

                entity.Property(e => e.CDiengiai2)
                    .HasColumnName("C_DIENGIAI2")
                    .HasMaxLength(300);

                entity.Property(e => e.CDongia)
                    .HasColumnName("C_DONGIA")
                    .HasColumnType("money");

                entity.Property(e => e.CHantt).HasColumnName("C_HANTT");

                entity.Property(e => e.CHantt2)
                    .HasColumnName("C_HANTT2")
                    .HasColumnType("datetime");

                entity.Property(e => e.CHoadon).HasColumnName("C_HOADON");

                entity.Property(e => e.CKhthue)
                    .HasColumnName("C_KHTHUE")
                    .HasMaxLength(100);

                entity.Property(e => e.CKhuco).HasColumnName("C_KHUCO");

                entity.Property(e => e.CKhuno).HasColumnName("C_KHUNO");

                entity.Property(e => e.CKm)
                    .HasColumnName("C_KM")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CLoaibt).HasColumnName("C_LOAIBT");

                entity.Property(e => e.CLoaict).HasColumnName("C_LOAICT");

                entity.Property(e => e.CLoaixn).HasColumnName("C_LOAIXN");

                entity.Property(e => e.CMrb).HasColumnName("C_MRB");

                entity.Property(e => e.CMst)
                    .HasColumnName("C_MST")
                    .HasMaxLength(20);

                entity.Property(e => e.CNgayct)
                    .HasColumnName("C_NGAYCT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNgaylap)
                    .HasColumnName("C_NGAYLAP")
                    .HasColumnType("datetime");

                entity.Property(e => e.CNguoilh)
                    .HasColumnName("C_NGUOILH")
                    .HasMaxLength(255);

                entity.Property(e => e.CNote)
                    .HasColumnName("C_NOTE")
                    .HasMaxLength(1000);

                entity.Property(e => e.CPosted).HasColumnName("C_POSTED");

                entity.Property(e => e.CPoster).HasColumnName("C_POSTER");

                entity.Property(e => e.CPromo).HasColumnName("C_PROMO");

                entity.Property(e => e.CPsco)
                    .HasColumnName("C_PSCO")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CPsco2)
                    .HasColumnName("C_PSCO2")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CPsno)
                    .HasColumnName("C_PSNO")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CPsno2)
                    .HasColumnName("C_PSNO2")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CSlkiemtra)
                    .HasColumnName("C_SLKIEMTRA")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CSoct)
                    .HasColumnName("C_SOCT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CSohdgtgt)
                    .HasColumnName("C_SOHDGTGT")
                    .HasMaxLength(10);

                entity.Property(e => e.CSoluong).HasColumnName("C_SOLUONG");

                entity.Property(e => e.CSophieu)
                    .IsRequired()
                    .HasColumnName("C_SOPHIEU")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.CSophieutralai)
                    .HasColumnName("C_SOPHIEUTRALAI")
                    .HasMaxLength(20);

                entity.Property(e => e.CSoxe)
                    .HasColumnName("C_SOXE")
                    .HasMaxLength(30);

                entity.Property(e => e.CTienthue)
                    .HasColumnName("C_TIENTHUE")
                    .HasColumnType("money");

                entity.Property(e => e.CTienthue2)
                    .HasColumnName("C_TIENTHUE2")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CTigia).HasColumnName("C_TIGIA");

                entity.Property(e => e.CTrong).HasColumnName("C_TRONG");

                entity.Property(e => e.CVat).HasColumnName("C_VAT");

                entity.Property(e => e.FkChungtu).HasColumnName("FK_CHUNGTU");

                entity.Property(e => e.FkCostCenter).HasColumnName("FK_CostCenter");

                entity.Property(e => e.FkDtcp).HasColumnName("FK_DTCP");

                entity.Property(e => e.FkDvcs).HasColumnName("FK_DVCS");

                entity.Property(e => e.FkDvt).HasColumnName("FK_DVT");

                entity.Property(e => e.FkKenhap).HasColumnName("FK_KENHAP");

                entity.Property(e => e.FkKetoan).HasColumnName("FK_KETOAN");

                entity.Property(e => e.FkKexuat).HasColumnName("FK_KEXUAT");

                entity.Property(e => e.FkKhachhang).HasColumnName("FK_KHACHHANG");

                entity.Property(e => e.FkKhachhangco).HasColumnName("FK_KHACHHANGCO");

                entity.Property(e => e.FkKhonhap).HasColumnName("FK_KHONHAP");

                entity.Property(e => e.FkKhoxuat).HasColumnName("FK_KHOXUAT");

                entity.Property(e => e.FkKmp).HasColumnName("FK_KMP");

                entity.Property(e => e.FkKmpc).HasColumnName("FK_KMPC");

                entity.Property(e => e.FkKttruong).HasColumnName("FK_KTTRUONG");

                entity.Property(e => e.FkLdhh).HasColumnName("FK_LDHH");

                entity.Property(e => e.FkLoaitien).HasColumnName("FK_LOAITIEN");

                entity.Property(e => e.FkLsx).HasColumnName("FK_LSX");

                entity.Property(e => e.FkLsxct).HasColumnName("FK_LSXCT");

                entity.Property(e => e.FkNguoigiao).HasColumnName("FK_NGUOIGIAO");

                entity.Property(e => e.FkNguoilap).HasColumnName("FK_NGUOILAP");

                entity.Property(e => e.FkNguoilh).HasColumnName("FK_NGUOILH");

                entity.Property(e => e.FkNguonvon).HasColumnName("FK_NGUONVON");

                entity.Property(e => e.FkNvkd).HasColumnName("FK_NVKD");

                entity.Property(e => e.FkOrder).HasColumnName("FK_ORDER");

                entity.Property(e => e.FkPhanxuong).HasColumnName("FK_PHANXUONG");

                entity.Property(e => e.FkPhongban).HasColumnName("FK_PHONGBAN");

                entity.Property(e => e.FkPttt).HasColumnName("FK_PTTT");

                entity.Property(e => e.FkQuicach).HasColumnName("FK_QUICACH");

                entity.Property(e => e.FkThukho).HasColumnName("FK_THUKHO");

                entity.Property(e => e.FkThuquy).HasColumnName("FK_THUQUY");

                entity.Property(e => e.FkThutruong).HasColumnName("FK_THUTRUONG");

                entity.Property(e => e.FkTkco)
                    .HasColumnName("FK_TKCO")
                    .HasMaxLength(12);

                entity.Property(e => e.FkTkno)
                    .HasColumnName("FK_TKNO")
                    .HasMaxLength(12);

                entity.Property(e => e.FkTruso).HasColumnName("FK_TRUSO");

                entity.Property(e => e.FkTscd).HasColumnName("FK_TSCD");

                entity.Property(e => e.FkUser).HasColumnName("FK_USER");

                entity.Property(e => e.FkVthh).HasColumnName("FK_VTHH");

                entity.Property(e => e.FkVuviec).HasColumnName("FK_VUVIEC");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .HasColumnType("numeric(19, 0)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
