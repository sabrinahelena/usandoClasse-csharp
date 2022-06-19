using System;
using System.Globalization;

namespace exercicioVetoresMediaPreco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de produtos: ");
            int quantProdutos = int.Parse(Console.ReadLine());

            Produto[] prod = new Produto[quantProdutos]; //cria o vetor

            for (int i = 0; i < quantProdutos; i++)
            {
                Console.Write("Digite o nome do produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Digite o preço do produto: ");
                double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                prod[i] = new Produto { NomeProduto = nomeProduto, PrecoProduto = precoProduto }; //Coloca os valores lidos em NomeProduto e PrecoProduto da classe
            }

            //Para fazer a soma e calcular a média

            double soma = 0; 
            for(int i = 0; i <prod.Length; i++)
            {
                soma += prod[i].PrecoProduto; //Soma começa com 0 e vai somando os valores armazenados em cada posição do vetor na aba PRECOPRODUTO

            }

            //Calculando a média
            double media;

            media = soma / quantProdutos;

            Console.WriteLine("Preço médio: " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}