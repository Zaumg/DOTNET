using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ExerciciosConsole;

    public class Veiculo
    {
        public int velocidade { get; private set; }
        
        public void alterarVelocidade(int ValorVelocidade)
        {
            if(ValorVelocidade <= 0 || ValorVelocidade >= 200)
            {
                Console.WriteLine("Velocidade não permitida");
            }
            else
            {
                velocidade = ValorVelocidade;
            }
        }
    }
