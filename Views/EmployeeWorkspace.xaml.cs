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
    /// Interaction logic for EmployeeWorkspace.xaml
    /// </summary>
    public partial class EmployeeWorkspace : Window
    {
        public EmployeeWorkspace()
        {
            InitializeComponent();
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
