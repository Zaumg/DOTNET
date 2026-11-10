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
            Console.WriteLine($"Salario: R$ {Salario:F2}");
        }

        public void DefinirSalario(Decimal valorSalario)
        {
            Salario = valorSalario;
        }

        public override decimal CalcularBonus()
        {
            return 1000m;
        }

        public override void Trabalhar()
        {
            Console.WriteLine("Gerenciando a equipe");
        }
    }
}


