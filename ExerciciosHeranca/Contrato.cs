using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosHeranca
{
    public class Contrato : IImprimivel
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimindo o contrato");
        }
    }
}