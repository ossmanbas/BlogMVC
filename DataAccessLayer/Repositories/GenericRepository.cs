using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<TEntity> : IGenericDAL<TEntity> where TEntity : class
    {
        Context c = new Context();
        public void Delete(TEntity entity)
        {
            c.Remove(entity);
            c.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
            return c.Set<TEntity>().ToList();
        }

        public TEntity GetByID(int id)
        {
            return c.Set<TEntity>().Find(id);
        }

        public void Insert(TEntity entity)
        {
            
            c.Add(entity);
            c.SaveChanges();
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter)
        {
           
            return c.Set<TEntity>().Where(filter).ToList();
        }

        public void Update(TEntity entity)
        {
            c.Update(entity);
            c.SaveChanges();
        }
    }
}
