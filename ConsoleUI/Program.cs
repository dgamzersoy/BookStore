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
         

            //BookTest(bookManager);

            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
           

        }

        private static void BookTest(BookManager bookManager)
        {
            foreach (var book in bookManager.GetAll())
            {
                Console.WriteLine(book.BookName);
            }
        }
    }
}
