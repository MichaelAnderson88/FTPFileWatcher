using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTPFileWatcher.SQL
{
    /// <summary>
    /// Creates a connection and dependancy onto a database.
    /// </summary>
    public class SQLWatcher
    {
        private static SqlDependency dependency;
        public string sqlChanges = "";

        public SQLWatcher()
        {
            string connectionString = "Data Source = vserps60.north49.local; Initial Catalog = TestQueryNotifications; User ID = qn_test; Password = Geadail1";
            string query = "SELECT PersonID FROM dbo.Persons";

            if (dependency != null)
            {
                dependency.OnChange -= OnChange;
                dependency = null;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                //cmd.CommandType = System.Data.CommandType.Text;

                
                /*
                List<string> aa = new List<string>();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string a = reader["ICItemNo"].ToString();
                        aa.Add(a);
                    }
                }
                MessageBox.Show(aa[0]);
                */
                cmd.Notification = null;
                dependency = new SqlDependency(cmd, null, 60);
                dependency.OnChange += new OnChangeEventHandler(OnChange);
                SqlDependency.Start(connectionString);

                //cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
        
        }

        void OnChange(object sender, SqlNotificationEventArgs e)
        {
            sqlChanges = "yes";
        }
    }
}
