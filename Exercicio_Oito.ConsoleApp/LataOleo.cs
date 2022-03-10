using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Oito.ConsoleApp
{
    internal class LataOleo
    {
        public int altura;
        public int raio;

        public double ObterVolume()
        {
            double volume=((Math.PI*(Math.Pow(raio, 2)*altura)));

            return volume;
        }


    }
}
