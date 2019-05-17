using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT1Q2
{
    public partial class MyBookForm : Form
    {
        private Book[] books;
        int numItems;
        private static int arrayMax = 10;

        public MyBookForm()
        {
            InitializeComponent();
            // Create an array of type book with size 10, (use a static variable for the array size)
            books = new Book[arrayMax];
            numItems = 0;
        }

        // A button click method that adds the details of each book to the single dimension book array, and then clears the input text boxes
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (numItems == arrayMax)
            {
                MessageBox.Show("Book Reference List is full");
                return;
            }
            else
            {
                // create a new Book object and pass through textbox text
                Book b = new Book(tbTitle.Text, tbAuthor.Text, tbDate.Text, tbPublisher.Text);
                books[numItems] = b;

                // increase numItem so the next new book can be created
                numItems++;

                // clear textboxes
                tbTitle.Clear();
                tbAuthor.Clear();
                tbDate.Clear();
                tbPublisher.Clear();

                // display books
                DisplayBooks();
            }

        }

        private void DisplayBooks()
        {
            lstOutput.Items.Clear();
            for (int i = 0; i < numItems; i++)
            {
                // display Book array in lstOutput
                lstOutput.Items.Add(books[i].getAuthor() + ", " + books[i].getAuthor() + ". " + books[i].getDate() + ". " + books[i].getPublisher());
            }
        }
    }
}
