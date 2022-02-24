using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Ex01.Models
{
    public class Convidado
    {
        [DisplayName("Identificador")]
        public int ConvidadoId { get; set; }
        [DisplayName("Convidado")]
        public string Nome { get; set; }
        [DisplayName("E-mail")]
        public string Email { get; set; }
        [DisplayName("Contato")]
        public string Telefone { get; set; }
        [DisplayName("Confirmação")]
        public bool? Comparecimento { get; set; }
    }
}
