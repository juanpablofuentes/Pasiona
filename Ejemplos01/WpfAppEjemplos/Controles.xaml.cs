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
    /// Lógica de interacción para Controles.xaml
    /// </summary>
    public partial class Controles : Window
    {
        public Controles()
        {
            InitializeComponent();
            cmbColors.ItemsSource = typeof(Colors).GetProperties();
        }
    }
}
