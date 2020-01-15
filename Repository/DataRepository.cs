using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace it_company.Repository
{
    public abstract class DataRepository<T> : IDataRepository<T> where T : class
    {
        protected DataContext Context;

        protected DataRepository(DataContext context)
        {
            Context = context;
        }

        public abstract T GetById(int id);
        public abstract List<T> GetAll();
        public abstract List<T> GetAll(Expression<Func<T, bool>> predicate);
        public abstract void Add(T entity);
        public abstract void Dell(T entity);
        public abstract void Edit(T entity);
        public abstract void Save();
    }
}
