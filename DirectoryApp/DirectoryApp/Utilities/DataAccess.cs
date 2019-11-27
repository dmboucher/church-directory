using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace DirectoryApp
{
    public static class DataAccess
    {
        public static bool CheckDatabaseConnection()
        {
            try
            {
                using (var connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;"
                    + "Data Source=" + Properties.Settings.Default.DatabaseFilePath + ";"
                    + "Persist Security Info=False;"))
                {
                    connection.Open();
                }
            } 
            catch
            {
                return false;
            }
            return true;
        }
    }
}
