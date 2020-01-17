using System;
using System.Collections.Generic;
using System.ComponentModel;
using it_company.Models;
using it_company.Repository;
using it_company.Views;

namespace it_company.ViewModels
{
    class AdminWorkspaceModel : INotifyPropertyChanged
    {
        public AdminWorkspaceModel(ref User user)
        {
            UpdateDepartments();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public event EventHandler Closing;

        private RelayCommand _login;
        private RelayCommand _addNewDepartment;
        private RelayCommand _addNewEmployee;
        private RelayCommand _viewEmployee;

        //Binding Departments
        //Binding SelectedDepartment
        //private IService _service = SocketService.GetInstance();
        private List<Department> _departments;
        private List<User> _employeesInDepartment;
        private Department _selectedDepartment;
        private User _selectedEmployee;

        public List<Department> Departments
        {
            get => _departments;
            set
            {
                _departments = value;
                OnPropertyChanged("Departments");
            }
        }

        public Department SelectedDepartment
        {
            get => _selectedDepartment;
            set
            {
                _selectedDepartment = value;
                OnPropertyChanged("SelectedDepartment");
                UpdateEmployeesInDepartment();
            }
        }

        public List<User> EmployeesInDepartment
        {
            get => _employeesInDepartment;
            set
            {
                _employeesInDepartment = value;
                OnPropertyChanged("EmployeesInDepartment");
            }
        }

        public User SelectedEmployee
        {
            get => _selectedEmployee;
            set
            {
                _selectedEmployee = value;
                OnPropertyChanged("SelectedEmployee");
                //UpdateEmployeesInDepartment();
            }
        }

        private void UpdateDepartments()
        {
            using (DataContext dataContext = new DataContext())
            {
                DepartmentRepository depRep = new DepartmentRepository(dataContext);
                Departments = depRep.GetAll();
            }
        }

        private void UpdateEmployeesInDepartment()
        {
            using (DataContext dataContext = new DataContext())
            {
                UserRepository userRepository = new UserRepository(dataContext);
                EmployeesInDepartment  = userRepository.GetAll(i => i.DepartmentId == SelectedDepartment.DepartmentId);
            }
        }
        //Binding EmployeesInDepartmentCollection
        //Binding SelectedEmployeeObject

        //Binding UnassignedEmployeesCollection
        //Binding SelectedEmployeeObject

        public RelayCommand Login
        {
            get
            {
                return _login ??
                       (_login = new RelayCommand(o =>
                       {
                           Login login = new Login();

                           login.Show();
                           Closing?.Invoke(this, EventArgs.Empty);
                       }));
            }
        }

        public RelayCommand AddDepartment
        {
            get
            {
                return _login ??
                       (_login = new RelayCommand(o =>

                       {
                           Login login = new Login();
                           login.Show();
                           Closing?.Invoke(this, EventArgs.Empty);
                       }));
            }
        }

        public RelayCommand ViewSelectedEmployee
        {
            get
            {
                return _viewEmployee ??
                       (_viewEmployee = new RelayCommand(o =>
                       {
                           var viewEmployee = new ViewEmployeeAsAdmin(ref _selectedEmployee);
                           viewEmployee.Show();
                       }));
            }
        }
    }
}
