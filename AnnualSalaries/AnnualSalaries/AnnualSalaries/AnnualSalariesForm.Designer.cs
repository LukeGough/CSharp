namespace AnnualSalaries
{
    partial class AnnualSalariesForm
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
            this.lstUnsortedSalaries = new System.Windows.Forms.ListBox();
            this.lstSortedSalaries = new System.Windows.Forms.ListBox();
            this.btnGenerateSalaries = new System.Windows.Forms.Button();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnMergeSort = new System.Windows.Forms.Button();
            this.btnRadixSort = new System.Windows.Forms.Button();
            this.tbTimer = new System.Windows.Forms.TextBox();
            this.lbUnsortedList = new System.Windows.Forms.Label();
            this.lbSortedSalaries = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbNumOfSalariesToGen = new System.Windows.Forms.Label();
            this.lbDefaultSalariesToGen = new System.Windows.Forms.Label();
            this.tbNumOfSalariesToGen = new System.Windows.Forms.TextBox();
            this.btnMultipleBubbleSortRuns = new System.Windows.Forms.Button();
            this.lbTestRuns = new System.Windows.Forms.Label();
            this.btnMultipleMergeSortRuns = new System.Windows.Forms.Button();
            this.btnMultipleRadixSortRuns = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUnsortedSalaries
            // 
            this.lstUnsortedSalaries.FormattingEnabled = true;
            this.lstUnsortedSalaries.Location = new System.Drawing.Point(15, 25);
            this.lstUnsortedSalaries.Name = "lstUnsortedSalaries";
            this.lstUnsortedSalaries.Size = new System.Drawing.Size(120, 433);
            this.lstUnsortedSalaries.TabIndex = 0;
            // 
            // lstSortedSalaries
            // 
            this.lstSortedSalaries.FormattingEnabled = true;
            this.lstSortedSalaries.Location = new System.Drawing.Point(141, 25);
            this.lstSortedSalaries.Name = "lstSortedSalaries";
            this.lstSortedSalaries.Size = new System.Drawing.Size(120, 433);
            this.lstSortedSalaries.TabIndex = 1;
            // 
            // btnGenerateSalaries
            // 
            this.btnGenerateSalaries.Location = new System.Drawing.Point(267, 80);
            this.btnGenerateSalaries.Name = "btnGenerateSalaries";
            this.btnGenerateSalaries.Size = new System.Drawing.Size(103, 23);
            this.btnGenerateSalaries.TabIndex = 2;
            this.btnGenerateSalaries.Text = "Generate Salaries";
            this.btnGenerateSalaries.UseVisualStyleBackColor = true;
            this.btnGenerateSalaries.Click += new System.EventHandler(this.btnGenerateSalaries_Click);
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Location = new System.Drawing.Point(267, 109);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(103, 23);
            this.btnBubbleSort.TabIndex = 3;
            this.btnBubbleSort.Text = "Bubble Sort";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnMergeSort
            // 
            this.btnMergeSort.Location = new System.Drawing.Point(267, 138);
            this.btnMergeSort.Name = "btnMergeSort";
            this.btnMergeSort.Size = new System.Drawing.Size(103, 23);
            this.btnMergeSort.TabIndex = 4;
            this.btnMergeSort.Text = "Merge Sort";
            this.btnMergeSort.UseVisualStyleBackColor = true;
            this.btnMergeSort.Click += new System.EventHandler(this.btnMergeSort_Click);
            // 
            // btnRadixSort
            // 
            this.btnRadixSort.Location = new System.Drawing.Point(267, 167);
            this.btnRadixSort.Name = "btnRadixSort";
            this.btnRadixSort.Size = new System.Drawing.Size(103, 23);
            this.btnRadixSort.TabIndex = 5;
            this.btnRadixSort.Text = "Radix Sort";
            this.btnRadixSort.UseVisualStyleBackColor = true;
            this.btnRadixSort.Click += new System.EventHandler(this.btnRadixSort_Click);
            // 
            // tbTimer
            // 
            this.tbTimer.Location = new System.Drawing.Point(267, 225);
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.ReadOnly = true;
            this.tbTimer.Size = new System.Drawing.Size(103, 20);
            this.tbTimer.TabIndex = 6;
            // 
            // lbUnsortedList
            // 
            this.lbUnsortedList.AutoSize = true;
            this.lbUnsortedList.Location = new System.Drawing.Point(12, 9);
            this.lbUnsortedList.Name = "lbUnsortedList";
            this.lbUnsortedList.Size = new System.Drawing.Size(90, 13);
            this.lbUnsortedList.TabIndex = 7;
            this.lbUnsortedList.Text = "Unsorted Salaries";
            // 
            // lbSortedSalaries
            // 
            this.lbSortedSalaries.AutoSize = true;
            this.lbSortedSalaries.Location = new System.Drawing.Point(138, 9);
            this.lbSortedSalaries.Name = "lbSortedSalaries";
            this.lbSortedSalaries.Size = new System.Drawing.Size(78, 13);
            this.lbSortedSalaries.TabIndex = 8;
            this.lbSortedSalaries.Text = "Sorted Salaries";
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Location = new System.Drawing.Point(264, 209);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(92, 13);
            this.lbTimer.TabIndex = 9;
            this.lbTimer.Text = "Time taken to sort";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 463);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(447, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatusLabel
            // 
            this.tsStatusLabel.Name = "tsStatusLabel";
            this.tsStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // lbNumOfSalariesToGen
            // 
            this.lbNumOfSalariesToGen.AutoSize = true;
            this.lbNumOfSalariesToGen.Location = new System.Drawing.Point(264, 25);
            this.lbNumOfSalariesToGen.Name = "lbNumOfSalariesToGen";
            this.lbNumOfSalariesToGen.Size = new System.Drawing.Size(155, 13);
            this.lbNumOfSalariesToGen.TabIndex = 11;
            this.lbNumOfSalariesToGen.Text = "Number of Salaries to Generate";
            // 
            // lbDefaultSalariesToGen
            // 
            this.lbDefaultSalariesToGen.AutoSize = true;
            this.lbDefaultSalariesToGen.Location = new System.Drawing.Point(264, 38);
            this.lbDefaultSalariesToGen.Name = "lbDefaultSalariesToGen";
            this.lbDefaultSalariesToGen.Size = new System.Drawing.Size(96, 13);
            this.lbDefaultSalariesToGen.TabIndex = 12;
            this.lbDefaultSalariesToGen.Text = "(Default is 100000)";
            // 
            // tbNumOfSalariesToGen
            // 
            this.tbNumOfSalariesToGen.Location = new System.Drawing.Point(267, 54);
            this.tbNumOfSalariesToGen.Name = "tbNumOfSalariesToGen";
            this.tbNumOfSalariesToGen.Size = new System.Drawing.Size(103, 20);
            this.tbNumOfSalariesToGen.TabIndex = 13;
            // 
            // btnMultipleBubbleSortRuns
            // 
            this.btnMultipleBubbleSortRuns.Location = new System.Drawing.Point(267, 333);
            this.btnMultipleBubbleSortRuns.Name = "btnMultipleBubbleSortRuns";
            this.btnMultipleBubbleSortRuns.Size = new System.Drawing.Size(103, 23);
            this.btnMultipleBubbleSortRuns.TabIndex = 14;
            this.btnMultipleBubbleSortRuns.Text = "Bubble Sort";
            this.btnMultipleBubbleSortRuns.UseVisualStyleBackColor = true;
            this.btnMultipleBubbleSortRuns.Click += new System.EventHandler(this.btnMultipleBubbleSortRuns_Click);
            // 
            // lbTestRuns
            // 
            this.lbTestRuns.AutoSize = true;
            this.lbTestRuns.Location = new System.Drawing.Point(264, 317);
            this.lbTestRuns.Name = "lbTestRuns";
            this.lbTestRuns.Size = new System.Drawing.Size(180, 13);
            this.lbTestRuns.TabIndex = 15;
            this.lbTestRuns.Text = "Buttons Used For Multiple Test Runs";
            // 
            // btnMultipleMergeSortRuns
            // 
            this.btnMultipleMergeSortRuns.Location = new System.Drawing.Point(267, 362);
            this.btnMultipleMergeSortRuns.Name = "btnMultipleMergeSortRuns";
            this.btnMultipleMergeSortRuns.Size = new System.Drawing.Size(103, 23);
            this.btnMultipleMergeSortRuns.TabIndex = 16;
            this.btnMultipleMergeSortRuns.Text = "Merge Sort";
            this.btnMultipleMergeSortRuns.UseVisualStyleBackColor = true;
            this.btnMultipleMergeSortRuns.Click += new System.EventHandler(this.btnMultipleMergeSortRuns_Click);
            // 
            // btnMultipleRadixSortRuns
            // 
            this.btnMultipleRadixSortRuns.Location = new System.Drawing.Point(267, 391);
            this.btnMultipleRadixSortRuns.Name = "btnMultipleRadixSortRuns";
            this.btnMultipleRadixSortRuns.Size = new System.Drawing.Size(103, 23);
            this.btnMultipleRadixSortRuns.TabIndex = 17;
            this.btnMultipleRadixSortRuns.Text = "Radix Sort";
            this.btnMultipleRadixSortRuns.UseVisualStyleBackColor = true;
            this.btnMultipleRadixSortRuns.Click += new System.EventHandler(this.btnMultipleRadixSortRuns_Click);
            // 
            // AnnualSalariesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 485);
            this.Controls.Add(this.btnMultipleRadixSortRuns);
            this.Controls.Add(this.btnMultipleMergeSortRuns);
            this.Controls.Add(this.lbTestRuns);
            this.Controls.Add(this.btnMultipleBubbleSortRuns);
            this.Controls.Add(this.tbNumOfSalariesToGen);
            this.Controls.Add(this.lbDefaultSalariesToGen);
            this.Controls.Add(this.lbNumOfSalariesToGen);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.lbSortedSalaries);
            this.Controls.Add(this.lbUnsortedList);
            this.Controls.Add(this.tbTimer);
            this.Controls.Add(this.btnRadixSort);
            this.Controls.Add(this.btnMergeSort);
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.btnGenerateSalaries);
            this.Controls.Add(this.lstSortedSalaries);
            this.Controls.Add(this.lstUnsortedSalaries);
            this.Name = "AnnualSalariesForm";
            this.Text = "Annual Salaries";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUnsortedSalaries;
        private System.Windows.Forms.ListBox lstSortedSalaries;
        private System.Windows.Forms.Button btnGenerateSalaries;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnMergeSort;
        private System.Windows.Forms.Button btnRadixSort;
        private System.Windows.Forms.TextBox tbTimer;
        private System.Windows.Forms.Label lbUnsortedList;
        private System.Windows.Forms.Label lbSortedSalaries;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLabel;
        private System.Windows.Forms.Label lbNumOfSalariesToGen;
        private System.Windows.Forms.Label lbDefaultSalariesToGen;
        private System.Windows.Forms.TextBox tbNumOfSalariesToGen;
        private System.Windows.Forms.Button btnMultipleBubbleSortRuns;
        private System.Windows.Forms.Label lbTestRuns;
        private System.Windows.Forms.Button btnMultipleMergeSortRuns;
        private System.Windows.Forms.Button btnMultipleRadixSortRuns;
    }
}

