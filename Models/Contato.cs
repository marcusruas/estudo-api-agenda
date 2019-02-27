using System;
using System.Collections.Generic;

namespace agendaAPI.Models
{
    public partial class Contato
    {
        public Contato()
        {
        }

        public Contato(string nome, string sexo, int idade, string telefone)
        {
            this.Nome = nome;
            this.Sexo = sexo;
            this.Telefone = telefone;
            this.Idade = idade;
        }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public int Idcontato { get; set; }
        
        public override string ToString(){
            return "Nome: "+this.Nome+"\n"+
                   "Idade"+this.Idade+"\n"+
                   "Sexo"+this.Sexo+"\n"+
                   "Telefone"+this.Telefone+"\n";
        }
    }
}
