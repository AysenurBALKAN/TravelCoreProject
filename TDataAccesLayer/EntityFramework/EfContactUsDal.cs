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
    public class EfContactUsDal : GenericRepository<ContactUs>, IContactUs
    {
        public void ContactUsStatusChangeByFalse(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> GetListByFalse()
        {
            using(var c=new Context())
            {
                var values = c.ContactUses.Where(x => x.MessageStatus == false).ToList();
                return values;
            }
        }

        public List<ContactUs> GetListByTrue()
        {
            using (var c = new Context())
            {
                var values = c.ContactUses.Where(x => x.MessageStatus == true).ToList();
                return values;
            }
        }
    }
}
