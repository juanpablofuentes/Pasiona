namespace WindowFormEjemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            lbInfo.Text = $"Clicks: {e.Clicks} Posición: ({e.X},{e.Y}) Botón: {e.Button}  Delta: {e.Delta}";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lbCapture.Text = $"Clicks: {e.Clicks} Posición: ({e.X},{e.Y}) Botón: {e.Button}  Delta: {e.Delta}";

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            lbMove.Text = $"Clicks: {e.Clicks} Posición: ({e.X},{e.Y}) Botón: {e.Button}  Delta: {e.Delta}";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedIndex + " - " + comboBox1.SelectedItem.ToString());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            var r = (RadioButton)sender;
            MessageBox.Show(r.Name);
        }
    }
}