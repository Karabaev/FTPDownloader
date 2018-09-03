namespace FTPDownloader.PresentationLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using DataAccessLayer;
    using BusinessLogicLayer;

    public partial class MainForm : Form
    {
        private Repository repository;
        private Logger logger;

        public MainForm()
        {
            InitializeComponent();
           // try
            {
                // logger = new Logger(SettingsContainer.Settings.LogFileName);
                logger = new Logger("Log.log");
            }
           // catch(Exception ex)
            {
            //   MessageBox.Show(ex.StackTrace + " : " + ex.Message);
            }
            
            repository = new Repository(SettingsContainer.Settings.DataFileName, logger);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.UpdateTable();
        }

        private void SettingsMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm setForm = new SettingsForm();
            setForm.Show(this);
        }

        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            repository.Add(new FTPAccessData(0, ShopTxt.Text, GLNTxt.Text, LoginTxt.Text, PassTxt.Text));
            this.UpdateTable();
        }

        private void ApplyChangesBtn_Click(object sender, EventArgs e)
        {
            repository.SaveChanges();
        }

        private void UpdateTable()
        {
            FTPDataAccessTbl.DataSource = repository.AccessDataList;
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            this.UpdateTable();
        }
    }
}
