using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBusinessLayer.Abstract.AbstractUnitOfWork
{
   public interface IGenericUOWService<T>
    {
        void TInsert(T t);
        void TMultiUpdate(List<T> t);
        void TUpdate(T t);
        T TGetById(int id);

    }
}
