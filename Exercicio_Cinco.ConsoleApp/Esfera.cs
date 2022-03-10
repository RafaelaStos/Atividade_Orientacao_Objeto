using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Cinco.ConsoleApp
{
    internal class Esfera
    {

        public int raio;

        public double ObterVolume()
        {
            double volume=((4 * Math.PI* Math.Pow(raio, 3)/3));

            return volume;
        }





    }
}
