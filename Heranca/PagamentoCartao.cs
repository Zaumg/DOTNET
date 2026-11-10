using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class PagamentoCartao : IPagamento
    {
        public void Pagar(decimal valor)
        {
            Console.WriteLine($"Pagamento via cartão: {valor:C}");
        }
    }
}