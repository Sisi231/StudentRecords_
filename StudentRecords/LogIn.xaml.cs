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

namespace StudentRecords
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Opening OpenOpening = new Opening();
            OpenOpening.Show();
            this.Close();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordBox1.Password.Length < 10 || PasswordBox1.Password.Length > 10)
            {
                MessageBox.Show("Your password should be 10 symbols long! Try again");
            }
            else if (txtUsername.Text.Equals(""))
            {
                MessageBox.Show("You cannot leave this field empty!");
            }
            else
            {
                ChooseStudent student1 = new ChooseStudent();
                student1.Show();
                this.Close();
            }
        }
    }
}


