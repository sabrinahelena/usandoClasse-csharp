using System;
using System.Globalization;

namespace 
    
    exercicio_lojinha_roupas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Loja p1 = new Loja();
            Loja p2 = new Loja();
            Loja total = new Loja();
            Console.WriteLine("Digite o código da primeira peça que deseja comprar, o valor unitário e a quantidade de peças, envie e depois repita o processo para a segunda peça> ");
            string [] produto1 = Console.ReadLine().Split(' ');
            string[] produto2 = Console.ReadLine().Split(' ');

            p1.codigoPeca = (int.Parse(produto1[0], CultureInfo.InvariantCulture));
            p1.precoPeca = (double.Parse(produto1[1], CultureInfo.InvariantCulture));
            p1.numeroPecas = (int.Parse(produto1[2], CultureInfo.InvariantCulture));

            p2.codigoPeca = (int.Parse(produto2[0], CultureInfo.InvariantCulture));
            p2.precoPeca = (double.Parse(produto2[1], CultureInfo.InvariantCulture));
            p2.numeroPecas = (int.Parse(produto2[2], CultureInfo.InvariantCulture));

            double valorPagoP1 = p1.valorASerPago(p1.precoPeca, p1.numeroPecas);
            double valorPagoP2 = p2.valorASerPago(p2.precoPeca, p2.numeroPecas);

            Console.WriteLine($"Você está comprando os produtos de código {p1.codigoPeca} e {p2.codigoPeca}, e o valor a pagar pelo produto 1 é de" +
                $" {(p1.valorASerPago(p1.precoPeca, p1.numeroPecas).ToString("F2"), CultureInfo.InvariantCulture)}, e o valor a pagar pelo produto 2 é de" +
                $"{(p2.valorASerPago(p2.precoPeca, p2.numeroPecas).ToString("F2"), CultureInfo.InvariantCulture)}. O valor a se pagar pelos dois em total é de" +
                $"{((valorPagoP1 + valorPagoP2).ToString("F2"), CultureInfo.InvariantCulture)}");


        }
    }
}