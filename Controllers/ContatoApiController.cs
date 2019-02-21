using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agendaAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace agendaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoApiController : ControllerBase
    {
        private readonly ContatoService _Service;
        public ContatoApiController(ContatoService service)
        {
            _Service = service;
        }

        [HttpGet]
        public string GetTodos()
        {
            return _Service.ObterTodosContatos();
        }

        [HttpPost]
        public void AdicionarContato([FromBody] string json)
        {
            Contato obj = (Contato)JsonConvert.DeserializeObject(json);
            _Service.AdicionarContato(obj);
        }
    }
}
