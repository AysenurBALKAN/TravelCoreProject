﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBusinessLayer.Abstract;
using TDataAccesLayer.Abstract;
using TEntityLayer.Concrete;

namespace TBusinessLayer.Concrete
{
    public class SubAboutManager : ISubAboutService
    {
        ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public void TAdd(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public void TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> TGetlist()
        {
            return _subAboutDal.GetList();
        }

        public void TUpdate(SubAbout t)
        {
            throw new NotImplementedException();
        }

        SubAbout IGenericService<SubAbout>.TGetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
