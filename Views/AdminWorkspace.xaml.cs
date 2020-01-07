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
    /// Interaction logic for AdminWorkspace.xaml
    /// </summary>
    public partial class AdminWorkspace : Window
    {
        public AdminWorkspace()
        {
            InitializeComponent();
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
