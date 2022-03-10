using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Tres.ConsoleApp
{
    public class Cilindro
    {
        public double raio;
        public double altura;
     
        public double obterVolume()
        {
            double volume = ((Math.PI*Math.Pow(raio, 2)*altura));
                
                
                return volume;
        }

    }
}
