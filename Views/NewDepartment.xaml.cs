﻿using System;
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
    /// Interaction logic for NewDepartment.xaml
    /// </summary>
    public partial class NewDepartment : Window
    {
        public NewDepartment()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdminWorkspace admin = new AdminWorkspace();
            admin.Show();
            Close();
        }
    }
}
