using System.Globalization;
using GestaoJogosEFCore.Data;
using GestaoJogosEFCore.Models;
using GestaoJogosEFCore.Repositories;
using GestaoJogosEFCore.Services;
using Microsoft.EntityFrameworkCore;

// Defini a variável com os dados para realizar login no servidor do SQL SERVER
string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=DB_GestaoJogos;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";

// DbContextOptionsBuilder reúne as configurações usadas pelo contexto.
// UseSqlServer seleciona o provedor do SQL Server e recebe a connection string.
var options = new DbContextOptionsBuilder<GestaoJogosContext>()
    .UseSqlServer(connectionString)
    .Options;

// O Program conversa com o serviço; o serviço delega o acesso ao repositório.
var repository = new JogoRepository(options);
var service = new JogoService(repository);

bool executando = true;

// Repete o menu enquanto executando permanecer true.
while (executando)
{
    LimparTela();
    Console.WriteLine("===== GESTÃO DE JOGOS - BANCO DE DADOS =====");
    Console.WriteLine("1 - Cadastrar jogo");
    Console.WriteLine("2 - Listar jogos");
    Console.WriteLine("3 - Consultar jogo");
    Console.WriteLine("4 - Atualizar jogo");
    Console.WriteLine("5 - Excluir jogo");
    Console.WriteLine("6 - Cadastrar desenvolvedora");
    Console.WriteLine("7 - Listar desenvolvedoras");
    Console.WriteLine("0 - Sair");
    Console.Write("\nEscolha uma opção: ");

    // ReadLine pode retornar null se a entrada for encerrada.
    string? opcao = Console.ReadLine();

    // Trata erros esperados para mostrar uma mensagem e manter a aplicação aberta.
    try
    {
        // Compara a opção digitada e chama a função responsável pela ação.
        switch (opcao)
        {
            case "1":
                CadastrarJogo();
                break;
            case "2":
                ListarJogos();
                break;
            case "3":
                ConsultarJogo();
                break;
            case "4":
                AtualizarJogo();
                break;
            case "5":
                ExcluirJogo();
                break;
            case "6":
                CadastrarDesenvolvedora();
                break;
            case "7":
                ListarDesenvolvedoras(Desenvolvedora);
                break;
            case "0":
                // Altera a condição do while para encerrar o menu.
                executando = false;
                break;
            default:
                Console.WriteLine("Opção inválida.");
                Pausar();
                break;
        }
    }
    catch (ArgumentException ex)
    {
        // Exibe erros de validação, como uma desenvolvedora inexistente.
        Console.WriteLine($"\nErro: {ex.Message}");
        Pausar();
    }
}

void ListarDesenvolvedoras(object desenvolvedoras)
{
    throw new NotImplementedException();
}

void ListarDesenvolvedoras(object desenvolvedoras)
{
    throw new NotImplementedException();
}

// Coleta os dados de um jogo e pede ao serviço para cadastrá-lo.
void CadastrarJogo()
{
    LimparTela();
    Console.WriteLine("===== CADASTRAR JOGO =====");

    // O jogo exige uma desenvolvedora existente por causa da chave estrangeira.
    // Any verifica se existe ao menos uma desenvolvedora cadastrada.
    if (service.ListarDesenvolvedoras().Any())
    {
        // A função de leitura monta a entidade; o serviço encaminha o cadastro ao repositório.
        service.Cadastrar(LerDadosJogo());
        Console.WriteLine("\nJogo cadastrado com sucesso!");
        Pausar();
    }
    else
    {
        Console.WriteLine("Cadastre uma desenvolvedora antes de cadastrar um jogo.");
        Pausar();
        return;
    }
}

// Consulta todos os jogos e apresenta cada resultado.
void ListarJogos()
{
    LimparTela();
    Console.WriteLine("===== JOGOS CADASTRADOS =====");

    // A consulta retorna uma lista de entidades preenchidas pelo EF Core.
    var jogos = service.Listar();
    // Count informa quantos resultados foram retornados.
    if (jogos.Count == 0)
        Console.WriteLine("Nenhum jogo cadastrado.");
    else
        // Percorre a lista e exibe cada jogo.
        foreach (var jogo in jogos)
            ExibirJogo(jogo);

    Pausar();
}

// Busca e exibe um único jogo a partir do ID digitado.
void ConsultarJogo()
{
    LimparTela();
    Console.WriteLine("===== CONSULTAR JOGO =====");
    Console.Write("Informe o ID: ");

    // Converte o ID digitado e consulta o registro no banco.
    int id = int.Parse(Console.ReadLine() ?? "");
    var jogo = service.BuscarPorId(id);

    // null indica que não existe um jogo com o ID informado.
    if (jogo is null)
        Console.WriteLine("Jogo não encontrado.");
    else
        ExibirJogo(jogo);

    Pausar();
}

// Procura o jogo e substitui seus dados pelos valores informados.
void AtualizarJogo()
{
    LimparTela();
    Console.WriteLine("===== ATUALIZAR JOGO =====");
    Console.Write("Informe o ID do jogo: ");

    int id = int.Parse(Console.ReadLine() ?? "");
    // Primeiro confirma que o registro a atualizar existe.
    var jogo = service.BuscarPorId(id);

    if (jogo is null)
    {
        Console.WriteLine("Jogo não encontrado.");
        Pausar();
        return;
    }

    Console.WriteLine("\nInforme os novos dados:");
    // Reaproveita a leitura dos campos usada no cadastro.
    var atualizado = LerDadosJogo();
    // Mantém o ID original para que o repositório atualize o registro correto.
    atualizado.IdJogo = id;

    // O repositório retorna false se o registro não existir mais.
    if (service.Atualizar(atualizado))
        Console.WriteLine("\nJogo atualizado com sucesso!");
    else
        Console.WriteLine("\nJogo não encontrado.");

    Pausar();
}

// Solicita ao serviço a exclusão do jogo indicado pelo ID.
void ExcluirJogo()
{
    LimparTela();
    Console.WriteLine("===== EXCLUIR JOGO =====");
    Console.Write("Informe o ID: ");

    int id = int.Parse(Console.ReadLine() ?? "");
    // O resultado informa se havia um jogo com esse ID para excluir.
    if (service.Excluir(id))
        Console.WriteLine("Jogo excluído com sucesso.");
    else
        Console.WriteLine("Jogo não encontrado.");

    Pausar();
}

// Lê os campos e cadastra uma nova desenvolvedora.
void CadastrarDesenvolvedora()
{
    LimparTela();
    Console.WriteLine("===== CADASTRAR DESENVOLVEDORA =====");
    Console.Write("Nome: ");
    string nome = Console.ReadLine() ?? "";
    Console.Write("País: ");
    string pais = Console.ReadLine() ?? "";

    // A desenvolvedora é gravada antes de poder ser associada a um jogo.
    service.CadastrarDesenvolvedora(new Desenvolvedora
    {
        Nome = nome,
        Pais = pais
    });

    Console.WriteLine("\nDesenvolvedora cadastrada com sucesso!");
    Pausar();
}

// Consulta e exibe as desenvolvedoras disponíveis no banco.
void ListarDesenvolvedoras(object desenvolvedoras1)
{
    LimparTela();
    Console.WriteLine("===== DESENVOLVEDORAS CADASTRADAS =====");

    var desenvolvedoras = service.ListarDesenvolvedoras();
    if (desenvolvedoras.Count == 0)
        Console.WriteLine("Nenhuma desenvolvedora cadastrada.");
    else
        // Percorre a lista e apresenta os dados de cada desenvolvedora.
        foreach (var desenvolvedora in desenvolvedoras1)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"ID: {desenvolvedora.IdDesenvolvedora}");
            Console.WriteLine($"Nome: {desenvolvedora.Nome}");
            Console.WriteLine($"País: {desenvolvedora.Pais}");
        }

    Pausar();
}

// Lê os dados do jogo e valida sua desenvolvedora antes de criar a entidade.
Jogo LerDadosJogo()
{
    // Carrega a lista para exibir opções válidas e validar o ID escolhido.
    var desenvolvedoras = service.ListarDesenvolvedoras();
    Console.WriteLine("\nDesenvolvedoras:");
    // Exibe o ID, que será armazenado como chave estrangeira no jogo.
    foreach (var desenvolvedora in desenvolvedoras)
        Console.WriteLine($"{desenvolvedora.IdDesenvolvedora} - {desenvolvedora.Nome}");

    Console.Write("ID da desenvolvedora: ");
    int idDesenvolvedora = int.Parse(Console.ReadLine() ?? "");
    // Any percorre a lista; d representa cada item testado pela condição.
    if (!desenvolvedoras.Any(d => d.IdDesenvolvedora == idDesenvolvedora))
    {
        throw new ArgumentException("A desenvolvedora informada não existe.");
    }

    Console.Write("Nome do jogo: ");
    string nome = Console.ReadLine() ?? "";
    Console.Write("Gênero: ");
    string genero = Console.ReadLine() ?? "";
    Console.Write("Ano de lançamento: ");
    int ano = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Preço: ");
    // Normaliza a vírgula decimal para que a conversão seja independente da região.
    string valor = (Console.ReadLine() ?? "").Replace(',', '.');
    // InvariantCulture interpreta o ponto como separador decimal.
    decimal preco = decimal.Parse(valor, CultureInfo.InvariantCulture);

    // Cria a entidade que será recebida pelo serviço e pelo repositório.
    return new Jogo
    {
        IdDesenvolvedora = idDesenvolvedora,
        Nome = nome,
        Genero = genero,
        AnoLancamento = ano,
        Preco = preco
    };
}

// Apresenta os dados do jogo e da desenvolvedora relacionada.
void ExibirJogo(Jogo jogo)
{
    Console.WriteLine("------------------------------");
    Console.WriteLine($"ID: {jogo.IdJogo}");
    Console.WriteLine($"Nome: {jogo.Nome}");
    Console.WriteLine($"Desenvolvedora: {jogo.IdDesenvolvedoraNavigation.Nome}");
    Console.WriteLine($"Gênero: {jogo.Genero}");
    Console.WriteLine($"Ano: {jogo.AnoLancamento}");
    Console.WriteLine($"Preço: {jogo.Preco:C}");
}

// Aguarda para que o resultado continue visível antes de retornar ao menu.
void Pausar()
{
    Console.WriteLine("\nPressione ENTER para continuar...");
    Console.ReadLine();
}

// Evita falha ao limpar a tela quando a saída está redirecionada, como em testes.
void LimparTela()
{
    if (!Console.IsOutputRedirected)
        Console.Clear();
}