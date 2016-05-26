using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FTPFileWatcher.FTP
{
    /// <summary>
    /// Creates an FTP connection using credentials stored in the FTPSetup class.
    /// </summary>
    public class FTPConnection
    {
        public FTPSetup info;
        public FtpWebRequest ftpConnection;

        public FTPConnection()
        {
            info = new FTPSetup();
        }

        public string connect()
        {
            //Populates the List of filenames
            List<string> ftpInformation = _getFileList();

            _downloadFiles(ftpInformation);
            _deleteFiles(ftpInformation);

            return ftpInformation.Count.ToString();
        }

        /// <summary>
        /// Scans the directory for all files. Files names are stored in a list and returned.
        /// </summary>
        /// <returns>List of file names</returns>
        private List<string> _getFileList()
        {
            List<string> fileList = new List<string>();

            //Creates connection and sets up FTP Credentials
            ftpConnection = (FtpWebRequest)WebRequest.Create(info.uri);
            ftpConnection.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            ftpConnection.Credentials = new NetworkCredential(info.username, info.password);

            //Creates FTP response
            FtpWebResponse response = (FtpWebResponse)ftpConnection.GetResponse();

            //Sets up response Stream
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            //Builds response string
            while (!reader.EndOfStream)
            {
                fileList.Add(reader.ReadLine());
            }

            reader.Close();
            response.Close();

            return fileList;
        }

        /// <summary>
        /// Downloads files from FTP
        /// </summary>
        private void _downloadFiles(List<string> files)
        {

        }

        /// <summary>
        /// Deletes files that were downloaded from FTP
        /// </summary>
        private void _deleteFiles(List<string> files)
        {


            string filename = "//README.txt";
            ftpConnection = (FtpWebRequest)WebRequest.Create(info.uri + filename);
            ftpConnection.Credentials = new NetworkCredential(info.username, info.password);
            ftpConnection.Method = WebRequestMethods.Ftp.DeleteFile;
            FtpWebResponse response = (FtpWebResponse)ftpConnection.GetResponse();
            response.Close();
        }
    }
}
