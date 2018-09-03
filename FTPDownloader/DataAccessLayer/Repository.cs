namespace FTPDownloader.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BusinessLogicLayer;
    using Newtonsoft.Json;
    using System.IO;

    public class Repository
    {
        private List<FTPAccessData> accessDataList;
        private string dataFileName;
        private string jsonData;
        private Logger logger;

        public Repository(string dataFileName, Logger logger)
        {
            this.dataFileName = dataFileName;
            this.AccessDataList = new List<FTPAccessData>();
            this.jsonData = string.Empty;
            this.logger = logger;
        }

        public bool Add(FTPAccessData newData)
        {
            if(newData == null)
            {
                return false;
            }

            AccessDataList.Add(newData);
            return true;
        }

        private bool GetAll()
        {
            FileStream stream = null;
            try
            {
                stream = File.OpenRead(dataFileName);
                byte[] byteArray = new byte[stream.Length];
                stream.Read(byteArray, 0, byteArray.Length);
                jsonData = Encoding.Default.GetString(byteArray);
                accessDataList = JsonConvert.DeserializeObject<List<FTPAccessData>>(jsonData);
            }
            catch(FileNotFoundException ex)
            {
                accessDataList = new List<FTPAccessData>();
                SaveChanges();
                logger.WriteLog(ex.Message);

            }
            finally
            {
                if(stream != null)
                {
                    stream.Close();
                }
            }
            return true;
        }

        public bool SaveChanges()
        {
            using (FileStream stream = new FileStream(dataFileName, FileMode.OpenOrCreate))
            {
                jsonData = JsonConvert.SerializeObject(AccessDataList);
                byte[] array = Encoding.Default.GetBytes(jsonData);

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

        public List<FTPAccessData> AccessDataList
        {
            get
            {
                this.GetAll();
                if(this.accessDataList == null)
                {

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
