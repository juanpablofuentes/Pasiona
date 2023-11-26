namespace ProdProv.Models
{
    public class Proveedor
    {
        public Proveedor()
        {
            Productos = new List<Producto>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NIF { get; set; }
        public string Mail { get; set; }

        public List<Producto> Productos { get; set; } 
    }
}
