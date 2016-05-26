using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTPFileWatcher.FTP
{
    /// <summary>
    /// Creates an FTP connection and watches a directory for changes to the files there.
    /// </summary>
    public class FTPMonitor
    {
        private FTPConnection connection;

        public FTPMonitor()
        {
            connection = new FTPConnection();
        }

        public string checkFTP()
        {
            string filesInFTP = "";

            filesInFTP = connection.connect();

            return filesInFTP;
        }
    }
}
