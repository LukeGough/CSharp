namespace CSVDisplay
{
    partial class CSVDisplayForm
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.ofdOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.lbCsvFile = new System.Windows.Forms.Label();
            this.tbCsvFile = new System.Windows.Forms.TextBox();
            this.grpRead = new System.Windows.Forms.GroupBox();
            this.grpWrite = new System.Windows.Forms.GroupBox();
            this.grpDisplay = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssRead = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.tssAdd = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.grpRead.SuspendLayout();
            this.grpWrite.SuspendLayout();
            this.grpDisplay.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(87, 47);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // ofdOpenFileDialog
            // 
            this.ofdOpenFileDialog.FileName = "openFileDialog1";
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(6, 48);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(250, 175);
            this.dgvTable.TabIndex = 1;
            // 
            // lbCsvFile
            // 
            this.lbCsvFile.AutoSize = true;
            this.lbCsvFile.Location = new System.Drawing.Point(6, 24);
            this.lbCsvFile.Name = "lbCsvFile";
            this.lbCsvFile.Size = new System.Drawing.Size(50, 13);
            this.lbCsvFile.TabIndex = 2;
            this.lbCsvFile.Text = "CSV File:";
            // 
            // tbCsvFile
            // 
            this.tbCsvFile.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbCsvFile.Location = new System.Drawing.Point(62, 21);
            this.tbCsvFile.Name = "tbCsvFile";
            this.tbCsvFile.ReadOnly = true;
            this.tbCsvFile.Size = new System.Drawing.Size(100, 20);
            this.tbCsvFile.TabIndex = 3;
            // 
            // grpRead
            // 
            this.grpRead.Controls.Add(this.statusStrip1);
            this.grpRead.Controls.Add(this.tbCsvFile);
            this.grpRead.Controls.Add(this.btnBrowse);
            this.grpRead.Controls.Add(this.lbCsvFile);
            this.grpRead.Location = new System.Drawing.Point(12, 12);
            this.grpRead.Name = "grpRead";
            this.grpRead.Size = new System.Drawing.Size(180, 98);
            this.grpRead.TabIndex = 4;
            this.grpRead.TabStop = false;
            this.grpRead.Text = "Read";
            // 
            // grpWrite
            // 
            this.grpWrite.Controls.Add(this.statusStrip2);
            this.grpWrite.Controls.Add(this.btnAdd);
            this.grpWrite.Controls.Add(this.lbName);
            this.grpWrite.Controls.Add(this.lbId);
            this.grpWrite.Controls.Add(this.tbName);
            this.grpWrite.Controls.Add(this.tbId);
            this.grpWrite.Location = new System.Drawing.Point(12, 116);
            this.grpWrite.Name = "grpWrite";
            this.grpWrite.Size = new System.Drawing.Size(180, 125);
            this.grpWrite.TabIndex = 5;
            this.grpWrite.TabStop = false;
            this.grpWrite.Text = "Write";
            // 
            // grpDisplay
            // 
            this.grpDisplay.Controls.Add(this.btnDisplay);
            this.grpDisplay.Controls.Add(this.dgvTable);
            this.grpDisplay.Location = new System.Drawing.Point(198, 12);
            this.grpDisplay.Name = "grpDisplay";
            this.grpDisplay.Size = new System.Drawing.Size(270, 229);
            this.grpDisplay.TabIndex = 6;
            this.grpDisplay.TabStop = false;
            this.grpDisplay.Text = "Display";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssRead});
            this.statusStrip1.Location = new System.Drawing.Point(3, 73);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(174, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssRead
            // 
            this.tssRead.Name = "tssRead";
            this.tssRead.Size = new System.Drawing.Size(0, 17);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(6, 19);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(62, 19);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(62, 45);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 1;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(35, 22);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(21, 13);
            this.lbId.TabIndex = 2;
            this.lbId.Text = "ID:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(18, 48);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(38, 13);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(87, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssAdd});
            this.statusStrip2.Location = new System.Drawing.Point(3, 100);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(174, 22);
            this.statusStrip2.TabIndex = 5;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // tssAdd
            // 
            this.tssAdd.Name = "tssAdd";
            this.tssAdd.Size = new System.Drawing.Size(0, 17);
            // 
            // CSVDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 251);
            this.Controls.Add(this.grpDisplay);
            this.Controls.Add(this.grpWrite);
            this.Controls.Add(this.grpRead);
            this.Name = "CSVDisplayForm";
            this.Text = "CSVDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.grpRead.ResumeLayout(false);
            this.grpRead.PerformLayout();
            this.grpWrite.ResumeLayout(false);
            this.grpWrite.PerformLayout();
            this.grpDisplay.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog ofdOpenFileDialog;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Label lbCsvFile;
        private System.Windows.Forms.TextBox tbCsvFile;
        private System.Windows.Forms.GroupBox grpRead;
        private System.Windows.Forms.GroupBox grpWrite;
        private System.Windows.Forms.GroupBox grpDisplay;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssRead;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel tssAdd;
    }
}

