using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class PagamentoPix : IPagamento
    {
        public void Pagar(decimal valor)
        {
            //throw new NotImplementedException(); //*classe nativa do C# enquanto a definição do método não é criada pelo desenvolvedor
            Console.WriteLine($"Pagamento via Pix: {valor:C}");
        }

        public void Receber(decimal valor)
        {
            throw new NotImplementedException();
        }
    }
}