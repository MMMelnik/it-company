using System.Windows;
using it_company.Models;
using it_company.ViewModels;

namespace it_company.Views
{
    /// <summary>
    /// Interaction logic for EmployeeWorkspace.xaml
    /// </summary>
    public partial class EmployeeWorkspace : Window
    {
        public EmployeeWorkspace(ref User user)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            EmployeeWorkspaceModel empWrkMod = new EmployeeWorkspaceModel(ref user);

            DataContext = empWrkMod;
            empWrkMod.Closing += (s, e) => Close();
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            ViewTaskAsEmployee empTask = new ViewTaskAsEmployee();
            empTask.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login logIn = new Login();
            logIn.Show();
            Close();
        }
    }
}
