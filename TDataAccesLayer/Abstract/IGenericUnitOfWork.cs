using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TDataAccesLayer.Abstract
{
 public   interface IGenericUnitOfWork<T> where T:class
    {
        void Insert(T t);
        void MultiUpdate(List<T> t);
        void Update(T t);

        T GetById(int id);
       
    }
}
