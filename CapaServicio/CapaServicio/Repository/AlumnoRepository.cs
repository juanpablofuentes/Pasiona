using CapaServicio.Models;

namespace CapaServicio.Repository
{
    public class AlumnoRepository:IAlumnoRepository
    {
        private readonly Contexto _context;

        public AlumnoRepository(Contexto context)
        {
            _context = context;
        }

        public IEnumerable<Alumno> ObtenerTodos()
        {
            return _context.Alumnos.ToList();
        }

        public Alumno ObtenerPorId(int id)
        {
            return _context.Alumnos.Find(id);
        }

        public void Agregar(Alumno Alumno)
        {
            _context.Alumnos.Add(Alumno);
            _context.SaveChanges();
        }

        public void Actualizar(Alumno Alumno)
        {
            _context.Alumnos.Update(Alumno);
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var Alumno = ObtenerPorId(id);
            if (Alumno != null)
            {
                _context.Alumnos.Remove(Alumno);
                _context.SaveChanges();
            }
        }
    }
}
