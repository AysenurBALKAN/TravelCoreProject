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
   public class TestimonialManager:ITestimonialService
    {
        ITestimonialDal _testimanoailDal;

        public TestimonialManager(ITestimonialDal testimanoailDal)
        {
            _testimanoailDal = testimanoailDal;
        }

        public void TAdd(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public void TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> TGetlist()
        {
            return _testimanoailDal.GetList();
        }

        public void TUpdate(Testimonial t)
        {
            throw new NotImplementedException();
        }

        Testimonial IGenericService<Testimonial>.TGetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
