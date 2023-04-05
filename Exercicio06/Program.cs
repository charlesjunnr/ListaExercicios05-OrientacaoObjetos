using Exercicio06;

namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            ParaFahrenheit fahrenheit = new ParaFahrenheit();

            Console.WriteLine("Conversor de Celsius para Fahrenheit");
            Console.WriteLine();
            Console.WriteLine("Digite o valor de ºC para a conversão: ");
            fahrenheit.celsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"O valor convertido é {fahrenheit.ConverterParaFahrenheit()} ºF.");
        }
    }
}