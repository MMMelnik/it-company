using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace it_company.Repository
{
    interface IDataRepository<T> where T: class
    {
        T GetById(int id);
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Dell(T entity);
        void Edit(T entity);
        void Save();
    }
}
