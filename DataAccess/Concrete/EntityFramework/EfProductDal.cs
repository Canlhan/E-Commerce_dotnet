using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, dbContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (dbContext context = new dbContext())
            {
                var result = from p in context.Product
                             join c in context.Category
                             on p.CategoryID equals c.CategoryID
                             select new ProductDetailDto { ProductID = p.ProductID, ProductName = p.ProductName, CategoryName = c.CategoryName, UnitsInStock = p.UnitsInStock };
                return result.ToList();
            }
        }
    }
}
