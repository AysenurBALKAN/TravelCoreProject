using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBusinessLayer.Abstract;
using TDataAccesLayer.Abstract;
using TEntityLayer.Concrete;

namespace TBusinessLayer.Concrete
{
  public  class ContactUsManager:IContactUsService
    {
        IContactUs _contactUs;

        public ContactUsManager(IContactUs contactUs)
        {
            _contactUs = contactUs;
        }

        public void TAdd(ContactUs t)
        {
            throw new NotImplementedException();
        }

        public void TContactUsStatusChangeByFalse(int id)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ContactUs t)
        {
            throw new NotImplementedException();
        }

        public ContactUs TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> TGetlist()
        {
            return _contactUs.GetList();
        }

        public List<ContactUs> TGetListByFalse()
        {
            return _contactUs.GetListByFalse();
        }

        public List<ContactUs> TGetListByTrue()
        {
           return _contactUs.GetListByTrue();
        }

        public void TUpdate(ContactUs t)
        {
            throw new NotImplementedException();
        }
    }
}
