﻿using FocusStory.База_данных;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public partial class BasketWindow : Window
    {
        public BasketWindow()
        {
            InitializeComponent();
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

        private void outMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void fullclear_Click(object sender, RoutedEventArgs e)
        {
            DGBasket.ItemsSource = null;
        }

        private void check_Click(object sender, RoutedEventArgs e)
        {
            BasketCont basketCont = new BasketCont(null);
            basketCont.Show();
            this.Close();
        }
    }
}

