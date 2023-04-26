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
        
        public IEnumerable<Evento> _evento = new Evento[]
            {
                new Evento() {
                    EventoId = 1, 
                    Tema = "Angular 11 e .net 5",
                    Local = "Pinheiral",
                    Lote = "1º lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(3).ToString(),
                    ImagemURL = "foto.png"
                }, 
                new Evento() {
                    EventoId = 2, 
                    Tema = "Angular 11 e Suas Novidades",
                    Local = "Volta redonda",
                    Lote = "3º lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(5).ToString(),
                    ImagemURL = "foto.png"
                }
            };

        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id)
        {
            return _evento.Where(evento => evento.EventoId.Equals(id));
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
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
