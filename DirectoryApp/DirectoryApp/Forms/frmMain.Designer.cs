namespace DirectoryApp
{
    partial class FrmMain
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.btnClearOutputFolder = new System.Windows.Forms.Button();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.lblOutputFolder = new System.Windows.Forms.Label();
            this.btnClearDatabaseFilePath = new System.Windows.Forms.Button();
            this.btnTestDatabaseConnection = new System.Windows.Forms.Button();
            this.txtDatabaseFilePath = new System.Windows.Forms.TextBox();
            this.lblDatabaseFilePath = new System.Windows.Forms.Label();
            this.tabDatabase = new System.Windows.Forms.TabPage();
            this.tabPrint = new System.Windows.Forms.TabPage();
            this.lblGenerateDirectoryStatus = new System.Windows.Forms.Label();
            this.btnGenerateDirectoryPages = new System.Windows.Forms.Button();
            this.diaDatabaseFilePath = new System.Windows.Forms.OpenFileDialog();
            this.diaOutputFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.tabMain.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabSettings);
            this.tabMain.Controls.Add(this.tabDatabase);
            this.tabMain.Controls.Add(this.tabPrint);
            this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(13, 13);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(775, 425);
            this.tabMain.TabIndex = 0;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.btnClearOutputFolder);
            this.tabSettings.Controls.Add(this.txtOutputFolder);
            this.tabSettings.Controls.Add(this.lblOutputFolder);
            this.tabSettings.Controls.Add(this.btnClearDatabaseFilePath);
            this.tabSettings.Controls.Add(this.btnTestDatabaseConnection);
            this.tabSettings.Controls.Add(this.txtDatabaseFilePath);
            this.tabSettings.Controls.Add(this.lblDatabaseFilePath);
            this.tabSettings.Location = new System.Drawing.Point(4, 29);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabSettings.Size = new System.Drawing.Size(767, 392);
            this.tabSettings.TabIndex = 0;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // btnClearOutputFolder
            // 
            this.btnClearOutputFolder.Location = new System.Drawing.Point(515, 195);
            this.btnClearOutputFolder.Name = "btnClearOutputFolder";
            this.btnClearOutputFolder.Size = new System.Drawing.Size(223, 39);
            this.btnClearOutputFolder.TabIndex = 6;
            this.btnClearOutputFolder.Text = "Clear Output Folder";
            this.btnClearOutputFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClearOutputFolder.UseVisualStyleBackColor = true;
            this.btnClearOutputFolder.Click += new System.EventHandler(this.btnClearOutputFolder_Click);
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(177, 149);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(563, 26);
            this.txtOutputFolder.TabIndex = 5;
            this.txtOutputFolder.Click += new System.EventHandler(this.txtOutputFolder_Click);
            // 
            // lblOutputFolder
            // 
            this.lblOutputFolder.AutoSize = true;
            this.lblOutputFolder.Location = new System.Drawing.Point(54, 151);
            this.lblOutputFolder.Name = "lblOutputFolder";
            this.lblOutputFolder.Size = new System.Drawing.Size(107, 20);
            this.lblOutputFolder.TabIndex = 4;
            this.lblOutputFolder.Text = "Output Folder";
            // 
            // btnClearDatabaseFilePath
            // 
            this.btnClearDatabaseFilePath.Location = new System.Drawing.Point(515, 62);
            this.btnClearDatabaseFilePath.Name = "btnClearDatabaseFilePath";
            this.btnClearDatabaseFilePath.Size = new System.Drawing.Size(223, 39);
            this.btnClearDatabaseFilePath.TabIndex = 3;
            this.btnClearDatabaseFilePath.Text = "Clear Database File Path";
            this.btnClearDatabaseFilePath.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClearDatabaseFilePath.UseVisualStyleBackColor = true;
            this.btnClearDatabaseFilePath.Click += new System.EventHandler(this.btnClearDatabaseFilePath_Click);
            // 
            // btnTestDatabaseConnection
            // 
            this.btnTestDatabaseConnection.Enabled = false;
            this.btnTestDatabaseConnection.Location = new System.Drawing.Point(177, 62);
            this.btnTestDatabaseConnection.Name = "btnTestDatabaseConnection";
            this.btnTestDatabaseConnection.Size = new System.Drawing.Size(223, 39);
            this.btnTestDatabaseConnection.TabIndex = 2;
            this.btnTestDatabaseConnection.Text = "Test Database Connection";
            this.btnTestDatabaseConnection.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTestDatabaseConnection.UseVisualStyleBackColor = true;
            this.btnTestDatabaseConnection.Click += new System.EventHandler(this.btnTestDatabaseConnection_Click);
            // 
            // txtDatabaseFilePath
            // 
            this.txtDatabaseFilePath.Location = new System.Drawing.Point(177, 18);
            this.txtDatabaseFilePath.Name = "txtDatabaseFilePath";
            this.txtDatabaseFilePath.Size = new System.Drawing.Size(563, 26);
            this.txtDatabaseFilePath.TabIndex = 1;
            this.txtDatabaseFilePath.Click += new System.EventHandler(this.txtDatabaseFilePath_Click);
            // 
            // lblDatabaseFilePath
            // 
            this.lblDatabaseFilePath.AutoSize = true;
            this.lblDatabaseFilePath.Location = new System.Drawing.Point(17, 21);
            this.lblDatabaseFilePath.Name = "lblDatabaseFilePath";
            this.lblDatabaseFilePath.Size = new System.Drawing.Size(145, 20);
            this.lblDatabaseFilePath.TabIndex = 0;
            this.lblDatabaseFilePath.Text = "Database File Path";
            // 
            // tabDatabase
            // 
            this.tabDatabase.Location = new System.Drawing.Point(4, 29);
            this.tabDatabase.Name = "tabDatabase";
            this.tabDatabase.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabDatabase.Size = new System.Drawing.Size(767, 392);
            this.tabDatabase.TabIndex = 1;
            this.tabDatabase.Text = "Database";
            this.tabDatabase.UseVisualStyleBackColor = true;
            // 
            // tabPrint
            // 
            this.tabPrint.Controls.Add(this.lblGenerateDirectoryStatus);
            this.tabPrint.Controls.Add(this.btnGenerateDirectoryPages);
            this.tabPrint.Location = new System.Drawing.Point(4, 29);
            this.tabPrint.Name = "tabPrint";
            this.tabPrint.Size = new System.Drawing.Size(767, 392);
            this.tabPrint.TabIndex = 2;
            this.tabPrint.Text = "Print";
            this.tabPrint.UseVisualStyleBackColor = true;
            // 
            // lblGenerateDirectoryStatus
            // 
            this.lblGenerateDirectoryStatus.AutoSize = true;
            this.lblGenerateDirectoryStatus.Location = new System.Drawing.Point(256, 29);
            this.lblGenerateDirectoryStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenerateDirectoryStatus.Name = "lblGenerateDirectoryStatus";
            this.lblGenerateDirectoryStatus.Size = new System.Drawing.Size(60, 20);
            this.lblGenerateDirectoryStatus.TabIndex = 1;
            this.lblGenerateDirectoryStatus.Text = "Label...";
            this.lblGenerateDirectoryStatus.UseMnemonic = false;
            // 
            // btnGenerateDirectoryPages
            // 
            this.btnGenerateDirectoryPages.Location = new System.Drawing.Point(20, 19);
            this.btnGenerateDirectoryPages.Name = "btnGenerateDirectoryPages";
            this.btnGenerateDirectoryPages.Size = new System.Drawing.Size(223, 39);
            this.btnGenerateDirectoryPages.TabIndex = 0;
            this.btnGenerateDirectoryPages.Text = "Generate Directory Pages";
            this.btnGenerateDirectoryPages.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGenerateDirectoryPages.UseVisualStyleBackColor = true;
            this.btnGenerateDirectoryPages.Click += new System.EventHandler(this.btnGenerateDirectoryPages_Click);
            // 
            // diaDatabaseFilePath
            // 
            this.diaDatabaseFilePath.FileName = "*.accdb";
            this.diaDatabaseFilePath.Filter = "Microsoft Access Files Only (*.accdb)|*accdb";
            this.diaDatabaseFilePath.Title = "Select a Microsoft Access Database";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabMain);
            this.Name = "FrmMain";
            this.Text = "Directory App";
            this.tabMain.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tabPrint.ResumeLayout(false);
            this.tabPrint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Label lblDatabaseFilePath;
        private System.Windows.Forms.TabPage tabDatabase;
        private System.Windows.Forms.TabPage tabPrint;
        public System.Windows.Forms.TextBox txtDatabaseFilePath;
        public System.Windows.Forms.OpenFileDialog diaDatabaseFilePath;
        public System.Windows.Forms.Button btnTestDatabaseConnection;
        private System.Windows.Forms.Button btnClearDatabaseFilePath;
        public System.Windows.Forms.Button btnGenerateDirectoryPages;
        public System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Label lblOutputFolder;
        public System.Windows.Forms.FolderBrowserDialog diaOutputFolder;
        private System.Windows.Forms.Button btnClearOutputFolder;
        public System.Windows.Forms.Label lblGenerateDirectoryStatus;
    }
}

