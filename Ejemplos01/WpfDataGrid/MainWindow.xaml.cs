using Microsoft.EntityFrameworkCore;
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

namespace WpfDataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private  AcademiaContext _context ;

        private CollectionViewSource cursoViewSource;
        public MainWindow()
        {
            InitializeComponent();
            cursoViewSource =
              (CollectionViewSource)FindResource(nameof(cursoViewSource));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _context= new AcademiaContext();
            _context.Cursos.Include(x=>x.Alumnos).Load();

            // bind to the source
            cursoViewSource.Source =
                _context.Cursos.Local.ToObservableCollection();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _context.SaveChanges();

            // this forces the grid to refresh to latest values
            cursoDataGrid.Items.Refresh();
            alumnoDataGrid.Items.Refresh();
        }
    }
}
