using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ex01.Models;

namespace Ex01.Controllers
{
    public class ConvidadosController : Controller
    {
        private static IList<Convidado> convidados = new List<Convidado>()
        {
            new Convidado()
            {
                ConvidadoId = 1,
                Nome = "Ricardo S.S.",
                Email = "rick@gmail.com",
                Telefone = "932927266",
                Comparecimento = null
            },
            new Convidado()
            {
                ConvidadoId = 2,
                Nome = "Gustavo Guanabara",
                Email = "gustavog@gmail.com",
                Telefone = "984752657",
                Comparecimento = null
            },
            new Convidado()
            {
                ConvidadoId = 3,
                Nome = "Nélio Alves",
                Email = "nelio@gmail.com",
                Telefone = "932732466",
                Comparecimento = null
            },
            new Convidado()
            {
                ConvidadoId = 4,
                Nome = "Lance Vance",
                Email = "lance@gmail.com",
                Telefone = "955246875",
                Comparecimento = null
            },
        };
        public IActionResult Index()
        {
            return View(convidados);
        }
    }
}
