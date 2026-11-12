using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosHeranca
{
    public class Veiculo
    {
        public string? Marca { get; set; }
        public string? Modelo { get; set; }

         public Veiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

          public virtual void ExibirInformacoes ()
        {
            Console.WriteLine($"O carro é da marca: {Marca} e do modelo: {Modelo} ");
        }


    }
}