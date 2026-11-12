using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosHeranca
{
    public class CursoOnline : ProdutoDigital
    {
           public int CargaHoraria { get; set; }
        public CursoOnline(string nome, decimal preco, int cargaHoraria) : base(nome, preco)
        {
            CargaHoraria = cargaHoraria;
        }
        
          public override void InformacoesProduto()
        {
            base.InformacoesProduto();
            Console.WriteLine($"A carga horaria é de: {CargaHoraria}");
        }

        
    }
}