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

        public static int CountWordsAndCommas(string inputString)
        {
            if (string.IsNullOrWhiteSpace(inputString)) return 0;

            int c = 0;
            for (int i = 1; i < inputString.Length; i++)
            {
                if (char.IsWhiteSpace(inputString[i - 1]) == true || inputString.Substring(i, 1) == ",")
                {
                    if (char.IsLetterOrDigit(inputString[i]) == true || char.IsPunctuation(inputString[i]))
                    {
                        c++;
                    }
                }
            }
            if (inputString.Length > 2)
            {
                c++;
            }
            return c;
        }
    }
}
