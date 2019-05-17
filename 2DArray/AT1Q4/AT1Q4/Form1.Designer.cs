namespace AT1Q4
{
    partial class Question4Form
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
            this.lbGameTitle = new System.Windows.Forms.Label();
            this.lbPlatform = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbPublisher = new System.Windows.Forms.Label();
            this.tbGameTitle = new System.Windows.Forms.TextBox();
            this.tbPlatform = new System.Windows.Forms.TextBox();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbPublisher = new System.Windows.Forms.TextBox();
            this.lbMyGames = new System.Windows.Forms.Label();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbGameTitle
            // 
            this.lbGameTitle.AutoSize = true;
            this.lbGameTitle.Location = new System.Drawing.Point(46, 13);
            this.lbGameTitle.Name = "lbGameTitle";
            this.lbGameTitle.Size = new System.Drawing.Size(58, 13);
            this.lbGameTitle.TabIndex = 0;
            this.lbGameTitle.Text = "Game Title";
            // 
            // lbPlatform
            // 
            this.lbPlatform.AutoSize = true;
            this.lbPlatform.Location = new System.Drawing.Point(59, 45);
            this.lbPlatform.Name = "lbPlatform";
            this.lbPlatform.Size = new System.Drawing.Size(45, 13);
            this.lbPlatform.TabIndex = 1;
            this.lbPlatform.Text = "Platform";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(68, 77);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(36, 13);
            this.lbGenre.TabIndex = 2;
            this.lbGenre.Text = "Genre";
            // 
            // lbPublisher
            // 
            this.lbPublisher.AutoSize = true;
            this.lbPublisher.Location = new System.Drawing.Point(54, 111);
            this.lbPublisher.Name = "lbPublisher";
            this.lbPublisher.Size = new System.Drawing.Size(50, 13);
            this.lbPublisher.TabIndex = 3;
            this.lbPublisher.Text = "Publisher";
            // 
            // tbGameTitle
            // 
            this.tbGameTitle.Location = new System.Drawing.Point(110, 10);
            this.tbGameTitle.Name = "tbGameTitle";
            this.tbGameTitle.Size = new System.Drawing.Size(100, 20);
            this.tbGameTitle.TabIndex = 4;
            // 
            // tbPlatform
            // 
            this.tbPlatform.Location = new System.Drawing.Point(110, 42);
            this.tbPlatform.Name = "tbPlatform";
            this.tbPlatform.Size = new System.Drawing.Size(100, 20);
            this.tbPlatform.TabIndex = 5;
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(110, 74);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(100, 20);
            this.tbGenre.TabIndex = 6;
            // 
            // tbPublisher
            // 
            this.tbPublisher.Location = new System.Drawing.Point(110, 108);
            this.tbPublisher.Name = "tbPublisher";
            this.tbPublisher.Size = new System.Drawing.Size(100, 20);
            this.tbPublisher.TabIndex = 7;
            // 
            // lbMyGames
            // 
            this.lbMyGames.AutoSize = true;
            this.lbMyGames.Location = new System.Drawing.Point(9, 137);
            this.lbMyGames.Name = "lbMyGames";
            this.lbMyGames.Size = new System.Drawing.Size(57, 13);
            this.lbMyGames.TabIndex = 8;
            this.lbMyGames.Text = "My Games";
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(12, 153);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(348, 173);
            this.lstOutput.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(232, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(232, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(232, 82);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(232, 106);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(232, 58);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Question4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 338);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.lbMyGames);
            this.Controls.Add(this.tbPublisher);
            this.Controls.Add(this.tbGenre);
            this.Controls.Add(this.tbPlatform);
            this.Controls.Add(this.tbGameTitle);
            this.Controls.Add(this.lbPublisher);
            this.Controls.Add(this.lbGenre);
            this.Controls.Add(this.lbPlatform);
            this.Controls.Add(this.lbGameTitle);
            this.Name = "Question4Form";
            this.Text = "Question 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbGameTitle;
        private System.Windows.Forms.Label lbPlatform;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Label lbPublisher;
        private System.Windows.Forms.TextBox tbGameTitle;
        private System.Windows.Forms.TextBox tbPlatform;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.TextBox tbPublisher;
        private System.Windows.Forms.Label lbMyGames;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClear;
    }
}

