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
    public class GuideManager : IGuideService
    {
        IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void TAdd(Guide t)
        {
            _guideDal.Insert(t);
        }

        public void TChangetoFalse(int id)
        {
            _guideDal.ChangetoFalse(id);
        }

        public void TChangetoTrue(int id)
        {
            _guideDal.ChangetoTrue(id);
        }

        public void TDelete(Guide t)
        {
            throw new NotImplementedException();
        }

        public void TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Guide> TGetlist()
        {
            return _guideDal.GetList();
        }

        public void TUpdate(Guide t)
        {
            _guideDal.Update(t);
        }

        Guide IGenericService<Guide>.TGetById(int id)
        {
            return _guideDal.GetById(id);
        }
    }
}
