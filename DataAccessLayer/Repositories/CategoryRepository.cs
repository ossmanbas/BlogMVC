using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate
{
    public class CategoryRepository : ICategoryDAL
    {
        Context c = new Context();
        public void Delete(Category entity)
        {
            c.Remove(entity);
            c.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return c.Set<Category>().ToList();

        }

        public Category GetByID(int id)
        {
            return c.Set<Category>().Find(id);
        }

        public void Insert(Category entity)
        {
            c.Add(entity);
            c.SaveChanges();
        }

        public void Update(Category entity)
        {
            c.Update(entity);
            c.SaveChanges();
        }
    }
}
