using System.Data.Entity;
using it_company.ViewModels;

namespace it_company.Repository
{
    public class DataContext : DbContext
    {
        static DataContext()
        {
            Database.SetInitializer(new DataContextInitialization());
        }

        public DataContext() : base("DataContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
