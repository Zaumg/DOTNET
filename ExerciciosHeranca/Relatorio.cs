using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosHeranca
{
    public class Relatorio : IImprimivel, IExportavel
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimindo o relatório");
        }

        public void Exportar()
        {
            Console.WriteLine("Exportando o relatóri");
        }
    }
}