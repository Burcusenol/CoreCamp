﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Add(Blog blog)
        {
            _blogDal.Insert(blog);
        }

        public void Delete(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public List<Blog> GetAll()
        {
            return _blogDal.GetAll();
        }

        public Blog GetById(int id)
        {
            return _blogDal.Get(i => i.BlogId==id);
        }

        public List<Blog> GetWithCategoroy()
        {
            return _blogDal.GetWithCategory();
        }

        public void Update(Blog blog)
        {
            _blogDal.Update(blog);
        }
    }
}
