using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Q1
{
    //class=book(public-because everyone can access it).
    public class Book
    {
        //properties-title & author(these are string data type).
        public String Title;
        public String Author;
    }

    internal class Program
    {
        static void Main()
        {
            Book book = new Book();
            book.Author = "Martin Wikramesinghe";
            book.Title = "Madol Duwa";

            Console.WriteLine(book.Title);
            Console.WriteLine(book.Author);
        }
    }
}