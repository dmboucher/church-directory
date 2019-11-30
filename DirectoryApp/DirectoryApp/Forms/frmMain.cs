using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace DirectoryApp
{
    public partial class FrmMain : Form
    {
        public List<DirectoryEntry> DirectoryEntries { get; set; }

        public FrmMain()
        {
            InitializeComponent();
            DirectoryEntries = DataAccess.GetDirectoryEntries();
            var bindingList = new BindingList<DirectoryEntry>(DirectoryEntries);
            var source = new BindingSource(bindingList, null);
            dgvDirectoryEntries.DataSource = source;
            dgvDirectoryEntries.Columns["ID"].ReadOnly = true;
        }

        private void mnuSettings_Click(object sender, EventArgs e)
        {
            FrmSettings settingsForm = new FrmSettings();
            settingsForm.Show();
        }

        private void mnuPrint_Click(object sender, EventArgs e)
        {
            FrmPrint printForm = new FrmPrint(DirectoryEntries);
            printForm.Show();
        }

        private void dgvDirectoryEntries_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("something changed");
        }
    }
}
