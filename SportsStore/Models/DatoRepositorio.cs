using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class DatoRepositorio : IRepositorio
    {
        private Contexto contexto;

        public DatoRepositorio(Contexto ctx) => contexto = ctx;

        public IEnumerable<Producto> Productos => contexto.Productos;

        public void AddProducto(Producto producto)
        {
            this.contexto.Productos.Add(producto);
            this.contexto.SaveChanges();
        }
    }
}
