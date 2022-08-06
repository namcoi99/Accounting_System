using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accounting_System
{
    public class Constants
    {
        public const string FDM = "CatalogPage";
        public const string FKH = "CustomerPage";
        public const string FGDH2 = "SalesOrderPage";
        public const string FXN = "UpdateDocumentPage";
        public const string FREP = "ReportPage";
        public const string FDUBAO = "OrderForcastPage";
        public const int T_SYS_LIST_ID = 30;
        public const int PHIEU_NHAP_HANG_HOA_ID = 167;
        public const int PHIEU_XUAT_BAN_HANG_ID = 425;
        public enum LoaiBT
        {
            BTTT = 1,           // Bút toán thông thường
            BTT = 2,           // Bút toán thuế
            BTKC = 3,           // Bút toán kết chuyển
            BTCP = 4,           // Bút toán chi phí mua/bán hàng
            BTXN = 5,           // Bút toán thuế xuất/nhập khẩu
            BTGV = 6,           // Bút toán giá vốn
            BTKH = 7,           // Bút toán khấu hao TSCĐ tự động
        }
    }
}
