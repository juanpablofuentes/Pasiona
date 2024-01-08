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

namespace WpfAppEjemplos
{
    /// <summary>
    /// Lógica de interacción para Eventos.xaml
    /// </summary>
    public partial class Eventos : Window
    {
        Button button;
        public Eventos()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBlock1.Text = "Button is Clicked";
            button=(Button)sender;
        }
        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            TextBlock2.Text = "Click event of StackPanel";
        }
        private void Window_Click(object sender, RoutedEventArgs e)
        {
          
            TextBlock3.Text = "Click event of Window "+button.Content;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock1.Text = $"Grid {e.ChangedButton} posicion {e.GetPosition(this)}";
            
        }

    
    }
}
