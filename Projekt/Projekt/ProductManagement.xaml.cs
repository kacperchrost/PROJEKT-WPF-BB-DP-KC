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

namespace Projekt
{
    /// <summary>
    /// Logika interakcji dla klasy ProductManagement.xaml
    /// </summary>
    public partial class ProductManagement : Page
    {
        private db_projectDataSet db_ProjectDataSet;
        private db_projectDataSetTableAdapters.ProductTableAdapter proAdapter;
        private CollectionViewSource productViewSource;

        public ProductManagement()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db_ProjectDataSet = (db_projectDataSet)this.FindResource("db_projectDataSet");
            proAdapter = new db_projectDataSetTableAdapters.ProductTableAdapter();
            proAdapter.Fill(db_ProjectDataSet.Product);
            productViewSource = ((CollectionViewSource)(this.FindResource("productViewSource")));
            productViewSource.View.MoveCurrentToFirst();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            Window win = new AddNewProduct();
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

        private void Save(object sender, RoutedEventArgs e)
        {
            try
            {
                var diff = (db_projectDataSet)db_ProjectDataSet.GetChanges();
                var a = proAdapter.Update(diff);
                db_ProjectDataSet.Merge(diff);
                db_ProjectDataSet.AcceptChanges();
                db_ProjectDataSet.Dispose();
                diff.Dispose();
                proAdapter.Dispose();
                MessageBox.Show(a.ToString());

            }
            catch
            {
                MessageBox.Show("Update failed");
            }


        }
    }
}
