﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDAL<TEntity> where TEntity : class
    {
        void Insert(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        List<TEntity> GetAll();

        TEntity GetByID(int id);
        List<TEntity> GetAll(Expression<Func<TEntity,bool>> filter);
    }
}
