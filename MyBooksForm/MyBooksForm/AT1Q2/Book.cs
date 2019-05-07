/*  
    Class: Cluster - Programming II
    Name: Luke Gough
    Student ID: 30003918
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT1Q2
{
    class Book
    {
        // private attributes
        private string title;
        private string author;
        private string date;
        private string publisher;

        // overloaded constructor
        public Book(string title, string author, string date, string publisher)
        {
            this.title = title;
            this.author = author;
            this.date = date;
            this.publisher = date;
        }

        // methods for accessing the value of the private attributes
        // method to get the private title attribute
        public string getTitle()
        {
            return title;
        }

        // method to set the private title attribute
        public void setTitle(string title)
        {
            this.title = title;
        }

        // method to get the private author attribute
        public string getAuthor()
        {
            return author;
        }

        // method to set the private author attribute
        public void setAuthor(string author)
        {
            this.author = author;
        }

        // method to get the private date attribute
        public string getDate()
        {
            return date;
        }

        // method to set the private date attribute
        public void setDate(string date)
        {
            this.date = date;
        }

        // method to get the private publisher attribute
        public string getPublisher()
        {
            return publisher;
        }

        // method to set the private publisher attribute
        public void setPublisher(string publisher)
        {
            this.publisher = publisher;
        }
    }
}