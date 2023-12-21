using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfAppEjemplo
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

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            label.Content= $"Clicks: {e.ClickCount} Posición: ({e.GetPosition(this).X},{e.GetPosition(this).X}) Botón: {e.ButtonState}  Delta: {e.LeftButton}";

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            label.Content = $"Clicks: {e.ClickCount} Posición: ({e.GetPosition(this).X},{e.GetPosition(this).X}) Botón: {e.ButtonState}  Delta: {e.LeftButton}";

        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
