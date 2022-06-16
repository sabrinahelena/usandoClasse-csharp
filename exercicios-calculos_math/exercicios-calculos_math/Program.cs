using System;
using System.Globalization;

namespace exercicios_calculos_math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculos circulo = new Calculos();
            Calculos diferenca = new Calculos();
            Console.WriteLine("Digite o raio do círculo: ");
            circulo.raio = (double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(circulo.areaCirculo(circulo.raio).ToString("F2"), CultureInfo.InvariantCulture);

            Console.WriteLine("---------------------------");
            
            Console.WriteLine("Digite o valor de A, B, C e D respectivamente separado por espaço simples: ");
            string[] valores = Console.ReadLine().Split(' ');
            diferenca.valorA = double.Parse(valores[0]);
            diferenca.valorB = double.Parse(valores[1]);
            diferenca.valorC = double.Parse(valores[2]);
            diferenca.valorD = double.Parse(valores[3]);

            Console.WriteLine(diferenca.calcularDiferenca(diferenca.valorA, diferenca.valorB, diferenca.valorC, diferenca.valorD));









        }
    }
}