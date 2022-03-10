

namespace Exercicio_Dois.ConsoleApp
{
    public class ConversorTemperatura
    {
        public double fahrenheit;
       

        public double ObterTemperaturaCelsius()
        {
            double temperatura = (fahrenheit - 32) / 1.8;
            return temperatura;

        }
    }
}
