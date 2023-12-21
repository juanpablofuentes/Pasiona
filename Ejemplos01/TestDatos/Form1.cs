using Microsoft.EntityFrameworkCore;

namespace TestDatos
{
    public partial class Form1 : Form
    {
        private AcademiaContext _context;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _context = new AcademiaContext();
            _context.Cursos.Load();
            this.cursoBindingSource.DataSource = _context.Cursos.Local.ToBindingList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            dataGridView1.Refresh();
            dataGridView2.Refresh();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (_context != null)
                {
                    var curso = (Curso)dataGridView1.CurrentRow.DataBoundItem;
                    if (curso != null)
                    {
                        _context.Entry(curso).Collection(c => c.Alumnos).Load();
                    }
                }
            }
            catch (Exception ex) { }
        }
    }
}