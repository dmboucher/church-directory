using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DirectoryApp
{
    public partial class FrmPrint : Form
    {
        private string FileName { get; set; }
        private List<DirectoryEntry> DirectoryEntries { get; set; }

        public FrmPrint(List<DirectoryEntry> directoryEntries)
        {
            InitializeComponent();
            DirectoryEntries = directoryEntries;
            btnGenerateDirectoryPages.Enabled = !string.IsNullOrWhiteSpace(Properties.Settings.Default.DatabaseFilePath)
                && !string.IsNullOrWhiteSpace(Properties.Settings.Default.PhotosFolder)
                && !string.IsNullOrWhiteSpace(Properties.Settings.Default.OutputFolder);
            lblGenerateDirectoryStatus.Text = btnGenerateDirectoryPages.Enabled ? string.Empty : "Please be sure all settings have values.";
            btnPrintYes.Visible = false;
            btnPrintNo.Visible = false;
        }

        private void btnGenerateDirectoryPages_Click(object sender, EventArgs e)
        {
            // Generate the file
            FileName = OfficeAutomation.GenerateDirectoryPages(DirectoryEntries, btnGenerateDirectoryPages, lblGenerateDirectoryStatus);

            // Option to open the file
            lblGenerateDirectoryStatus.Text = $"Your file has been created at\r\n{FileName}\r\n "
                + "\r\nWould you like to open the file now?";            
            btnPrintYes.Visible = true;
            btnPrintNo.Visible = true;
        }

        private void btnPrintYes_Click(object sender, EventArgs e)
        {
            var app = new Microsoft.Office.Interop.Word.Application
            {
                Visible = true
            };
            var doc = app.Documents.Open(FileName);
            Close();
            Dispose();
        }

        private void btnPrintNo_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
