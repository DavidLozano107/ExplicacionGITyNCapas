using EjemploTelegram.Negocio.Ejemplo.Interfaces;
using EjemploTelegram.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploTelegram.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly IlibroNegocio lb;

        public LibroController(IlibroNegocio lb)
        {
            this.lb = lb;
        }


        [HttpPost]
        public async Task<ActionResult<Libro>>Post(Libro libro)
        {
            var Libro = await lb.CrearLibro(libro);

            if (Libro != null)
            {
                return Ok(Libro);
            }

            return BadRequest("Valide nuevamente");
        }

    }
}
