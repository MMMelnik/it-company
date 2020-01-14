using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using it_company.ViewModels;

namespace it_company.Repository
{
    class UserRepository : DataRepository<User>
    {
        public UserRepository(DataContext context) : base(context)
        {
        }

        public override User GetById(int id)
        {
            return Context.Users.Find(id);
        }

        public override List<User> GetAll()
        {
            return Context.Users.ToList();
        }

        public override List<User> GetAll(Expression<Func<User, bool>> predicate)
        {
            return Context.Users.Where(predicate).ToList();
        }

        public override void Add(User entity)
        {
            Context.Entry(entity).State = EntityState.Added;
        }

        public override void Dell(User entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
        }

        public override void Edit(User entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

        public override void Save()
        {
            Context.SaveChanges();
        }
    }
}
