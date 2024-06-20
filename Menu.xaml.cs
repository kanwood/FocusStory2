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
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Quit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Client_Selected(object sender, RoutedEventArgs e)
        {
            ClientBase clientBase = new ClientBase();
            clientBase.Show();
            this.Close();
        }

        private void Control_Selected(object sender, RoutedEventArgs e)
        {
            Control control = new Control();
            control.Show();
            this.Close();
        }

        private void Basket_Selected(object sender, RoutedEventArgs e)
        {
            BasketWindow basket = new BasketWindow();
            basket.Show();
            this.Close();
        }

        private void Password_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Пароли для активных ролей: \n Администратор -> [Admin] \n Менеджер -> [Manager] \n Оператор -> [Operator]");
        }

        private void Product_Selected(object sender, RoutedEventArgs e)
        {
            Storage storage = new Storage();
            storage.Show();
            this.Close();
        }
    }
}