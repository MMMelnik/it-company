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
    /// Interaction logic for ViewTaskAsEmployee.xaml
    /// </summary>
    public partial class ViewTaskAsEmployee : Window
    {
        public ViewTaskAsEmployee()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmployeeWorkspace eWor = new EmployeeWorkspace();
            eWor.Show();
            Close();
        }
    }
}
