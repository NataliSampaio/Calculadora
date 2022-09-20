using Calculadora;

 Console.WriteLine("Bem vindo a sua calculadora!!!");
operacoes operacoes = new operacoes();
Console.WriteLine("Soma: " + operacoes.Soma.Calcular(10, 10));

Console.WriteLine("Subtração: " + operacoes.Subtracao.Calcular(10, 10));

Console.WriteLine("Multiplicacao: " + operacoes.Multiplicacao.Calcular(10, 10));

Console.WriteLine("Divisao: " + operacoes.Divisao.Calcular(10, 10));

