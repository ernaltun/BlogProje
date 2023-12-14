using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AuthorManager
    {
        Repository<Author> repoAuthor = new Repository<Author>();

        public List<Author> GetAll()
        {
            return repoAuthor.List();
        }
        public int AddAuthorBL(Author p)
        {
			if (p.AuthorName == "" | p.AuthorShort == "" | p.AuthorTitle == "")
			{
				return -1;
			}
			return repoAuthor.Insert(p);

		}
		public Author FindAuthor(int id)
		{
			return repoAuthor.Find(x => x.AuthorID == id);
		}
		public int UpdateAuthorBL(Author p)
        {
            Author author = repoAuthor.Find(x => x.AuthorID == p.AuthorID);
			author.AuthorName = p.AuthorName;
			author.AuthorShort = p.AuthorShort;
			author.AuthorTitle = p.AuthorTitle;
			author.AuthorAbout = p.AuthorAbout;
			author.AuthorImage = p.AuthorImage;
			author.Mail = p.Mail;
			author.Password = p.Password;
			author.PhoneNumber = p.PhoneNumber;
            return repoAuthor.Update(p);
        }
		

	}
}
