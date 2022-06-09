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
        public const string CONNECTION_STRING = "Data Source=NAMCOI\\SQLEXPRESS;Initial Catalog=Cafe1;Integrated Security=True;";
        public const int T_SYS_LIST_ID = 30;
        public enum TableName
        {
            T_DONDATHANG
        }
    }
}
