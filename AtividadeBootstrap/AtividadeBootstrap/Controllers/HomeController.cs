using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtividadeBootstrap.Models;
using Microsoft.AspNetCore.Mvc;

namespace AtividadeBootstrap.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Produto> lista = new List<Produto> {
                new Produto{ID=1,Descricao="Detergente Liquido",Preco=1.59},
                new Produto{ID=2,Descricao="Sabao em Pó",Preco=9.59},
                new Produto{ID=3,Descricao="Limpa Inox",Preco=4.59},

            };
            return View(lista);
        }
    }
}