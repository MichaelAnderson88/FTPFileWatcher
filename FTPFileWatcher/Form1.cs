using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FTPFileWatcher.FTP;
using FTPFileWatcher.SQL;

namespace FTPFileWatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FTPMonitor ftp = new FTPMonitor();
            filesLabel.Text = ftp.checkFTP();
        }

        private void buttonSQLWatcher_Click(object sender, EventArgs e)
        {
            SqlNotificationConsole sql = new SqlNotificationConsole();
            //SQLChangesLabel.Text = sql.sqlChanges;
        }
    }
}
