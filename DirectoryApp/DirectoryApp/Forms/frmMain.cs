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
            LoadGridData();
            ResizeGrid();
        }


        public void LoadGridData()
        {
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.DatabaseFilePath))
            {
                DirectoryEntries = new List<DirectoryEntry>();
                lblGridStatus.Text = "Please go to settings and identify the path to the database.";
            }
            else
            {
                DirectoryEntries = DataAccess.GetDirectoryEntries();
                lblGridStatus.Text = "Edit in the grid below. "
                    + "Use the bottom row to Add. Right-click to Delete.";
            }
            var bindingList = new BindingList<DirectoryEntry>(DirectoryEntries);
            var source = new BindingSource(bindingList, null);
            dgvDirectoryEntries.DataSource = source;
            dgvDirectoryEntries.Columns["ID"].ReadOnly = true;
            dgvDirectoryEntries.Columns["Picture"].ReadOnly = true;
        }


        public void UpdatePicture(int rowId, string fileName)
        {
            var success = DataAccess.UpdatePicture(rowId, fileName);
            if (success)
            {
                LoadGridData();
            }
        }


        private void mnuSettings_Click(object sender, EventArgs e)
        {
            FrmSettings settingsForm = new FrmSettings(this);
            settingsForm.Show();
        }


        private void mnuPrint_Click(object sender, EventArgs e)
        {
            FrmPrint printForm = new FrmPrint(DirectoryEntries);
            printForm.Show();
        }


        private void dgvDirectoryEntries_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            bool success;
            if (DirectoryEntries[e.RowIndex].ID == 0)
            {
                success = DataAccess.InsertDirectoryEntry(DirectoryEntries[e.RowIndex]);
                LoadGridData();
            }
            else
            {
                success = DataAccess.UpdateDirectoryEntry(DirectoryEntries[e.RowIndex]);
            }

            if (success)
            {
                ShowSaveSuccessLabel();
            }
        }


        private void ShowSaveSuccessLabel()
        {
            var t = new Timer
            {
                Interval = 2000 // it will Tick in 3 seconds
            };
            t.Tick += (s, e) =>
            {
                lblSaveStatus.Visible = false;
                t.Stop();
                t.Dispose();
            };
            t.Start();
            lblSaveStatus.Visible = true;
        }


        private void FrmMain_SizeChanged(object sender, EventArgs e)
        {
            ResizeGrid();
        }


        private void ResizeGrid()
        {
            dgvDirectoryEntries.Left = 25;
            dgvDirectoryEntries.Top = 75;
            dgvDirectoryEntries.Width = Width - 75;
            dgvDirectoryEntries.Height = Height - 150;
            lblSaveStatus.Left = Width - 110;
        }

        

        private void dgvDirectoryEntries_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowSelectedIndex = e.RowIndex;
            int columnSelectedIndex = e.ColumnIndex;

            // Handler for right-click context menu
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1)
                {
                    dgvDirectoryEntries.ClearSelection();
                    dgvDirectoryEntries.Rows[rowSelectedIndex].Selected = true;
                }
            }
            else
            {
                // Handler for picture helper - only check for this if not right-click
                if (dgvDirectoryEntries.Columns[columnSelectedIndex].HeaderText.ToLowerInvariant() == "picture")
                {
                    var pictureHelperForm = new FrmPictureHelper(this, DirectoryEntries[rowSelectedIndex].ID,
                        DirectoryEntries[rowSelectedIndex].FirstName + " " + DirectoryEntries[rowSelectedIndex].LastName,
                        DirectoryEntries[rowSelectedIndex].Picture);
                    pictureHelperForm.Show();
                }
            }
        }


        private void ctxDeleteRow_Click(object sender, EventArgs e)
        {
            // Pull selected row
            var row = dgvDirectoryEntries.SelectedRows[0];
            var recordName = string.IsNullOrWhiteSpace(row.Cells["FirstName"].Value.ToString())
                && string.IsNullOrWhiteSpace(row.Cells["LastName"].Value.ToString())
                ? "this record" : row.Cells["FirstName"].Value + " " + row.Cells["LastName"].Value;

            // Confirm delete
            var dialogResult = MessageBox.Show($"Are you sure you want to delete {recordName}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (DataAccess.DeleteDirectoryEntry((int)row.Cells["ID"].Value))
                {
                    LoadGridData();
                    ShowSaveSuccessLabel();
                }
            }           
        }
    }
}
