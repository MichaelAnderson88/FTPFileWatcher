using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTPFileWatcher.FTP
{
    /// <summary>
    /// Reads FTP credentials from an XML file and stores them to be used to create a FTP connection.
    /// </summary>
    public class FTPSetup
    {

        public Uri uri;
        public string username;
        public string password;

        public FTPSetup()
        {
            uri = new Uri("ftp://localhost");
            username = "Mike";
            password = "12345";
        }
    }
}
