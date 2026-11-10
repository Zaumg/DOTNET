using Heranca;

Gerente gerente = new Gerente();

gerente.Nome = "Carlos";
gerente.Codigo = 123;

Gerente gerente2 = new Gerente
{
    Nome = "Kessia", 

};

gerente2.DefinirSalario(2000);


gerente.Trabalhar();
gerente.GerenciarEquipe();


Funcionario f = new Gerente(); //Crie um objeto do tipo gerente e permita que a variavel f, declarada como Funcionario, referencie esse objeto.
gerente2.ExibirSalario();

IPagamento p1 = new PagamentoPix();
