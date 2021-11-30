using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{

    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            return new SuccessResult(Messages.CategoryAdded);
        }

        public IResult Delete(Category category)
        {
            return new SuccessResult(Messages.CategoryDeleted);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetAllByCategoryId(int Id)
        {
            return _categoryDal.Get(c => c.Id == Id);
        }

        public IResult Update(Category category)
        {
            return new SuccessResult(Messages.CategoryUpdated);
        }

        IDataResult<List<Category>> ICategoryService.GetAll()
        {
            throw new NotImplementedException();
        }

        IDataResult<Category> ICategoryService.GetAllByCategoryId(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
