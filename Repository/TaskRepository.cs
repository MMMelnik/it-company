using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using it_company.Models;

namespace it_company.Repository
{
    public class TaskRepository : DataRepository<Task>
    {
        public TaskRepository(DataContext context) : base(context)
        {
        }

        public override void Add(Task entity)
        {
            Context.Entry(entity).State = EntityState.Added;
        }

        public override void Dell(Task entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
        }

        public override void Edit(Task entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

        public override List<Task> GetAll()
        {
            return Context.Tasks.ToList();
        }

        public override List<Task> GetAll(Expression<Func<Task, bool>> predicate)
        {
            return Context.Tasks.Where(predicate).ToList();
        }

        public override Task GetById(int id)
        {
            return Context.Tasks.Find(id);
        }

        public override void Save()
        {
            Context.SaveChanges();
        }
    }
}
