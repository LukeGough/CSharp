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

namespace AT1Q4
{
    public partial class Question4Form : Form
    {
        static int maxRowSize;
        static int maxColSize;
        int numItems;
        private string[,] games;

        public Question4Form()
        {
            InitializeComponent();
            maxRowSize = 10;
            maxColSize = 4;
            numItems = 0;
            games = new string[maxRowSize, maxColSize];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (numItems == maxRowSize)
                {
                    MessageBox.Show("Games collection is full");
                    return;
                }
                else
                {
                    // store textbox valus in Row i (numItems), Columns 1, 2, 3 & 4
                    games[numItems, 0] = tbGameTitle.Text;
                    games[numItems, 1] = tbPlatform.Text;
                    games[numItems, 2] = tbGenre.Text;
                    games[numItems, 3] = tbPublisher.Text;

                    // increase numItem so the next new Game can be created
                    numItems++;

                    // clear textboxes
                    Clear();

                    // display games
                    DisplayGames();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = tbGameTitle.Text;
            int index = BinarySearch(games, search);

            if (index != -1)
            {
                tbPlatform.Text = games[index, 1];
                tbGenre.Text = games[index, 2];
                tbPublisher.Text = games[index, 3];

                // focus on the searched item
                lstOutput.SelectedIndex = index;
                lstOutput.Focus();
            }
            else
            {
                MessageBox.Show("Game not found");
                Clear();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Open();
        }

        // method to open games.dat
        private void Open()
        {
            try
            {
                // create new BinaryReader named reader and open file "games.dat"
                using (BinaryReader reader = new BinaryReader(File.Open("games.dat", FileMode.Open)))
                {
                    // read int numItems
                    numItems = reader.ReadInt32();

                    // loop through and create + read string
                    // then assign string to array
                    for (int i = 0; i < numItems; i++)
                    {
                        games[i, 0] = reader.ReadString();
                        games[i, 1] = reader.ReadString();
                        games[i, 2] = reader.ReadString();
                        games[i, 3] = reader.ReadString();
                    }

                    // call DisplayGames method
                    DisplayGames();
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Exception" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // method to save games array to games.dat
        private void Save()
        {
            try
            {
                // call BubbleSort method with games array
                BubbleSort(games);

                // Saves to \AT1Q4\AT1Q4\AT1Q4\bin\Debug\games.dat
                using (BinaryWriter writer = new BinaryWriter(File.Open("games.dat", FileMode.Create)))
                {
                    // write current number of items in game array
                    writer.Write(numItems);

                    // loop through and write the items in the games array to binary file
                    for (int i = 0; i < numItems; i++)
                    {
                        writer.Write(games[i, 0]);
                        writer.Write(games[i, 1]);
                        writer.Write(games[i, 2]);
                        writer.Write(games[i, 3]);
                    }

                    // show message box telling user file has been saved
                    MessageBox.Show("File has been saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Exception" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // bubble sort method
        private void BubbleSort(string[,] games)
        {
            for (int outer = 0; outer < numItems; outer++)
            {
                for (int inner = 0; inner < (numItems - outer - 1); inner++)
                {
                    if (string.Compare(games[inner,0], games[inner + 1, 0]) > 0)
                    {
                        // saving inner + 1 array into a temp string
                        // replacing inner + 1 with inner
                        // replacing inner with tmp, which is actually inner + 1
                        //string tmp = games[inner + 1, 0];
                        //games[inner + 1, 0] = games[inner, 0];
                        //games[inner, 0] = tmp;

                        //tmp = games[inner + 1, 1];
                        //games[inner + 1, 1] = games[inner, 1];
                        //games[inner, 1] = tmp;

                        //tmp = games[inner + 1, 2];
                        //games[inner + 1, 2] = games[inner, 2];
                        //games[inner, 2] = tmp;

                        //tmp = games[inner + 1, 3];
                        //games[inner + 1, 3] = games[inner, 3];
                        //games[inner, 3] = tmp;
                        BubbleSortSwap(games, inner);
                    }
                }
            }
        }
        
        private void BubbleSortSwap(string[,] games, int inner)
        {
            string tmp = games[inner + 1, 0];
            games[inner + 1, 0] = games[inner, 0];
            games[inner, 0] = tmp;

            tmp = games[inner + 1, 1];
            games[inner + 1, 1] = games[inner, 1];
            games[inner, 1] = tmp;

            tmp = games[inner + 1, 2];
            games[inner + 1, 2] = games[inner, 2];
            games[inner, 2] = tmp;

            tmp = games[inner + 1, 3];
            games[inner + 1, 3] = games[inner, 3];
            games[inner, 3] = tmp;
        }

        // binary search method
        private int BinarySearch(string[,] games, string search)
        {
            int lowerBound = 0;
            int upperBound = numItems;
            int mid;

            while (true)
            {
                // find middle by plusing lower and upper and dividing by 2
                mid = (lowerBound + upperBound) / 2;

                // if games[mid, 0] is the searched item then return it
                if (games[mid, 0] == search)
                {
                    return mid;
                }
                else if (lowerBound > upperBound)
                {
                    return -1;
                }
                else
                {
                    // if the compared string is bigger then 0 decrease mid by 1
                    if (string.Compare(games[mid, 0], search, false) > 0)
                    {
                        upperBound = mid - 1;
                    }
                    // else increase mid by 1
                    else
                    {
                        lowerBound = mid + 1;
                    }
                }
            }
        }

        // method to clear all textboxes
        public void Clear()
        {
            tbGameTitle.Clear();
            tbPlatform.Clear();
            tbGenre.Clear();
            tbPublisher.Clear();
        }

        // method to display games to lstOutput
        public void DisplayGames()
        {
            // clear all items in lstOutput
            lstOutput.Items.Clear();

            // call BubbleSort method with games array
            BubbleSort(games);

            // display games array in lstOutput
            for (int i = 0; i < numItems; i++)
            {
                lstOutput.Items.Add(games[i, 0] + ", " + games[i, 1] + ", " + games[i, 2] + ", " + games[i, 3]);
            }
        }
    }
}
