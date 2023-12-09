using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CommentManager
    {
        Repository<Comment> repoComment = new Repository<Comment>();

        public List<Comment> CommentList() // bütün yorumları getirir bu yüzde admin panelinde kullanılacak
        {
            return repoComment.List();
        }
        public List<Comment> GetCommentByBlog(int id) // blog idlerine göre yorumların getirilmesi 
        {
            return repoComment.List(x => x.BlogID == id);
        }
        public int CommentAdd(Comment c)
        {
            if(c.CommentText.Length<=4 || c.CommentText.Length>=301||
                c.UserName == "" || c.Mail=="" || c.UserName.Length <= 4)
            {
                return -1;
            }
            return repoComment.Insert(c);
        }
    }
}
