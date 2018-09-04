namespace FTPDownloader.PresentationLayer
{
    using System;
    using System.Windows.Forms;
    using DataAccessLayer;
    using BusinessLogicLayer;

    /// <summary>
    /// Главная форма приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Репозитой данных.
        /// </summary>
        private Repository repository;
        /// <summary>
        /// Логгер.
        /// </summary>
        private Logger logger;

        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            logger = new Logger();
            repository = new Repository(logger);
        }

        /// <summary>
        /// Загрузка страницы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.UpdateTable();
        }

        /// <summary>
        /// Клик по пункту меню настроек.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingsMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm setForm = new SettingsForm();
            setForm.Show(this);
        }

        /// <summary>
        /// Клик по кнопке добавить новую запись.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            repository.Add(new FTPAccessData(0, ShopTxt.Text, GLNTxt.Text, LoginTxt.Text, PassTxt.Text, LocalFolderTxt.Text));
            this.UpdateTable();
        }

        /// <summary>
        /// Клик по кнопке применить изменения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApplyChangesBtn_Click(object sender, EventArgs e)
        {
            repository.SaveChanges();
        }

        /// <summary>
        /// Заполнить таблицу обновленными данными.
        /// </summary>
        private void UpdateTable()
        {
            FTPDataAccessTbl.DataSource = repository.AccessDataList;
        }

        /// <summary>
        /// Клик по кнопке удалить запись.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            this.UpdateTable();
        }
    }
}
