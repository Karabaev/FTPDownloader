namespace FTPDownloader.BusinessLogicLayer
{
    using System;
    using System.Text;
    using Newtonsoft.Json;
    using System.IO;

    /// <summary>
    /// Хранилище настроек.
    /// </summary>
    public static class SettingsContainer
    {
        private static SettingProps settings;
        private static string defaultLogFileName = "Log.log";
        private static string defaultDataFileName = "Data.json";
        private static string settingsFileName = "Settings.json";
        private static Logger logger;

        static SettingsContainer()
        {
            logger = new Logger(Settings.LogFileName);
            Read();       
        }

        public static SettingProps Settings
        {
            get
            {
                if(settings == null)
                {
                    settings = JsonConvert.DeserializeObject<SettingProps>(Read());
                }
                return settings;
            }
            set
            {
                settings = value;
                Save(JsonConvert.SerializeObject(settings));
            }
        }

        /// <summary>
        /// Записать json в файл.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        private static bool Save(string json)
        {
            using (FileStream stream = new FileStream(settingsFileName, FileMode.OpenOrCreate))
            {
                byte[] array = Encoding.Default.GetBytes(json);

                try
                {
                    stream.Write(array, 0, array.Length);
                }
                catch (IOException ex)
                {
                    logger.WriteLog(ex.Message);
                    return false;
                }

            }
            return true;
        }

        /// <summary>
        /// Читать json из файла.
        /// </summary>
        /// <returns></returns>
        private static string Read()
        {
            FileStream stream = null;
            try
            {
                stream = File.OpenRead(settingsFileName);
                byte[] byteArray = new byte[stream.Length];
                stream.Read(byteArray, 0, byteArray.Length);
                return Encoding.Default.GetString(byteArray);
            }
            catch(FileNotFoundException ex)
            {
                Save(JsonConvert.SerializeObject(new SettingProps { DataFileName = defaultDataFileName, LogFileName = defaultLogFileName }));
                logger.WriteLog(ex.Message);
                return string.Empty;
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }
        }
    }
}
