using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOExample
{
    internal interface IAlumnoDAO
    {
        Alumno getAlumno(int id);
        Alumno getAlumno(string name);
        List<Alumno> getAll();
        List<Alumno> getAll(string name);
        List<Alumno> getAll(int limite, int pagina=0);
        int addAlumno(Alumno alumno);
        int updateAlumno(Alumno alumno);
        int deleteAlumno(int id);
        int deleteAlumno(Alumno alumno);
    }
}
