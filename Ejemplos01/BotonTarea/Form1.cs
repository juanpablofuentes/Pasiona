using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BotonTarea
{
    public partial class Form1 : Form
    {
        List<Elemento> elementos;
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int tam = int.Parse(tamArray.Text);
            Task<int[]> taskCrear = new Task<int[]>(() =>
            {

                int[] nuevo = Utils.crear(tam);

                return nuevo;
            });

            // Iniciar la tarea asincrónica
            taskCrear.Start();

            // Esperar a que la tarea asincrónica se complete
            int[] result = await taskCrear;

            // Mostrar el resultado de la tarea asincrónica
            textBox1.Text = "Creado " + result[0] + "..." + result[result.Length - 1];

            Task<int[]> taskOrdenar = new Task<int[]>(() =>
            {

                int[] nuevo = Utils.ordenar(result, textRes);

                return nuevo;
            });

            // Iniciar la tarea asincrónica
            taskOrdenar.Start();

            // Esperar a que la tarea asincrónica se complete
            int[] ordenado = await taskOrdenar;
            textBox1.Text += "\r\nOrdenado " + ordenado[0] + "..." + ordenado[ordenado.Length - 1];

            Task<int[]> taskFiltrar = new Task<int[]>(() =>
            {

                int[] nuevo = Utils.filtrar(ordenado, a => a % 2 == 0);

                return nuevo;
            });

            // Iniciar la tarea asincrónica
            taskFiltrar.Start();

            // Esperar a que la tarea asincrónica se complete
            int[] filtrado = await taskFiltrar;
            textBox1.Text += "\r\nFiltrado (" + filtrado.Length + ")" + filtrado[0] + "..." + filtrado[filtrado.Length - 1];

            button1.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\r\n-----";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alerta");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Queue<int> cola = new Queue<int>(new int[] { 1, 2, 3, 4, 5, 2, 3, 4, 5, 2, 3, 4, 5 });

            List<Task> tareas = new List<Task>() {new Task(() => Utils.manejarPila("Tarea 1", cola, textRes)),
            new Task(() => Utils.manejarPila("Tarea 2", cola, textRes)),
            new Task(() => Utils.manejarPila("Tarea 3", cola, textRes)) };
            foreach (var task in tareas)
            {
                task.Start();
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            elementos = new List<Elemento>();
            for (int i = 0; i < 10; i++)
            {
                elementos.Add(new Elemento(i, 0, textRes));
            }
            List<Task> tareas = new List<Task>() {new Task(() => Utils.crearElementos("Crear", elementos)),
                new Task(() => Utils.liberarElementos("Liberar", elementos)),
                new Task(() => Utils.procesarElementos("Procesar", elementos))
            };
            foreach (var task in tareas)
            {
                task.Start();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            elementos.Add(new Elemento((new Random()).Next(100000), 0, textRes));
        }
    }
}