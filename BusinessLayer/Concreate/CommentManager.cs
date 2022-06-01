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
    public class CommentManager : ICommentService
    {
        ICommentDAL _commentDal;

        public CommentManager(ICommentDAL commentDal)
        {
            _commentDal = commentDal;
        }

        public void AddComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetList(int id)
        {
          return  _commentDal.GetAll(x => x.BlogID == id);
        }
    }
}
