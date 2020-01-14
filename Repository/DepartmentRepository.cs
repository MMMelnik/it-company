using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using it_company.ViewModels;

namespace it_company.Repository
{
    class DepartmentRepository : DataRepository<Department>
    {
        public DepartmentRepository(DataContext context) : base(context)
        {
        }

        public override Department GetById(int id)
        {
            return Context.Departments.Find(id);
        }

        public override List<Department> GetAll()
        {
            return Context.Departments.ToList();
        }

        public override List<Department> GetAll(Expression<Func<Department, bool>> predicate)
        {
            return Context.Departments.Where(predicate).ToList();
        }

        public override void Add(Department entity)
        {
            Context.Entry(entity).State = EntityState.Added;
        }

        public override void Dell(Department entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
        }

        public override void Edit(Department entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

        public override void Save()
        {
            Context.SaveChanges();
        }
    }
}
