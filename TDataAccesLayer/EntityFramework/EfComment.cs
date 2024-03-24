using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDataAccesLayer.Abstract;
using TDataAccesLayer.Concrete;
using TDataAccesLayer.Repository;
using TEntityLayer.Concrete;

namespace TDataAccesLayer.EntityFramework
{
    public class EfComment : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetListCommentWithDestination()
        {
            using (var c = new Context()) {
                return c.Comments.Include(x => x.Destination).ToList();
                    }
        }
    }
}
