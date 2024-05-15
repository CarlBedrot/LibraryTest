using System;

namespace LibraryApp
{
    class Program
    {
        static void Main(String[] args)
        {
            var library = new Library();
            var user = new User(1, "Alice");

            var book1 = new Book(1, "1984", "George Orwell", "1234567890");
            var book2 = new Book(2, "To Kill a Mockingbird", "Harper Lee", "0987654321");


            library.AddBook(book1);
            library.AddBook(book2);

            Console.WriteLine("All books in the library:");
            foreach (var book in library.GetAllBooks())
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("\nAlice borrows '1984':");
            user.BorrowBook(book1);
            Console.WriteLine(book1);
            Console.WriteLine(user);

            Console.WriteLine("\nAlice returns '1984':");
            user.ReturnBook(book1);
            Console.WriteLine(book1);
            Console.WriteLine(user);
            Console.WriteLine(library.FindBookByID(1));


        }
    }
}