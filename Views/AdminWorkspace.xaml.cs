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
    }
}
