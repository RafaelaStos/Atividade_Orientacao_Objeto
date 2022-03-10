using System;

namespace Exercicio_Dez.ConsoleApp
{
    internal class TesteMediaPonderada
    {
        static void Main(string[] args)
        {
            MediaPonderada media = new MediaPonderada();

            media.prova1 = 2;
            media.prova2 = 9;
            media.peso1 = 5;
            media.peso2 = 10;


            Console.WriteLine("A media ponderada das provas é: "+media.ObterMedia());
        }
    }
}
