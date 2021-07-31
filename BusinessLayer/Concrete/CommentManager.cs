using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class CommentManager
    {
        Repository<Comment> repocomment = new Repository<Comment>();
        public List<Comment> CommentList()
        {
            return (List<Comment>)repocomment.List();
        }
        public List<Comment> CommentByBlog(int id)
        {
            return repocomment.List(x => x.BlogID == id);
        }
        public int CommendAdd(Comment c)
        {
            if(c.CommentText.Length<=4 || c.CommentText.Length>=300 || c.UserName=="" || c.Mail==" "||c.UserName.Length<=5)
            {
                return -1;
            }
            return repocomment.Insert(c);
        }
    }
}
