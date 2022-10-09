using BusinessLayer.Abstract;
using BusinessLayer.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {

            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), Messages.ProductsListed);

        }

        public IDataResult<Category> GetById(int CategoryID)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryID == CategoryID));
        } 

        public IResult Add(Category category)
        {
            //iş kodları buraya... eğer ürün öyleyse böyleyse kodları... her şey geçerliyse ekle geçersizse ekleme

            _categoryDal.Add(category);

            return new SuccessResult(Messages.ProductAdded);
        }
    }
}
