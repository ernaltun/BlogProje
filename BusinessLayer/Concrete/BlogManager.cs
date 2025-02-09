﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class BlogManager
    {
        Repository<Blog> repoBlog = new Repository<Blog>();

        public List<Blog> GetAll()
        {
            return repoBlog.List();
        }
        public List<Blog> GetBlogByID(int id)
        {
            return repoBlog.List(x => x.BlogID == id);
        }
        public List<Blog> GetBlogByAuthor(int id)
        {
            return repoBlog.List(x =>x.AuthorID == id);
        }
        public List<Blog> BlogByCategory(int id)
        {
            return repoBlog.List(x =>x.CategoryID == id);
        }
        public int BlogAddPl(Blog p)
        {
            if (p.BlogTitle == "" || p.BlogImage == "" || p.BlogTitle.Length <= 5
                || p.BlogContent.Length <= 200)
            {
                return -1;
            }
            return repoBlog.Insert(p);
        }
        public int DeleteBlogBL(int p)
        {
            Blog blog = repoBlog.Find(x => x.BlogID == p);
            return repoBlog.Delete(blog);
        }
        public Blog FindBlog(int id)
        {
            return repoBlog.Find(x=>x.BlogID == id);
        }
        public int UpdateBlog(Blog p)
        {
            Blog blog = repoBlog.Find(x => x.BlogID == p.BlogID);
            blog.BlogTitle = p.BlogTitle;
            blog.BlogContent = p.BlogContent;
            blog.BlogDate = p.BlogDate;
            blog.BlogImage = p.BlogImage;
            blog.CategoryID = p.CategoryID;
            blog.AuthorID = p.AuthorID;
            return repoBlog.Update(blog);
        }
    }
}
