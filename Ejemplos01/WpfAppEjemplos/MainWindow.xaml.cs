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

namespace WpfAppEjemplos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Eventos eventos = new Eventos();
            eventos.Show();
        }

        private void Grid_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Boton1.Content=e.GetPosition(this);
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            Controles controles = new Controles();
            controles.Show();
        }
    }
}
