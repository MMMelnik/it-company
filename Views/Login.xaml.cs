using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
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
            InitializeComponent();
            LoginViewModel loginViewModel = new LoginViewModel();

            DataContext = loginViewModel;

            loginViewModel.Closing += (s, e) => Close();
        }

        public Login(string email)
        {
            this.TbEmail.Text = email;
            InitializeComponent();
            LoginViewModel loginViewModel = new LoginViewModel(email);

            DataContext = loginViewModel;

            loginViewModel.Closing += (s, e) => Close();
        }

    }
}

