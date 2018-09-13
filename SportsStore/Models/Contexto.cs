using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opts) : base(opts) { }

        public DbSet<Producto> Productos { get; set; }
    }
}
