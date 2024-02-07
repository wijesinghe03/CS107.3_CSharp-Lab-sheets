using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Q5
{
    class LibraryBook
    {
        // Properties
        public string Title { get; }
        public string Author { get; }
        private bool _available;

        // Constructor
        public LibraryBook(string title, string author, bool available)
        {
            Title = title;
            Author = author;
            _available = available;
        }

        // Method to borrow book
        public void BorrowBook()
        {
            if (_available)
            {
                _available = false;
                Console.WriteLine($"The book \"{Title}\" by {Author} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"Sorry, the book \"{Title}\" by {Author} is currently not available.");
            }
        }

        // Method to display book details
        public void DisplayBookDetails()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Available: {_available}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate multiple book objects
            List<LibraryBook> books = new List<LibraryBook>
        {
            new LibraryBook("The Great Gatsby", "F. Scott Fitzgerald", true),
            new LibraryBook("To Kill a Mockingbird", "Harper Lee", false),
            new LibraryBook("1984", "George Orwell", true),
            new LibraryBook("Pride and Prejudice", "Jane Austen", true)
        };

            // Display library status before borrowing
            Console.WriteLine("Library Status Before Borrowing:");
            foreach (var book in books)
            {
                book.DisplayBookDetails();
            }

            // Borrow a book
            books[1].BorrowBook(); // Borrow "To Kill a Mockingbird"

            // Display updated library status
            Console.WriteLine("\nLibrary Status After Borrowing:");
            foreach (var book in books)
            {
                book.DisplayBookDetails();
            }
        }
    }
}