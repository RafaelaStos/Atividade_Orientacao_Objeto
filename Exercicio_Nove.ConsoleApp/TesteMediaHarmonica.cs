using System;

namespace Exercicio_Nove.ConsoleApp
{
    internal class TesteMediaHarmonica
    {
        static void Main(string[] args)
        {
            MediaHarmonica media = new MediaHarmonica();
            media.nota1 = 7;
            media.nota2 = 9;
            media.nota3 = 8;
            media.nota4 = 5;


            Console.WriteLine("A Media Harmonica do aluno é: "+media.ObterMedia());
        }
    }
}
