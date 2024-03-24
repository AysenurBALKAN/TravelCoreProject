using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEntityLayer.Concrete;

namespace TBusinessLayer.Abstract
{
  public  interface IContactUsService:IGenericService<ContactUs>
    {
        List<ContactUs> TGetListByTrue();
        List<ContactUs> TGetListByFalse();
        void TContactUsStatusChangeByFalse(int id);
    }
}
