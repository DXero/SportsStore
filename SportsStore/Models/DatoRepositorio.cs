using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class DatoRepositorio : IRepositorio
    {
        private List<Producto> dato = new List<Producto>();

        public IEnumerable<Producto> Productos => dato;

        public void AddProducto(Producto producto)
        {
            this.dato.Add(producto);
        }
    }
}
