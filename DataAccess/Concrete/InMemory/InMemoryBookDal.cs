using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBookDal : IBookDal
    {
        List<Book> _books;
        public InMemoryBookDal()
        {
            _books = new List<Book>
            {
                new Book{Id=1, CategoryId=2, BookName="Fareler ve İnsanlar", DateofIssue=DateTime.Parse("12/11/2004"), UnitPrice=20, UnitsInStock=10},
                 new Book{Id=2, CategoryId=2, BookName="Kanatlar", DateofIssue=DateTime.Parse("12/11/2004"), UnitPrice=20, UnitsInStock=10},
                  new Book{Id=3, CategoryId=2, BookName="Karıncalar", DateofIssue=DateTime.Parse("12/11/2004"), UnitPrice=20, UnitsInStock=10},


            };
        }
        public void Add(Book book)
        {
            _books.Add(book);
        }

        public void Delete(Book book)
        {
            Book bookToDelete = _books.SingleOrDefault(b => b.Id == book.Id);
          _books.Remove(bookToDelete);
        }

        public Book Get(Expression<Func<Book, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            return _books;
        }

        public List<Book> GetAll(Expression<Func<Book, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllByCategory(int categoryId)
        {
            return _books.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Book book)
        {
            Book bookToUpdate = _books.SingleOrDefault(b => b.Id == book.Id);
            bookToUpdate.CategoryId = book.CategoryId;
            bookToUpdate.BookName = book.BookName;
            bookToUpdate.DateofIssue = book.DateofIssue;
            bookToUpdate.UnitPrice = book.UnitPrice;
            bookToUpdate.UnitsInStock = book.UnitsInStock;
        }
    }
}
