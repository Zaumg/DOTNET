using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosHeranca
{
    public abstract class Jogo
    {
         public string? Nome { get; set; }

    protected string? Plataforma;

    public Jogo(string nome, string plataforma)
    {
        Nome = nome;
        Plataforma = plataforma;
    }

    public abstract void ExibirInformacoesJogos();
        }
 }
