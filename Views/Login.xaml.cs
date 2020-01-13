using System.Windows;
using it_company.ViewModels;

namespace it_company.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            LoginViewModel loginViewModel = new LoginViewModel();

            DataContext = loginViewModel;

            loginViewModel.Closing += (s, e) => Close();
        }

        public Login(string email)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.TbEmail.Text = email;
            InitializeComponent();
            LoginViewModel loginViewModel = new LoginViewModel(email);

            DataContext = loginViewModel;

            loginViewModel.Closing += (s, e) => Close();
        }

    }
}

