using System;
using System.Globalization;

namespace 
    
    exercicio_lojinha_roupas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Loja cliente = new Loja();
            Console.WriteLine("Digite o código da peça que deseja comprar, o valor unitário e a quantidade de peças. ");
            string [] produto = Console.ReadLine().Split(' ');

            cliente.codigoPeca = (int.Parse(produto[0], CultureInfo.InvariantCulture));
            cliente.precoPeca = (double.Parse(produto[1], CultureInfo.InvariantCulture));
            cliente.numeroPecas = (int.Parse(produto[2], CultureInfo.InvariantCulture));

            Console.WriteLine($"Você está comprando o produto de código {cliente.codigoPeca}, e o valor a pagar é de {(cliente.valorASerPago(cliente.precoPeca, cliente.numeroPecas).ToString("F2"), CultureInfo.InvariantCulture)}");

            
        }
    }
}