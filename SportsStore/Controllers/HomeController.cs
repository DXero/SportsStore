using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private IRepositorio repositorio;

        public HomeController(IRepositorio repo) => repositorio = repo;

        public IActionResult Index()
        {
            return View(repositorio.Productos);
        }

        [HttpPost]
        public IActionResult AddProducto(Producto producto) {
            repositorio.AddProducto(producto);
            return RedirectToAction(nameof(Index));
        }
    }
}