using Newtonsoft.Json;
using System.Linq;

namespace agendaAPI.Models
{
    public class ContatoService
    {
        private readonly DBContext _Context;
        public ContatoService(DBContext context)
        {
            _Context = context;
        }
        
        public string GetTodosContatos(){
            var retorno = _Context.Contato.Where(ctr => !ctr.Nome.Equals(""));
            return JsonConvert.SerializeObject(retorno);
        }
    }
}