using System;
using System.Globalization;

namespace exercicios_membrosEstaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cotação dólar: ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar?: ");
            double valorDolarDesejado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultadoFinal = Compra.valorASerPago(cotacaoDolar, valorDolarDesejado);
            Console.WriteLine($"Valor a ser pago em reais: {(resultadoFinal.ToString("F2"),CultureInfo.InvariantCulture)}");


        }
    }
}