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
    /// Логика взаимодействия для ClientBase.xaml
    /// </summary>
    public partial class ClientBase : Window
    {
        public ClientBase()
        {
            InitializeComponent();
            DGClient.ItemsSource = BaseModelFocusEntities6.GetContext().Clients.ToList();
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            AddClients addClients = new AddClients(null);
            addClients.Show();
            this.Close();
        }

        private void RemoveItem_Click(object sender, RoutedEventArgs e)
        {
            Clients selectitem = (Clients)DGClient.SelectedItem;

            if (selectitem == null)
            {
                MessageBox.Show("Выберите Клиента.");
            }
            else
            {
                List<Clients> a = BaseModelFocusEntities6.GetContext().Clients.Where(us => us.idClient == selectitem.idClient).ToList();
                BaseModelFocusEntities6.GetContext().Clients.Remove(a[0]);
                BaseModelFocusEntities6.GetContext().SaveChanges();

                DGClient.ItemsSource = null;
                DGClient.ItemsSource = BaseModelFocusEntities6.GetContext().Clients.ToList();
            }
        }

        private void outmenu(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void EditItem_Click(object sender, RoutedEventArgs e)
        {
            AddClients editClients = new AddClients((sender as Button).DataContext as Clients);
            editClients.Show();
            this.Close();
        }
    }
}
