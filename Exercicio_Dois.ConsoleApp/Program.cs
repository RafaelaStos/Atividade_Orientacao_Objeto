using System;

namespace Exercicio_Dois.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            ConversorTemperatura celsius = new ConversorTemperatura();

            celsius.fahrenheit = 68;

            Console.WriteLine("Resultadoa da converção da temperatura é: "+celsius.ObterTemperaturaCelsius()+"°C");


        }
    }
}
