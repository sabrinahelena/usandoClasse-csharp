using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_classe_leitura_dados
{
    internal class Pessoa
    {
        public string Nome;
        public int Quartos;
        public double PrecoProduto;
        public string UltimoNome;
        public int Idade;
        public double Altura;

        public void status()
        {
            Console.WriteLine($"Olá {Nome} {UltimoNome}! Você tem {Idade} anos e {Altura} altura. Você mora em uma casa com " +
                $"{Quartos} quartos, e possui um produto que custa {PrecoProduto}. ");
        }
    }
}
