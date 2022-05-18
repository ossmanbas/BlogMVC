using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDAL
    {
        Context c = new Context();
        public void Delete(Blog entity)
        {
            c.Remove(entity);
            c.SaveChanges();
        }

        public List<Blog> GetAll()
        {
            return c.Set<Blog>().ToList();
        }

        public Blog GetByID(int id)
        {
          return c.Set<Blog>().Find(id);
        }

        public void Insert(Blog entity)
        {
            c.Add(entity);
            c.SaveChanges();
        }

        public void Update(Blog entity)
        {
            c.Update(entity);
            c.SaveChanges();
        }
    }
}
