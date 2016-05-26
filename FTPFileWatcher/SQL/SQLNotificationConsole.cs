using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace FTPFileWatcher.SQL
{

    class SqlNotificationConsole
    {

        private static SqlDependency dependency;
        private static string connectionString = @"Data Source = vserps60.north49.local; Initial Catalog = TestQueryNotifications; User ID = qn_test; Password = Geadail1";

        public SqlNotificationConsole()
        {
            var connection = new SqlConnection(connectionString);
            SqlDependency.Start(connectionString);
            RefreshDataWithSqlDependency();

            //block main thread - SqlDependency thread will monitor changes
            Console.ReadLine();
            SqlDependency.Stop(connectionString);
        }

        static void RefreshDataWithSqlDependency()
        {
            try
            {
                //Remove existing dependency, if necessary
                if (dependency != null)
                {
                    dependency.OnChange -= onDependencyChange;
                    dependency = null;
                }

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand(
                 "SELECT supplier_id FROM dbo.suppliers",
                 connection);

                // Create a dependency (class member) and associate it with the command.
                dependency = new SqlDependency(command);

                // Subscribe to the SqlDependency event.
                dependency.OnChange += new OnChangeEventHandler(onDependencyChange);

                // start dependency listener
                SqlDependency.Start(connectionString);

                // execute command and refresh data
                refreshData(command);

                connection.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private static void onDependencyChange(Object o, SqlNotificationEventArgs args)
        {
            if ((args.Source.ToString() == "Data") || (args.Source.ToString() == "Timeout"))
            {
                Console.WriteLine("Refreshing data due to {0}", args.Source);
                RefreshDataWithSqlDependency();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Data not refreshed due to unexpected SqlNotificationEventArgs: Source={0}, Info={1}, Type={2}", args.Source, args.Info, args.Type.ToString());
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        private static void refreshData(SqlCommand command)
        {
            var reader = command.ExecuteReader();
            //Console.Clear();
            while (reader.Read())
            {
               // Console.WriteLine("id = {0}, random_text = {1}, dt = {2}", reader[0], reader[1], reader[2]);
            }
            reader.Close();
        }
    }
}
