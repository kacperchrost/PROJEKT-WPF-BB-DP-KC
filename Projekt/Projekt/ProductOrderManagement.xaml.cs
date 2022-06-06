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
    /// Logika interakcji dla klasy ProductOrderManagement.xaml
    /// </summary>
    public partial class ProductOrderManagement : Page
    {
        public ProductOrderManagement()
        {
            InitializeComponent();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            Window w = new AddNewProduct();
            w.ShowDialog();
        }

        private void Modify(object sender, RoutedEventArgs e)
        {

        }

        private void Delete(object sender, RoutedEventArgs e)
        {

        }

        private void Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("OrdersManagement.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
