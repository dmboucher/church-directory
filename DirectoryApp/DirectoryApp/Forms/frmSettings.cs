using System;
using System.Windows.Forms;

namespace DirectoryApp
{
    public partial class FrmSettings : Form
    {
        private FrmMain ParentMainForm { get; set; }


        public FrmSettings(FrmMain frmMain)
        {
            InitializeComponent();
            ParentMainForm = frmMain;
            SetDatabaseFilePath(Properties.Settings.Default.DatabaseFilePath);
            SetNoPictureFilePath(Properties.Settings.Default.NoPictureFilePath);
            SetPhotosFolder(Properties.Settings.Default.PhotosFolder);
            SetOutputFolder(Properties.Settings.Default.OutputFolder);
        }


        private void txtDatabaseFilePath_Click(object sender, EventArgs e)
        {
            var result = diaDatabaseFilePath.ShowDialog();
            if (result == DialogResult.OK)
            {
                SetDatabaseFilePath(diaDatabaseFilePath.FileName);
                ParentMainForm.LoadGridData();
            }
        }


        private void txtNoPictureFilePath_Click(object sender, EventArgs e)
        {
            var result = diaNoPictureFilePath.ShowDialog();
            if (result == DialogResult.OK)
            {
                SetNoPictureFilePath(diaNoPictureFilePath.FileName);
            }
        }


        private void txtPhotosFolder_Click(object sender, EventArgs e)
        {
            var result = diaPhotosFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                SetPhotosFolder(diaPhotosFolder.SelectedPath);
            }
        }


        private void txtOutputFolder_Click(object sender, EventArgs e)
        {
            var result = diaOutputFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                SetOutputFolder(diaOutputFolder.SelectedPath);
            }
        }


        private void btnTestDatabaseConnection_Click(object sender, EventArgs e)
        {
            if (DataAccess.CheckDatabaseConnection())
            {
                MessageBox.Show("Connection to database is successful!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Unable to connect to database.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnClearDatabaseFilePath_Click(object sender, EventArgs e)
        {
            SetDatabaseFilePath(string.Empty);
            ParentMainForm.LoadGridData();
        }


        private void btnNoPictureFilePath_Click(object sender, EventArgs e)
        {
            SetNoPictureFilePath(string.Empty);
        }


        private void btnClearPhotosFolder_Click(object sender, EventArgs e)
        {
            SetPhotosFolder(string.Empty);
        }


        private void btnClearOutputFolder_Click(object sender, EventArgs e)
        {
            SetOutputFolder(string.Empty);
        }


        private void SetDatabaseFilePath(string filePath)
        {
            txtDatabaseFilePath.Text = filePath;
            diaDatabaseFilePath.FileName = filePath;
            Properties.Settings.Default.DatabaseFilePath = filePath;
            Properties.Settings.Default.Save();
            btnTestDatabaseConnection.Enabled = !string.IsNullOrWhiteSpace(filePath);
        }


        private void SetNoPictureFilePath(string filePath)
        {
            txtNoPictureFilePath.Text = filePath;
            diaDatabaseFilePath.FileName = filePath;
            Properties.Settings.Default.NoPictureFilePath = filePath;
            Properties.Settings.Default.Save();
        }


        private void SetPhotosFolder(string folderPath)
        {
            txtPhotosFolder.Text = folderPath;
            diaPhotosFolder.SelectedPath = folderPath;
            Properties.Settings.Default.PhotosFolder = folderPath;
            Properties.Settings.Default.Save();
        }


        private void SetOutputFolder(string folderPath)
        {
            txtOutputFolder.Text = folderPath;
            diaOutputFolder.SelectedPath = folderPath;
            Properties.Settings.Default.OutputFolder = folderPath;
            Properties.Settings.Default.Save();
        }
    }
}
