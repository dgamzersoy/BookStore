using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IBookService
    {
        IDataResult<List<Book>> GetAll();

        IDataResult<Book> GetBookByCategoryId(int categoryId);

        IResult Add(Book book);
        IResult Update(Book book);
        IResult Delete(Book book);
      
        IDataResult<List<BookDetailDto>> GetBookDetails();

        IDataResult<Book> GetById(int id);
    
    }
}
