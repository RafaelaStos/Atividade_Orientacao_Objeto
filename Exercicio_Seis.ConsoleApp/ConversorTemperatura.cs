using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Seis.ConsoleApp
{
    internal class ConversorTemperatura
    {
        public int celsius;

        public double ObtemTemperatura()
        {
            double fahrenheit = (celsius * 9 / 5) + 32;


            return fahrenheit; 
        }
    }
}
