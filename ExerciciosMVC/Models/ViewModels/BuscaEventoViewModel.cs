using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMVC.Models.ViewModels
{
    public class BuscaEventoViewModel
    {
        public string? NomeBusca { get; set; }
        public string? LocalBusca { get; set; }
        public DateTime? DataInicial { get; set;}
        public List<Evento> Resultados { get; set; } = new();
    }
}