using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Data;
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
            var retorno = from contato in _Context.Contato select contato;
            return JsonConvert.SerializeObject(retorno);
        }

        public string AdicionarContato(Contato contato){
            _Context.Contato.Add(contato);
            _Context.SaveChanges();
            return ContatoPorId(contato.Idcontato);
        }

        public string RemoverContato(Contato contato){
            bool rtn;
            object retorno;
            try{
                _Context.Contato.Remove(contato);
                _Context.SaveChanges();
                rtn = true;
            }catch(DbUpdateException){
                rtn = false;
            }

            retorno = new {
                resultado = rtn
            };
            
            return JsonConvert.SerializeObject(retorno);
        }

        public string AtualizarContato(Contato contato){
            bool rtn;
            object retorno;
            try{
                _Context.Contato.Update(contato);
                _Context.SaveChanges();
                rtn = true;
            }catch(DbUpdateException){
                rtn = false;
            }

            retorno = new {
                resultado = rtn
            };
            
            return JsonConvert.SerializeObject(retorno);
        }

        private string ContatoPorId(int id){
            var retorno = _Context.Contato.Where(ctr => ctr.Idcontato == id);
            return JsonConvert.SerializeObject(retorno.FirstOrDefault());
        }
    }
}