using CapaServicio.Models;
using CapaServicio.Repository;

namespace CapaServicio.Service
{
    public class AlumnoService:IAlumnoService
    {
        private readonly IAlumnoRepository _AlumnoRepository;

        public AlumnoService(IAlumnoRepository AlumnoRepository)
        {
            _AlumnoRepository = AlumnoRepository;
        }

        public IEnumerable<Alumno> ObtenerTodos()
        {
            return _AlumnoRepository.ObtenerTodos();
        }

        public Alumno ObtenerPorId(int id)
        {
            return _AlumnoRepository.ObtenerPorId(id);
        }

        public void Agregar(Alumno Alumno)
        {
            _AlumnoRepository.Agregar(Alumno);
        }

        public void Actualizar(Alumno Alumno)
        {
            _AlumnoRepository.Actualizar(Alumno);
        }

        public void Eliminar(int id)
        {
            _AlumnoRepository.Eliminar(id);
        }
    }
}
