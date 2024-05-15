using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryApp
{

    public class Library
    {

        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }


        public void RemoveBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                books.Remove(book);
            }
            else Console.WriteLine("This book does not exist");
        }

        public Book? FindBookByID(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public void CheckoutBook(int id)
        {
            var book = FindBookByID(id);
            if (book != null)
            {
                book.IsCheckedOut = true;
            }
        }

        public void ReturnBook(int id)
        {
            var book = FindBookByID(id);
            if (book != null)
            {
                book.IsCheckedOut = false;
            }
        }
    }
}