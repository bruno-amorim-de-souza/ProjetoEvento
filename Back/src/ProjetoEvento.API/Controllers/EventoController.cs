using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoEvento.API.Models;

namespace ProjetoEvento.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[]{
             new Evento(){
                EventoId =1,
                Tema = "Angular 11 e .NET5",
                Local = "Belo Horizonte",
                Lote = "1ºlote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png"
            },
             new Evento(){
                EventoId =2,
                Tema = "Angular 11 e Novidades",
                Local = "Londrina",
                Lote = "2ºlote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemURL = "foto1.png"
             }
        };
        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
                
        }
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id );
                
        }    

        
    }
}
