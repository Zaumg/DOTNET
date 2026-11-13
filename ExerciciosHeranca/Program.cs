using ExerciciosHeranca;

//*EXERCICIO 1
// Carro c1 = new Carro("Toyota", "Toyota Corolla Cross", 4);
// Motocicleta m1 = new Motocicleta("Honda", "CB 500F", 500);

// c1.ExibirInformacoes();
// m1.ExibirInformacoes();

//*EXERCICIO 2
// Ebook e1 = new Ebook("Herdeira do Fogo", 3500m, 518);
// CursoOnline co1 = new CursoOnline("Desevolvimento de Sistemas", 1000m, 180);

// e1.InformacoesProduto();
// co1.InformacoesProduto();

//*EXERCICIO 3
// JogoDigital jd1 = new JogoDigital("Call of Duty", "PC");
// JogoFisico jf1 = new JogoFisico("Need for Speed", "Play Station 3");

// jd1.ExibirInformacoesJogos();
// jf1.ExibirInformacoesJogos();

//*EXERCICIO 4
// NotificacaoEmail ne1 = new NotificacaoEmail();
// NotificacaoSMS nsms1 = new NotificacaoSMS();
// NotificacaoPush np1 = new NotificacaoPush();

// ne1.Enviar();
// nsms1.Enviar();
// np1.Enviar();

//*EXERCICIO 5
// List<Entrega> entregas = new List<Entrega>();

// entregas.Add(new EntregaExpressa(10));
// entregas.Add(new EntregaEconomica(10));
// entregas.Add(new RetiradaLocal(10));

// foreach (Entrega entrega in entregas)
// {
//     Console.WriteLine("Valor dp frete: R$ " + entrega.CalcularFrete());
// }

//*EXERCICIO 6
Relatorio r1 = new Relatorio();
Contrato c1 = new Contrato();

Console.WriteLine("Relatório:");
r1.Imprimir();
r1.Exportar();

Console.WriteLine("\nContrato:");
c1.Imprimir();