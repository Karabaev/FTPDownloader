namespace FTPDownloader.PresentationLayer
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CloseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataFileTxt = new System.Windows.Forms.TextBox();
            this.LogFileTxt = new System.Windows.Forms.TextBox();
            this.ChangeDataFileBtn = new System.Windows.Forms.Button();
            this.ChangeLogFileBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(399, 86);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data file:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Log file:";
            // 
            // DataFileTxt
            // 
            this.DataFileTxt.Location = new System.Drawing.Point(67, 6);
            this.DataFileTxt.Name = "DataFileTxt";
            this.DataFileTxt.Size = new System.Drawing.Size(312, 20);
            this.DataFileTxt.TabIndex = 3;
            // 
            // LogFileTxt
            // 
            this.LogFileTxt.Location = new System.Drawing.Point(67, 39);
            this.LogFileTxt.Name = "LogFileTxt";
            this.LogFileTxt.Size = new System.Drawing.Size(312, 20);
            this.LogFileTxt.TabIndex = 4;
            // 
            // ChangeDataFileBtn
            // 
            this.ChangeDataFileBtn.Location = new System.Drawing.Point(399, 4);
            this.ChangeDataFileBtn.Name = "ChangeDataFileBtn";
            this.ChangeDataFileBtn.Size = new System.Drawing.Size(75, 23);
            this.ChangeDataFileBtn.TabIndex = 5;
            this.ChangeDataFileBtn.Text = "Change";
            this.ChangeDataFileBtn.UseVisualStyleBackColor = true;
            this.ChangeDataFileBtn.Click += new System.EventHandler(this.ChangeDataFileBtn_Click);
            // 
            // ChangeLogFileBtn
            // 
            this.ChangeLogFileBtn.Location = new System.Drawing.Point(399, 37);
            this.ChangeLogFileBtn.Name = "ChangeLogFileBtn";
            this.ChangeLogFileBtn.Size = new System.Drawing.Size(75, 23);
            this.ChangeLogFileBtn.TabIndex = 6;
            this.ChangeLogFileBtn.Text = "Change";
            this.ChangeLogFileBtn.UseVisualStyleBackColor = true;
            this.ChangeLogFileBtn.Click += new System.EventHandler(this.ChangeLogFileBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 126);
            this.Controls.Add(this.ChangeLogFileBtn);
            this.Controls.Add(this.ChangeDataFileBtn);
            this.Controls.Add(this.LogFileTxt);
            this.Controls.Add(this.DataFileTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseBtn);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DataFileTxt;
        private System.Windows.Forms.TextBox LogFileTxt;
        private System.Windows.Forms.Button ChangeDataFileBtn;
        private System.Windows.Forms.Button ChangeLogFileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}