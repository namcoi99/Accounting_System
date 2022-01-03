using Accounting_System.Interfaces;
using Accounting_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accounting_System.Services
{
    public class DataAccessService : IDataAccessService
    {
        private readonly Cafe1Context _context;
        public DataAccessService(Cafe1Context context)
        {
            _context = context;
        }
        public IList<TSysCommand> GetUserMenuByLevel(string parent, int level)
        {
            var commandList = _context.TSysCommand
                .Where(command => command.CMenuparent == parent && command.CMenulevel == level && command.CMenu != "-")
                .ToList();
            return commandList;
        }
    }
}
