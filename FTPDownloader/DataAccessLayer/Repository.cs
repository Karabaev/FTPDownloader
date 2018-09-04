namespace FTPDownloader.DataAccessLayer
{
    using System.Collections.Generic;
    using System.Text;
    using BusinessLogicLayer;
    using Newtonsoft.Json;
    using System.IO;

    /// <summary>
    /// Репозиторий данных.
    /// </summary>
    public class Repository
    {
        /// <summary>
        /// Лист данных.
        /// </summary>
        private List<FTPAccessData> accessDataList;
        /// <summary>
        /// json текст.
        /// </summary>
        private string jsonData;
        /// <summary>
        /// Логгер.
        /// </summary>
        private Logger logger;

        /// <summary>
        /// Инициализирует новый объект в памяти.
        /// </summary>
        /// <param name="logger"></param>
        public Repository(Logger logger)
        {
            this.accessDataList = new List<FTPAccessData>();
            this.jsonData = string.Empty;
            this.logger = logger;
        }

        /// <summary>
        /// Добавить в лист новые данные.
        /// </summary>
        /// <param name="newData">Новые данные.</param>
        /// <returns>true, в случае успешной записи иначе false.</returns>
        public bool Add(FTPAccessData newData)
        {
            if(newData == null)
            {
                logger.WriteLog("Error adding record", LogTypes.WARNING);
                return false;
            }

            accessDataList.Add(newData);
            logger.WriteLog("The entry was successfully added to data list");
            return true;
        }

        /// <summary>
        /// Считать все данные из файла.
        /// </summary>
        /// <returns>true, в случае успешной записи иначе false.</returns>
        private List<FTPAccessData> GetData()
        {
            try
            {
                using (FileStream stream = File.OpenRead(SettingsContainer.Settings.DataFileName))
                {
                    List<FTPAccessData> result = null;
                    byte[] byteArray = new byte[stream.Length];
                    stream.Read(byteArray, 0, byteArray.Length);
                    jsonData = Encoding.Default.GetString(byteArray);
                    result = JsonConvert.DeserializeObject<List<FTPAccessData>>(jsonData);
                    logger.WriteLog(string.Format("{0} records are loaded", result.Count));
                    return result;
                }
            }
            catch(IOException ex)
            {
                logger.WriteLog(ex.StackTrace, LogTypes.ERROR);
                logger.WriteLog(ex.Message, LogTypes.ERROR);
                return null;
            }
        }

        /// <summary>
        /// Сохранить данные в файл.
        /// </summary>
        /// <returns>true, в случае успешной записи иначе false.</returns>
        public bool SaveChanges()
        {
            try
            {
                using (FileStream stream = new FileStream(SettingsContainer.Settings.DataFileName, FileMode.OpenOrCreate))
                {
                    jsonData = JsonConvert.SerializeObject(accessDataList);
                    byte[] array = Encoding.Default.GetBytes(jsonData);
                    stream.Write(array, 0, array.Length);
                    logger.WriteLog(string.Format("All data was saved."));
                    return true;
                }
            }
            catch(IOException ex)
            {
                logger.WriteLog(ex.StackTrace, LogTypes.ERROR);
                logger.WriteLog(ex.Message, LogTypes.ERROR);
                return false;
            }
        }

        /// <summary>
        /// Лист данных. Get - Читает данные из файла, если файл не найден, то созадет его.
        /// </summary>
        public List<FTPAccessData> AccessDataList
        {
            get
            {
                this.accessDataList = this.GetData();

                if(this.accessDataList == null)
                {
                    this.accessDataList = new List<FTPAccessData>();
                    this.SaveChanges();
                }

                return this.accessDataList;
            }
            private set
            {
                this.accessDataList = value;
            }
        }
    }
}
