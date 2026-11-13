using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosHeranca
{
    public class RetiradaLocal : Entrega
    {
        public RetiradaLocal(double distancia) : base(distancia)
        {

        }

        public override decimal CalcularFrete()
        {
            return 0;
        }
    }
}