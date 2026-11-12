using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosHeranca
{
    public class EntregaExpressa : Entrega
    {
        public EntregaExpressa(double distancia) : base(distancia)
        {
            
        }
        public override double CalcularFrete()
        {
            return Distancia * 5 + 10;
        }
    }
}