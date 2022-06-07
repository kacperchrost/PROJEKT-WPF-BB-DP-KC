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
    /// Logika interakcji dla klasy WorkersManagement.xaml
    /// </summary>
    public partial class WorkersManagement : Page
    {
        private db_employeeDataSet db_EmployeeDataSet;
        private db_employeeDataSetTableAdapters.EmployeeTableAdapter proAdapter;
        private CollectionViewSource employeeViewSource;
        public WorkersManagement()
        {
            InitializeComponent();
        }
        private void Window_Load(object sender, RoutedEventArgs e)
        {
            db_EmployeeDataSet = (db_employeeDataSet)this.FindResource("db_employeeDataSet");
            proAdapter = new db_employeeDataSetTableAdapters.EmployeeTableAdapter();
            proAdapter.Fill(db_EmployeeDataSet.Employee);
            employeeViewSource = ((CollectionViewSource)this.FindResource("employeeViewSource"));
            //clientViewSource.View.MoveCurrentToFirst();
        }
        private void Add(object sender, RoutedEventArgs e)
        {
            Window win = new AddNewWorker();
            win.ShowDialog();
        }
        private void Modify(object sender, RoutedEventArgs e)
        {
            Window win = new ModifyWorker();
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
                proAdapter.Update(db_EmployeeDataSet);
            }
        }
    }
}
