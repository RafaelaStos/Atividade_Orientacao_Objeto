using System;

namespace Exercicio_Oito.ConsoleApp
{
    internal class TesteLataOleo
    {
        static void Main(string[] args)
        {
            LataOleo lata= new LataOleo();

            lata.altura = 5;
            lata.raio = 4;

            Console.WriteLine("O volume da lata de oleo é de: "+lata.ObterVolume());
        }
    }
}
