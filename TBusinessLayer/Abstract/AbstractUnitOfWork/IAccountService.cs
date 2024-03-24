using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEntityLayer.Concrete;

namespace TBusinessLayer.Abstract.AbstractUnitOfWork
{
   public interface IAccountService:IGenericUOWService<Account>
    {
    }
}
