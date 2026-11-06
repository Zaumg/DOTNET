//*EXERCICIO 1
// Console.Write("Digite seu nome: ");
// string? nome = Console.ReadLine();

// Console.Write("Digite sua idade: ");
// string? idade = Console.ReadLine();

// Console.Write("Digite sua cidade: ");
// string? cidade = Console.ReadLine();

// Console.WriteLine("Meu nome é " + nome + " eu tenho "  + idade + " anos de idade e moro em " + cidade);

//*EXERCICIO 2
/*
Console.Write("Nome do produto: ");
string? produto = Console.ReadLine();

Console.Write("Quantidade comprada: ");
int Quantidade = int.Parse(Console.ReadLine()!) ;

Console.Write("Preco unitário: ");
decimal Preco = decimal.Parse(Console.ReadLine()!);

decimal ValorTotal = Quantidade * Preco;

Console.WriteLine($"Nome do produto: {produto}, quantidade comprada: {Quantidade}, preço unitário: ${Preco} Valor total: ${ValorTotal}");
*/

//*EXERCICIO 3
/*
    Console.WriteLine("Digite seu nome: ");
    string? nome = Console.ReadLine();

    Console.WriteLine("Digite sua nota: ");
    int nota = int.Parse(Console.ReadLine()!);

if (nota >= 7)
{
  Console.WriteLine("Aprovado");
}
else if (nota >= 5 && nota < 7)
{
  Console.WriteLine("Recuperação");
}
else if (nota < 5)
{
  Console.WriteLine("Reprovado");
}
else
{
  Console.WriteLine("Nota inválida");
}
*/

// EXERCICIO 4
/*
Console.WriteLine("Digite um número: ");
int numero = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}
*/

// EXERCICIO 5
// int numeroSecreto = 67;

// Console.Write("Chute o número secreto: ");
// int palpite = int.Parse(Console.ReadLine()!);

// int tentativa = 1;
// while (numeroSecreto != palpite)
// {
//     if (numeroSecreto > palpite)
//     {
//         Console.WriteLine("O número secreto é maior.\n");
//     } 
//     else
//     {
//         Console.WriteLine("O número secreto é menor.\n");
//     }
//     Console.Write("Chute o número secreto: ");
//     palpite = int.Parse(Console.ReadLine()!);
//     tentativa++;
// }


// Console.WriteLine($"Você acertou, o número secreto era {palpite} \nNúmero de tentativas: {tentativa}");

//DESAFIO EXTRA

// int numeroSecreto = 67;
// int tentativa = 0;
// int palpite;

// do
// {
//     Console.Write("Chute o número secreto: ");
//     palpite = int.Parse(Console.ReadLine()!);
//     if (secreto > palpite)
//     {
//         Console.WriteLine("O número secreto é maior.\n");
//     }
//     else
//     {
//         Console.WriteLine("O número secreto é menor.\n");
//     }
//     tentativa++;
// } while (numeroSecreto != palpite);

// Console.WriteLine($"Você acertou, o número secreto era {palpite} \nNúmero de tentativas: {tentativa}");


// EXERCICIO 6
// Console.Write("Digite o primeiro número: ");
// int a = int.Parse(Console.ReadLine()!);

// Console.Write("Digite o segundo número: ");
// int b = int.Parse(Console.ReadLine()!);

// int Somar()
// {
//     int soma = a + b;
//     return soma;
// }

// int Multi()
// {
//     int multi = a * b;
//     return multi;
// }

// Console.WriteLine($"A soma dos dois número é {Somar()} \nE a multiplicação é {Mult()}");

// EXERCICIO 7
// int[] notas = new int[3];
// int media = 0;

// Console.Write("Digite a primeira nota: ");
// int n1 = int.Parse(Console.ReadLine()!);

// Console.Write("Digite a segunda nota: ");
// int n2 = int.Parse(Console.ReadLine()!);

// Console.Write("Digite a terceira nota: ");
// int n3 = int.Parse(Console.ReadLine()!);

// notas[0] = n1;
// notas[1] = n2;
// notas[2] = n3;

// for (int i = 0; i < notas.Length; i++)
// {
//     Console.WriteLine($"Sua {i}ª nota é: {notas[i]}");
// }

// foreach (var nota in notas)
// {
//     media += nota; 
// }

// media /= notas.Count();

// Console.WriteLine($"A média das suas nota é {media}");


// EXERCICIO 8
// int[] numeros = new int[5];

// for (int i = 0; i < numeros.Length; i++)
// {
//     Console.Write($"Digite o número {i + 1}: ");
//     numeros[i] = int.Parse(Console.ReadLine()!);
// }

// int pares = 0;
// int maior = numeros[0];

// Console.WriteLine("\nNúmeros informados:");
// for (int i = 0; i < numeros.Length; i++)
// {
//     Console.WriteLine(numeros[i]);


//     if (numeros[i] % 2 == 0)
//     {
//         pares++;
//     }

//     if (numeros[i] > maior)
//     {
//         maior = numeros[i];
//     }
// }

// Console.WriteLine($"Quantidade de números pares: {pares}");
// Console.WriteLine($"Maior número: {maior}");

//EXERCICIO 9
// List<string> names = new List<string>();

// for (int i = 0; i < 3; i++)
// {
//     Console.Write("Digite o nome do produto: ");
//     string? produto = Console.ReadLine();
// }
//    names.Add(produto);

// Console.WriteLine("Produtos cadastrados:");


// foreach (var produto in names)
// {
//     Console.WriteLine(produto);
// }

// Console.Write("Digite o nome de um produto para pesquisa: ");
// string? pesquisa = Console.ReadLine();

// Console.WriteLine(names.Contains(pesquisa));

// Console.Write("Digite um produto para removê-lo: ");
// string? remover = Console.ReadLine();
// names.Remove(remover);

// Console.WriteLine("Lista atualizada: ");

// foreach (var produto in names)
// {
//     Console.WriteLine(produto);
// }


// EXERCICIO 10
List<string> produtos = new List<string>
{
"Notebook",
"Mouse",
"Teclado",
"Monitor",
"Webcam"
};


Console.Write("Digite o nome ou início do nome do produto: ");
string? pesquisa = Console.ReadLine()!;


string? encontrado = produtos.Find(
    produto => produto.StartsWith(pesquisa)
);


if (encontrado != null)
{
    Console.WriteLine($"Produto encontrado: {encontrado}");
}
else
{
    Console.WriteLine("Produto não encontrado!");
}

