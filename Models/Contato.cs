using System;
using System.Collections.Generic;

namespace agendaAPI.Models
{
    public partial class Contato
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public int Idcontato { get; set; }
    }
}
