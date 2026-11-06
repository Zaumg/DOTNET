using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosConsole
{
    public class Veiculo
    {
        public decimal Velocidade { get; set;}

        public void Exibir()
        {
            Console.WriteLine($"{Velocidade}");
        }

        public void DiferencaVelocidade()
        { 
            if(Velocidade > 0)
            {
                 Velocidade = Velocidade;
            }
           else
            {
                Console.WriteLine("Valor não encontrado");
            }
        }
    }
}