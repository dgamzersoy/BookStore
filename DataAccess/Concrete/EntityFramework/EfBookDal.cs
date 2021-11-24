using Core.DataAccess.EntityFramework;
using DataAccess.Abstarct;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBookDal : EfEntityRepositoryBase<Book, BookContext>, IBookDal
    {
        public List<BookDetailDto> GetBookDetails()
        {
            using (BookContext context = new BookContext())
            {
                var result = from b in context.Books
                             join c in context.Categories
                             on b.CategoryId equals c.Id
                             select new BookDetailDto
                             {
                                 Id = b.Id,
                                 BookName = b.BookName,
                                 CategoryName = c.CategoryName,
                                 UnitsInStock = b.UnitsInStock,
                                 UnitPrice = b.UnitPrice
                             };
                return result.ToList();
            }
        }
    }
}
