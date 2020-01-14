using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using it_company.ViewModels;

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
