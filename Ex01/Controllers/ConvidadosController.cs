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
                Telefone = "(35)93292-7266",
                Comparecimento = null
            },
            new Convidado()
            {
                ConvidadoId = 2,
                Nome = "Gustavo Guanabara",
                Email = "gustavog@gmail.com",
                Telefone = "(21)98475-2657",
                Comparecimento = null
            },
            new Convidado()
            {
                ConvidadoId = 3,
                Nome = "Nélio Alves",
                Email = "nelio@gmail.com",
                Telefone = "(11)93273-2466",
                Comparecimento = null
            },
            new Convidado()
            {
                ConvidadoId = 4,
                Nome = "Lance Vance Dance",
                Email = "lance@gmail.com",
                Telefone = "(01)95524-6875",
                Comparecimento = null
            },
        };
        public IActionResult Index()
        {
            return View(convidados);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Convidado convidado)
        {
            convidados.Add(convidado);
            convidado.ConvidadoId = convidados.Select(c => c.ConvidadoId).Max() + 1;
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            return View(convidados.Where(m => m.ConvidadoId == id).First());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Convidado convidado)
        {                                                          
            convidados.Remove(convidados.Where(c => c.ConvidadoId == convidado.ConvidadoId).First());
            convidados.Add(convidado);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            return View(convidados.Where(c => c.ConvidadoId == id).First());
        }
        public IActionResult Delete(int id)
        {
            return View(convidados.Where(c => c.ConvidadoId == id).First());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Convidado convidado)
        {
            convidados.Remove(convidados.Where(c => c.ConvidadoId == convidado.ConvidadoId).First());
            return RedirectToAction("Index");
        }
    }
}
