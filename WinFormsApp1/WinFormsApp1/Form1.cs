namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        ProductContext productContext;
        public Form1()
        {
            InitializeComponent();
            productContext = new ProductContext();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource=productContext.Products.ToList();
        }
    }
}