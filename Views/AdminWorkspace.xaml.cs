using System.Windows;
using it_company.ViewModels;
using it_company.Models;

namespace it_company.Views
{
    /// <summary>
    /// Interaction logic for AdminWorkspace.xaml
    /// </summary>
    public partial class AdminWorkspace : Window
    {
        public AdminWorkspace(ref User user)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            AdminWorkspaceModel adWrkMod = new AdminWorkspaceModel(ref user);
            DataContext = adWrkMod;
            adWrkMod.Closing += (s, e) => Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login log = new Login();
            log.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NewEmployee newEmp = new NewEmployee();
            newEmp.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NewDepartment newDep = new NewDepartment();
            newDep.Show();
            Close();
        }
    }
}
