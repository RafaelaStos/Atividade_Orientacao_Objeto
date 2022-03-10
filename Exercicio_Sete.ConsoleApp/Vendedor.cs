using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Sete.ConsoleApp
{
    internal class Vendedor
    {
        public double salarioBase;
        public double totalVendas;
        public double percentualGanho;




        public double ObterSalarioTotal()
        {
            double ComissaoVendas= totalVendas * ( percentualGanho / 100);

            double SalarioTotal= salarioBase + ComissaoVendas;

            return SalarioTotal;
        } 


    }
}
