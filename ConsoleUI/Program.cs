using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BookManager bookManager = new BookManager(new EfBookDal());

            Book book1 = new Book();

            book1.BookName = "Ben";
            book1.UnitPrice = 0;
            book1.CategoryId = 1;
            book1.UnitsInStock = 1;
            book1.DateofIssue = DateTime.Parse("21/01/1993");

            bookManager.Add(book1);
           


            foreach (var book in bookManager.GetAll())
            {
                Console.WriteLine(book.BookName);
            }
            

        }
    }
}
