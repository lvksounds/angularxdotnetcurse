using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext context;
        public EventoController(DataContext context)
        {
            this.context = context;
        }
        
        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id)
        {
            return context.Eventos.Where(x=> x.EventoId == id);
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
