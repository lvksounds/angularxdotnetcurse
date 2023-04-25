using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {

        }

        [HttpGet]
        public string Get()
        {
            return "Caminho do get";
        }

        [HttpPost]
        public string Post()
        {
            return "Caminho de post";
        }

        [HttpPut]
        [Route("{id}")]
        public string Put(int id)
        {
            return $"a id passada pelo put é {id}";
        }
    }
}
