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
    public class EfGuideDal : GenericRepository<Guide>, IGuideDal
    {
        Context context = new Context();
        public void ChangetoFalse(int id)
        {
            var values = context.Guides.Find(id);
            values.Status = false;
            context.Update(values);
            context.SaveChanges();
        }

        public void ChangetoTrue(int id)
        {
            var values = context.Guides.Find(id);
            values.Status = true;
            context.Update(values);
            context.SaveChanges();
        }
    }
}
