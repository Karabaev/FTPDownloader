using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FTPDownloader.BusinessLogicLayer
{
    public class Logger
    {
        private string logFileName;

        public Logger(string logFileName)
        {
            this.logFileName = logFileName;   
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void WriteLog(string log)
        {
            using (FileStream stream = new FileStream(logFileName, FileMode.OpenOrCreate))
            {
                StringBuilder fullLog = new StringBuilder();
                fullLog.AppendFormat("{0}: {1}.\n", DateTime.Now, log);
                byte[] array = Encoding.Default.GetBytes(fullLog.ToString());

                try
                {
                    stream.Write(array, 0, array.Length);
                }
                catch(IOException ex)
                {
                    throw new IOException();
                }
                this.ShowMessage(log);
            }
        }
    }
}
