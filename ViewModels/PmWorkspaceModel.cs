using System;
using System.ComponentModel;
using it_company.Models;

namespace it_company.ViewModels
{
    class PmWorkspaceModel : INotifyPropertyChanged
    {
        public PmWorkspaceModel(ref User user)
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler Closing;
    }
}
