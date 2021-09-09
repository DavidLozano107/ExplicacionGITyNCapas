using EjemploTelegram.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploTelegram.Negocio.Ejemplo.Interfaces
{
    interface IAutorNegocio
    {
        Task<Autor> CrearAutor(Autor autor);
        Task<Autor> GetAutorById(int id);
        Task<List<Autor>> GetAutores();
    }
}
