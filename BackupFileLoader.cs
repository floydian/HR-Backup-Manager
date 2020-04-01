using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HR_Backup_Manager
{
    public static class BackupFileLoader
    {

        public static string LastError = "";

        public static string Load(string path)
        {
            string result = "";
            try
            {
                result = File.ReadAllText(path);
            }
            catch (Exception e)
            {
                LastError = e.Message;
            }
            return result;
        }
    }
}
