namespace DirectoryApp
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.btnClearOutputFolder = new System.Windows.Forms.Button();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.lblOutputFolder = new System.Windows.Forms.Label();
            this.btnClearDatabaseFilePath = new System.Windows.Forms.Button();
            this.btnTestDatabaseConnection = new System.Windows.Forms.Button();
            this.txtDatabaseFilePath = new System.Windows.Forms.TextBox();
            this.lblDatabaseFilePath = new System.Windows.Forms.Label();
            this.diaDatabaseFilePath = new System.Windows.Forms.OpenFileDialog();
            this.diaOutputFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.lblSpacer = new System.Windows.Forms.Label();
            this.btnClearPhotosFolder = new System.Windows.Forms.Button();
            this.txtPhotosFolder = new System.Windows.Forms.TextBox();
            this.lblPhotosFolder = new System.Windows.Forms.Label();
            this.diaPhotosFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnClearOutputFolder
            // 
            this.btnClearOutputFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearOutputFolder.Location = new System.Drawing.Point(692, 322);
            this.btnClearOutputFolder.Name = "btnClearOutputFolder";
            this.btnClearOutputFolder.Size = new System.Drawing.Size(223, 39);
            this.btnClearOutputFolder.TabIndex = 13;
            this.btnClearOutputFolder.Text = "Clear Output Folder";
            this.btnClearOutputFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClearOutputFolder.UseVisualStyleBackColor = true;
            this.btnClearOutputFolder.Click += new System.EventHandler(this.btnClearOutputFolder_Click);
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputFolder.Location = new System.Drawing.Point(194, 283);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(722, 26);
            this.txtOutputFolder.TabIndex = 12;
            this.txtOutputFolder.Click += new System.EventHandler(this.txtOutputFolder_Click);
            // 
            // lblOutputFolder
            // 
            this.lblOutputFolder.AutoSize = true;
            this.lblOutputFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputFolder.Location = new System.Drawing.Point(72, 285);
            this.lblOutputFolder.Name = "lblOutputFolder";
            this.lblOutputFolder.Size = new System.Drawing.Size(107, 20);
            this.lblOutputFolder.TabIndex = 11;
            this.lblOutputFolder.Text = "Output Folder";
            // 
            // btnClearDatabaseFilePath
            // 
            this.btnClearDatabaseFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDatabaseFilePath.Location = new System.Drawing.Point(692, 72);
            this.btnClearDatabaseFilePath.Name = "btnClearDatabaseFilePath";
            this.btnClearDatabaseFilePath.Size = new System.Drawing.Size(223, 39);
            this.btnClearDatabaseFilePath.TabIndex = 10;
            this.btnClearDatabaseFilePath.Text = "Clear Database File Path";
            this.btnClearDatabaseFilePath.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClearDatabaseFilePath.UseVisualStyleBackColor = true;
            this.btnClearDatabaseFilePath.Click += new System.EventHandler(this.btnClearDatabaseFilePath_Click);
            // 
            // btnTestDatabaseConnection
            // 
            this.btnTestDatabaseConnection.Enabled = false;
            this.btnTestDatabaseConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestDatabaseConnection.Location = new System.Drawing.Point(194, 72);
            this.btnTestDatabaseConnection.Name = "btnTestDatabaseConnection";
            this.btnTestDatabaseConnection.Size = new System.Drawing.Size(223, 39);
            this.btnTestDatabaseConnection.TabIndex = 9;
            this.btnTestDatabaseConnection.Text = "Test Database Connection";
            this.btnTestDatabaseConnection.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTestDatabaseConnection.UseVisualStyleBackColor = true;
            this.btnTestDatabaseConnection.Click += new System.EventHandler(this.btnTestDatabaseConnection_Click);
            // 
            // txtDatabaseFilePath
            // 
            this.txtDatabaseFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabaseFilePath.Location = new System.Drawing.Point(194, 37);
            this.txtDatabaseFilePath.Name = "txtDatabaseFilePath";
            this.txtDatabaseFilePath.Size = new System.Drawing.Size(722, 26);
            this.txtDatabaseFilePath.TabIndex = 8;
            this.txtDatabaseFilePath.Click += new System.EventHandler(this.txtDatabaseFilePath_Click);
            // 
            // lblDatabaseFilePath
            // 
            this.lblDatabaseFilePath.AutoSize = true;
            this.lblDatabaseFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabaseFilePath.Location = new System.Drawing.Point(34, 40);
            this.lblDatabaseFilePath.Name = "lblDatabaseFilePath";
            this.lblDatabaseFilePath.Size = new System.Drawing.Size(145, 20);
            this.lblDatabaseFilePath.TabIndex = 7;
            this.lblDatabaseFilePath.Text = "Database File Path";
            // 
            // diaDatabaseFilePath
            // 
            this.diaDatabaseFilePath.FileName = "*.accdb";
            this.diaDatabaseFilePath.Filter = "Microsoft Access Files Only (*.accdb)|*accdb";
            this.diaDatabaseFilePath.Title = "Select a Microsoft Access Database";
            // 
            // lblSpacer
            // 
            this.lblSpacer.AutoSize = true;
            this.lblSpacer.ForeColor = System.Drawing.SystemColors.Info;
            this.lblSpacer.Location = new System.Drawing.Point(952, 373);
            this.lblSpacer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpacer.Name = "lblSpacer";
            this.lblSpacer.Size = new System.Drawing.Size(10, 13);
            this.lblSpacer.TabIndex = 14;
            this.lblSpacer.Text = ".";
            // 
            // btnClearPhotosFolder
            // 
            this.btnClearPhotosFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPhotosFolder.Location = new System.Drawing.Point(692, 198);
            this.btnClearPhotosFolder.Name = "btnClearPhotosFolder";
            this.btnClearPhotosFolder.Size = new System.Drawing.Size(223, 39);
            this.btnClearPhotosFolder.TabIndex = 17;
            this.btnClearPhotosFolder.Text = "Clear Photos Folder";
            this.btnClearPhotosFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClearPhotosFolder.UseVisualStyleBackColor = true;
            this.btnClearPhotosFolder.Click += new System.EventHandler(this.btnClearPhotosFolder_Click);
            // 
            // txtPhotosFolder
            // 
            this.txtPhotosFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhotosFolder.Location = new System.Drawing.Point(194, 160);
            this.txtPhotosFolder.Name = "txtPhotosFolder";
            this.txtPhotosFolder.Size = new System.Drawing.Size(722, 26);
            this.txtPhotosFolder.TabIndex = 16;
            this.txtPhotosFolder.Click += new System.EventHandler(this.txtPhotosFolder_Click);
            // 
            // lblPhotosFolder
            // 
            this.lblPhotosFolder.AutoSize = true;
            this.lblPhotosFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhotosFolder.Location = new System.Drawing.Point(72, 161);
            this.lblPhotosFolder.Name = "lblPhotosFolder";
            this.lblPhotosFolder.Size = new System.Drawing.Size(108, 20);
            this.lblPhotosFolder.TabIndex = 15;
            this.lblPhotosFolder.Text = "Photos Folder";
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(962, 391);
            this.Controls.Add(this.btnClearPhotosFolder);
            this.Controls.Add(this.txtPhotosFolder);
            this.Controls.Add(this.lblPhotosFolder);
            this.Controls.Add(this.lblSpacer);
            this.Controls.Add(this.btnClearOutputFolder);
            this.Controls.Add(this.txtOutputFolder);
            this.Controls.Add(this.lblOutputFolder);
            this.Controls.Add(this.btnClearDatabaseFilePath);
            this.Controls.Add(this.btnTestDatabaseConnection);
            this.Controls.Add(this.txtDatabaseFilePath);
            this.Controls.Add(this.lblDatabaseFilePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmSettings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearOutputFolder;
        public System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Label lblOutputFolder;
        private System.Windows.Forms.Button btnClearDatabaseFilePath;
        public System.Windows.Forms.Button btnTestDatabaseConnection;
        public System.Windows.Forms.TextBox txtDatabaseFilePath;
        private System.Windows.Forms.Label lblDatabaseFilePath;
        public System.Windows.Forms.OpenFileDialog diaDatabaseFilePath;
        public System.Windows.Forms.FolderBrowserDialog diaOutputFolder;
        private System.Windows.Forms.Label lblSpacer;
        private System.Windows.Forms.Button btnClearPhotosFolder;
        public System.Windows.Forms.TextBox txtPhotosFolder;
        private System.Windows.Forms.Label lblPhotosFolder;
        public System.Windows.Forms.FolderBrowserDialog diaPhotosFolder;
    }
}