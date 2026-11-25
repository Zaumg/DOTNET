using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoJogosEFCore.Data;
using GestaoJogosEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoJogosEFCore.Repositories
{
    public class JogoRepository
    {
        //Guarda a configuração do EF Core para criar contextos nas operações do repositório
        private readonly DbContextOptions<GestaoJogosContext> _options;

        //atalho para contrutor
        public JogoRepository(DbContextOptions<GestaoJogosContext> options)
        {
            //Recebe as opções configurações na inicialização da aplicação
            _options = options;
        }

        public List<Jogo> Listar()
        {
            //Cada operação usa seu proprio contexto; using descarta o contexto ao finalizar o método
            using var context = new GestaoJogosContext(_options);

            return context.Jogo
            //Include carrega a navegação da desenvolvedora junto com os jogos
                .Include(j => j.IdDesenvolvedoraNavigation)
                //Ordenar os dados por ID em ordem crescente
                .OrderBy(j => j.IdJogo)
                //Executa a consulta no banco de dados e devolve os dados em uma lista
                .ToList();
        }

        public Jogo? BuscarPorId(int id)
        {
             using var context = new GestaoJogosContext(_options);

             return context.Jogo
                .Include(j => j.IdDesenvolvedoraNavigation)

                //retorna o primeiro resultado ou o valor padrão => null
                .FirstOrDefault(j => j.IdJogo == id);
        }

        public void Adicionar(Jogo jogo)
        {
            using var context = new GestaoJogosContext(_options);

            context.Jogo.Add(jogo);
            context.SaveChanges();
        }

        public bool Atualizar(Jogo jogoAtualizado)
        {
            using var context = new GestaoJogosContext(_options);

            //procura pela PK e rastreia a entidade encontrada
            var jogo = context.Jogo.Find(jogoAtualizado.IdJogo);

            if (jogo is null)
            {
                return false;
            }

            //copiando para a entidade encontrada os valores recebidos pelo objeto jogoAtualizado
            jogo.IdDesenvolvedora = jogoAtualizado.IdDesenvolvedora;
            jogo.Nome = jogoAtualizado.Nome;
            jogo.Genero = jogoAtualizado.Genero;
            jogo.AnoLancamento = jogoAtualizado.AnoLancamento;
            jogo.Preco = jogoAtualizado.Preco;

            context.SaveChanges();
            return true;

        }

        public bool Excluir(int id)
        {
            using var context = new GestaoJogosContext(_options);

            var jogo = context.Jogo.Find(id);

            if(jogo is null)
            {
                return false;
            }
            // exclui o jogo como o delete faria pelo sql
            context.Jogo.Remove(jogo);
            context.SaveChanges();
            return true;
        }

        public List<Desenvolvedora> ListarDesenvolvedoras()
        {
            using var context = new GestaoJogosContext(_options);

            return context.Desenvolvedora
            .OrderBy(d => d.Nome)
            .ToList();
        }

        public void AdicionarDesenvolvedora(Desenvolvedora desenvolvedora)
        {
            using var context = new GestaoJogosContext(_options);

            context.Desenvolvedora.Add(desenvolvedora);
            context.SaveChanges();
        }
    }
}