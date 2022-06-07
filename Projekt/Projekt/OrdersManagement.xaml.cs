using System;
using System.Collections.Generic;
using System.Data;
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
        private db_orderMtMDataSet db_OrdersDataSet;
        private db_orderMtMDataSetTableAdapters.OrdersTableAdapter proAdapter;
        private CollectionViewSource ordersViewSource;
        public OrdersManagement()
        {
            InitializeComponent();
        }
        private void Window_Load(object sender, RoutedEventArgs e)
        {
            db_OrdersDataSet = (db_orderMtMDataSet)this.FindResource("db_orderMtMDataSet");
            proAdapter = new db_orderMtMDataSetTableAdapters.OrdersTableAdapter();
            proAdapter.Fill(db_OrdersDataSet.Orders);
            ordersViewSource = ((CollectionViewSource)this.FindResource("ordersViewSource1"));
            //clientViewSource.View.MoveCurrentToFirst();
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

        private void Save(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mb = MessageBox.Show(messageBoxText: "Czy na pewno chcesz zapisać?", "Zapisywanie", MessageBoxButton.YesNo);
            if (mb.Equals(MessageBoxResult.Yes))
            {
                proAdapter.Adapter.Update(db_OrdersDataSet);
            }
        }

        private void PrintOrder(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mb = MessageBox.Show(messageBoxText: "Czy na pewno chcesz wydrukować?", "Drukowanie", MessageBoxButton.YesNo);
            if (mb.Equals(MessageBoxResult.Yes))
            {
                /* PrintDG print = new PrintDG();
                 print.printDG(datagridName, "Title");*/
                PrintDialog myPrintDialog = new PrintDialog();
                if (myPrintDialog.ShowDialog() == true)
                {
                    myPrintDialog.PrintVisual(OrdersGrid, "Form All Controls Print");
                }
            }
        }

        private void ProductOrder(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("ProductOrderManagement.xaml", UriKind.RelativeOrAbsolute));
        } 
    }
}
