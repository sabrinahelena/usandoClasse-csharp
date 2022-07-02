/*
 *Exercício propõe interação com usuário, lendo dados e depois exibindo, mas lendo vários
 * dados ao mesmo tempo de tipos diferentes.
 */

using System;
using System.Globalization;

namespace exercicio_classe_leitura_dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Console.WriteLine("Digite seu nome: ");
            pessoa.Nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?: ");
            pessoa.Quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            pessoa.PrecoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha separado por espaços simples): ");
            string[] v = Console.ReadLine().Split(' '); //Uso vetor para armazenar mais de um dado passado pelo usuário e divido os valores pelos espaços em Split
            pessoa.UltimoNome = v[0]; //Primeiro pedaço separado
            pessoa.Idade = int.Parse(v[1]);
            pessoa.Altura = double.Parse(v[2]);
      

            pessoa.status();
        }
    }
}