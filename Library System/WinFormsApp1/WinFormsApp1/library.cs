using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Library : Catalog
    {
        //list to store the books
        private List<Book> books;
        public Library()
        {
            books = new List<Book>();
        }
        //Add the book
        public void addBook(Book b)
        {
            books.Add(b);
        }
        //Remove a book
        public void removeBook(Book b)
        {
            books.Remove(b);
        }
        //Get all the books
        public List<Book> getBooks()
        {
            return books;
        }
        //Search a book by its title
        public List<Book> SearchBooks(string searchText)
        {
            List<Book> searchResults = new List<Book>();

            // Search by title
            searchResults.AddRange(books.Where(book => book.Title.Contains(searchText)));

            // Search by author
            searchResults.AddRange(books.Where(book => book.Author.Contains(searchText)));

            // Search by ISBN
            searchResults.AddRange(books.Where(book => book.Isbn.Contains(searchText)));

            return searchResults;
        }

        public List<Book> SearchBooks(string a,string b, string c)
        {
            List<Book> searchResults = new List<Book>();

            // Search by title
            searchResults.AddRange(books.Where(book => book.Title.Contains(a)));

            // Search by author
            searchResults.AddRange(books.Where(book => book.Author.Contains(b)));

            // Search by ISBN
            searchResults.AddRange(books.Where(book => book.Isbn.Contains(c)));

            return searchResults;
        }
    }
}

