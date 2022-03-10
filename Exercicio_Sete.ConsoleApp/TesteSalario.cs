using System;

namespace Exercicio_Sete.ConsoleApp
{
    internal class TesteSalario
    {
        static void Main(string[] args)
        {
            Vendedor Salario = new Vendedor();

            Salario.totalVendas = 3000;
            Salario.percentualGanho = 30;
            Salario.salarioBase = 2000;

            Console.WriteLine("O salario total Do vendedor é: "+Salario.ObterSalarioTotal());
        }
    }
}
