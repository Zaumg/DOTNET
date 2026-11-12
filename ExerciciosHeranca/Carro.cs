using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosHeranca
{
    public class Carro : Veiculo
    {
        public int QuantidadePortas { get; set; }

        
          public override void ExibirInformacoes ()
        {
            Console.WriteLine($"O carro possui: {QuantidadePortas} portas");
        }

        public Carro(string marca, string modelo, int quantidadePortas) : base(marca, modelo)
        {
            QuantidadePortas = quantidadePortas;
        }
    }
}