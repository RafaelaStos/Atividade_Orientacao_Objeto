using System;

namespace Exercicio_Quatro.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Carro percurso = new Carro();

            percurso.kmInicial= 10;
            percurso.kmFinal= 20;
            percurso.consumo= 10;

            Console.WriteLine("O comsumo por km foi: "+percurso.ConsumoTotal());



        }
    }
}
