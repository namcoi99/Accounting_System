using Accounting_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accounting_System.Interfaces
{
    interface IDataAccessService
    {
        IList<TSysCommand> GetUserMenuByLevel(string parent, int level);
    }
}
