using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using it_company.ViewModels;

namespace it_company.ViewModels
{
    class AdminWorkspaceModel : INotifyPropertyChanged
    {
        public AdminWorkspaceModel(ref User user)
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
