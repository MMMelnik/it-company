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
    /// Interaction logic for PMWorkspace.xaml
    /// </summary>
    public partial class PMWorkspace : Window
    {
        public PMWorkspace()
        {
            InitializeComponent();
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
