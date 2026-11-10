using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosConsole
{
    public class Funcionario
    {
        public string? Nome { get; set; }
        public string? Cargo { get; set; }
        public decimal Salario { get; private set; }

        public Funcionario(string nome, string cargo, decimal salarioInicial)
        {
            Nome = nome;
            Cargo = cargo;
            Salario = salarioInicial;
        }

        public void AumentarSalario(decimal percentualSalario)
        {
            if (percentualSalario > 0)
            {
                Salario += Salario * (percentualSalario / 100);
                Console.WriteLine($"Salário de {Nome} aumentado em {percentualSalario}% com sucesso!");
            }
            else
            {
                Console.WriteLine("O percentual de aumento deve ser maior que zero.");
            }
        }

        public void ConsultarSalario()
        {
            Console.WriteLine($"O salário atual de {Nome} é: {Salario:C2}");
        }
    }
 }
