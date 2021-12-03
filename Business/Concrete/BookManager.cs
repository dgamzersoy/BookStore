using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
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

        [ValidationAspect(typeof(BookValidator))]
        public IResult Add(Book book)
        {
           
                _bookDal.Add(book);

            return new SuccessResult(Messages.BookAdded);
        }

        public IResult Delete(Book book)
        {
            return new SuccessResult(Messages.BookDeleted);
        }

        public IDataResult< List<Book>> GetAll()
        {
            if(DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Book>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll());
        }


        public IDataResult<Book> GetBookByCategoryId(int categoryId)
        {
            return new SuccessDataResult<Book>(_bookDal.Get(b => b.CategoryId == categoryId));
        }

        public IDataResult<List<BookDetailDto>> GetBookDetails()
        {
            return new SuccessDataResult<List<BookDetailDto>>( _bookDal.GetBookDetails());
        }

        public IDataResult< Book> GetById(int id)
        {
            return new SuccessDataResult<Book> (_bookDal.Get(b=>b.Id==id));
        }

        public IResult Update(Book book)
        {
            return new SuccessResult(Messages.BookUpdated);
        }
    }
}