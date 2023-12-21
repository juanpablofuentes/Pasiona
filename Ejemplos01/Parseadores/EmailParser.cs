using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parseadores
{
    public static class EmailParser
    {
        public static string GetName(string email)
        {
            int indexOfAt = email.IndexOf('@');

            if (indexOfAt != -1)
            {
                // Devuelve la parte del nombre antes de la arroba
                return email.Substring(0, indexOfAt);
            }
            else
            {
                // No hay arroba, devolver cadena vacía
                return string.Empty;
            }
        }

        public static string GetDomain(string email)
        {
            int indexOfAt = email.IndexOf('@');
          
            if (indexOfAt != -1)
            {
                int another = email.IndexOf("@", indexOfAt+1);
                if (another != -1)
                {
                    return string.Empty;
                }
                // Devuelve la parte del dominio después de la arroba
                return email.Substring(indexOfAt + 1);
            }
            else
            {
                // No hay arroba, devolver cadena vacía
                return string.Empty;
            }
        }
    }
}
