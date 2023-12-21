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
            //        MessageBox.Show("Hola que tal");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormularioPrincipal f = new FormularioPrincipal();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //     MessageBox.Show("Formulario cargado");
        }




        private void Form1_Resize(object sender, EventArgs e)
        {
            label1.Text = $"{this.Size.Width} - {this.Size.Height}";
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Text = $"{e.X} - {e.Y}";
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //   MessageBox.Show("Activado");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //          MessageBox.Show("Mostrar");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //    MessageBox.Show("Una vez cerrado");

        }

        private void label1_Click(object sender, EventArgs e)
        {
            var l = (Label)sender;
            MessageBox.Show(l.Name);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label3.Text = label3.Text + e.KeyChar.ToString();
            e.Handled = true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                label3.Text = "Pulsado enter";
            }
            if (e.Shift)
            {
                label3.Text = "Pulsado mayúsculas";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var boton = (Button)sender;

            boton.Text = "Pulsado";
            boton.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "Cambiando textbox";
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1')
            {
                e.Handled = true;
            }
        }

        private void textBox2_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Text = e.X + " - " + e.Y;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var ch = (CheckBox)sender;
            label3.Text = ch.Name + " - " + ch.Checked.ToString();
        }
    }
}