using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accounting_System.Models
{
    public class CommonTableData
    {
        public CommonTableData()
        {
        }

        public CommonTableData(TSysList currentCatalog, IList<TSysListdetail> catalogListDetail, Dictionary<string, List<object>> tableData, int rowsCount)
        {
            CurrentCatalog = currentCatalog;
            CatalogListDetail = catalogListDetail;
            TableData = tableData;
            RowsCount = rowsCount;
        }
        public TSysList CurrentCatalog { get; set; }
        public IList<TSysListdetail> CatalogListDetail { get; set; }
        public Dictionary<string, List<object>> TableData { get; set; }
        public int RowsCount { get; set; }
    }
}
