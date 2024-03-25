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
   public class FeatureManager:IFeatureService
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Feature t)
        {
            throw new NotImplementedException();
        }

        public void TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> TGetlist()
        {
            return _featureDal.GetList();
        }

        public void TUpdate(Feature t)
        {
            throw new NotImplementedException();
        }

        Feature IGenericService<Feature>.TGetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
