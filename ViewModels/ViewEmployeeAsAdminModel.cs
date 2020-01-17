using System;
using System.ComponentModel;
using it_company.Models;

namespace it_company.ViewModels
{
    class ViewEmployeeAsAdminModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ViewEmployeeAsAdminModel(ref User employee)
        {
            _employee = employee;
            FirstName = employee.FName;
            LastName = employee.LName;
            //Email 

        }

        public void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public event EventHandler Closing;

        private RelayCommand _saveChanges;
        private RelayCommand _deleteEmployee;

        private string _fName;
        private string _lName;
        private string _email;
        private Role _role;
        private User _employee;

        public string FirstName
        {
            get => _fName;
            set
            {
                _fName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }
        public string LastName
        {
            get => _lName;
            set
            {
                _lName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public Role SelectedRole
        {
            get => _role;
            set
            {
                _role = value;
                OnPropertyChanged(nameof(SelectedRole));
            }
        }
    }
}
