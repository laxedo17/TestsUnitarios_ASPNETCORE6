namespace AppSimple.Models
{
    public class Producto
    {
        public string Nome { get; set; } = string.Empty;
        public decimal? Precio { get; set; }

        // public static Producto[] GetProductos()
        // {
        //     Producto kayak = new Producto { Nome = "Kayak", Precio = 275M };
        //     Producto chaleco = new Producto { Nome = "Chaleco", Precio = 48.95M };

        //     return new Producto[] { kayak, chaleco };
        // }

        public class ProductoOrixenDatos : IOrixenDatos
        {
            public IEnumerable<Producto> Productos =>
            new Producto[]
            {
                new Producto { Nome = "Kayak", Precio = 275M },
                new Producto { Nome = "Chaleco", Precio = 48.95M }
            };
        }
    }
}