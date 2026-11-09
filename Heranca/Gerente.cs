using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Gerente : Funcionario
    {
        public int Codigo { get; set; }

        public void GerenciarEquipe()
        {
            Console.WriteLine("O gestor está gerenciando a equipe");
        }

        public Gerente()
        {
            
        }

        public Gerente(string nome, decimal salario) : base(nome, salario)
        {
  
        }

        public void ExibirSalario ()
        {
            Console.WriteLine(Salario);
        }
    }
}


