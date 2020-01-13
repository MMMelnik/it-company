using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using it_company.Models;

namespace it_company.ViewModels
{
    class EmployeeWorkspaceModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public EmployeeWorkspaceModel(ref User user) 
        {
        }
    }
}
