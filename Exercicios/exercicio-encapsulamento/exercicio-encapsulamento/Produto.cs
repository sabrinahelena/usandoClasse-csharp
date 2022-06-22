using System;
using System.Globalization;

namespace exercicio_encapsulamento
{
    internal class Produto
    {
        private string _nome;
        private double _preco;
        //Usando auto propriedade
        public int Quantidade { get; private set; }

        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            Quantidade = quantidade;
        }

        //Usando propriedades
        public string Nome
        {
            get { return _nome;  }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        //Modo atributos privados
        public double GetPreco()
        {
            return _preco;
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
