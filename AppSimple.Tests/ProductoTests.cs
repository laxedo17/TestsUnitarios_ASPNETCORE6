using AppSimple.Models;
using Xunit;

namespace AppSimple.Tests
{
    public class ProductoTests
    {
        [Fact]
        public void PodeCambiarNomeProducto()
        {
            //Arrange
            var p = new Producto { Nome = "Test", Precio = 100M };

            //Act
            p.Nome = "Novo Nome";

            //Assert
            Assert.Equal("Novo Nome", p.Nome);
        }

        [Fact]
        public void PodeCambiarPrecioProducto()
        {
            //Arrange
            var p = new Producto { Nome = "Test", Precio = 100M };

            //Act
            p.Precio = 200M;

            //Assert
            Assert.Equal(200M, p.Precio);
        }
    }
}