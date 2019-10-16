namespace PayrollApp
{
    partial class PayrollForm
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
            this.lstStaffNames = new System.Windows.Forms.ListBox();
            this.tbStaffName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbStaffName = new System.Windows.Forms.Label();
            this.btnFindLeftMost = new System.Windows.Forms.Button();
            this.tbFindLeftMost = new System.Windows.Forms.TextBox();
            this.tbFindRightMost = new System.Windows.Forms.TextBox();
            this.btnFindRightMost = new System.Windows.Forms.Button();
            this.ssStatusStrip = new System.Windows.Forms.StatusStrip();
            this.ssErrorMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.ttToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ssStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstStaffNames
            // 
            this.lstStaffNames.FormattingEnabled = true;
            this.lstStaffNames.Location = new System.Drawing.Point(15, 138);
            this.lstStaffNames.Name = "lstStaffNames";
            this.lstStaffNames.Size = new System.Drawing.Size(805, 238);
            this.lstStaffNames.TabIndex = 0;
            // 
            // tbStaffName
            // 
            this.tbStaffName.Location = new System.Drawing.Point(12, 25);
            this.tbStaffName.Name = "tbStaffName";
            this.tbStaffName.Size = new System.Drawing.Size(100, 20);
            this.tbStaffName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(118, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(224, 23);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(330, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbStaffName
            // 
            this.lbStaffName.AutoSize = true;
            this.lbStaffName.Location = new System.Drawing.Point(12, 9);
            this.lbStaffName.Name = "lbStaffName";
            this.lbStaffName.Size = new System.Drawing.Size(106, 13);
            this.lbStaffName.TabIndex = 5;
            this.lbStaffName.Text = "Staff Members Name";
            // 
            // btnFindLeftMost
            // 
            this.btnFindLeftMost.Location = new System.Drawing.Point(118, 75);
            this.btnFindLeftMost.Name = "btnFindLeftMost";
            this.btnFindLeftMost.Size = new System.Drawing.Size(100, 23);
            this.btnFindLeftMost.TabIndex = 6;
            this.btnFindLeftMost.Text = "Find Left Most";
            this.btnFindLeftMost.UseVisualStyleBackColor = true;
            this.btnFindLeftMost.Click += new System.EventHandler(this.btnFindLeftMost_Click);
            // 
            // tbFindLeftMost
            // 
            this.tbFindLeftMost.Location = new System.Drawing.Point(12, 77);
            this.tbFindLeftMost.Name = "tbFindLeftMost";
            this.tbFindLeftMost.ReadOnly = true;
            this.tbFindLeftMost.Size = new System.Drawing.Size(100, 20);
            this.tbFindLeftMost.TabIndex = 7;
            // 
            // tbFindRightMost
            // 
            this.tbFindRightMost.Location = new System.Drawing.Point(12, 103);
            this.tbFindRightMost.Name = "tbFindRightMost";
            this.tbFindRightMost.ReadOnly = true;
            this.tbFindRightMost.Size = new System.Drawing.Size(100, 20);
            this.tbFindRightMost.TabIndex = 9;
            // 
            // btnFindRightMost
            // 
            this.btnFindRightMost.Location = new System.Drawing.Point(118, 101);
            this.btnFindRightMost.Name = "btnFindRightMost";
            this.btnFindRightMost.Size = new System.Drawing.Size(100, 23);
            this.btnFindRightMost.TabIndex = 8;
            this.btnFindRightMost.Text = "Find Right Most";
            this.btnFindRightMost.UseVisualStyleBackColor = true;
            this.btnFindRightMost.Click += new System.EventHandler(this.btnFindRightMost_Click);
            // 
            // ssStatusStrip
            // 
            this.ssStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssErrorMessage});
            this.ssStatusStrip.Location = new System.Drawing.Point(0, 388);
            this.ssStatusStrip.Name = "ssStatusStrip";
            this.ssStatusStrip.Size = new System.Drawing.Size(833, 22);
            this.ssStatusStrip.TabIndex = 10;
            // 
            // ssErrorMessage
            // 
            this.ssErrorMessage.Name = "ssErrorMessage";
            this.ssErrorMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // PayrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 410);
            this.Controls.Add(this.ssStatusStrip);
            this.Controls.Add(this.tbFindRightMost);
            this.Controls.Add(this.btnFindRightMost);
            this.Controls.Add(this.tbFindLeftMost);
            this.Controls.Add(this.btnFindLeftMost);
            this.Controls.Add(this.lbStaffName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbStaffName);
            this.Controls.Add(this.lstStaffNames);
            this.Name = "PayrollForm";
            this.Text = "Payroll Application";
            this.Load += new System.EventHandler(this.PayrollForm_Load);
            this.ssStatusStrip.ResumeLayout(false);
            this.ssStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstStaffNames;
        private System.Windows.Forms.TextBox tbStaffName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbStaffName;
        private System.Windows.Forms.Button btnFindLeftMost;
        private System.Windows.Forms.TextBox tbFindLeftMost;
        private System.Windows.Forms.TextBox tbFindRightMost;
        private System.Windows.Forms.Button btnFindRightMost;
        private System.Windows.Forms.StatusStrip ssStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ssErrorMessage;
        private System.Windows.Forms.ToolTip ttToolTip;
    }
}

