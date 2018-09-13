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

        public IActionResult Index() => View(repositorio.Productos);

        public IActionResult Index2() {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Producto producto) {
            repositorio.AddProducto(producto);
            return RedirectToAction(nameof(Index));
        }
    }
}