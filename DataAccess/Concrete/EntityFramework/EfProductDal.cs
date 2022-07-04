using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using (dbContext context = new dbContext())
            {
                var addedEntity = context.Entry(entity); //ref i yakala
                addedEntity.State = EntityState.Added; // bu aslında eklenebilecek bi nesne
                context.SaveChanges(); //ekle 
            }
        }

        public void Delete(Product entity)
        {
#pragma warning disable IDE0090 // 'new(...)' kullanın
            using (dbContext context = new dbContext())
#pragma warning restore IDE0090 // 'new(...)' kullanın
            {
                var deletedEntity = context.Entry(entity); 
                deletedEntity.State = EntityState.Deleted; 
                context.SaveChanges(); 
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            using (dbContext context = new dbContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
