using DataAccess.Abstarct;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBookDal : IBookDal
    {
        public void Add(Book entity)
        {
            using (BookContext context = new BookContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Book entity)
        {
            using (BookContext context = new BookContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Book Get(Expression<Func<Book, bool>> filter)
        {
            using (BookContext context= new BookContext())
            {
                return context.Set<Book>().SingleOrDefault(filter);
            }
        }

        public List<Book> GetAll(Expression<Func<Book, bool>> filter = null)
        {
            using (BookContext context = new BookContext())
            {
                return filter == null
                    ? context.Set<Book>().ToList() 
                    : context.Set<Book>().Where(filter).ToList();
            }
        }

        public void Update(Book entity)
        {
            using (BookContext context = new BookContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
