using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosConsole
{
    public class Livro
    {
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public int NumeroPaginas { get; set; }

        public Livro()
        {
            Titulo = "Sem título";
            Autor = "Autor desconhecido";
            NumeroPaginas = 0;
        }
        public Livro(string titulo)
        {
            Titulo = titulo;
            Autor = "Autor desconhecido";
            NumeroPaginas = 0;
        }

        public Livro(string titulo, string autor)
        {
           Titulo = titulo;
            Autor = autor;
            NumeroPaginas = 0;
        }

    
        public Livro(string titulo, string autor, int numeroPaginas)
        {
           Titulo = titulo;
            Autor = autor;
            NumeroPaginas = numeroPaginas;
    }

    public void ExibirDados()
        {
            Console.WriteLine($"Título: {Titulo}.  Autor: {Autor}.  Páginas: {NumeroPaginas}");
        }
}
}