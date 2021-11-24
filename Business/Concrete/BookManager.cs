using Business.Abstract;
using DataAccess.Abstarct;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void Add(Book book)
        {
            if (book.UnitPrice <= 0 || book.BookName.Length <= 2)
            {
                Console.WriteLine("Eksik giriş yaptınız");
            }
            else
            {
                _bookDal.Add(book);
            }
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }

        public List<Book> GetAllByCategory(int categoryId)
        {
            return _bookDal.GetAll(b => b.CategoryId == categoryId);
        }

        public List<BookDetailDto> GetBookDetails()
        {
            return _bookDal.GetBookDetails();
        }
    }
}