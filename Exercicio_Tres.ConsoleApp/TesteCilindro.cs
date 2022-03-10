using System;

namespace Exercicio_Tres.ConsoleApp
{
    internal class TesteCilindro
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro();

            cilindro.altura = 20;
            cilindro.raio = 10;

            Console.WriteLine("O volume do Cilindro é: "+cilindro.obterVolume());

        }
    }
}
