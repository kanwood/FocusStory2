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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FocusStory
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AdminMenuButton_Click(object sender, RoutedEventArgs e)
        {
            PasswordWindow passwordWindow = new PasswordWindow();
            passwordWindow.Show();
            this.Close();
        }

        private void ManagerMenuButton_Click(object sender, RoutedEventArgs e)
        {
            PasswordLogin1 passwordlog1 = new PasswordLogin1();
            passwordlog1.Show();
            this.Close();
        }

        private void OperatorMenuButton_Click(object sender, RoutedEventArgs e)
        {
            PasswordLogin2 passwordlog2 = new PasswordLogin2();
            passwordlog2.Show();
            this.Close();
        }
    }
}
