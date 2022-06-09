using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accounting_System.Helpers
{
    public class Utils
    {
        public static string GetPageName(string menuCommand)
        {
            switch (menuCommand)
            {
                case "FDM":
                    return Constants.FDM;
                case "FKH":
                    return Constants.FKH;
                case "FGDH2":
                    return Constants.FGDH2;
                default:
                    return "";
            }
        }
    }
}
