using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsDatos
{
    public class Categoria
    {
        public int Id { get; set; }

        public string? Nombre { get; set; }

        public virtual ObservableCollectionListSource<Producto> Productos { get; } = new();

    }
}
