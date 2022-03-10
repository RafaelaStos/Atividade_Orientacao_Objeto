using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Dez.ConsoleApp
{
    internal class MediaPonderada
    {
        public int prova1;
        public int prova2;
        public int peso1;
        public int peso2;

        public double ObterMedia()
        {
            double media = (prova1*peso1 + prova2*peso2) / (peso1 + peso2);

            return media;

        }
    }
}
