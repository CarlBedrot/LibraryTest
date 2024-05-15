using System;
using System.Collections.Generic;

namespace LibraryApp
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
            BorrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            if (!book.IsCheckedOut)
            {
                BorrowedBooks.Add(book);
                book.IsCheckedOut = true;
            }
        }

        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Remove(book);
                book.IsCheckedOut = false;
            }
        }

        public override string ToString()
        {
            return $"{Name}, ID: {Id}, Borrowed Books: {BorrowedBooks.Count}";
        }
    }
}
