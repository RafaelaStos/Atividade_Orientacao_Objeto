using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Nove.ConsoleApp
{
    internal class MediaHarmonica
    {
       
        public double nota1;
        public double nota2;
        public double nota3;
        public double nota4;

        public double ObterMedia()
            {
            double media= 4/((1/ nota1) + (1 / nota2) + (1 / nota3) + (1 / nota4));

            return media;

            }
    }
}
