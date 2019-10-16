using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVDisplay
{
    public partial class CSVDisplayForm : Form
    {
        string csvFile;
        List<CSVRecord> records = new List<CSVRecord>();

        public CSVDisplayForm()
        {
            InitializeComponent();
        }

        #region Methods
        private void ReadRecord()
        {
            try
            {
                using (var reader = new StreamReader(csvFile))
                using (var csv = new CsvHelper.CsvReader(reader))
                {
                    var csvRecords = csv.GetRecords<CSVRecord>();

                    foreach (var csvRecord in csvRecords)
                    {
                        records.Add(csvRecord);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void AddRecord(int id, string name)
        {
            try
            {
                records.Add(new CSVRecord { Id = id, Name = name });

                using (var writer = new StreamWriter(csvFile, false))
                using (var csv = new CsvHelper.CsvWriter(writer))
                {
                    csv.WriteRecords(records);
                    writer.Flush();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void DisplayRecords()
        {
            try
            {
                using (var reader = new StreamReader(csvFile))
                using (var csv = new CsvHelper.CsvReader(reader))
                {
                    using (var dr = new CsvHelper.CsvDataReader(csv))
                    {
                        var dt = new DataTable();
                        dt.Load(dr);

                        dgvTable.DataSource = dt;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region WinForm Button Events
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = ofdOpenFileDialog.ShowDialog(); // Show the dialog.
                if (result == DialogResult.OK) // Test result.
                {
                    csvFile = ofdOpenFileDialog.SafeFileName;
                    tbCsvFile.Text = csvFile;
                    ReadRecord();
                    tssRead.Text = "CSV file successfully read.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception:");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (!(String.IsNullOrEmpty(csvFile)))
            {
                int i;
                if (int.TryParse(tbId.Text, out i) && !(String.IsNullOrEmpty(tbName.Text)))
                {
                    AddRecord(i, tbName.Text);
                    tbId.Clear();
                    tbName.Clear();
                    tssAdd.Text = "Record added successfully.";

                    DisplayRecords();
                }
                else
                {
                    MessageBox.Show("Please enter ID as a number and a name.");
                }
            }
            else
            {
                MessageBox.Show("Please read in a CSV file.");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(csvFile)))
            {
                DisplayRecords();
            }
            else
            {
                MessageBox.Show("Please read in a CSV file.");
            }
        }
        #endregion
    }
}
