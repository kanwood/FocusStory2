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
    public partial class AddItem : Window
    {
        private Item _currentProducts = new Item();

        public AddItem(Item selectedProducts)
        {
            InitializeComponent();

            if (selectedProducts != null)
                _currentProducts = selectedProducts;

            DataContext = _currentProducts;
        }

        private void outProducts_Click(object sender, RoutedEventArgs e)
        {
            Control control = new Control();
            control.Show();
            this.Close();
        }

        private void SaveCh_Click(object sender, RoutedEventArgs e)
        {
            if (_currentProducts.idItem == 0)
                BaseModelFocusEntities6.GetContext().Item.Add(_currentProducts);
            BaseModelFocusEntities6.GetContext().SaveChanges();
            MessageBox.Show("Данные успешно обновлены!");
        }

        private void outControl_Click(object sender, RoutedEventArgs e)
        {
            Control control = new Control();
            control.Show();
            this.Close();
        }
    }
}