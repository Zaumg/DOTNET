
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public abstract class Funcionario
    {
        public string? Nome { get; set;} //atributo

        protected decimal Salario; //campo

        public void Trabalhar()
        {
            Console.WriteLine("Funcionário está executando atividades");
        }

        public Funcionario()
        {
            
        }

        public Funcionario(string nome, decimal salario)
        {
            Nome = nome;
            Salario = salario;
        }
    }
}