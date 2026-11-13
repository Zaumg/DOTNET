using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosHeranca
{
    public class EntregaEconomica : Entrega
    {
        public EntregaEconomica(double distancia) : base(distancia)
        {
            
        }

        public override decimal CalcularFrete()
        {
            return (decimal)Distancia * 2;
        }
    }
}