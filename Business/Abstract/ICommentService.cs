using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICommentService
    {
        void Add(Comment comment);
        void Update(Comment comment);
        void Delete(Comment comment);
        List<Comment> GetAll();
        Comment GetById(int id);
    }
}
