using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOAcademia
{
    internal interface IDAO<T>
    {
        List<T> GetAll();
        T GetById(int id);
        int Insert(T entity);
        int Update(T entity);
        int Save(T entity);
        int Delete(int id);
    }
}
