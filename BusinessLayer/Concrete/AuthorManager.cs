﻿using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
