using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using it_company.ViewModels;

namespace it_company.Repository
{
    class ProjectRepository : DataRepository<Project>
    {
        public ProjectRepository(DataContext context) : base(context)
        {
        }

        public override Project GetById(int id)
        {
            return Context.Projects.Find(id);
        }

        public override List<Project> GetAll()
        {
            return Context.Projects.ToList();
        }

        public override List<Project> GetAll(Expression<Func<Project, bool>> predicate)
        {
            return Context.Projects.Where(predicate).ToList();
        }

        public override void Add(Project entity)
        {
            Context.Entry(entity).State = EntityState.Added;
        }

        public override void Dell(Project entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
        }

        public override void Edit(Project entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

        public override void Save()
        {
            Context.SaveChanges();
        }
    }
}
