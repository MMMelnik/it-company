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
        }

        private void TblForgotPassword_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ForgotPassword fgpass = new ForgotPassword();
            fgpass.Show();
            Close();
        }

        private void TblRegistration_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Register register = new Register();
            register.Show();
            Close();
        }

        private void TblExit_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            EmployeeWorkspace empWork = new EmployeeWorkspace();
            AdminWorkspace admWork = new AdminWorkspace();
            PMWorkspace pmWork = new PMWorkspace();
            //Thread.Sleep(50);
            empWork.Show();
            admWork.Show();
            pmWork.Show();
            Close();
        }
    }
}

