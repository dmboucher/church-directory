namespace DirectoryApp
{
    partial class FrmPictureHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPictureHelper));
            this.diaSelectPhoto = new System.Windows.Forms.OpenFileDialog();
            this.pbxPicture = new System.Windows.Forms.PictureBox();
            this.btnSelectPicture = new System.Windows.Forms.Button();
            this.btnSaveNewPicture = new System.Windows.Forms.Button();
            this.lblPictureForFamily = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // diaSelectPhoto
            // 
            this.diaSelectPhoto.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            // 
            // pbxPicture
            // 
            this.pbxPicture.Image = ((System.Drawing.Image)(resources.GetObject("pbxPicture.Image")));
            this.pbxPicture.Location = new System.Drawing.Point(27, 172);
            this.pbxPicture.Name = "pbxPicture";
            this.pbxPicture.Size = new System.Drawing.Size(1144, 753);
            this.pbxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPicture.TabIndex = 0;
            this.pbxPicture.TabStop = false;
            // 
            // btnSelectPicture
            // 
            this.btnSelectPicture.Location = new System.Drawing.Point(27, 24);
            this.btnSelectPicture.Name = "btnSelectPicture";
            this.btnSelectPicture.Size = new System.Drawing.Size(274, 67);
            this.btnSelectPicture.TabIndex = 1;
            this.btnSelectPicture.Text = "Select Picture";
            this.btnSelectPicture.UseVisualStyleBackColor = true;
            this.btnSelectPicture.Click += new System.EventHandler(this.btnSelectPicture_Click);
            // 
            // btnSaveNewPicture
            // 
            this.btnSaveNewPicture.Location = new System.Drawing.Point(339, 24);
            this.btnSaveNewPicture.Name = "btnSaveNewPicture";
            this.btnSaveNewPicture.Size = new System.Drawing.Size(324, 67);
            this.btnSaveNewPicture.TabIndex = 2;
            this.btnSaveNewPicture.Text = "Save New Picture";
            this.btnSaveNewPicture.UseVisualStyleBackColor = true;
            this.btnSaveNewPicture.Visible = false;
            this.btnSaveNewPicture.Click += new System.EventHandler(this.btnSaveNewPicture_Click);
            // 
            // lblPictureForFamily
            // 
            this.lblPictureForFamily.AutoSize = true;
            this.lblPictureForFamily.Location = new System.Drawing.Point(27, 112);
            this.lblPictureForFamily.Name = "lblPictureForFamily";
            this.lblPictureForFamily.Size = new System.Drawing.Size(264, 37);
            this.lblPictureForFamily.TabIndex = 3;
            this.lblPictureForFamily.Text = "Picture for family:";
            // 
            // FrmPictureHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 959);
            this.Controls.Add(this.lblPictureForFamily);
            this.Controls.Add(this.btnSaveNewPicture);
            this.Controls.Add(this.btnSelectPicture);
            this.Controls.Add(this.pbxPicture);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPictureHelper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Helper";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog diaSelectPhoto;
        private System.Windows.Forms.PictureBox pbxPicture;
        private System.Windows.Forms.Button btnSelectPicture;
        private System.Windows.Forms.Button btnSaveNewPicture;
        public System.Windows.Forms.Label lblPictureForFamily;
    }
}