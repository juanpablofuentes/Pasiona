using CapaServicio.Models;

namespace CapaServicio.Repository
{
    public interface IAlumnoRepository
    {
        IEnumerable<Alumno> ObtenerTodos();
        Alumno ObtenerPorId(int id);
        void Agregar(Alumno alumno);
        void Actualizar(Alumno alumno);
        void Eliminar(int id);
    }
}
