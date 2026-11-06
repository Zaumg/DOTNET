using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosConsole
{
    public class Pessoa
    {
        public string? Nome{ get; set; }
        public int Idade { get; set; }
        public string?  Cidade { get; set; }

        public void Apresentar()
        {
        Console.WriteLine($"{Nome} - {Idade} - {Cidade}");
        }

        public Pessoa()
       {
        Nome = "Não informado";
        Idade = 0;
        Cidade = "Não informado";
       }
    }
}