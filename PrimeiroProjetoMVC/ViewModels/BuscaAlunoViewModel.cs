using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrimeiroProjetoMVC.Models;

namespace PrimeiroProjetoMVC.ViewModels
{
    public class BuscaAlunoViewModel
    {
        public string? TermoBusca { get; set; }
        public List<Aluno> Resultados { get; set; } = new();
        
    }
}