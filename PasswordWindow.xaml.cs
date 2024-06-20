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

namespace FocusStory
{
    /// <summary>
    /// Логика взаимодействия для PasswordWindow.xaml
    /// </summary>
    public partial class PasswordWindow : Window
    {
        private const string PasswordAdmin = "Admin";
        public PasswordWindow()
        {
            InitializeComponent();
        }

        private void MenuLogin_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordLogin.Password == PasswordAdmin)
            {
                Menu menuadmin = new Menu();
                menuadmin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неправильный пароль. Повторите заново.");
            }
        }
    }
}
