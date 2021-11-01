using Core.DataAccess.EntityRepository;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBlogDal : EfEntityRepositoryBase<Blog, Context>, IBlogDal
    {
        public List<Blog> GetWithCategory()
        {
            using(var context=new Context())
            {
                return context.Blogs.Include(x => x.Category).ToList();
            }
             
        }
    }
}
