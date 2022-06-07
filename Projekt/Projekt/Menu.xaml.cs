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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projekt
{
    /// <summary>
    /// Logika interakcji dla klasy Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void Product(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("ProductManagement.xaml", UriKind.RelativeOrAbsolute));
        }
        private void Client(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("ClientManagement.xaml", UriKind.RelativeOrAbsolute));
        }
        private void Worker(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("WorkersManagement.xaml", UriKind.RelativeOrAbsolute));
        }
        private void Supply(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ni mo", "Ni mo", MessageBoxButton.OK, MessageBoxImage.Warning);
            //this.NavigationService.Navigate(new Uri("SupplyManagement.xaml", UriKind.RelativeOrAbsolute));
        }
        private void Order(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("OrdersManagement.xaml", UriKind.RelativeOrAbsolute));
        }
        private void About(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("About.xaml", UriKind.RelativeOrAbsolute));
        }
        private void Category(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ni mo", "Ni mo", MessageBoxButton.OK, MessageBoxImage.Warning);
            //this.NavigationService.Navigate(new Uri("CategoryManagement.xaml", UriKind.RelativeOrAbsolute));
        }
        private void LogOut(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Login.xaml", UriKind.RelativeOrAbsolute));
        }
      


    }
}

