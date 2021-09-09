using EjemploTelegram.AccesoDatos.BaseDeDatos;
using EjemploTelegram.Negocio.Ejemplo.Interfaces;
using EjemploTelegram.Shared.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploTelegram.Negocio.Ejemplo
{
    public class libroNegocio : IlibroNegocio
    {
        private readonly AppDbContext db;

        public libroNegocio(AppDbContext db)
        {
            this.db = db;
        }
        public async Task<Libro> CrearLibro(Libro libro)
        {
            if (libro.AutorId != 0)
            {
                var existe = await db.Autor.AnyAsync(x => x.Id == libro.AutorId);

                if (existe)
                {
                    db.Libro.Add(libro);
                    await db.SaveChangesAsync();
                    return libro;
                }
                else
                {
                    return null;
                }

            }

            return null;
        }
    }
}
