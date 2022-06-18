using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_lojinha_roupas
{
    internal class Loja
    {
        public int codigoPeca;
        public double precoPeca;
        public int numeroPecas;

        public double valorASerPago(double precoPeca, int numeroPecas)
        {
            return numeroPecas * precoPeca;
        }
    }
}
