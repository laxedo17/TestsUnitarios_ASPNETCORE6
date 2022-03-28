using Microsoft.AspNetCore.Mvc;
using AppSimple.Models;
using static AppSimple.Models.Producto;

namespace AppSimple.Controllers
{
    public class HomeController : Controller
    {
        public IOrixenDatos orixenDatos = new ProductoOrixenDatos();
        public ViewResult Index()
        {
            return View(orixenDatos.Productos);
        }
    }
}