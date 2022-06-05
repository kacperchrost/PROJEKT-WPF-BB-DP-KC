﻿using System;
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

namespace Projekt
{
    /// <summary>
    /// Logika interakcji dla klasy OrdersManagement.xaml
    /// </summary>
    public partial class OrdersManagement : Page
    {
        public OrdersManagement()
        {
            InitializeComponent();
        }

        private void AddNewOrder(object sender, RoutedEventArgs e)
        {
            Window w = new AddNewOrder();
            w.ShowDialog();
        }

        private void ModifyOrder(object sender, RoutedEventArgs e)
        {
            Window w = new ModifyOrder();
            w.ShowDialog();
        }

        private void DeleteOrder(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Wybrane zamówinie zostało usunięte!", "Uwaga", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void BackFromOrders(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Menu.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
