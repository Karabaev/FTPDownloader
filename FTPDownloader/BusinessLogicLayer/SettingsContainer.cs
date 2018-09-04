namespace FTPDownloader.BusinessLogicLayer
{
    using System.Text;
    using Newtonsoft.Json;
    using System.IO;

    /// <summary>
    /// Хранилище настроек.
    /// </summary>
    public static class SettingsContainer
    {
        /// <summary>
        /// Настройки.
        /// </summary>
        private static SettingProps settings;
        /// <summary>
        /// Стандартное имя файла логов.
        /// </summary>
        private static string defaultLogFileName = "Log.log";
        /// <summary>
        /// Стандартное имя файла данных.
        /// </summary>
        private static string defaultDataFileName = "Data.json";
        /// <summary>
        /// Стандартное имя файла настроек.
        /// </summary>
        private static string settingsFileName = "Settings.json";
        /// <summary>
        /// Логгер.
        /// </summary>
        private static Logger logger;

        /// <summary>
        /// Инициализирует объект в памяти. Инициализирует логгер, читает настройки из файла.
        /// </summary>
        static SettingsContainer()
        {
            Read();       
        }

        /// <summary>
        /// Инициализирует ссылку на логгер.
        /// </summary>
        /// <param name="_logger">Логгер.</param>
        public static void SettingsInit(Logger _logger)
        {
            logger = _logger;
        }

        /// <summary>
        /// Настройки. Get - читает настройки из файла. Set - записывает настройки в файл.
        /// </summary>
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
        /// <param name="json">Текст в json формате для записи в файл.</param>
        /// <returns></returns>
        private static bool Save(string json)
        {
            try
            {
                using (FileStream stream = new FileStream(settingsFileName, FileMode.OpenOrCreate))
                {
                    byte[] array = Encoding.Default.GetBytes(json);
                    stream.Write(array, 0, array.Length);
                }
                return true;
            }
            catch (IOException ex)
            {
                logger.WriteLog(string.Format("{0}, {1}", ex.StackTrace, ex.Message), LogTypes.ERROR);
                return false;
            }
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
