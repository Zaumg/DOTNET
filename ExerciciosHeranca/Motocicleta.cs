using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosHeranca
{
    public class Motocicleta : Veiculo
    {
        public int Cilindradas { get; set; }

        
          public override void ExibirInformacoes ()
        {
            Console.WriteLine($"A motocicleta possui: {Cilindradas} cilindradas");
        }

        public Motocicleta(string marca, string modelo, int cilindradas) : base(marca, modelo)
        {
            Cilindradas = cilindradas;
        }
    }
}