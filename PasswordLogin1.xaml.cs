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
    public partial class PasswordLogin1 : Window
    {
        private const string PasswordManager = "Manager";
        public PasswordLogin1()
        {
            InitializeComponent();
        }

        private void MenuLogin_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordLogin.Password == PasswordManager)
            {
                MenuManager menuManager = new MenuManager();
                menuManager.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неправильный пароль. Повторите заново.");
            }
        }
    }
}
