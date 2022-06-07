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
    /// Logika interakcji dla klasy ClientManagement.xaml
    /// </summary>
    public partial class ClientManagement : Page
    {
        private db_clientDataSet db_ClientDataSet;
        private db_clientDataSetTableAdapters.ClientTableAdapter proAdapter;
        private CollectionViewSource clientViewSource;
        public ClientManagement()
        {
            InitializeComponent();
        } 
        private void Window_Load(object sender, RoutedEventArgs e)
        {
            db_ClientDataSet = (db_clientDataSet)this.FindResource("db_clientDataSet");
            proAdapter = new db_clientDataSetTableAdapters.ClientTableAdapter();
            proAdapter.Fill(db_ClientDataSet.Client);
            clientViewSource = ((CollectionViewSource)this.FindResource("clientViewSource"));
            //clientViewSource.View.MoveCurrentToFirst();
        }
        private void Add(object sender, RoutedEventArgs e)
        {
            Window win = new AddNewClient();
            win.ShowDialog();
        }
        private void Modify(object sender, RoutedEventArgs e)
        {
            Window win = new ModifyClient();
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
            MessageBoxResult mb = MessageBox.Show(messageBoxText: "Czy na pewno chcesz zapisać?", "Zapisywanie", MessageBoxButton.YesNo);
            if (mb.Equals(MessageBoxResult.Yes))
            {
                proAdapter.Update(db_ClientDataSet);
            }
        }
    }
}
