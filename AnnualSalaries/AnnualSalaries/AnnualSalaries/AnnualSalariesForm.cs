using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading; // used to add a delay when sorting to verify Stopwatch is working
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnnualSalaries
{
    public partial class AnnualSalariesForm : Form
    {
        public AnnualSalariesForm()
        {
            InitializeComponent();
        }

        Stopwatch sw = new Stopwatch();

        string fileName;
        int[] salaries;
        int numOfSalariesToGen;
        int defaultNumOfSalariesToGen = 10000000;
        int minSalary = 37000;
        int maxSalary = 175000;

        #region Generate Salaries Button
        private void btnGenerateSalaries_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(string.IsNullOrEmpty(tbNumOfSalariesToGen.Text)) && (int.TryParse(tbNumOfSalariesToGen.Text, out numOfSalariesToGen)))
                {
                    numOfSalariesToGen = int.Parse(tbNumOfSalariesToGen.Text);
                }
                else if(!(string.IsNullOrEmpty(tbNumOfSalariesToGen.Text)) && !(int.TryParse(tbNumOfSalariesToGen.Text, out numOfSalariesToGen)))
                {
                    MessageBox.Show("A number was not entered, please enter a number or no number to use the default.", "Number Not Provided.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    numOfSalariesToGen = defaultNumOfSalariesToGen;
                }

                salaries = new int[numOfSalariesToGen];

                Random r = new Random();
                for (int i = 0; i < salaries.Length; i++)
                {
                    int num = r.Next(minSalary, maxSalary);
                    salaries[i] = num;
                }
                
                DisplayUnsorted();

                tsStatusLabel.Text = "Salaries generated!";

                tbTimer.Text = "";
            }
            catch (Exception)
            {
                tsStatusLabel.Text = "Unable to generate salaries.";
            }
        }
        #endregion

        #region Bubble Sort Button
        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            try
            {
                sw.Start();
                salaries = BubbleSort.Sort(salaries);
                //Thread.Sleep(10000);
                sw.Stop();

                // writing to csv
                fileName = "BubbleSortTimes.csv";
                addRecord("BubbleSort", salaries.Length, StopwatchDisplay(StopwatchElapsedTime()), fileName);

                // displaying time
                tbTimer.Text = StopwatchDisplay(StopwatchElapsedTime());
                StopwatchReset();
                DisplaySorted();

                tsStatusLabel.Text = "Bubble Sort successful! Time Written to " + fileName;
            }
            catch (Exception)
            {
                tsStatusLabel.Text = "Unable to Bubble Sort.";
            }
        }
        #endregion

        #region Merge Sort Button
        private void btnMergeSort_Click(object sender, EventArgs e)
        {
            try
            {
                sw.Start();
                salaries = MergeSort.Sort(salaries);
                //Thread.Sleep(10000);
                sw.Stop();

                // writing to csv
                fileName = "MergeSort.csv";
                addRecord("MergeSort", salaries.Length, StopswatchDisplayNanoSeconds(StopwatchElapsedTime()), fileName);

                // displaying time
                //tbTimer.Text = StopwatchDisplay(StopwatchElapsedTime());
                tbTimer.Text = StopswatchDisplayNanoSeconds(StopwatchElapsedTime());
                StopwatchReset();
                DisplaySorted();

                tsStatusLabel.Text = "Merge Sort successful! Time Written to " + fileName;
            }
            catch (Exception)
            {
                tsStatusLabel.Text = "Unable to Merge Sort.";
            }
        }
        #endregion

        #region Radix Sort Button
        private void btnRadixSort_Click(object sender, EventArgs e)
        {
            try
            {
                sw.Start();
                salaries = RadixSort.Sort(salaries);
                //Thread.Sleep(10000);
                sw.Stop();

                // writing to csv
                fileName = "RadixSort.csv";
                addRecord("RadixSort", salaries.Length, StopswatchDisplayNanoSeconds(StopwatchElapsedTime()), fileName);

                // displaying time
                tbTimer.Text = StopswatchDisplayNanoSeconds(StopwatchElapsedTime());
                StopwatchReset();
                DisplaySorted();

                tsStatusLabel.Text = "Radix Sort successful! Time Written to " + fileName;
            }
            catch (Exception)
            {
                tsStatusLabel.Text = "Unable to Radix Sort.";
            }
        }
        #endregion

        #region Display Methods
        private void DisplayUnsorted()
        {
            lstUnsortedSalaries.Items.Clear();
            lstSortedSalaries.Items.Clear();
            foreach (int s in salaries)
            {
                lstUnsortedSalaries.Items.Add(s);
            }
        }

        private void DisplaySorted()
        {
            lstUnsortedSalaries.Items.Clear();
            lstSortedSalaries.Items.Clear();
            foreach (int s in salaries)
            {
                lstSortedSalaries.Items.Add(s);
            }
        }
        #endregion

        #region Stopwatch Methods
        private TimeSpan StopwatchElapsedTime()
        {
            TimeSpan ts = sw.Elapsed;
            return ts;
        }

        private string StopwatchDisplay(TimeSpan ts)
        {
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            return elapsedTime;
        }

        private string StopswatchDisplayNanoSeconds(TimeSpan ts)
        {
            string elapsedTime = String.Format("{0:00}.{1:00}", ts.Seconds, ts.Milliseconds * 1000000);
            return elapsedTime;
        }

    private void StopwatchReset()
        {
            sw.Reset();
        }
        #endregion

        #region Write to CSV file
        public static void addRecord(string sortingMethod, int numOfSalariesSorted, string elapsedTime, string fileName)
        {
            try
            {
                //using (System.IO.StreamWriter file = new System.IO.StreamWriter("times.txt", true))
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName, true))
                {
                    file.WriteLine(sortingMethod + "," + numOfSalariesSorted + "," + elapsedTime);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex, "Writing to CSV Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Multiple Run Buttons
        #region Multiple BubbleSort Runs
        private void btnMultipleBubbleSortRuns_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                btnGenerateSalaries_Click(sender, e);
                btnBubbleSort_Click(sender, e);
            }
        }
        #endregion

        #region Multiple MergeSort Runs
        private void btnMultipleMergeSortRuns_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                btnGenerateSalaries_Click(sender, e);
                btnMergeSort_Click(sender, e);
            }
        }
        #endregion

        #region Multiple RadixSort Runs
        private void btnMultipleRadixSortRuns_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                btnGenerateSalaries_Click(sender, e);
                btnRadixSort_Click(sender, e);
            }
        }
        #endregion
        #endregion
    }
}
