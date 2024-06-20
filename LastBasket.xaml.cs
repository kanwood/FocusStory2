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
    /// Логика взаимодействия для LastBasket.xaml
    /// </summary>
    public partial class LastBasket : Window
    {
        public LastBasket()
        {
            InitializeComponent();
            DGClient1.ItemsSource = BaseModelFocusEntities6.GetContext().Clients.ToList();
            List<Basket> basketlist = BaseModelFocusEntities6.GetContext().Basket.ToList();
            List<Item> items = new List<Item>();

            foreach (Basket basket in basketlist)
            {
                items.Add(BaseModelFocusEntities6.GetContext().Item.Where(i => i.idItem == basket.idItem).ToList()[0]);
            }
            DGBasket.ItemsSource = items;

            int totalprice = 0;
            foreach (var sk in DGBasket.Items)
            {
                Item item = (Item)sk;
                totalprice += (int)item.price;
            }
            totalpricename.Text = $"Общая цена = {totalprice}";
        }


        private void check_Click(object sender, RoutedEventArgs e)
        {
            int totalprice = 0;

            string check = "";

            foreach (var sk in DGBasket.Items)
            {
                Item item = (Item)sk;
                check += $"{item.name} {item.price} \n";
                totalprice += (int)item.price;
            }
            MessageBox.Show($"Магазин Одежды FOCUS 2 \n Ваши товары: \n {check}  \n Общая цена = {totalprice} \n Спасибо за покупку <3");
        }
    }
}
