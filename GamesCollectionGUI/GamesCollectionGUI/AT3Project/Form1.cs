using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AT3Project
{
    public partial class ComputerGamesCollectionForm : Form
    {
        private string[] names;
        private string[] platforms;
        private string[] genres;
        int numItems;

        public ComputerGamesCollectionForm()
        {
            InitializeComponent();
            names = new string[20];
            platforms = new string[20];
            genres = new string[20];
            numItems = 0;

            // display current amount of items in array into tbArrayIndex
            tbArrayIndex.Text = ((numItems).ToString());
            
            // load information from mygames.data
            Open();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")  // check if text boxe are empty
            {
                MessageBox.Show("Please enter a Name");
                return;
            }
            else if (tbPlatform.Text == "") // check if text boxe are empty
            {
                MessageBox.Show("Please enter a Platform");
                return;
            }
            else if (tbGenre.Text == "")    // check if text boxe are empty
            {
                MessageBox.Show("Please enter a Genre");
                return;
            }
            else
            {
                names[numItems] = tbName.Text;
                platforms[numItems] = tbPlatform.Text;
                genres[numItems] = tbGenre.Text;
                numItems++;
                Clear();
                DisplayGames();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstOutput.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Select an item");
                return;
            }

            DeleteAt(names, platforms, genres, index);
            Clear();
            DisplayGames();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
            DisplayGames();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = lstOutput.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Select an item");
                return;
            }
            else
            {
                names[index] = tbName.Text;
                platforms[index] = tbPlatform.Text;
                genres[index] = tbGenre.Text;

                lstOutput.Items.RemoveAt(index);
                //String updated = (tbName.Text + " " + tbPlatform.Text + " " +tbGenre.Text);
                //lstOutput.Items.Insert(index, updated);
                //lstOutput.Items.Insert(index, (tbName.Text + " " + tbPlatform.Text + " " + tbGenre.Text));
                lstOutput.Items.Insert(index, (names[index] + " " + platforms[index] + " " + genres[index]));
            }

            Clear();
            DisplayGames();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = tbName.Text;
            int index = BinarySearch(names, search);

            if (index != -1)
            {
                tbPlatform.Text = platforms[index];
                tbGenre.Text = genres[index];

                // focus on the searched item
                lstOutput.SelectedIndex = index;
                lstOutput.Focus();
            }
            else
            {
                MessageBox.Show("Game not found");
                tbName.Clear();
                tbPlatform.Clear();
                tbGenre.Clear();
            }
        }

        private void Save()
        {
            try
            {
                // Saves to \AT3Project\AT3Project\bin\Debug\mygames.dat
                using (BinaryWriter writer = new BinaryWriter(File.Open("mygames.dat", FileMode.Create)))
                {
                    writer.Write(numItems);
                    for (int i = 0; i < numItems; i++)
                    {
                        //writer.Write(names[i] + " " + platforms[i] + " " + genres[i]);
                        writer.Write(names[i]);
                        writer.Write(platforms[i]);
                        writer.Write(genres[i]);
                    }

                    MessageBox.Show("File has been saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Exception: " + ex);
            }
        }

        private void Open()
        {
            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open("mygames.dat", FileMode.Open)))
                {
                    numItems = reader.ReadInt32();
                    for (int i = 0; i < numItems; i++)
                    {
                        string name = reader.ReadString();
                        string platform = reader.ReadString();
                        string genre = reader.ReadString();

                        names[i] = name;
                        platforms[i] = platform;
                        genres[i] = genre;
                    }
                    DisplayGames();
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Exception: " + ex);
            }

        }

        private void Clear()
        {
            // clear all text boxes
            tbName.Clear();
            tbPlatform.Clear();
            tbGenre.Clear();
        }

        private void Reset()
        {
            // the for loop does work but isn't required as numItems is set to 0
            // because numItems is set to 0 the previous items in the arrays will be overwritten
            //for (int i = 0; i < numItems; i++)
            //{
            //    names[i] = null;
            //    platforms[i] = null;
            //    genres[i] = null;
            //}
            numItems = 0;
        }

        private void DeleteAt(string[] names, string[] platforms, string[] genres, int index)
        {
            for (int i = index; i < numItems - 1; i++)
            {
                // shuffling items in the array, basically moving the item into the previous array index
                names[i] = names[i + 1];
                platforms[i] = platforms[i + 1];
                genres[i] = genres[i + 1];
            }
            numItems--;
        }

        private void DisplayGames()
        {
            lstOutput.Items.Clear();
            BubbleSort(names, platforms, genres);
            for (int i = 0; i < numItems; i++)
            {
                // display arrays in lstOutput
                lstOutput.Items.Add(names[i] + " " + platforms[i] + " " + genres[i]);
            }
            tbArrayIndex.Text = ((numItems).ToString());
        }

        private void BubbleSort(string[] names, string[] platforms, string[] genres)
        {
            for (int outer = 0; outer < numItems; outer++)
            {
                for (int inner = 0; inner < (numItems - outer - 1); inner++)
                {
                    if (string.Compare(names[inner], names[inner + 1]) > 0)
                    {
                        // saving inner + 1 array into a temp string
                        // replacing inner + 1 with inner
                        // replacing inner with tmp, which is actually inner + 1

                        string tmp = names[inner + 1];
                        names[inner + 1] = names[inner];
                        names[inner] = tmp;

                        tmp = platforms[inner + 1];
                        platforms[inner + 1] = platforms[inner];
                        platforms[inner] = tmp;

                        tmp = genres[inner + 1];
                        genres[inner + 1] = genres[inner];
                        genres[inner] = tmp;
                    }
                }
            }
        }

        private void lstOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstOutput.SelectedIndex;

            // if statement is need to check if nothing is selected
            // if nothing is selected, return (contiune with rest of code)
            if (index == -1)
            {
                return;
            }

            tbName.Text = names[index];
            tbPlatform.Text = platforms[index];
            tbGenre.Text = genres[index];
        }

        private void ComputerGamesCollectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // call save method when closing program
            Save();
        }

        private void ComputerGamesCollectionForm_Load(object sender, EventArgs e)
        {
            // setup tooltips for text boxes on form load
            toolTip.SetToolTip(tbName, "Enter Game Name");
            toolTip.SetToolTip(tbPlatform, "Enter Platform Name");
            toolTip.SetToolTip(tbGenre, "Enter Genre Name");
        }

        private int BinarySearch(string[] names, string search)
        {
            int lowerBound = 0;
            int upperBound = numItems;
            int mid;

            while (true)
            {
                mid = (lowerBound + upperBound) / 2;
                if (names[mid] == search)
                {
                    return mid;
                }
                else if (lowerBound > upperBound)
                {
                    return -1;
                }
                else
                {
                    if (string.Compare(names[mid], search, false) > 0)
                    {
                        upperBound = mid - 1;
                    }
                    else
                    {
                        lowerBound = mid + 1;
                    }
                }
            }
        }
    }
}