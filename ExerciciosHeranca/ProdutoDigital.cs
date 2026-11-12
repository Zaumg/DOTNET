using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosHeranca
{
    public abstract class ProdutoDigital
    {
        public string? Nome { get; set; }
        public decimal Preco { get; set; }

         public ProdutoDigital(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

          public virtual void InformacoesProduto ()
        {
            Console.WriteLine($" O nome do produto é {Nome}, ele custa: {Preco:C2}");
        }

    }
}