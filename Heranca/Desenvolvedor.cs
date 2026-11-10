using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Desenvolvedor : Funcionario
    {
        public override decimal CalcularBonus()
        {
            return 500m;
        }
    }
}