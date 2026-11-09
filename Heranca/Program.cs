using Heranca;

Gerente gerente = new Gerente();

gerente.Nome = "Carlos";
gerente.Codigo = 123;

Gerente gerente2 = new Gerente
{
    Nome = "Kessia", 
    Salario = 30000m
};

gerente.Trabalhar();
gerente.GerenciarEquipe();


Funcionario f = new Gerente(); //Crie um objeto do tipo gerente e permita que a variavel f, declarada como Funcionario, referencie esse objeto.

