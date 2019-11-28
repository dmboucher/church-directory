using System;
using System.Windows.Forms;

namespace DirectoryApp
{
    public partial class FrmMain : Form
    {
        public Common Common { get; set; }

        public FrmMain()
        {
            InitializeComponent();
            Common = new Common(this);
            Common.SetDatabaseFilePath(Properties.Settings.Default.DatabaseFilePath);
            Common.SetOutputFolder(Properties.Settings.Default.OutputFolder);
        }

        private void txtDatabaseFilePath_Click(object sender, EventArgs e)
        {
            var result = diaDatabaseFilePath.ShowDialog();
            if (result == DialogResult.OK)
            {
                Common.SetDatabaseFilePath(diaDatabaseFilePath.FileName);
            }
        }

        private void btnClearDatabaseFilePath_Click(object sender, EventArgs e)
        {
            Common.SetDatabaseFilePath(string.Empty);
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

        private void btnGenerateDirectoryPages_Click(object sender, EventArgs e)
        {
            OfficeAutomation.GenerateDirectoryPages(btnGenerateDirectoryPages, lblGenerateDirectoryStatus);
        }

        private void txtOutputFolder_Click(object sender, EventArgs e)
        {
            var result = diaOutputFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                Common.SetOutputFolder(diaOutputFolder.SelectedPath);
            }
        }

        private void btnClearOutputFolder_Click(object sender, EventArgs e)
        {
            Common.SetOutputFolder(string.Empty);
        }
    }
}
