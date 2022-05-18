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
    public class CommentRepository : GenericRepository<Comment>
    {
        Context c = new Context();
        public void Delete(Comment entity)
        {
            c.Remove(entity);
            c.SaveChanges();
        }

        public List<Comment> GetAll()
        {
            return c.Set<Comment>().ToList();

        }

        public Comment GetByID(int id)
        {
            return c.Set<Comment>().Find(id);
        }

        public void Insert(Comment entity)
        {
            c.Add(entity);
            c.SaveChanges();
        }

        public void Update(Comment entity)
        {
            c.Update(entity);
            c.SaveChanges();
        }
    }
}
