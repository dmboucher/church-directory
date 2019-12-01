using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

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
                var sql = "SELECT [ID], [LastName], [FirstName], [Address1], [Address2], [City], [State], [Zipcode], "
                    + "[Children], [PhoneWork], [PhoneHome], [PhoneCell], [Email], [Email2], [Email3], [Picture] "
                    + "FROM [Directory] ORDER BY [LastName], [FirstName]";

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


        public static bool InsertDirectoryEntry(DirectoryEntry directoryEntry)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    // Pull max id
                    int maxId;
                    var maxSql = "SELECT MAX([ID]) FROM Directory";
                    using (var maxCommand = new OleDbCommand(maxSql, connection))
                    {
                        maxId = (int)maxCommand.ExecuteScalar();
                        maxCommand.Dispose();
                    }

                    // Insert record
                    var insertSql = "INSERT INTO Directory "
                        + "([ID], [LastName], [FirstName], [Address1], [Address2], [City], [State], [Zipcode], "
                        + "[Children], [PhoneWork], [PhoneHome], [PhoneCell], [Email], [Email2], [Email3], [Picture]) "
                        + "VALUES "
                        + $"({maxId + 1}, '{directoryEntry.LastName}', '{directoryEntry.FirstName}', '{directoryEntry.Address1}', "
                        + $"'{directoryEntry.Address2}', '{directoryEntry.City}', '{directoryEntry.State}', '{directoryEntry.Zipcode}', "
                        + $"'{directoryEntry.Children}', '{directoryEntry.PhoneWork}', '{directoryEntry.PhoneHome}', '{directoryEntry.PhoneCell}', "
                        + $"'{directoryEntry.Email}', '{directoryEntry.Email2}', '{directoryEntry.Email3}', '{directoryEntry.Picture}')";
                    using (var insertCommand = new OleDbCommand(insertSql, connection))
                    {
                        insertCommand.ExecuteNonQuery();
                        insertCommand.Dispose();
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to save.\r\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }


        public static bool UpdateDirectoryEntry(DirectoryEntry directoryEntry)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    // Update record
                    var insertSql = "UPDATE Directory "
                        + $"SET [LastName] = '{directoryEntry.LastName}', [FirstName] = '{directoryEntry.FirstName}', "
                        + $"[Address1] = '{directoryEntry.Address1}', [Address2] = '{directoryEntry.Address2}', "
                        + $"[City] = '{directoryEntry.City}', [State] = '{directoryEntry.State}', "
                        + $"[Zipcode] = '{directoryEntry.Zipcode}', [Children] = '{directoryEntry.Children}', "
                        + $"[PhoneWork] = '{directoryEntry.PhoneWork}', [PhoneHome] = '{directoryEntry.PhoneHome}', "
                        + $"[PhoneCell] = '{directoryEntry.PhoneCell}', [Email] = '{directoryEntry.Email}', "
                        + $"[Email2] = '{directoryEntry.Email2}', [Email3] = '{directoryEntry.Email3}', "
                        + $"[Picture] = '{directoryEntry.Picture}' "
                        + $"WHERE [ID] = {directoryEntry.ID}";
                    using (var insertCommand = new OleDbCommand(insertSql, connection))
                    {
                        insertCommand.ExecuteNonQuery();
                        insertCommand.Dispose();
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to save.\r\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }


        public static bool DeleteDirectoryEntry(int idToDelete)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    // Delete record
                    var insertSql = $"DELETE FROM Directory WHERE [ID] = {idToDelete}";
                    using (var insertCommand = new OleDbCommand(insertSql, connection))
                    {
                        insertCommand.ExecuteNonQuery();
                        insertCommand.Dispose();
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to delete.\r\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }


        public static bool UpdatePicture(int rowId, string fileName)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    // Update record
                    var insertSql = "UPDATE Directory "
                        + $"SET [Picture] = '{fileName}' "
                        + $"WHERE [ID] = {rowId}";
                    using (var insertCommand = new OleDbCommand(insertSql, connection))
                    {
                        insertCommand.ExecuteNonQuery();
                        insertCommand.Dispose();
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to update the picture.\r\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }


        private static OleDbConnection GetConnection()
        {
            return new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;"
                    + "Data Source=" + Properties.Settings.Default.DatabaseFilePath + ";"
                    + "Persist Security Info=False;");
        }
    }
}
