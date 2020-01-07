using System.Data.Entity;


namespace it_company.Repository
{
    class DataContextInitialization : CreateDatabaseIfNotExists<DataContext>
    {
        UserRepository _userRepository;
        TaskRepository _taskRepository;
        ProjectRepository _projectRepository;
        DepartmentRepository _departmentRepository;

        protected override void Seed(DataContext context)
        {
            _projectRepository = new ProjectRepository(context);
            _userRepository = new UserRepository(context);
            _departmentRepository = new DepartmentRepository(context);
            _taskRepository = new TaskRepository(context);
        }
    }
}
