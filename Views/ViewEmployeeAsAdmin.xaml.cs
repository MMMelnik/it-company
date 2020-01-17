using System.Windows;
using it_company.Models;
using it_company.ViewModels;


namespace it_company.Views
{
    /// <summary>
    /// Interaction logic for ViewEmployeeAsAdmin.xaml
    /// </summary>
    public partial class ViewEmployeeAsAdmin : Window
    {
        public ViewEmployeeAsAdmin(ref User employee)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            ViewEmployeeAsAdminModel viewEmployeeAsAdminModel = new ViewEmployeeAsAdminModel(ref employee);
            DataContext = viewEmployeeAsAdminModel;
            viewEmployeeAsAdminModel.Closing += (s, e) => Close();
        }
    }
}
