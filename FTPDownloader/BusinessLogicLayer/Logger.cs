namespace FTPDownloader.BusinessLogicLayer
{ 
    using System;
    using System.Text;
    using System.IO;
    using System.Windows.Forms;

    


    /// <summary>
    /// Типы логов.
    /// </summary>
    public enum LogTypes
    {
        INFO = 0,
        ERROR,
        WARNING
    }

    /// <summary>
    /// Логгер.
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// Вывести сообщение на экран.
        /// </summary>
        /// <param name="message">Текст сообщения.</param>
        /// <param name="caption">Текст шапки.</param>
        public void ShowMessage(string message, string caption = "")
        {
            MessageBox.Show(message, caption);
        }

        /// <summary>
        /// Записать лог в файл.
        /// </summary>
        /// <param name="log">Текст лога для записи.</param>
        public void WriteLog(string log, LogTypes type = LogTypes.INFO)
        {
            try
            {
                using (FileStream stream = new FileStream(SettingsContainer.Settings.LogFileName, FileMode.Append))
                {
                    StringBuilder fullLog = new StringBuilder();
                    fullLog.AppendFormat("{0}: {1} {2}.\n", DateTime.Now, type, log);
                    byte[] array = Encoding.Default.GetBytes(fullLog.ToString());
                    stream.Write(array, 0, array.Length);
                }
            }
            catch (IOException ex)
            {
                this.ShowMessage(string.Format("{0}: {1}", ex.StackTrace, ex.Message), "Error writing log to file.");
            }
            
        }
    }
}
