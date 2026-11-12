using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DadosComCSV.Models
{

    //Representa os dados de um jogo que serão salvos no arquivo .CSV
    public class Jogo
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty; //quando coloca o Empty, você quer dizer que esta vazia (""). 
        // O que é diferente de nula!
        public string Desenvolvedora { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty; //o nulo só funciona com string, da erro se tentar colocar com int (por exemplo). Quando voce coloca uma propiedade de numero, 
        // ela já vem com o numero 0, então ela nunca pode ser nula, pois já vem com um valor
        public int AnoLancamento { get; set; }
        public decimal Preco { get; set; }
    }
}