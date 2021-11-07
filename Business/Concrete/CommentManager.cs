using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public IResult Add(Comment comment)
        {
            _commentDal.Insert(comment);
            return new SuccessResult(Messages.CommentAdded);
        }



        public IDataResult<List<Comment>> GetList(int id)
        {
            return new SuccessDataResult<List<Comment>>(_commentDal.GetAll(x => x.BlogId == id), Messages.CommentListed);
        }

       
    }
}
