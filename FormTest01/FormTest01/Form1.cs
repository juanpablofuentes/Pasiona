namespace FormTest01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 f = new Form1();
            f.Show();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void aaaaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }
    }
}