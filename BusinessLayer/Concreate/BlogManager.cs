using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class BlogManager : IBlogService
    {
        IBlogDAL _blogDAL;

        public BlogManager(IBlogDAL blogDAL)
        {
            _blogDAL = blogDAL;
        }

        

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDAL.GetListWithCategory();
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }
        public List<Blog> GetBlogById(int id)
        {
            return _blogDAL.GetAll(x=>x.BlogID==id);
        }

        public List<Blog> GetList()
        {
            return _blogDAL.GetAll();
        }


        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDAL.GetAll(b => b.WriterID==id);
        }
        public List<Blog> GetLast3Blog()
        {
            return _blogDAL.GetAll().Take(3).ToList();
        }

        public void TAdd(Blog t)
        {
            throw new NotImplementedException();
        }

        public void TRemove(Blog t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Blog t)
        {
            throw new NotImplementedException();
        }
    }
}
