using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEntityLayer.Concrete;

namespace TBusinessLayer.Abstract
{
   public interface IGuideService:IGenericService<Guide>
    {
        void TChangetoTrue(int id);
        void TChangetoFalse(int id);
    }
}
