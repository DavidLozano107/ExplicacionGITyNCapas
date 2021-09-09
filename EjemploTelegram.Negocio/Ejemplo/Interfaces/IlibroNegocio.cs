using EjemploTelegram.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploTelegram.Negocio.Ejemplo.Interfaces
{
    public interface IlibroNegocio
    {
        Task<Libro> CrearLibro(Libro libro);
    }
}
