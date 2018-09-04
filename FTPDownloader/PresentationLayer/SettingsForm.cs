using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTPDownloader.PresentationLayer
{
    using BusinessLogicLayer;

    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            DataFileTxt.Text = SettingsContainer.Settings.DataFileName;
            LogFileTxt.Text = SettingsContainer.Settings.LogFileName;
        }

        /// <summary>
        /// Нажатие на кнопку изменить файл данных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeDataFileBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SettingsContainer.Settings.DataFileName = openFileDialog1.FileName;
                DataFileTxt.Text = SettingsContainer.Settings.DataFileName;
            }
        }

        /// <summary>
        /// Нажатие на кнопку изменить файл логов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeLogFileBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SettingsContainer.Settings.LogFileName = openFileDialog1.FileName;
                LogFileTxt.Text = SettingsContainer.Settings.LogFileName;
            }
        }

        /// <summary>
        /// Нажатие на кнопку закрыть.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            SettingsContainer.Settings.DataFileName = DataFileTxt.Text;
            SettingsContainer.Settings.LogFileName = LogFileTxt.Text;
            this.Close();
        }
    }
}
