using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryApp
{
    public partial class FrmDatabaseEdit : Form
    {
        private int SelectedDirectoryEntryIndex { get; set; }

        public FrmDatabaseEdit()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SetSelectedDirectoryEntry(SelectedDirectoryEntryIndex - 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SetSelectedDirectoryEntry(SelectedDirectoryEntryIndex + 1);
        }

        private void SetSelectedDirectoryEntry(int selectedDirectoryEntryIndex)
        {
            // Update buttons
            SelectedDirectoryEntryIndex = selectedDirectoryEntryIndex;
            btnBack.Enabled = SelectedDirectoryEntryIndex > 0;
            //btnNext.Enabled = SelectedDirectoryEntryIndex < DirectoryEntries.Count - 1;

            // Update controls
            //txtFirstName.Text = DirectoryEntries[SelectedDirectoryEntryIndex].FirstName;
            //txtLastName.Text = DirectoryEntries[SelectedDirectoryEntryIndex].LastName;
            //txtChildren.Text = DirectoryEntries[SelectedDirectoryEntryIndex].Children;
        }
    }
}
