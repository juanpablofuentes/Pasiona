using Microsoft.EntityFrameworkCore;
using TestDatos;

namespace WFDataGrid
{
    public partial class Form1 : Form
    {
        private AcademiaContext? dbContext;
        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            this.dbContext = new AcademiaContext();



            this.dbContext.Cursos.Load();

            this.cursoBindingSource.DataSource = dbContext.Cursos.Local.ToBindingList();

        }

        private void dataGridCursos_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext != null)
            {
                if (this.dataGridCursos.CurrentRow != null)
                {
                    var curso = (Curso)this.dataGridCursos.CurrentRow.DataBoundItem;

                    if (curso != null && dbContext.Entry(curso).IsKeySet)
                    {
                        this.dbContext.Entry(curso).Collection(e => e.Alumnos).Load();
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbContext.SaveChanges();
            dataGridCursos.Refresh();
            dataGridAlumnos.Refresh();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void cursoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}