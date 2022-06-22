using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_Encapsulamento_Propriedades
{
    internal class Vendedor
    {
        public string NomeVendedor;
        private double _SalarioFixoPorMes;
        public double ComissaoEmPorcentagem { get; private set; }
        public double ValorVendasFinal;

        public Vendedor(string nomeVendedor, double valorVendasFinal)
        {
            NomeVendedor = nomeVendedor;
            ValorVendasFinal = valorVendasFinal;
        }



        public double SalarioFixoPorMes
        {
            get { return _SalarioFixoPorMes; }
            set { _SalarioFixoPorMes = value; }
        }

        public double calcularSalarioFinal(double ValorVendasFinal)
        {
            ComissaoEmPorcentagem = 15.00;
            return this.SalarioFixoPorMes + (ValorVendasFinal * (ComissaoEmPorcentagem / 100));
        }





    }
}
