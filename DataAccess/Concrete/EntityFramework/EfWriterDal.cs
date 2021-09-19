using Core.DataAccess.EntityRepository;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfWriterDal:EfEntityRepositoryBase<Writer, Context>,IWriterDal
    {
    }
}
