using Accounting_System.Interfaces;
using Accounting_System.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Accounting_System.Services
{
    public class DataAccessService : IDataAccessService
    {
        private readonly Cafe1Context _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public DataAccessService(Cafe1Context context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }
        public IList<TSysCommand> GetUserMenuByLevel(string parent, int level)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var commandList = _context.TSysCommand
                .Where(command => 
                command.CRead.Contains("," + userId + ",") && 
                command.CMenuparent == parent && 
                command.CMenulevel == level && 
                command.CMenu != "-"
                )
                .ToList();
            return commandList;
        }
    }
}
