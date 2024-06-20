using FocusStory.База_данных;
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
    /// Логика взаимодействия для BasketCont.xaml
    /// </summary>
    public partial class BasketCont : Window
    {
        private Clients _currentClients = new Clients();
        public BasketCont(Clients selectedClients)
        {
            InitializeComponent();
            if (selectedClients != null)
                _currentClients = selectedClients;
            DataContext = _currentClients;
        }

        private void SaveCh_Click(object sender, RoutedEventArgs e)
        {
            if (_currentClients.idClient == 0)
                BaseModelFocusEntities6.GetContext().Clients.Add(_currentClients);
            BaseModelFocusEntities6.GetContext().SaveChanges();
            MessageBox.Show("Данные успешно обновлены!");
            LastBasket lastBasket = new LastBasket();
            lastBasket.Show();
            this.Close();
        }

        private void outControl_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
