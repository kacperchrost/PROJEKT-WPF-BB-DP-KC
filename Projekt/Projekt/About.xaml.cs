using HelixToolkit.Wpf;
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
    /// Logika interakcji dla klasy About.xaml
    /// </summary>
    public partial class About : Page
    {
        public About()
        {
            InitializeComponent();
            Create3DViewPort();
        }

        private void Create3DViewPort() { 
            var hVp3D = new HelixViewport3D();
            var lights = new DefaultLights();
            var teaPot = new Teapot();
            hVp3D.Children.Add(lights);
            hVp3D.Children.Add(teaPot);
            //this.AddChild(hVp3D);
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Menu.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Frog(object sender, RoutedEventArgs e)
        {
            Window frog = new Frog();
            frog.Show();
        }
    }
}
