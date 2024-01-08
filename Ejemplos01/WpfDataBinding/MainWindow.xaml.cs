using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Alumno> alumnos;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ModeloDatos();
            alumnos=new ObservableCollection<Alumno>();
            alumnos.Add(new Alumno() { Nombre="Ana",Nota="5"});
            alumnos.Add(new Alumno() { Nombre = "Eva", Nota = "7" });
            alumnos.Add(new Alumno() { Nombre = "Pep", Nota = "4" });
            alumnos.Add(new Alumno() { Nombre = "Rosa", Nota = "8" });
            lvDataBinding.ItemsSource = alumnos;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is ModeloDatos modeloDatos)
            {
                MessageBox.Show(modeloDatos.Nombre);

            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (DataContext is ModeloDatos modeloDatos)
            {
                modeloDatos.Valor++;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (DataContext is ModeloDatos modeloDatos)
            {
                modeloDatos.Valor--;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            alumnos.Add(new Alumno() { Nombre = txNombre.Text, Nota = txNota.Text });
        }
    }
    public class ModeloDatos : INotifyPropertyChanged
    {
        public string Nombre { get; set; } = "Ana";
        private int valor=0;
        public int Valor { get { return valor; } set { valor = value; OnPropertyChanged("Valor"); } }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public class Alumno
    {
        public string Nombre { get; set; }
        public string Nota { get; set; }
    }
}