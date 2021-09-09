using EjemploTelegram.AccesoDatos.BaseDeDatos;
using EjemploTelegram.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EjemploTelegram.api.Controllers
{
    [Route("api/autor")]
    [ApiController]
    public class AutorController : ControllerBase
    {
     

        [HttpGet]
        public async Task<ActionResult<List<Autor>>> Get()
        {
           
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Autor>> Get(int id)
        {
            
        }


        [HttpPost]
        public async Task<Autor>Post (Autor autor)
        {
          
        }


    }
}
