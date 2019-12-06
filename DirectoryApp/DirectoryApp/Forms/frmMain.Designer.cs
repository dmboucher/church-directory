namespace DirectoryApp
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDirectoryEntries = new System.Windows.Forms.DataGridView();
            this.ctxGridMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxDeleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGridStatus = new System.Windows.Forms.Label();
            this.lblSaveStatus = new System.Windows.Forms.Label();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectoryEntries)).BeginInit();
            this.ctxGridMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSettings,
            this.mnuPrint});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.mnuMain.Size = new System.Drawing.Size(634, 27);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "Menu";
            // 
            // mnuSettings
            // 
            this.mnuSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuSettings.Name = "mnuSettings";
            this.mnuSettings.Size = new System.Drawing.Size(78, 25);
            this.mnuSettings.Text = "Settings";
            this.mnuSettings.Click += new System.EventHandler(this.mnuSettings_Click);
            // 
            // mnuPrint
            // 
            this.mnuPrint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.Size = new System.Drawing.Size(55, 25);
            this.mnuPrint.Text = "Print";
            this.mnuPrint.Click += new System.EventHandler(this.mnuPrint_Click);
            // 
            // dgvDirectoryEntries
            // 
            this.dgvDirectoryEntries.AllowUserToResizeRows = false;
            this.dgvDirectoryEntries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDirectoryEntries.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDirectoryEntries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDirectoryEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirectoryEntries.ContextMenuStrip = this.ctxGridMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDirectoryEntries.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDirectoryEntries.Location = new System.Drawing.Point(0, 104);
            this.dgvDirectoryEntries.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDirectoryEntries.MultiSelect = false;
            this.dgvDirectoryEntries.Name = "dgvDirectoryEntries";
            this.dgvDirectoryEntries.RowHeadersVisible = false;
            this.dgvDirectoryEntries.RowHeadersWidth = 82;
            this.dgvDirectoryEntries.RowTemplate.Height = 33;
            this.dgvDirectoryEntries.Size = new System.Drawing.Size(200, 208);
            this.dgvDirectoryEntries.TabIndex = 2;
            this.dgvDirectoryEntries.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDirectoryEntries_CellMouseDown);
            this.dgvDirectoryEntries.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDirectoryEntries_CellValueChanged);
            // 
            // ctxGridMenu
            // 
            this.ctxGridMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ctxGridMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxDeleteRow});
            this.ctxGridMenu.Name = "ctxGridMenu";
            this.ctxGridMenu.Size = new System.Drawing.Size(134, 26);
            // 
            // ctxDeleteRow
            // 
            this.ctxDeleteRow.Name = "ctxDeleteRow";
            this.ctxDeleteRow.Size = new System.Drawing.Size(133, 22);
            this.ctxDeleteRow.Text = "Delete Row";
            this.ctxDeleteRow.Click += new System.EventHandler(this.ctxDeleteRow_Click);
            // 
            // lblGridStatus
            // 
            this.lblGridStatus.AutoSize = true;
            this.lblGridStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridStatus.Location = new System.Drawing.Point(21, 42);
            this.lblGridStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGridStatus.Name = "lblGridStatus";
            this.lblGridStatus.Size = new System.Drawing.Size(102, 20);
            this.lblGridStatus.TabIndex = 3;
            this.lblGridStatus.Text = "Grid Status...";
            // 
            // lblSaveStatus
            // 
            this.lblSaveStatus.AutoSize = true;
            this.lblSaveStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveStatus.Location = new System.Drawing.Point(547, 42);
            this.lblSaveStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaveStatus.Name = "lblSaveStatus";
            this.lblSaveStatus.Size = new System.Drawing.Size(58, 20);
            this.lblSaveStatus.TabIndex = 4;
            this.lblSaveStatus.Text = "Saved!";
            this.lblSaveStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblSaveStatus.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 402);
            this.Controls.Add(this.lblSaveStatus);
            this.Controls.Add(this.lblGridStatus);
            this.Controls.Add(this.dgvDirectoryEntries);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Name = "FrmMain";
            this.Text = "Directory App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.FrmMain_SizeChanged);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectoryEntries)).EndInit();
            this.ctxGridMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuSettings;
        private System.Windows.Forms.ToolStripMenuItem mnuPrint;
        private System.Windows.Forms.DataGridView dgvDirectoryEntries;
        private System.Windows.Forms.Label lblGridStatus;
        private System.Windows.Forms.Label lblSaveStatus;
        private System.Windows.Forms.ContextMenuStrip ctxGridMenu;
        private System.Windows.Forms.ToolStripMenuItem ctxDeleteRow;
    }
}

