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
        
        public string ObterTodosContatos(){
            var retorno = _Context.Contato.Where(ctr => !ctr.Nome.Equals(""));
            return JsonConvert.SerializeObject(retorno);
        }

        public string AdicionarContato(Contato contato){
            _Context.Contato.Add(contato);
            _Context.SaveChanges();
            return ContatoPorId(contato.Idcontato);
        }

        public string RemoverContato(Contato contato){
            _Context.Contato.Remove(contato);
            _Context.SaveChanges();
            return ObterTodosContatos();
        }

        private string ContatoPorId(int id){
            var retorno = _Context.Contato.Where(ctr => ctr.Idcontato == id);
            return JsonConvert.SerializeObject(retorno.FirstOrDefault());
        }
    }
}