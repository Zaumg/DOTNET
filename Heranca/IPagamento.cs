using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public interface IPagamento //uma interface define "um contrato" que estabelece quais metodos, propriedades ou outros membros uma classe deve disponibilizar
    {
      void Pagar(decimal valor);
      //void Receber(decimal valor); //Interfaces podem conter diversos métodos 
    }
}
