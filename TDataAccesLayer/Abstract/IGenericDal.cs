using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TDataAccesLayer.Abstract
{
   public interface IGenericDal<T>//Entşty e karşılık gelen T parametresi
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();

        T GetById(int id);

        List<T> GetListByFilter(Expression<Func<T, bool>> filter);
    }
}
