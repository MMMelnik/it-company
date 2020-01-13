using System.Windows;
using it_company.ViewModels;

namespace it_company.Views
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            RegistrationViewModel registrationViewModel = new RegistrationViewModel();
            DataContext = registrationViewModel;

            registrationViewModel.Closing += (s, e) => Close();
        }
    }
}
