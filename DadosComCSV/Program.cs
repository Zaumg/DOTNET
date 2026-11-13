using DadosComCSV.Models;
using DadosComCSV.Repositories;
using DadosComCSV.Services;

//Program(cliente) => Service(garçom) => Repository(cozinha) => Model + DB (ingredientes)

var repository = new JogoRepository();
var service = new JogoService(repository);

bool executando = true;

while (executando)
{
    Console.Clear();
    Console.WriteLine("======== GESTÃO DE JOGOS ========");
    Console.WriteLine("1 - CADASTRAR JOGO");
    Console.WriteLine("2 - LISTAR JOGOS");
    Console.WriteLine("0 - SAIR");
    Console.WriteLine("\nEscolha uma opção: ");

    string? opcao = Console.ReadLine();

    try
    {
        switch (opcao)
        {
            case "1":
                Cadastrar();
                break;
            case "2":
               Listar();
                break;
            case "0":
                executando = false;
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"\nErro: {ex.Message}");
        throw;
    }
}

void Listar()
{
    Console.Clear();
    Console.WriteLine("======== JOGOS CADASTRADOS ========");

    var jogos = service.Listar(); //me retorna uma lista de jogos, os jogos que existem no sistema

    if (jogos.Count == 0)
    {
        Console.WriteLine("Nenhum jogo cadastrado.");
    }
    else
    {
        foreach (var jogo in jogos) //cada jogo em jogos
        {
            ExibirJogo(jogo);
        }
    }

    Pausar();
} //recebe um objeto do tipo jogo

void ExibirJogo(Jogo jogo)
{
    Console.WriteLine($"""
    --------------------------------------
    ID: {jogo.Id}
    Nome: {jogo.Nome}
    Desenvolvedora: {jogo.Desenvolvedora}
    Gênero: {jogo.Genero}
    Ano: {jogo.AnoLancamento}
    Preço: {jogo.Preco:C}
    """);
}

void Pausar()
{
    Console.WriteLine("\n Pressione ENTER para continuar...");
    Console.ReadLine();
}

void Cadastrar()
{
    Console.Clear();
    Console.WriteLine("======== Cadastrar Jogo ========");

    var jogo = LerDadosJogo();

    service.Cadastrar(jogo);

    Console.WriteLine("\nJogo cadastrado com sucesso!");
    Pausar();
}

Jogo LerDadosJogo()
{
    Console.Write("Nome: ");
    string nome = Console.ReadLine() ?? ""; //na variavel nome, se nao for digitado nada (nulo) entra uma string vazia

    Console.Write("Desenvolvedora: ");
    string desenvolvedora = Console.ReadLine() ?? "";

    Console.Write("Gênero: ");
    string genero = Console.ReadLine() ?? "";

    Console.Write("Ano Lancamento: ");
    int ano = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Preço: ");
    decimal valor = decimal.Parse(Console.ReadLine() ?? "");

    return new Jogo
    {
        Nome = nome,
        Desenvolvedora = desenvolvedora,
        Genero = genero,
        AnoLancamento = ano,
        Preco = valor
    };
}