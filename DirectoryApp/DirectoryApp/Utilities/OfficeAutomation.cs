using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Microsoft.Office.Interop.Word;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DirectoryApp
{
    public static class OfficeAutomation
    {
        public static void GenerateDirectoryPages(Button btnGenerateDirectoryPages, Label lblGenerateDirectoryStatus)
        {
            Microsoft.Office.Interop.Word.Application application = null;
            try
            {
                btnGenerateDirectoryPages.Enabled = false;
                lblGenerateDirectoryStatus.Text = "Processing...";

                application = new Microsoft.Office.Interop.Word.Application();
                var document = application.Documents.Add();
                var paragraph = document.Paragraphs.Add();
                paragraph.Range.Text = "some text";

                string fileName = $"{Properties.Settings.Default.OutputFolder}\\DirectoryBody_{DateTime.Now:yyyyMMddHHmmss}.docx";
                application.ActiveDocument.SaveAs(fileName, WdSaveFormat.wdFormatDocumentDefault);
                document.Close();
                MessageBox.Show($"Your file has been created at {fileName}", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (application != null)
                {
                    application.Quit();
                    Marshal.FinalReleaseComObject(application);

                    lblGenerateDirectoryStatus.Text = string.Empty;
                    btnGenerateDirectoryPages.Enabled = true;
                }
            }
        }
    }
}
