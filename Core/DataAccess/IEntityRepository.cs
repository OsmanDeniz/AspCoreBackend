﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {

        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T tEntity);
        void Update(T tEntity);
        void Delete(T tEntity);

    }
}

// server=127.0.0.1;user id=root;persistsecurityinfo=True;database=northwind