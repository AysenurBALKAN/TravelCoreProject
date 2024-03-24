using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEntityLayer.Concrete;

namespace TBusinessLayer.Abstract
{
   public interface ICommentService:IGenericService<Comment>
    {
        List<Comment> TGetListCommentWithDestination();
    }
}
