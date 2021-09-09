using EjemploTelegram.AccesoDatos.BaseDeDatos;
using EjemploTelegram.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EjemploTelegram.Negocio.Ejemplo.Interfaces;

namespace EjemploTelegram.api.Controllers
{
    [Route("api/autor")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly IAutorNegocio autorNegocio;

        public AutorController(IAutorNegocio autorNegocio)
        {
            this.autorNegocio = autorNegocio;
        }

        [HttpGet]
        public async Task<ActionResult<List<Autor>>> Get()
        {
            return await autorNegocio.GetAutores();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Autor>> Get(int id)
        {
            return await autorNegocio.GetAutorById(id);
        }


        [HttpPost]
        public async Task<Autor>Post (Autor autor)
        {
            return await autorNegocio.CrearAutor(autor);
        }


    }
}
