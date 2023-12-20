namespace FormulariosWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola que tal");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Formulario cargado");
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Text = "OK";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Text = "KO";
        }
    }
}