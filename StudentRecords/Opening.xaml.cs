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

namespace StudentRecords
{
    /// <summary>
    /// Interaction logic for Opening.xaml
    /// </summary>
    public partial class Opening : Window
    {
        public Opening()
        {
            InitializeComponent();
        }

        private void Submit_2_Click(object sender, RoutedEventArgs e)
        {
            SignIn OpenSignUp = new SignIn();
            OpenSignUp.Show();
            this.Close();
        }

        private void Submit_3__Click(object sender, RoutedEventArgs e)
        {
            LogIn OpenLogIn = new LogIn();
            OpenLogIn.Show();
            this.Close();
        }

    }
}

