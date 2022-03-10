using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Quatro.ConsoleApp
{
    internal class Carro
    {
        public int kmInicial;
        public int kmFinal;
        public int consumo;

        public double ConsumoTotal()
        {
            double distanciaPercorrida = kmFinal - kmInicial;

        double gastoTotal = distanciaPercorrida / consumo;
            return gastoTotal;
        }

    }
}
