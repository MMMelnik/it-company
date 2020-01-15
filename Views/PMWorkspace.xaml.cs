using System.Windows;
using it_company.ViewModels;
using it_company.Models;

namespace it_company.Views
{
    /// <summary>
    /// Interaction logic for PMWorkspace.xaml
    /// </summary>
    public partial class PmWorkspace : Window
    {
        public PmWorkspace(ref User user)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            PmWorkspaceModel pmWrkMod = new PmWorkspaceModel(ref user);
            DataContext = pmWrkMod;
            pmWrkMod.Closing += (s, e) => Close();
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            ViewTaskAsEmployee taskEmp = new ViewTaskAsEmployee();
            taskEmp.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewProject nProj = new NewProject();
            nProj.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NewTask nTask = new NewTask();
            nTask.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Login log = new Login();
            log.Show();
            Close();
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            ViewProject viewPr = new ViewProject();
            viewPr.Show();
        }
    }
}
