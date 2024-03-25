using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEntityLayer.Concrete;

namespace TDataAccesLayer.Abstract
{
   public interface IContactUs:IGenericDal<ContactUs>
    {
        List<ContactUs> GetListByTrue();
        List<ContactUs> GetListByFalse();
        void ContactUsStatusChangeByFalse(int id);
      
    }
}
