using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agendaAPI.Models;
using Microsoft.AspNetCore.Mvc;

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
            return _Service.GetTodosContatos();
        }


        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }


        [HttpPost]
        public void Post([FromBody] string value)
        {
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
