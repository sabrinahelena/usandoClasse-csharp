using System;
using System.Globalization;

/* 
 * Exercício:
 * O programa deve ler o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas
 * por ele no mês em reais. O vendedor ganha 15% de comissão sob suas vendas 
 * Informar o valor final que ele receberá.
 */


namespace exercicio_Encapsulamento_Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Seja bem vindo vendedor.");
            Console.Write("Digite seu nome: ");
            string nomeVendedor = Console.ReadLine();
            Console.Write("Digite o total de vendas em reais feita nesse mês: ");
            double valorVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Vendedor v1 = new Vendedor(nomeVendedor, valorVendas); //usando constructor, coloquei os valores armazenados nas variáveis criadas na classe.

            v1.SalarioFixoPorMes = 1700.00;  //setei o salário fixo por mês.
            double salarioFinal = v1.calcularSalarioFinal(valorVendas);
            Console.WriteLine($"Olá {nomeVendedor}, o seu salário final é R$ {salarioFinal.ToString("F2", CultureInfo.InvariantCulture)}");



        }
    }
}