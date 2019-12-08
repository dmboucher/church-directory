using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryApp
{
    public partial class FrmPrint : Form
    {
        private string FileName { get; set; }
        private List<DirectoryEntry> DirectoryEntries { get; set; }
        private CancellationTokenSource cts { get; set; }

        public FrmPrint(List<DirectoryEntry> directoryEntries)
        {
            InitializeComponent();
            DirectoryEntries = directoryEntries;
            btnGenerateDirectoryPages.Enabled = !string.IsNullOrWhiteSpace(Properties.Settings.Default.DatabaseFilePath)
                && !string.IsNullOrWhiteSpace(Properties.Settings.Default.PhotosFolder)
                && !string.IsNullOrWhiteSpace(Properties.Settings.Default.OutputFolder);
            lblGenerateDirectoryStatus.Text = btnGenerateDirectoryPages.Enabled ? string.Empty : "Please be sure all settings have values.";
            btnCancelOutputCreation.Visible = false;
            btnPrintYes.Visible = false;
            btnPrintNo.Visible = false;
        }

        private async void btnGenerateDirectoryPages_Click(object sender, EventArgs e)
        {
            try
            {
                // Generate the file
                btnCancelOutputCreation.Visible = true;
                btnGenerateDirectoryPages.Enabled = false;
                lblGenerateDirectoryStatus.Visible = true;
                cts = new CancellationTokenSource();
                CancellationToken token = cts.Token;
                FileName = await OfficeAutomation.GenerateDirectoryPages(DirectoryEntries, new Progress<string>(StatusUpdate), token);
                btnCancelOutputCreation.Visible = false;
                btnGenerateDirectoryPages.Enabled = true;

                // Option to open the file
                lblGenerateDirectoryStatus.Text = $"Your file has been created at\r\n{FileName}\r\n "
                    + "\r\nWould you like to open the file now?";
                btnPrintYes.Visible = true;
                btnPrintNo.Visible = true;
            }
            catch
            {
                lblGenerateDirectoryStatus.Text = string.Empty;
                lblGenerateDirectoryStatus.Visible = false;
                btnCancelOutputCreation.Visible = false;
                btnGenerateDirectoryPages.Enabled = true;
            }
        }

        private void btnPrintYes_Click(object sender, EventArgs e)
        {
            var app = new Microsoft.Office.Interop.Word.Application
            {
                Visible = true,
                WindowState = Microsoft.Office.Interop.Word.WdWindowState.wdWindowStateMaximize
            };
            var doc = app.Documents.Open(FileName);
            app.Activate();
            Close();
            Dispose();
        }

        private void btnPrintNo_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void btnCancelOutputCreation_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }

        private void StatusUpdate(string updateMessage)
        {
            lblGenerateDirectoryStatus.Text = updateMessage;
            //Invoke((Action)(() => { lblGenerateDirectoryStatus.Text = updateMessage; }));
        }
    }
}
