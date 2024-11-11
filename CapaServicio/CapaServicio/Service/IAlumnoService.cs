using CapaServicio.Models;

namespace CapaServicio.Service
{
    public interface IAlumnoService
    {
        IEnumerable<Alumno> ObtenerTodos();
        Alumno ObtenerPorId(int id);
        void Agregar(Alumno alumno);
        void Actualizar(Alumno alumno);
        void Eliminar(int id);
    }
}
