using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Book
    {
        string title, author, isbn;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public Book(string t, string a, string i)
        {
            title = t;
            author = a;
            isbn = i;
        }

    }

}
