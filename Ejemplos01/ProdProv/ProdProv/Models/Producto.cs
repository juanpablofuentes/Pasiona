namespace ProdProv.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public Decimal Precio { get; set; }

        public int ProveedorId { get; set; }
        public  Proveedor? Proveedor { get; set; }
    }
}
