using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryApp
{
    public partial class FrmPictureHelper : Form
    {
        private FrmMain ParentMainForm { get; set; }
        private int RowId { get; set; }
        private string RecordName { get; set; }
        private string PictureValue { get; set; }
        private string NewFileName { get; set; }


        public FrmPictureHelper(FrmMain frmMain, int rowId, string recordName, string pictureValue)
        {
            InitializeComponent();
            ParentMainForm = frmMain;
            RowId = rowId;
            RecordName = recordName;
            PictureValue = pictureValue;

            // Load image
            if (!string.IsNullOrWhiteSpace(PictureValue) 
                && File.Exists(Properties.Settings.Default.PhotosFolder + "\\" + PictureValue))
            {
                pbxPicture.ImageLocation = Properties.Settings.Default.PhotosFolder + "\\" + PictureValue;
                btnSelectPicture.Text = "Change Picture";
            }

            // Set label
            if (!string.IsNullOrWhiteSpace(RecordName))
            {
                lblPictureForFamily.Text = $"Picture for the {RecordName} family:";
            }
        }


        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            diaSelectPhoto.InitialDirectory = Properties.Settings.Default.PhotosFolder;
            if (diaSelectPhoto.ShowDialog() == DialogResult.OK)
            {
                while (Path.GetDirectoryName(diaSelectPhoto.FileName) != Properties.Settings.Default.PhotosFolder)
                {
                    // Confirmation that it is in the proper folder
                    MessageBox.Show("Please only select a photo that is in your Photos Folder (from Settings):\r\n"
                        + $"{Properties.Settings.Default.PhotosFolder}", "Wrong folder", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    diaSelectPhoto.InitialDirectory = Properties.Settings.Default.PhotosFolder;
                    diaSelectPhoto.ShowDialog();
                }

                // We're good to go
                NewFileName = diaSelectPhoto.SafeFileName;
                if (PictureValue == NewFileName)
                {
                    btnSaveNewPicture.Visible = false;
                }
                else
                {
                    pbxPicture.ImageLocation = Properties.Settings.Default.PhotosFolder + "\\" + NewFileName;
                    btnSelectPicture.Text = "Change Picture";
                    btnSaveNewPicture.Visible = true;
                }
            }
        }


        private void btnSaveNewPicture_Click(object sender, EventArgs e)
        {
            // Confirm delete
            var dialogResult = MessageBox.Show("Are you sure you want to save this picture?",
                "Confirm Picture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                ParentMainForm.UpdatePicture(RowId, NewFileName);
                Close();
                Dispose();
            }
        }
    }
}
