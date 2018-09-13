using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public interface IRepositorio
    {
        IEnumerable<Producto> Productos { get; }

        void AddProducto(Producto producto);
    }
}
