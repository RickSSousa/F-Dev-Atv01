using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex01.Models
{
    public class Convidado
    {
        public int ConvidadoId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public bool? Comparecimento { get; set; }
    }
}
