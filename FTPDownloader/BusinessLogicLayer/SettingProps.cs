namespace FTPDownloader.BusinessLogicLayer
{
    /// <summary>
    /// Хранилище настроек.
    /// </summary>
    public class SettingProps
    {
        /// <summary>
        /// Полное имя файла, хранящего информацию о магазинах.
        /// </summary>
        public string DataFileName { get; set; }
        /// <summary>
        /// Полное имя файла, хранящего логи.
        /// </summary>
        public string LogFileName { get; set; }
    }
}
