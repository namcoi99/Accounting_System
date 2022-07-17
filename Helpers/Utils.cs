using System;
using System.Collections.Generic;
using System.IO;
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
                case "FXN":
                    return Constants.FXN;
                case "FREP":
                    return Constants.FREP;
                case "FDUBAO":
                    return Constants.FDUBAO;
                default:
                    return "";
            }
        }
        public static FileInfo GetCleanFileInfo(string file)
        {
            var fi = new FileInfo(file);
            if (fi.Exists)
            {
                fi.Delete();  // ensures we create a new workbook
            }
            return fi;
        }
    }
}
