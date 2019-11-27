using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryApp
{
    public class Common
    {
        public FrmMain FrmMain { get; set; }

        public Common(FrmMain mainForm)
        {
            FrmMain = mainForm;
        }

        public void SetDatabaseFilePath(string filePath)
        {
            FrmMain.txtDatabaseFilePath.Text = filePath;
            FrmMain.diaDatabaseFilePath.FileName = filePath;
            Properties.Settings.Default.DatabaseFilePath = filePath;
            Properties.Settings.Default.Save();
            FrmMain.btnTestDatabaseConnection.Enabled = !string.IsNullOrWhiteSpace(filePath);
            FrmMain.btnGenerateDirectoryPages.Enabled = !string.IsNullOrWhiteSpace(filePath)
                && !string.IsNullOrWhiteSpace(Properties.Settings.Default.OutputFolder);
            FrmMain.lblGenerateDirectoryStatus.Text = FrmMain.btnGenerateDirectoryPages.Enabled ? "" : "Please complete settings";
        }

        public void SetOutputFolder(string folderPath)
        {
            FrmMain.txtOutputFolder.Text = folderPath;
            FrmMain.diaOutputFolder.SelectedPath = folderPath;
            Properties.Settings.Default.OutputFolder = folderPath;
            Properties.Settings.Default.Save();
            FrmMain.btnGenerateDirectoryPages.Enabled = !string.IsNullOrWhiteSpace(folderPath)
                && !string.IsNullOrWhiteSpace(Properties.Settings.Default.DatabaseFilePath);
            FrmMain.lblGenerateDirectoryStatus.Text = FrmMain.btnGenerateDirectoryPages.Enabled ? "" : "Please complete settings";
        }
    }
}
