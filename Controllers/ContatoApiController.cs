using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agendaAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


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
        [Route("[action]")]
        public string GetTodos()
        {
            return _Service.ObterTodosContatos();
        }

        [HttpPost]
        [Route("[action]")]
        public string AdicionarContato([FromBody] Contato json)
        {
            return _Service.AdicionarContato(json);
        }

        [HttpDelete]
        [Route("[action]")]
        public string RemoverContato([FromBody] Contato json)
        {
            return _Service.RemoverContato(json);
        }
    }
}
