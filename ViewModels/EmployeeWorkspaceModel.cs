using System;
using System.ComponentModel;
using it_company.Models;

namespace it_company.ViewModels
{
    class EmployeeWorkspaceModel : INotifyPropertyChanged
    {
        public EmployeeWorkspaceModel(ref User user) 
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public event EventHandler Closing;
    }
}
