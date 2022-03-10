using System;

namespace Exercicio_Um.Consoleapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //intanciamento da class
            CaixaRetangular caixa =new CaixaRetangular();

            caixa.altura = 10;
            caixa.largura = 10;
            caixa.comprimento = 10;

            Console.WriteLine(" oO vaolume da caixa é : "+caixa.ObtemVolume());

        }

        
    }
}
