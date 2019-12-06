namespace DirectoryApp
{
    partial class FrmPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrint));
            this.lblGenerateDirectoryStatus = new System.Windows.Forms.Label();
            this.btnGenerateDirectoryPages = new System.Windows.Forms.Button();
            this.btnPrintYes = new System.Windows.Forms.Button();
            this.btnPrintNo = new System.Windows.Forms.Button();
            this.lblSpacer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGenerateDirectoryStatus
            // 
            this.lblGenerateDirectoryStatus.AutoSize = true;
            this.lblGenerateDirectoryStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerateDirectoryStatus.Location = new System.Drawing.Point(10, 72);
            this.lblGenerateDirectoryStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenerateDirectoryStatus.Name = "lblGenerateDirectoryStatus";
            this.lblGenerateDirectoryStatus.Size = new System.Drawing.Size(60, 20);
            this.lblGenerateDirectoryStatus.TabIndex = 3;
            this.lblGenerateDirectoryStatus.Text = "Label...";
            this.lblGenerateDirectoryStatus.UseMnemonic = false;
            // 
            // btnGenerateDirectoryPages
            // 
            this.btnGenerateDirectoryPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateDirectoryPages.Location = new System.Drawing.Point(14, 18);
            this.btnGenerateDirectoryPages.Name = "btnGenerateDirectoryPages";
            this.btnGenerateDirectoryPages.Size = new System.Drawing.Size(223, 39);
            this.btnGenerateDirectoryPages.TabIndex = 2;
            this.btnGenerateDirectoryPages.Text = "Generate Directory Pages";
            this.btnGenerateDirectoryPages.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGenerateDirectoryPages.UseVisualStyleBackColor = true;
            this.btnGenerateDirectoryPages.Click += new System.EventHandler(this.btnGenerateDirectoryPages_Click);
            // 
            // btnPrintYes
            // 
            this.btnPrintYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintYes.Location = new System.Drawing.Point(14, 184);
            this.btnPrintYes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrintYes.Name = "btnPrintYes";
            this.btnPrintYes.Size = new System.Drawing.Size(60, 38);
            this.btnPrintYes.TabIndex = 4;
            this.btnPrintYes.Text = "Yes";
            this.btnPrintYes.UseVisualStyleBackColor = true;
            this.btnPrintYes.Visible = false;
            this.btnPrintYes.Click += new System.EventHandler(this.btnPrintYes_Click);
            // 
            // btnPrintNo
            // 
            this.btnPrintNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintNo.Location = new System.Drawing.Point(84, 184);
            this.btnPrintNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrintNo.Name = "btnPrintNo";
            this.btnPrintNo.Size = new System.Drawing.Size(60, 38);
            this.btnPrintNo.TabIndex = 5;
            this.btnPrintNo.Text = "No";
            this.btnPrintNo.UseVisualStyleBackColor = true;
            this.btnPrintNo.Visible = false;
            this.btnPrintNo.Click += new System.EventHandler(this.btnPrintNo_Click);
            // 
            // lblSpacer
            // 
            this.lblSpacer.AutoSize = true;
            this.lblSpacer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSpacer.Location = new System.Drawing.Point(947, 218);
            this.lblSpacer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpacer.Name = "lblSpacer";
            this.lblSpacer.Size = new System.Drawing.Size(10, 13);
            this.lblSpacer.TabIndex = 6;
            this.lblSpacer.Text = ".";
            // 
            // FrmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(962, 241);
            this.Controls.Add(this.lblSpacer);
            this.Controls.Add(this.btnPrintNo);
            this.Controls.Add(this.btnPrintYes);
            this.Controls.Add(this.lblGenerateDirectoryStatus);
            this.Controls.Add(this.btnGenerateDirectoryPages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPrint";
            this.Text = "Print";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblGenerateDirectoryStatus;
        public System.Windows.Forms.Button btnGenerateDirectoryPages;
        private System.Windows.Forms.Button btnPrintYes;
        private System.Windows.Forms.Button btnPrintNo;
        private System.Windows.Forms.Label lblSpacer;
    }
}