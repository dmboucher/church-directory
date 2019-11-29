using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;

namespace DirectoryApp
{
    public static class DataAccess
    {
        public static bool CheckDatabaseConnection()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    connection.Close();
                }
            } 
            catch
            {
                return false;
            }
            return true;
        }


        public static List<DirectoryEntry> GetDirectoryEntries()
        {
            var directoryEntries = new List<DirectoryEntry>();

            using (var connection = GetConnection())
            {
                // Set query
                var sql = "SELECT ID, LastName, FirstName, Address1, Address2, City, State, Zipcode, "
                    + "Children, PhoneWork, PhoneHome, PhoneCell, Email, Email2, Email3, Picture "
                    + "FROM Directory ORDER BY LastName, FirstName";

                // Pull data
                using (var command = new OleDbDataAdapter(sql, connection))
                {
                    connection.Open();
                    var dataSet = new DataSet();
                    command.Fill(dataSet, "Directory");

                    // Convert to a strongly typed list of model objects
                    directoryEntries =
                          (from row in dataSet.Tables["Directory"].AsEnumerable()
                           select new DirectoryEntry
                           {
                               ID = row.Field<int>("ID"),
                               LastName = row.Field<string>("LastName"),
                               FirstName = row.Field<string>("FirstName"),
                               Address1 = row.Field<string>("Address1"),
                               Address2 = row.Field<string>("Address2"),
                               City = row.Field<string>("City"),
                               State = row.Field<string>("State"),
                               Zipcode = row.Field<string>("Zipcode"),
                               Children = row.Field<string>("Children"),
                               PhoneWork = row.Field<string>("PhoneWork"),
                               PhoneHome = row.Field<string>("PhoneHome"),
                               PhoneCell = row.Field<string>("PhoneCell"),
                               Email = row.Field<string>("Email"),
                               Email2 = row.Field<string>("Email2"),
                               Email3 = row.Field<string>("Email3"),
                               Picture = row.Field<string>("Picture")
                           }).ToList();
                    command.Dispose();
                }
                connection.Close();
            }

            // Return the data
            return directoryEntries;
        }


        private static OleDbConnection GetConnection()
        {
            return new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;"
                    + "Data Source=" + Properties.Settings.Default.DatabaseFilePath + ";"
                    + "Persist Security Info=False;");
        }
    }
}
