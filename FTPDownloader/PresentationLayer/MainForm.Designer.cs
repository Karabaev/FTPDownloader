namespace FTPDownloader.PresentationLayer
{
    partial class MainForm
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
            this.FTPDataAccessTbl = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.ShopTxt = new System.Windows.Forms.TextBox();
            this.GLNTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddNewBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.ApplyChangesBtn = new System.Windows.Forms.Button();
            this.LocalFolderTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FTPDataAccessTbl)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FTPDataAccessTbl
            // 
            this.FTPDataAccessTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FTPDataAccessTbl.Location = new System.Drawing.Point(12, 27);
            this.FTPDataAccessTbl.Name = "FTPDataAccessTbl";
            this.FTPDataAccessTbl.Size = new System.Drawing.Size(503, 411);
            this.FTPDataAccessTbl.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.Size = new System.Drawing.Size(61, 20);
            this.SettingsMenuItem.Text = "Settings";
            this.SettingsMenuItem.Click += new System.EventHandler(this.SettingsMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shop";
            // 
            // ShopTxt
            // 
            this.ShopTxt.Location = new System.Drawing.Point(525, 45);
            this.ShopTxt.Name = "ShopTxt";
            this.ShopTxt.Size = new System.Drawing.Size(263, 20);
            this.ShopTxt.TabIndex = 3;
            // 
            // GLNTxt
            // 
            this.GLNTxt.Location = new System.Drawing.Point(525, 85);
            this.GLNTxt.Name = "GLNTxt";
            this.GLNTxt.Size = new System.Drawing.Size(263, 20);
            this.GLNTxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "GLN";
            // 
            // LoginTxt
            // 
            this.LoginTxt.Location = new System.Drawing.Point(525, 131);
            this.LoginTxt.Name = "LoginTxt";
            this.LoginTxt.Size = new System.Drawing.Size(263, 20);
            this.LoginTxt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "FTP login";
            // 
            // PassTxt
            // 
            this.PassTxt.Location = new System.Drawing.Point(525, 171);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(263, 20);
            this.PassTxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "FTP password";
            // 
            // AddNewBtn
            // 
            this.AddNewBtn.Location = new System.Drawing.Point(713, 237);
            this.AddNewBtn.Name = "AddNewBtn";
            this.AddNewBtn.Size = new System.Drawing.Size(75, 23);
            this.AddNewBtn.TabIndex = 12;
            this.AddNewBtn.Text = "Add new";
            this.AddNewBtn.UseVisualStyleBackColor = true;
            this.AddNewBtn.Click += new System.EventHandler(this.AddNewBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(521, 400);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(90, 38);
            this.RemoveBtn.TabIndex = 13;
            this.RemoveBtn.Text = "Remove selected";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // ApplyChangesBtn
            // 
            this.ApplyChangesBtn.Location = new System.Drawing.Point(606, 292);
            this.ApplyChangesBtn.Name = "ApplyChangesBtn";
            this.ApplyChangesBtn.Size = new System.Drawing.Size(97, 40);
            this.ApplyChangesBtn.TabIndex = 14;
            this.ApplyChangesBtn.Text = "Apply changes";
            this.ApplyChangesBtn.UseVisualStyleBackColor = true;
            this.ApplyChangesBtn.Click += new System.EventHandler(this.ApplyChangesBtn_Click);
            // 
            // LocalFolderTxt
            // 
            this.LocalFolderTxt.Location = new System.Drawing.Point(525, 211);
            this.LocalFolderTxt.Name = "LocalFolderTxt";
            this.LocalFolderTxt.Size = new System.Drawing.Size(263, 20);
            this.LocalFolderTxt.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Local folder";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LocalFolderTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ApplyChangesBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.AddNewBtn);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LoginTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GLNTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShopTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FTPDataAccessTbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "General";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FTPDataAccessTbl)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FTPDataAccessTbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ShopTxt;
        private System.Windows.Forms.TextBox GLNTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddNewBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button ApplyChangesBtn;
        private System.Windows.Forms.TextBox LocalFolderTxt;
        private System.Windows.Forms.Label label5;
    }
}