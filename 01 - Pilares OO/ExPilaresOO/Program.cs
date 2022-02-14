// See https://aka.ms/new-console-template for more information

using ExPilaresOO.POO;
using ExPilaresOO.Interface;



/* interfaces */
// ICalculadora calcInterface = new PolCalculo();
// System.Console.WriteLine(calcInterface.Somar(5, 10));


/* Polimorfismo com construtores (Early Binding) */
// PolCalculo calc= new PolCalculo();
// System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(1, 2));
// System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(1, 2, 3));
// System.Console.WriteLine("Resultado da substração: " + calc.Subtrair(1, 2));


/* Herança e polimorfismo com sobrescrita de métodos (Early Binding)*/
// HerColaborador c1 = new HerColaborador();
// c1.Nome = "Mateus";
// c1.SobreNome = "Colet";
// c1.Idade = 30;
// c1.Salario = 1000;
// c1.Apresentar();

/* Herança com classe abstrata */
// ContaCorrente c = new ContaCorrente();
// c.Creditar(100);
// c.Creditar(100);
// c.ExibirSaldo();
// c.Sacar(50);
// c.ExibirSaldo();
// c.Sacar(160);
// c.ExibirSaldo();

/*Encapsulamento*/
// EncRetangulo r1 = new EncRetangulo();
// r1.DefinirMedidas(10, 20);
// System.Console.WriteLine($"Área: {r1.ObterAreaRet()}");
// //valores inválidos
// r1.DefinirMedidas(0, 0);
// System.Console.WriteLine($"Área: {r1.ObterAreaRet()}");


/*Abstração*/
// AbsPessoa p1 = new AbsPessoa();
// p1.Nome = "Mateus";
// p1.SobreNome = "Colet";
// p1.Idade = 30;
// p1.Apresentar();


