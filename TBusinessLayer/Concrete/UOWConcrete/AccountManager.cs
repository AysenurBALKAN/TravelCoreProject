using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBusinessLayer.Abstract.AbstractUnitOfWork;
using TDataAccesLayer.Abstract;
using TDataAccesLayer.UnitOfWork;
using TEntityLayer.Concrete;

namespace TBusinessLayer.Concrete.UOWConcrete
{
    public class AccountManager : IAccountService
    {
        private readonly IAccountDal _accountDal;
        private readonly IUnitOfWorkDal _unitOfWorkDal;

        public AccountManager(IAccountDal accountDal, IUnitOfWorkDal unitOfWorkDal)
        {
            _accountDal = accountDal;
            _unitOfWorkDal = unitOfWorkDal;
        }

        public Account TGetById(int id)
        {
           return  _accountDal.GetById(id);
        }

        public void TInsert(Account t)
        {
            _accountDal.Insert(t);
            _unitOfWorkDal.save();
        }

        public void TMultiUpdate(List<Account> t)
        {
            _accountDal.MultiUpdate(t);
            _unitOfWorkDal.save();
        }

        public void TUpdate(Account t)
        {
            _accountDal.Update(t);
            _unitOfWorkDal.save();
        }
    }
}
