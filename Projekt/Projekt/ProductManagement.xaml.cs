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
    /// Logika interakcji dla klasy ProductManagement.xaml
    /// </summary>
    public partial class ProductManagement : Page
    {
        public ProductManagement()
        {
            InitializeComponent();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            Window win = new AddProductPop();
            win.ShowDialog();
        }
        private void Modify(object sender, RoutedEventArgs e)
        {
            Window win = new ModifyProduct();
            win.ShowDialog();

        }
        private void Delete(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Czy na pewno chcesz usunąć", "Usuń", MessageBoxButton.OKCancel, MessageBoxImage.Warning);

        }
        private void Back(object sender, RoutedEventArgs e)
        {

            this.NavigationService.Navigate(new Uri("Menu.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
