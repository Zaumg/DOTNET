using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExerciciosMVC.Models;
using ExerciciosMVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ExerciciosMVC.Controllers
{
    public class EventosController : Controller
    {
          private static List<Evento> _evento = new()
        {
            new Evento {Id = 1, Nome = "CCXP", Descricao = "Evento de cultura Geek que reune diversas pessoas todos os anos.", Local = "São Paulo Expo", DataEvento = new DateTime(2026, 12, 18), QuantidadeVagas = 990, ValorIngresso = 300},
        };

        //GET /Alunos - listar todos os alunos
        public IActionResult Index()
        {
            return View(_evento);
        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Evento evento)
        {
            //var Evento = _evento.FirstOrDefault(a => a.Id == id);

            if (!ModelState.IsValid)
            {
                return View(evento);
            }

            evento.Id = _evento.Any() ? _evento.Max(a => a.Id) + 1 : 1;
            _evento.Add(evento);


            return RedirectToAction("Index");
        }

        //GET /Evento/Detalhes - exibir detalhes do evento]

        public IActionResult Detalhes(int id)
        {
            var evento = _evento.FirstOrDefault(a => a.Id == id);

            if (evento == null)
            {
                return NotFound();
            }
            return View(evento);
        }

        [HttpPost]
       // [ValidadeAntiForgeryToken]
        public IActionResult Buscar(BuscaEventoViewModel vm){
            vm.Resultados = _evento;
        {
            if (!string.IsNullOrWhiteSpace(vm.NomeBusca))
            {
                vm.Resultados = vm.Resultados.Where(a => a.Nome.Contains(vm.NomeBusca, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (!string.IsNullOrWhiteSpace(vm.LocalBusca))
            {
                vm.Resultados = vm.Resultados.Where(a =>
                    a.Local.Contains(vm.LocalBusca,
                    StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (vm.DataInicial.HasValue)
            {
                vm.Resultados = vm.Resultados.Where(a =>
                    a.DataEvento.Date == vm.DataInicial.Value.Date).ToList();
            }

    
        return View(vm);
            }

        }
    }
}

















