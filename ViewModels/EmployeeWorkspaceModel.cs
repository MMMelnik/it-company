using System;
using System.ComponentModel;
using it_company.Models;

namespace it_company.ViewModels
{
    class EmployeeWorkspaceModel : INotifyPropertyChanged
    {
        private User _currentUser = new User();

        public EmployeeWorkspaceModel(ref User user)
        {
            _currentUser = user;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public event EventHandler Closing;

        private int _selectedTaskId;

        public int SelectedTaskId
        {
            get { return _selectedTaskId; }
            set
            {
                if (value != _selectedTaskId)
                {
                    //open task
                    _selectedTaskId = value;
                }
            }
        }
        //public class Physician
        //{
        //    private int _selectedClinicId;

        //    public Physician()
        //    {
        //        Name = "Overpaid consultant";
        //        Clinics = new ObservableCollection<Clinic>
        //        {
        //            new Clinic {Id = 0, Name = "Out Patients"},
        //            new Clinic {Id = 1, Name = "ENT"},
        //            new Clinic {Id = 2, Name = "GE"},
        //        };
        //    }

        //    public string Name { get; set; }
        //    public IEnumerable<Clinic> Clinics { get; private set; }

        //    public int SelectedClinicId
        //    {
        //        get { return _selectedClinicId; }
        //        set
        //        {
        //            if (value != _selectedClinicId)
        //            {
        //                Debug.WriteLine(string.Format("setting clinic to: {0}", value));
        //                _selectedClinicId = value;
        //            }
        //        }
        //    }
        //}
    }
}
