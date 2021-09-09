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
    class AutorNegocio : IAutorNegocio
    {
        private readonly AppDbContext db;
        public AutorNegocio(AppDbContext db)
        {
            this.db = db;
        }

        public async Task<Autor> CrearAutor(Autor autor)
        {
            db.Autor.Add(autor);
            await db.SaveChangesAsync();
            return autor;
        }

        public async Task<Autor> GetAutorById(int id)
        {
            var autor = await db.Autor.FirstOrDefaultAsync(x => x.Id == id);

            if (autor != null)
            {
                return autor;
            }
            return new Autor();
        }

        public async Task<List<Autor>> GetAutores()
        {
            var autores = await db.Autor.ToListAsync();
            return autores;
        }
    }
}
