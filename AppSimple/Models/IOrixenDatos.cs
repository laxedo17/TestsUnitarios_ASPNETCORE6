namespace AppSimple.Models
{
    public interface IOrixenDatos
    {
        IEnumerable<Producto> Productos { get; }
    }
}