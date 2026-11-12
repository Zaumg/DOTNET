using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosHeranca
{
    public class JogoDigital : Jogo
    {
           public JogoDigital(string nome, string plataforma) : base(nome, plataforma)
        {
            
        }
    
    public override void ExibirInformacoesJogos()
    {
        Console.WriteLine("Jogo: " + Nome);
        Console.WriteLine("Plataforma: " + Plataforma);
        Console.WriteLine("Formato: Digital");
    }
    }
}