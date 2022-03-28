using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AppSimple.Controllers;
using AppSimple.Models;
using Xunit;
using AppSimple.Tests;
using Moq;

namespace SimpleApp.Tests
{
    public class HomeControllerTests
    {
        // class OrixenDatosMentira : IOrixenDatos
        // {
        //     public OrixenDatosMentira(Producto[] datos) => Productos = datos;
        //     public IEnumerable<Producto> Productos { get; set; }
        // }

        [Fact]
        public void IndexActionModelEstaCompleto()
        {
            // Arrange
            Producto[] testDatos = new Producto[] {
            new Producto { Nome = "P1", Precio = 75.10M },
            new Producto { Nome = "P2", Precio = 120M },
            new Producto { Nome = "P3", Precio = 110M }
            };
            //IOrixenDatos datos = new OrixenDatosMentira(testDatos);
            var mock = new Mock<IOrixenDatos>();
            mock.SetupGet(m => m.Productos).Returns(testDatos);
            var controller = new HomeController();
            controller.orixenDatos = mock.Object;
            // Producto[] productos = new Producto[] {
            // new Producto { Nome = "Kayak", Precio = 275M },
            // new Producto { Nome = "Chaleco", Precio = 48.95M}
            // };
            // Act
            var modelo = (controller.Index() as ViewResult)?.ViewData.Model
            as IEnumerable<Producto>;
            // Assert
            Assert.Equal(testDatos, modelo,
            Comparer.Get<Producto>((p1, p2) => p1?.Nome == p2?.Nome
            && p1?.Precio == p2?.Precio));
            mock.VerifyGet(m => m.Productos, Times.Once);
        }
    }
}
