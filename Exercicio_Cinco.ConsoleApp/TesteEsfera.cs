using System;

namespace Exercicio_Cinco.ConsoleApp
{
    internal class TesteEsfera
    {
        static void Main(string[] args)
        {
            Esfera volumeEsfera = new Esfera();

            volumeEsfera.raio = 5;

            Console.WriteLine("O volume da esfera é: "+volumeEsfera.ObterVolume());
        }
    }
}
