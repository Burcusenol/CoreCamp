using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBlogService
    {
        IResult Add(Blog blog);
        IResult Update(Blog blog);
        IResult Delete(Blog blog);
        IDataResult<List<Blog>> GetAll();
        IDataResult<List<Blog>> GetBlogDetail(int id);
        IDataResult<Blog> GetById(int id);
        IDataResult<List<Blog>> GetWithCategoroy();
        
    }
}
