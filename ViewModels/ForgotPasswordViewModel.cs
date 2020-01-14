using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using it_company.Views;

namespace it_company.ViewModels
{
    class ForgotPasswordViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        private RelayCommand _sendPassword;
        private RelayCommand _login;
        private RelayCommand _exit;

        private string _email;
        private string _password = "password";


        public event EventHandler Closing;

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public RelayCommand SendPassword
        {
            get
            {
                return _sendPassword ??
                       (_sendPassword = new RelayCommand(o =>
                       {
                           EmailService emailService = new EmailService();
                           emailService.sendPasswordOnEmail();
                           Login login = new Login();
                           login.Show();
                           Closing?.Invoke(this, EventArgs.Empty);
                       }));
            }
        }

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

        public RelayCommand Exit
        {
            get
            {
                return _exit ??
                       (_exit = new RelayCommand(o =>
                       {
                           Environment.Exit(0);
                       }));
            }
        }
    }
}
