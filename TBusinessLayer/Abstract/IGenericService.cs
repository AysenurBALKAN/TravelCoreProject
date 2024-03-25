﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TBusinessLayer.Abstract
{
public    interface IGenericService<T>
    {
        void TAdd(T t);

        void TDelete(T t);

        void TUpdate(T t);

        List<T> TGetlist();

        T TGetById(int id);

        //List<T> TGetByFilter(Expression<Func<T, bool>> filter);
    }
}