using System;
namespace LibraryApp
{


    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public string ISBN { get; set; }

        public bool IsCheckedOut { get; set; }

        // create a constructor with id, title, author and isbn
        public Book(int id, string title, string author, string isbn)
        {
            Id = id;
            Title = title;
            Author = author;
            ISBN = isbn;
            IsCheckedOut = false;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Title: {Title}, Author: {Author}, ISBN: {ISBN}, isCheckOut: {IsCheckedOut}";
        }


    }
}