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
    public partial class MenuManager : Window
    {
        public MenuManager()
        {
            InitializeComponent();
        }

        private void Client_Selected(object sender, RoutedEventArgs e)
        {
            ClientBase clientBase = new ClientBase();
            clientBase.Show();
            this.Close();
        }

        private void Basket_Selected(object sender, RoutedEventArgs e)
        {
            BasketWindow basket = new BasketWindow();
            basket.Show();
            this.Close();
        }

        private void Product_Selected(object sender, RoutedEventArgs e)
        {
            Storage storage = new Storage();
            storage.Show();
            this.Close();
        }
    
        private void Quit(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
