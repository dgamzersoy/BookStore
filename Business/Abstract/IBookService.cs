using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IBookService
    {
        List<Book> GetAll();
        List<Book> GetAllByCategory(int categoryId);

        void Add(Book book);
        List<BookDetailDto> GetBookDetails();
    }
}
