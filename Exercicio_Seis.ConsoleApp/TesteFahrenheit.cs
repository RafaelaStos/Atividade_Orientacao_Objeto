using System;

namespace Exercicio_Seis.ConsoleApp
{
    internal class TesteFahrenheit
    {
        static void Main(string[] args)
        {
            ConversorTemperatura temperatura = new ConversorTemperatura();
            temperatura.celsius = 25;

            Console.WriteLine("A temperatura convertida é: "+temperatura.ObtemTemperatura()+"°F");
        }
    }
}
