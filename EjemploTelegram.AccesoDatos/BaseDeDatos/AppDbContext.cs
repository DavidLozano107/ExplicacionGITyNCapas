using EjemploTelegram.Shared.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploTelegram.AccesoDatos.BaseDeDatos
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> op ) : base(op)
        {

        }

        public DbSet<Autor> Autor { get; set; }
        public DbSet<Libro> Libro { get; set; }
    }

}
