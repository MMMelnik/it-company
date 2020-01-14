using System.Windows;
using System.Windows.Input;
using it_company.ViewModels;

namespace it_company.Views
{
    /// <summary>
    /// Interaction logic for ForgotPassword.xaml
    /// </summary>
    public partial class ForgotPassword : Window
    {
        public ForgotPassword()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            ForgotPasswordViewModel forPassMod = new ForgotPasswordViewModel();
            DataContext = forPassMod;
            forPassMod.Closing += (s, e) => Close();
        }
    }
}