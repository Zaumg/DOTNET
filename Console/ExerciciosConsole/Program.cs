using ExerciciosConsole;

//EXERCICIO 1
// Pessoa p1 = new Pessoa();
// p1.Nome = "Giovanna";
// p1.Idade = 19;
// p1.Cidade = "São Paulo";

// p1.Apresentar();

// Pessoa p2 = new Pessoa();
// p2.Apresentar();

//EXERCICIO 2
// Calculadora c1 = new Calculadora();

// int resultado = c1.Somar(10, 20);
// Console.WriteLine($"resultado: {resultado}");

// int resultado2 = c1.Subtrair(20, 10);
// Console.WriteLine($"resultado: {resultado2}");

// int resultado3 = c1.Multiplicar(10, 20);
// Console.WriteLine($"resultado: {resultado3}");

// int resultado4 = Calculadora.Dividir(10, 2);
// Console.WriteLine($"resultado: {resultado4}");

//EXERCICIO 3
// Veiculo v1 = new Veiculo();
// v1.alterarVelocidade(100);

// Console.WriteLine($"A velocidade esta em: {v1.velocidade}km/h");

//EXERCICIO 4
// Funcionario f1 = new Funcionario("Giovanna", "Desenvolvedora", 3000m); //tem que colocar pois foi declarado assim na classe Funcionario
// f1.Nome = "Giovanna";
// f1.Cargo = "Desenvolvedora";


// Console.WriteLine($"Funcionário: {f1.Nome} do cargo: {f1.Cargo}");
// f1.ConsultarSalario();

// Console.WriteLine("\nAplicando aumento...");
// f1.AumentarSalario(10); 
// f1.ConsultarSalario();

// Console.WriteLine($"Funcionário: {f1.Nome} do cargo: {f1.Cargo}");
// f1.ConsultarSalario();

// Console.WriteLine("\nAplicando aumento...");
// f1.AumentarSalario(50);
// f1.ConsultarSalario();

// Console.WriteLine($"Funcionário: {f1.Nome} do cargo: {f1.Cargo}");
// f1.ConsultarSalario();

// Console.WriteLine("\nAplicando aumento...");
// f1.AumentarSalario(5);
// f1.ConsultarSalario();

//EXERCICIO 5
Livro l1 = new Livro();

Livro l2 = new Livro("Dom Casmurro");

Livro l3 = new Livro("O Principe Cruel", "Holly Black");

Livro l4 = new Livro("Reino de Cinzas","Sarah J.Mass", 938);

Console.WriteLine("Informações dos livros:");
l1.ExibirDados();
l2.ExibirDados();
l3.ExibirDados();
l4.ExibirDados();